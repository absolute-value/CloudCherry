// This is store the questions from each json object. Do not change

namespace Cloudcherry
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public partial class Question
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("sequence")]
        public long? Sequence { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("titleText")]
        public string TitleText { get; set; }

        [JsonProperty("audio")]
        public string Audio { get; set; }

        [JsonProperty("displayType")]
        public string DisplayType { get; set; }

        [JsonProperty("multiSelect")]
        public List<string> MultiSelect { get; set; }

        [JsonProperty("displayLegend")]
        public List<string> DisplayLegend { get; set; }

        [JsonProperty("multiSelectChoiceTag")]
        public List<string> MultiSelectChoiceTag { get; set; }

        [JsonProperty("leadingDisplayTexts")]
        public List<LeadingDisplayText> LeadingDisplayTexts { get; set; }

        [JsonProperty("staffFill")]
        public bool? StaffFill { get; set; }

        [JsonProperty("apiFill")]
        public bool? ApiFill { get; set; }

        [JsonProperty("displayLocation")]
        public List<string> DisplayLocation { get; set; }

        [JsonProperty("displayLocationByTag")]
        public List<string> DisplayLocationByTag { get; set; }

        [JsonProperty("userWeight")]
        public long? UserWeight { get; set; }

        [JsonProperty("displayStyle")]
        public string DisplayStyle { get; set; }

        [JsonProperty("endOfSurvey")]
        public bool? EndOfSurvey { get; set; }

        [JsonProperty("endOfSurveyMessage")]
        public string EndOfSurveyMessage { get; set; }

        [JsonProperty("conditionalFilter")]
        public Filter ConditionalFilter { get; set; }

        [JsonProperty("presentationMode")]
        public string PresentationMode { get; set; }

        [JsonProperty("isRequired")]
        public bool? IsRequired { get; set; }

        [JsonProperty("questionTags")]
        public List<string> QuestionTags { get; set; }

        [JsonProperty("topicTags")]
        public List<string> TopicTags { get; set; }

        [JsonProperty("goodAfter")]
        public DateTimeOffset? GoodAfter { get; set; }

        [JsonProperty("goodBefore")]
        public DateTimeOffset? GoodBefore { get; set; }

        [JsonProperty("timeOfDayAfter")]
        public DateTimeOffset? TimeOfDayAfter { get; set; }

        [JsonProperty("timeOfDayBefore")]
        public DateTimeOffset? TimeOfDayBefore { get; set; }

        [JsonProperty("isRetired")]
        public bool? IsRetired { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("backgroundURL")]
        public string BackgroundUrl { get; set; }

        [JsonProperty("disclaimerText")]
        public string DisclaimerText { get; set; }

        [JsonProperty("validationRegex")]
        public string ValidationRegex { get; set; }

        [JsonProperty("validationHint")]
        public string ValidationHint { get; set; }

        [JsonProperty("translated")]
        public Attributes Translated { get; set; }

        [JsonProperty("timeLimit")]
        public long? TimeLimit { get; set; }

        [JsonProperty("interactiveLiveAPIPreFillUrl")]
        public string InteractiveLiveApiPreFillUrl { get; set; }

        [JsonProperty("restrictedData")]
        public bool? RestrictedData { get; set; }

        [JsonProperty("sensitiveData")]
        public bool? SensitiveData { get; set; }

        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty("customMetric")]
        public CustomMetric CustomMetric { get; set; }

        [JsonProperty("perLocationOverride")]
        public List<PerLocationOverride> PerLocationOverride { get; set; }

        [JsonProperty("redactFullyOnFinding")]
        public List<string> RedactFullyOnFinding { get; set; }

        [JsonProperty("redactNumbersOver")]
        public long? RedactNumbersOver { get; set; }

        [JsonProperty("redactEmailAddresses")]
        public bool? RedactEmailAddresses { get; set; }

        [JsonProperty("pipingOptions")]
        public List<PipingOption> PipingOptions { get; set; }

        [JsonProperty("processTextSentiment")]
        public ProcessText ProcessTextSentiment { get; set; }

        [JsonProperty("processTextTheme")]
        public ProcessText ProcessTextTheme { get; set; }

        [JsonProperty("retiredOptions")]
        public List<string> RetiredOptions { get; set; }

        [JsonProperty("anchorMetricName")]
        public string AnchorMetricName { get; set; }
    }

    public partial class Attributes
    {
    }

    public partial class Filter
    {
        [JsonProperty("location")]
        public List<string> Location { get; set; }

        [JsonProperty("surveyClient")]
        public List<string> SurveyClient { get; set; }

        [JsonProperty("afterdate")]
        public DateTimeOffset? Afterdate { get; set; }

        [JsonProperty("beforedate")]
        public DateTimeOffset? Beforedate { get; set; }

        [JsonProperty("filterquestions")]
        public List<Filterquestion> Filterquestions { get; set; }

        [JsonProperty("archived")]
        public bool? Archived { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("withTickets")]
        public bool? WithTickets { get; set; }

        [JsonProperty("withTicketStatus")]
        public string WithTicketStatus { get; set; }

        [JsonProperty("withNotes")]
        public bool? WithNotes { get; set; }

        [JsonProperty("notesWithAttachmentType")]
        public string NotesWithAttachmentType { get; set; }

        [JsonProperty("notesMediaTheme")]
        public string NotesMediaTheme { get; set; }

        [JsonProperty("notesMediaMood")]
        public string NotesMediaMood { get; set; }

        [JsonProperty("onlyWithAttachments")]
        public bool? OnlyWithAttachments { get; set; }

        [JsonProperty("days")]
        public List<string> Days { get; set; }

        [JsonProperty("aftertime")]
        public DateTimeOffset? Aftertime { get; set; }

        [JsonProperty("beforetime")]
        public DateTimeOffset? Beforetime { get; set; }

        [JsonProperty("ticket")]
        public Ticket Ticket { get; set; }

        [JsonProperty("sortByOldest")]
        public bool? SortByOldest { get; set; }

        [JsonProperty("sampledSize")]
        public long? SampledSize { get; set; }

        [JsonProperty("sampleBySegment")]
        public List<SampleBySegment> SampleBySegment { get; set; }

        [JsonProperty("filterName")]
        public string FilterName { get; set; }

        [JsonProperty("viewAs")]
        public string ViewAs { get; set; }
    }

    public partial class Filterquestion
    {
        [JsonProperty("questionId")]
        public string QuestionId { get; set; }

        [JsonProperty("answerCheck")]
        public List<string> AnswerCheck { get; set; }

        [JsonProperty("number")]
        public long? Number { get; set; }

        [JsonProperty("groupBy")]
        public string GroupBy { get; set; }

        [JsonProperty("segment")]
        public string Segment { get; set; }
    }

    public partial class SampleBySegment
    {
        [JsonProperty("segment")]
        public string Segment { get; set; }

        [JsonProperty("percent")]
        public long? Percent { get; set; }
    }

    public partial class Ticket
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

        [JsonProperty("nextEscalationUser")]
        public string NextEscalationUser { get; set; }

        [JsonProperty("currentAssignedTo")]
        public string CurrentAssignedTo { get; set; }

        [JsonProperty("priority")]
        public long? Priority { get; set; }

        [JsonProperty("isEscalated")]
        public bool? IsEscalated { get; set; }

        [JsonProperty("isDeferred")]
        public bool? IsDeferred { get; set; }

        [JsonProperty("isPendingRating")]
        public bool? IsPendingRating { get; set; }

        [JsonProperty("isRated")]
        public bool? IsRated { get; set; }

        [JsonProperty("isShowcased")]
        public bool? IsShowcased { get; set; }

        [JsonProperty("isGlobalShowcased")]
        public bool? IsGlobalShowcased { get; set; }
    }

    public partial class CustomMetric
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public long? Value { get; set; }

        [JsonProperty("raw")]
        public string Raw { get; set; }

        [JsonProperty("elements")]
        public List<Attributes> Elements { get; set; }

        [JsonProperty("arguments")]
        public List<Attributes> Arguments { get; set; }

        [JsonProperty("callee")]
        public Attributes Callee { get; set; }

        [JsonProperty("left")]
        public Attributes Left { get; set; }

        [JsonProperty("right")]
        public Attributes Right { get; set; }
    }

    public partial class LeadingDisplayText
    {
        [JsonProperty("filter")]
        public Filter Filter { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("titleText")]
        public string TitleText { get; set; }

        [JsonProperty("audio")]
        public string Audio { get; set; }

        [JsonProperty("multiSelect")]
        public List<string> MultiSelect { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public partial class PerLocationOverride
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("sequence")]
        public long? Sequence { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("titleText")]
        public string TitleText { get; set; }

        [JsonProperty("displayLegend")]
        public List<string> DisplayLegend { get; set; }

        [JsonProperty("audio")]
        public string Audio { get; set; }

        [JsonProperty("staffFill")]
        public bool? StaffFill { get; set; }

        [JsonProperty("apiFill")]
        public bool? ApiFill { get; set; }

        [JsonProperty("endOfSurvey")]
        public bool? EndOfSurvey { get; set; }

        [JsonProperty("endOfSurveyMessage")]
        public string EndOfSurveyMessage { get; set; }

        [JsonProperty("conditionalFilter")]
        public Filter ConditionalFilter { get; set; }

        [JsonProperty("isRequired")]
        public bool? IsRequired { get; set; }

        [JsonProperty("backgroundURL")]
        public string BackgroundUrl { get; set; }

        [JsonProperty("disclaimerText")]
        public string DisclaimerText { get; set; }

        [JsonProperty("timeLimit")]
        public long? TimeLimit { get; set; }

        [JsonProperty("interactiveLiveAPIPreFillUrl")]
        public string InteractiveLiveApiPreFillUrl { get; set; }

        [JsonProperty("translated")]
        public Attributes Translated { get; set; }

        [JsonProperty("leadingDisplayTexts")]
        public List<LeadingDisplayText> LeadingDisplayTexts { get; set; }

        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty("customMetric")]
        public CustomMetric CustomMetric { get; set; }

        [JsonProperty("pipingOptions")]
        public List<PipingOption> PipingOptions { get; set; }
    }

    public partial class PipingOption
    {
        [JsonProperty("questionId")]
        public string QuestionId { get; set; }

        [JsonProperty("shouldPipeUnselected")]
        public bool? ShouldPipeUnselected { get; set; }

        [JsonProperty("defaultOptions")]
        public List<string> DefaultOptions { get; set; }

        [JsonProperty("dynamicOptions")]
        public Attributes DynamicOptions { get; set; }
    }

    public partial class ProcessText
    {
        [JsonProperty("engines")]
        public List<string> Engines { get; set; }

        [JsonProperty("classificationType")]
        public string ClassificationType { get; set; }

        [JsonProperty("saveResultToQuestionId")]
        public string SaveResultToQuestionId { get; set; }
    }

    public partial class Question
    {
        public static Question FromJson(string json) => JsonConvert.DeserializeObject<Question>(json, Cloudcherry.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Question self) => JsonConvert.SerializeObject(self, Cloudcherry.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}