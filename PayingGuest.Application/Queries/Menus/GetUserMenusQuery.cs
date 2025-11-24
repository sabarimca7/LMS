using MediatR;
using LMS.Application.DTOs.Menus;
using LMS.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Queries.Menus
{
    public class GetUserMenusQuery : IRequest<ApiResponse<List<MenuDto>>>
    {
        public int UserId { get; set; }
    }
}
