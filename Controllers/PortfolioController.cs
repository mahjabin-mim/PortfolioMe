using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortfolioMe.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PortfolioMe.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            Info info = new Info("Mahjabin Mim", "20-42231-1", "mahjabinmim711@gmail.com","+880 186095446");
            return View(info);
        }

        public IActionResult Education()
        {
            Education education1 = new Education("BSc", "American International University-Bangladesh, Dhaka", "2025","Computer Science and Engineering", "3.75");
            return View(education1);
        }
    }
}

