namespace Cloudcherry
{
    //class to store the final answers whic match the given criteria
    internal class RequiredAnswer
    {
        public string QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string InputText { get; set; }

        public RequiredAnswer(string id, string question, string input)
        {
            QuestionId = id;
            QuestionText = question;
            InputText = input;
        }
    }
}