using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.DTOs.Course
{
    public class CreateCourseRequest
    {
        public string CourseCode { get; set; } = default!;
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? Level { get; set; }
    }
}
