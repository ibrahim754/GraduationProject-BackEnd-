namespace MainProject.Models.Subjects
{
    public class Question
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int ChapterId { get; set; }

        public string QuestionText { get; set; }

        public int QuestionType { get; set; } // true/false or Multi
        public string Explaination { get; set; }
        public int CorrectAnswerId { get; set; }
        public string CreatedAt { get; set; }



    }
}
