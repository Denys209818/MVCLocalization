using LocalizationDefault.ActionServices;
using LocalizationDefault.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace LocalizationDefault.Controllers
{
    [Internalization]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //  Створення обєкту IStringLocalizer<HomeController>, щоб отримати дані з
        //  ресурсів на контроллері
        private IStringLocalizer<HomeController> _stringLocalizer;
        public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            //  Ініціалізація IStringLocalizer<HomeController>
            _stringLocalizer = localizer;
        }

        public IActionResult Index()
        {
            //  Отримання Email на контроллері
            string email = _stringLocalizer["Email"];
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
