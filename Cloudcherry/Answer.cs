// This is store the answers from each json object. Do not change

namespace Cloudcherry
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public partial class Answers
    {
        [JsonProperty("responses")]
        public List<AnswerResponse> Responses { get; set; }

        [JsonProperty("currentPage")]
        public long? CurrentPage { get; set; }

        [JsonProperty("totalPages")]
        public long? TotalPages { get; set; }

        [JsonProperty("totalCount")]
        public long? TotalCount { get; set; }
    }

    public partial class AnswerResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("locationId")]
        public string LocationId { get; set; }

        [JsonProperty("responseDateTime")]
        public DateTimeOffset? ResponseDateTime { get; set; }

        [JsonProperty("responseDuration")]
        public long? ResponseDuration { get; set; }

        [JsonProperty("surveyClient")]
        public string SurveyClient { get; set; }

        [JsonProperty("responses")]
        public List<ResponseResponse> Responses { get; set; }

        [JsonProperty("archived")]
        public bool? Archived { get; set; }

        [JsonProperty("notes")]
        public List<Note> Notes { get; set; }

        [JsonProperty("openTicket")]
        public OpenTicket OpenTicket { get; set; }

        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }
    }

    public partial class Note
    {
        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("noteTime")]
        public DateTimeOffset? NoteTime { get; set; }

        [JsonProperty("note")]
        public string NoteNote { get; set; }

        [JsonProperty("noteSurveyID")]
        public string NoteSurveyId { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("mood")]
        public string Mood { get; set; }

        [JsonProperty("attached")]
        public List<Attached> Attached { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
    }

    public partial class Attached
    {
        [JsonProperty("userFileName")]
        public string UserFileName { get; set; }

        [JsonProperty("apiFileName")]
        public string ApiFileName { get; set; }

        [JsonProperty("timeStamp")]
        public DateTimeOffset? TimeStamp { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("mood")]
        public string Mood { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("isExternalResource")]
        public bool? IsExternalResource { get; set; }
    }

    public partial class OpenTicket
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("assignedBy")]
        public string AssignedBy { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("orginalRoutedTo")]
        public string OrginalRoutedTo { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset? Created { get; set; }

        [JsonProperty("after")]
        public DateTimeOffset? After { get; set; }

        [JsonProperty("sequence")]
        public long? Sequence { get; set; }

        [JsonProperty("nextEscalationIn")]
        public DateTimeOffset? NextEscalationIn { get; set; }

        [JsonProperty("nextEscalationUser")]
        public string NextEscalationUser { get; set; }

        [JsonProperty("closed")]
        public DateTimeOffset? Closed { get; set; }

        [JsonProperty("rating")]
        public long? Rating { get; set; }

        [JsonProperty("routeHistory")]
        public List<string> RouteHistory { get; set; }

        [JsonProperty("currentAssignedTo")]
        public string CurrentAssignedTo { get; set; }

        [JsonProperty("currentAssignedAt")]
        public DateTimeOffset? CurrentAssignedAt { get; set; }

        [JsonProperty("cCedTo")]
        public List<string> CCedTo { get; set; }

        [JsonProperty("priority")]
        public long? Priority { get; set; }

        [JsonProperty("isEscalated")]
        public bool? IsEscalated { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("diagnosticSurveyResponses")]
        public List<string> DiagnosticSurveyResponses { get; set; }

        [JsonProperty("isShowcased")]
        public bool? IsShowcased { get; set; }

        [JsonProperty("isGlobalShowcased")]
        public bool? IsGlobalShowcased { get; set; }

        [JsonProperty("showcaseTitle")]
        public string ShowcaseTitle { get; set; }

        [JsonProperty("showcasedBy")]
        public string ShowcasedBy { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("escalatedHistory")]
        public List<string> EscalatedHistory { get; set; }
    }

    public partial class ResponseResponse
    {
        [JsonProperty("questionId")]
        public string QuestionId { get; set; }

        [JsonProperty("questionText")]
        public string QuestionText { get; set; }

        [JsonProperty("textInput")]
        public string TextInput { get; set; }

        [JsonProperty("numberInput")]
        public long? NumberInput { get; set; }
    }

    public partial class Answers
    {
        public static Answers FromJson(string json) => JsonConvert.DeserializeObject<Answers>(json, Cloudcherry.Converter.Settings);
    }
}