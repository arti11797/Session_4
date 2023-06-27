using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppSession_4.Contex
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

       // [ForeignKey(nameof(CatId))]
       // public int CatId { get; set; }
        //public Category Category { get; set; }
    }
}
