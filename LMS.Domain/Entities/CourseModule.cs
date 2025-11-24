using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Entities
{
    public class CourseModule
    {
        public int ModuleId { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; } = default!;
        public int DisplayOrder { get; set; }

        public Course Course { get; set; } = default!;
        public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
    }
}
