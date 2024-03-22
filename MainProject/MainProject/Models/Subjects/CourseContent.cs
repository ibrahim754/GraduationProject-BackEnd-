namespace MainProject.Models.Subjects
{
    public class Chapter
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string ChapterName { get; set; }
        public string ChapterVideoURL { get; set; }
        public string ChapterPDFURL { get; set; }


    }
}
