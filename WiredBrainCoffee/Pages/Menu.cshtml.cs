using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee.Pages
{
    public class MenuModel : PageModel
    {
        private readonly IMenuService _menuService;
        private readonly ILogger<MenuModel> _logger;

        public List<MenuItem> Menu { get; set; }

        public MenuModel(IMenuService menuService, ILogger<MenuModel> logger)
        {
            _menuService = menuService ?? throw new ArgumentNullException(nameof(menuService));
            _logger = logger;
        }

        public void OnGet()
        {
            try
            {
                Menu = _menuService.GetMenuItems();
                throw new Exception("asd");
            }
            catch (Exception exception)
            {
                _logger.Log(LogLevel.Debug, "Could not retrieve menu");
            }
            
        }

        public void OnReason()
        {

        }
    }
}
