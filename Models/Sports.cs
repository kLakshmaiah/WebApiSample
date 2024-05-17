using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class Sports
    {
        [Required(ErrorMessage ="{0} is required")]
        [Min(2,ErrorMessage ="{0} value is minimum {1}")]
        [Max(10,ErrorMessage ="{0} value is Maximum {1}")]
        public int? Id { get; set; }
        //[Required(ErrorMessage ="{0 is required}")]
        [StringLength(3,MinimumLength =3,ErrorMessage ="{0} having  {1} characters only")]
        //[Min(2,ErrorMessage = "{0} having only {1} characters\"")]
        public string? SportName { get; set; }
        public int? NumberOfPlayers { get; set; }

    }
}
