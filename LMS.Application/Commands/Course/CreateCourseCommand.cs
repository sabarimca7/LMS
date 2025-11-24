using LMS.Application.DTOs.Course;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Commands.Course
{
    public record CreateCourseCommand(CreateCourseRequest Request, int CurrentUserId)
        : IRequest<int>;
}
