using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Cloudcherry
{
    //class to interact with cloudcherry for login, to get questions and answers
    internal class WebClient
    {
        public string BearerToken { get; set; }
        public string BaseUri { get; set; }

        public WebClient(string baseAddress)
        {
            BaseUri = baseAddress;
        }

        //login with given credentials and get bearer token
        public bool Login(string username, string password, string apiUri)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(this.BaseUri + apiUri);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";

                //enter the login credentials
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string body = "grant_type=password&username=" + username + "&password=" + password;
                    streamWriter.Write(body);
                    streamWriter.Flush();
                }

                //get response from the server
                var httpResponse = (HttpWebResponse)request.GetResponse();
                string response = "";

                if (httpResponse.StatusCode == HttpStatusCode.OK)
                {
                    //read entire response
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        response = streamReader.ReadToEnd();
                    }

                    //split the response to get bearer token
                    var data = response.TrimStart('{').TrimEnd('}').Replace("\"", String.Empty).Split(',');
                    BearerToken = data[0].Split(':')[1];

                    if (BearerToken != null)
                    {
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine(httpResponse.StatusDescription);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in Login:" + e.Message);
            }
            return false;
        }

        //get the list of all questions which match the criteria and return the question ids
        public async Task<List<string>> GetQuestions(string absoluteUri, string displayType, List<string> questionTags)
        {
            List<string> Ids = new List<string>();
            HttpResponseMessage response;
            try
            {
                //get the data
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(BaseUri);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", BearerToken);
                    response = await client.GetAsync(BaseUri + absoluteUri);
                }

                //if success
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;

                    //convert json objects into class objects
                    var questions = JsonConvert.DeserializeObject<List<Question>>(result);

                    foreach (var question in questions)
                    {
                        //cehck if the questions have required tags
                        if (question.DisplayType == displayType)
                        {
                            foreach (var tag in questionTags)
                            {
                                if (question.QuestionTags.Contains(tag))
                                {
                                    Ids.Add(question.Id);
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Error in getting Questions: {response.StatusCode}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in getting questions: " + e);
            }
            return Ids;
        }

        //get the list of all answers whic match the criteria and return the required fields for further processing
        public async Task<List<RequiredAnswer>> GetAnswers(string absoluteUri, int pageRequested, int rows, List<string> Ids, DateFilter dateFilter)
        {
            var requiredAnswers = new List<RequiredAnswer>();
            HttpResponseMessage response;
            try
            {
                //get the data
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(dateFilter);
                    var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

                    client.BaseAddress = new Uri(BaseUri);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", BearerToken);
                    response = await client.PostAsync(BaseUri + absoluteUri + pageRequested + "/" + rows, httpContent);
                }

                //if success
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;

                    //convert json objects into class objects
                    var answers = Newtonsoft.Json.JsonConvert.DeserializeObject<Answers>(result);

                    foreach (var answer in answers.Responses)
                    {
                        //get each response from the list of all
                        var answerResponse = answer.Responses;
                        foreach (var responseFromUser in answerResponse)
                        {
                            if (Ids.Contains(responseFromUser.QuestionId))
                            {
                                requiredAnswers.Add(new RequiredAnswer(responseFromUser.QuestionId, responseFromUser.QuestionText, responseFromUser.TextInput));
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Error in getting Answers: {response.StatusCode}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in getting answers: " + e);
            }
            return requiredAnswers;
        }
    }
}