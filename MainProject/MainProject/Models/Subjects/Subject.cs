using System.ComponentModel.DataAnnotations;

namespace MainProject.Models.Subjects
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Subject name is required")]
        [StringLength(100, ErrorMessage = "Subject name must be between 1 and 100 characters", MinimumLength = 1)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Subject description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Subject category is required")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Subject level is required")]
        public int LevelId { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Duration must be a positive number")]
        public double Duration { get; set; }



        [Required(ErrorMessage = "Teacher name is required")]
        public string Teacher { get; set; }

        [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5")]
        public double Rating { get; set; }

        public string Prerequisites { get; set; }

        // You may have additional properties as needed

        public DateTime CreationDate { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
