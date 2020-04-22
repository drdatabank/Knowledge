using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knowledge.Data;
using Microsoft.AspNetCore.Mvc;

namespace Knowledge.Controllers
{
    public class EnglishController : Controller
    {
        private readonly ApplicationDbContext context;

        public EnglishController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllWords()
        {
            var result = context.EnglishDictionary.ToList();
            return View();
        }
    }
}