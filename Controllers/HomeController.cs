using CurencyParcer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CurencyParcer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMemoryCache memoryCahe;

        public HomeController(IMemoryCache memoryCahe)
        {
            this.memoryCahe = memoryCahe;
        }

        public IActionResult Index()
        {
            if(!memoryCahe.TryGetValue("key_currency",out CurencyConverter model))
            {
                throw new Exception("Ошибка получения данных");
            }
            return View(model);
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
