using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Data;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportsController : ControllerBase
    {

        [HttpGet]
        public ActionResult GetSports()
        {
            return Ok(SportsData.Sports);
        }

        [HttpPost]
        public IActionResult Post(Sports sports)
        {   
            if(ModelState.IsValid)
            {
                return Ok(sports);
            }
            return Ok(ModelState.Values.SelectMany(e => e.Errors).Select(e => e.ErrorMessage).ToList());
        }
    }
}
