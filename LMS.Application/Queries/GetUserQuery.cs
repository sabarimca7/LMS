using MediatR;
using LMS.Application.DTOs;
using LMS.Common.Models;

namespace LMS.Application.Queries
{
    public class GetUserQuery : IRequest<ApiResponse<UserDto>>
    {
        public int UserId { get; set; }
    }
}