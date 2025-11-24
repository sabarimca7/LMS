using MediatR;
using Microsoft.Extensions.Logging;
using LMS.Application.DTOs.Menus;
using LMS.Application.Interfaces;
using LMS.Common.Models;
using LMS.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Queries.Menus
{
    public class GetUserMenusQueryHandler : IRequestHandler<GetUserMenusQuery, ApiResponse<List<MenuDto>>>
    {
        private readonly IMenuService _menuService;
        private readonly ILogger<GetUserMenusQueryHandler> _logger;

        public GetUserMenusQueryHandler(
            IMenuService menuService,
            ILogger<GetUserMenusQueryHandler> logger)
        {
            _menuService = menuService;
            _logger = logger;
        }

        public async Task<ApiResponse<List<MenuDto>>> Handle(GetUserMenusQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var menus = await _menuService.GetUserMenusAsync(request.UserId);

                if (menus == null || !menus.Any())
                {
                    return ApiResponse<List<MenuDto>>.SuccessResponse(
                        new List<MenuDto>(),
                        "No menus found for this user");
                }

                return ApiResponse<List<MenuDto>>.SuccessResponse(menus, "Menus retrieved successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving menus for user {UserId}", request.UserId);
                return ApiResponse<List<MenuDto>>.ErrorResponse($"Error retrieving menus: {ex.Message}");
            }
        }
    }
}
