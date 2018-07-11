using System.ComponentModel.DataAnnotations;

namespace CasaDoCodigo.Models{
    public class Categoria :BaseModel{

        public Categoria(){

        }

        public Categoria(string nome){
            this.Nome = nome;
        }
        [Required]
        public string Nome{get; private set;}
    }
}