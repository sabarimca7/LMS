using LMS.Domain.Entities;
using LMS.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Commands.Course
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, int>
    {
        private readonly IUnitOfWork _db;

        public CreateCourseCommandHandler(IUnitOfWork db)
        {
            _db = db;
        }

        public async Task<int> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            // Validation: unique CourseCode
            //bool exists = await _db.Courses
            //    .AnyAsync(c => c.CourseCode == request.Request.CourseCode, cancellationToken);

            //if (exists)
            //{
            //    throw new InvalidOperationException("CourseCode already exists.");
            //}

            //var entity = new Course
            //{
            //    CourseCode = request.Request.CourseCode,
            //    Title = request.Request.Title,
            //    Description = request.Request.Description,
            //    Category = request.Request.Category,
            //    Level = request.Request.Level,
            //    IsPublished = false,
            //    CreatedBy = request.CurrentUserId,
            //    CreatedDate = DateTime.UtcNow
            //};

            //_db.Courses.Add(entity);
            //await _db.SaveChangesAsync(cancellationToken);

            //return entity.CourseId;

            return 0;
        }
    }
}
