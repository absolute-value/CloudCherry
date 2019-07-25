using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cloudcherry
{
    internal static class Program
    {
        //stores answers whic match the given criteria
        public static List<RequiredAnswer> finalAnswers = new List<RequiredAnswer>();

        private static void Main(string[] args)
        {
            //base url of cloudcherry
            var baseUri = "https://api.getcloudcherry.com/";
            var webClient = new WebClient(baseUri);

            //login using endpoint url and store the bearer token
            string username = "ccpa01";
            string password = "Login@123";
            string apiUri = "api/LoginToken";
            webClient.Login(username, password, apiUri);

            //run all methods in async mode, so that app will not be blocked
            RunAsync(webClient).Wait();

            //finally find the most repeated word in user answers
            RepeatedWords words = new RepeatedWords();
            words.FindRepeatedWords(finalAnswers);

            Console.ReadKey();
        }

        private static async Task RunAsync(WebClient webClient)
        {
            //get list of questions with specified properties
            var displayType = "MultilineText";
            List<string> questionTags = new List<string>() { "Comments", "User Comments" };
            //returns list of question ids
            List<string> Ids = await webClient.GetQuestions("api/Questions/Active", displayType, questionTags);

            //
            //get list of answers from first page with matching questionIds
            int pages = 1;
            int rows = 1000;
            DateFilter dateFilter = new DateFilter(new DateTime(2019, 01, 19), new DateTime(2019, 07, 20));
            //returns list of answers
            finalAnswers = await webClient.GetAnswers("api/Answers/Page/", pages, rows, Ids, dateFilter);
        }
    }
}