using System.ComponentModel.DataAnnotations;

namespace projetoRenova.Models{
    public class Points{
        [Key]
        public int Id {get;set;}
        public string nomePonto{get;set;}
        public string descricaoPonto{get;set;}
        public string telefone{get;set;}
        public string email{get; set;}      
        public string endereco{get;set;}
        public string numero{get;set;}
        public string cep{get;set;}
        public string bairro{get;set;}
        public string cidade{get;set;}
        public string lat{get;set;}
        public string longtd{get;set;}  
        public int pointsId{get;set;}
        public Points Point{ get; set; }
    }
}