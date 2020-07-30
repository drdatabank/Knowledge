using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knowledge.Data;
using Knowledge.Data.Entities.English;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Knowledge.Controllers
{
    //[Route("api/[Controller]")]
    public class EnglishController : Controller
    {
        //private readonly ILogger logger;
        private readonly ApplicationDbContext context;

        public EnglishController(/*ILogger logger,*/ ApplicationDbContext context)
        {
            //this.logger = logger;
            this.context = context;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = context.EnglishDictionary
                    //.Select(e=>new {
                    //    englishWord = e.englishWord,
                    //    polishWord = e.polishWord
                    //})                    
                    .ToList();
                
                return Ok(result);
            }
            catch (Exception ex)
            {
                //logger.LogError($"Failed to get english words: {ex}");
                return BadRequest($"Failed to get english words");
            }

        }

        [HttpGet]
        public JsonResult GetDetails(int id)
        {
            try
            {
                //var result = context.EnglishDictionary
                //    .Select(e=>e.EnglishDictionaryDetails)               
                //    .ToList();

                //var result = new List<EnglishDictionaryDetails>();
                var details = new EnglishDictionaryDetails();
                details.Id = id;
                details.CorrectWrittenCount = 1;
                details.CorrectAnswersCount = 4;
                details.WrongAnswersCount = 12;
                //result.Add(details);

                return Json(details);//Ok(result);
            }
            finally { }
            //catch (Exception ex)
            //{
            //    //logger.LogError($"Failed to get english words: {ex}");
            //    return BadRequest($"Failed to get english words");
            //}
        }
    }
}