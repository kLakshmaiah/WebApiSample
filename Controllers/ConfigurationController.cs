using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        public ConfigurationController(IConfiguration configuration,ILogger<ConfigurationController> logger) 
        {
            Configuration = configuration;
            Logger = logger;
        }

        public IConfiguration Configuration { get; }
        public ILogger<ConfigurationController> Logger { get; }

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
            DatabaseValue databaseValue =   Configuration.GetSection("Database").Get<DatabaseValue>();

            DatabaseValue databaseValue1 =new DatabaseValue();
                Configuration.GetSection("Database").Bind(databaseValue1);
            #endregion
            return Ok(databaseValue1.ConnectionString);
        }
    }
}
