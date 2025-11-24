using System.Collections.Generic;
using MediatR;
using LMS.Application.DTOs;
using LMS.Common.Models;

namespace LMS.Application.Queries
{
    public class GetUsersByTypeQuery : IRequest<ApiResponse<IEnumerable<UserDto>>>
    {
        public int PropertyId { get; set; }
        public string UserType { get; set; } = string.Empty;
    }
}