namespace MainProject.Models
{
    public class StudentsComments
    {
        public int CommentId { get; set; }
        public int SubjectId { get; set; }

        public int StudentId { get; set;}

        string CommentContent { get; set; }

        public string PostedAt { get; set; }
    }
}
