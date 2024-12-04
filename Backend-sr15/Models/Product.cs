

using System.ComponentModel.DataAnnotations;

namespace Backend_sr15.Models
{
	public class Product
	{
        // KLUCZ GŁÓWNY
        // I sposób: Id
        public int Id { get; set; }

        // II sposób: [nazwaKlasy]Id // ProductId
        //public int ProductId { get; set; }

        // III sposób: dowolna nazwa + atrybut [Key]
        //[Key]
        //public int IdProd { get; set; }

        [Required]
        public string Name { get; set; }

        public double? Price { get; set; }
    }
}
