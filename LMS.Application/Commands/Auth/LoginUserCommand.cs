using MediatR;
using LMS.Application.DTOs.Auth;
using LMS.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Commands.Auth
{
    public class LoginUserCommand : IRequest<ApiResponse<LoginResponseDto>>
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
