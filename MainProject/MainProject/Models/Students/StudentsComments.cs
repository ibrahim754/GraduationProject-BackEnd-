namespace MainProject.Models.Students
{
    public class StudentComments
    {
        public int  Id { get; set; }
        public int SubjectId { get; set; }

        public int StudentId { get; set; }

        public string CommentContent { get; set; }

        public DateTime PostedAt { get; set; }
    }
}
