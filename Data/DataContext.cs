using API.models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
       // Construtor

       public DataContext(DbContextOptions<DataContext> options) : base(options) { }
   
   
       //lista de propriedades das classes de modelos que vao virar tabelas no banco
     public DbSet<Categoria> Categorias {get; set;}
     public DbSet<Usuario> Usuarios {get; set;}
     public DbSet<Vaga> Vagas {get; set;}
     
   
    }
}