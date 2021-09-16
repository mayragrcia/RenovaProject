using System.ComponentModel.DataAnnotations;

namespace projetoRenova.Models{
    public class Items{
        [Key]
        public int Id {get; set;}

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string nomeItem {get; set;}
    }
}