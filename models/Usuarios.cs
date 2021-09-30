using System;

namespace API.models
{
    

    
    public class Usuario
    {
     
     //Construtor
        public Usuario() => CriadoEm = DateTime.Now;
    
    // atributos ou propriedades     
     public int Id {get; set;}
     public string Nome { get; set; }    
     public string Sobrenome {  get; set; } 
     public string Endereco {get;  set;  }
     public string Descricao {get; set; }
     public DateTime CriadoEm {get; set; }
        
     public override string ToString() =>
      $"Nome: {Nome} | Sobrenome: {Sobrenome} | CriadoEm em: {CriadoEm}";
    
    }
}