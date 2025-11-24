using MediatR;
using LMS.Application.DTOs;
using LMS.Common.Models;

namespace LMS.Application.Commands
{
    public class RegisterUserCommand : IRequest<ApiResponse<UserDto>>
    {
        public RegisterUserDto RegisterUserDto { get; set; } = null!;
    }
}