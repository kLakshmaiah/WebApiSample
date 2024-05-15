namespace WebApplication5.Models
{
    public class ConstructorClass
    {
        public readonly List<Vechile>? Vechiles;

        public ConstructorClass(List<Vechile> vechile)
        {
             // Vechiles?.AddRange(vechile);
              Vechiles = vechile;
        }
    }
}
