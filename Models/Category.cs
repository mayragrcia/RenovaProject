using System.ComponentModel.DataAnnotations;

namespace projetoRenova.Models{
    public class Category{
        [Key]
        public int Id {get; set;}
        public string nomeCategory {get; set;}

        public int categoryId{get;set;}
        public Category category { get; set; }
    }
}