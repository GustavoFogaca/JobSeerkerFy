using System;

namespace API.models
{
    

    
    public class Categoria
    {
     
     //Construtor
        public Categoria() => CriadoEm = DateTime.Now;
    
    // atributos ou propriedades     
     public int Id {get; set;}
     public string Nome { get; set; }    
     public double Piso {  get; set; } 
     public double Teto {get;  set;  }
     public string Descricao {get; set; }
     public DateTime CriadoEm {get; set; }
        
     public override string ToString() =>
      $"Nome: {Nome} | Piso: {Piso:C2} | CriadoEm em: {CriadoEm}";
    
    }
}