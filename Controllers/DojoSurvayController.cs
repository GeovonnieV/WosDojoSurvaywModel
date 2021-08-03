using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WosDojoSurvaywModel.Models;


namespace WosDojoSurvaywModel.Controllers
    {
        public class DojoSurvayController : Controller
            {
                [HttpGet("")]
                public IActionResult Index()
                    {
                       return View();
                    }


                [HttpGet("results")]
                public IActionResult results()
                    {
                        return View("results");
                    }
                
                [HttpPost("results")]
                public IActionResult resultsPost(Person guy)
                    {
                      
                      return View("results", guy);
                    }
            }

    }
