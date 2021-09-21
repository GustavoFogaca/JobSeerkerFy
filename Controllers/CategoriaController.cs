using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.models; 
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/categoria")]
    
    
    // post api/categoria/create
    
    public class CategoriaController : ControllerBase
  {  
      
          private  readonly DataContext _context;
      
      
      public CategoriaController(DataContext context) =>  _context = context;
     
      
      
      [HttpPost]
      [Route("create")]
      public Categoria Create(Categoria categoria)
      {
        _context.Categorias.Add(categoria);
        _context.SaveChanges();
        return categoria;
      }
        
          [HttpGet]
          [Route("list")]
        public List<Categoria> List() => _context.Categorias.ToList();
    
   
   
   
   
   
   
   }
}