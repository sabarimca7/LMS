using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseCode { get; set; } = default!;
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? Level { get; set; }
        public bool IsPublished { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public ICollection<CourseModule> Modules { get; set; } = new List<CourseModule>();
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
