using System;

namespace API.models
{
    
    public class Vaga
    {
     
     //Construtor
        public Vaga() => CriadoEm = DateTime.Now;
    
    // atributos ou propriedades     
     public int Id {get; set;}
     public string Nome { get; set; }    
     public string Descricao {get; set; }
     public DateTime CriadoEm {get; set; }
        
     public override string ToString() =>
      $"Nome: {Nome} | CriadoEm em: {CriadoEm}";
    
    }
}