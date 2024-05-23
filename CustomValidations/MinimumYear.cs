using System.ComponentModel.DataAnnotations;

namespace WebApplication5.CustomValidations
{
    public class MinimumYear:ValidationAttribute
    {
        string DefaulYear { get; set; } = "Year Must be greater than {0} your value is {1}";
        public int MinimuYear { get; set; }

        public MinimumYear(int minimuYear)
        {
            MinimuYear = minimuYear;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            DateTime? date = value as DateTime?;
            if(date is not null)
            {
                if(date.Value.Year>= MinimuYear)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(string.Format(ErrorMessage??DefaulYear, MinimuYear, date.Value.Year) );
                }
            }
            return null;
        }
    }
}
