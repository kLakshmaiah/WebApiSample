using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Linq;
using WebApplication5.IRepository;
using WebApplication5.Models;
using WebApplication5.Repository;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        public ConfigurationController(IConfiguration configuration,ILogger<ConfigurationController> logger, IStudentService studentService,IOptions<DatabaseValue> options) 
        {
            Configuration = configuration;
            Logger = logger;
            StudentService = studentService;
            Options = options;
        }

        public IConfiguration Configuration { get; }
        public ILogger<ConfigurationController> Logger { get; }
        public IStudentService StudentService { get; }
        public IOptions<DatabaseValue> Options { get; }

        [HttpGet]
        public IActionResult Get()
        {
            Logger.LogInformation("We are in ConfigurationController and Get Endpoint");
            //string ConnectionString1= Configuration["Database:ConnectionString"];
            #region  GetValue Method
            //string ConnectionString = Configuration.GetValue<string>("Database:ConnectionString");
            #endregion
            #region  Section Example
            IConfigurationSection configurationsection = Configuration.GetSection("Database");
            string ConnectionString = configurationsection.GetValue<string>("ConnectionString");
            #endregion
            #region  Through Class
            DatabaseValue databaseValue =  StudentService.GetDatabaseValuesFromConfiugration(configuration: Configuration, secotionName: "Database");//configuration:Configuration,secotionName: "IStudentService"
            DatabaseValue databaseValue2 = Configuration.GetSection("Database").Get<DatabaseValue>();
            DatabaseValue databaseValue1 =new DatabaseValue();
                Configuration.GetSection("Database").Bind(databaseValue1);
            #endregion
            return Ok(Options.Value);
        }
    }
}
