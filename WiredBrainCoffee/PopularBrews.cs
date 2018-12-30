using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee
{
    public class PopularBrews : ViewComponent
    {
        private readonly IMenuService _menuService;

        public PopularBrews(IMenuService menuService)
        {
            _menuService = menuService ?? throw new ArgumentNullException(nameof(menuService));
        }

        public async Task<IViewComponentResult> InvokeAsync(int count)
        {            
            return View(_menuService.GetMenuItems().Take(count));
        }
    }
}
