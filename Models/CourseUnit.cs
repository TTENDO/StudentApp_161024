using System.ComponentModel.DataAnnotations;

namespace StudentApp_161024.Models
{
    public class CourseUnit
    {
        [Key]
        public int Id { get; set; }
        public string CourseUnitCode { get; set; }
        public string Name { get; set; }
        public string DoneInYear { get; set; }

    }
}
