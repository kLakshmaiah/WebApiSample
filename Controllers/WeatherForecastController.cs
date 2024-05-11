//using Microsoft.AspNetCore.Mvc;
//using WebApplication5.Model;
//using WebApplication5.Models;

//namespace WebApplication5.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class WeatherForecastController : ControllerBase
//    {
//        public Vechile VechlisList;
//        public WeatherForecastController()
//        {
//            try
//            {
//                List<Vechile> vechiles = new List<Vechile> {
//                new Vechile(new List<Vechile>())
//                {
//                    Description = "John is a student1",
//                    Id = 1,
//                    Name = "John",
//                    StudentId = 1
//                }
//                };
//                VechlisList = new Vechile(vechiles);

                
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }
//        [HttpGet]
//        public List<Vechile> GetVechiles()
//        {
//            return VechlisList.Vechiles;
//        }
//        [HttpPost]
//        public Vechile Post(Vechile vechile)
//        {

//            return vechile;
//        }
//    }
//}
