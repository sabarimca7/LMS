using Microsoft.EntityFrameworkCore;
using LMS.Domain.Entities;
using LMS.Domain.Interfaces;
using LMS.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructure.Repositories
{
    public class MenuRepository : Repository<Menu>, IMenuRepository
    {
        public MenuRepository(LMSDbContext context) : base(context)
        {
        }

       public async Task<IEnumerable<Menu>> GetMenusByUserIdAsync(int userId)
    {
        var menus = await (from menu in _context.Menus
                          join rmp in _context.RoleMenuPermissions on menu.MenuId equals rmp.MenuId
                          join role in _context.Roles on rmp.RoleId equals role.RoleId
                          join ur in _context.UserRoles on role.RoleId equals ur.RoleId
                          where ur.UserId == userId && menu.IsActive && rmp.IsActive && rmp.CanView
                          select menu)
                          .Distinct()
                          .OrderBy(m => m.DisplayOrder)
                          .ToListAsync();

        return menus;
    }

    public async Task<IEnumerable<Menu>> GetMenusByRoleIdsAsync(List<int> roleIds)
    {
        var menus = await (from menu in _context.Menus
                          join rmp in _context.RoleMenuPermissions on menu.MenuId equals rmp.MenuId
                          where roleIds.Contains(rmp.RoleId) && menu.IsActive && rmp.IsActive && rmp.CanView
                          select menu)
                          .Distinct()
                          .OrderBy(m => m.DisplayOrder)
                          .ToListAsync();

        return menus;
    }
    }
}
