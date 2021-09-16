using System.ComponentModel.DataAnnotations;

namespace projetoRenova.Models{
    public class Points{
        [Key]
        public int Id {get;set;}

        public string nomePonto{get;set;}
        public string descricaoPonto{get;set;}
        
    }
}