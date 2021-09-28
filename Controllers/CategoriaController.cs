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
    public class CategoriaController : ControllerBase
    {
        private readonly DataContext _context;

        //Construtor
        public CategoriaController(DataContext context) => _context = context;

        //POST: api/categoria/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            return Created("", categoria);
        }

        //GET: api/categoria/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Categorias.ToList());

        //GET: api/categoria/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {

            Categoria categoria = _context.Categorias.Find(id);
            if (categoria == null)
            {
                return NotFound();
            }
            return Ok(categoria);
        }
          //DELETE: api/categoria/delete/piao
         [HttpDelete]
         [Route("delete/{name}")]
         public IActionResult Delete([FromRoute] string name)
         {
             Categoria categoria = _context.Categorias.FirstOrDefault(
                 x => x.Nome == name
             );
             if (categoria == null)
             {
                 return NotFound();
             }
             _context.Categorias.Remove(categoria);
             _context.SaveChanges();
             return Ok(_context.Categorias.ToList());
         }
        //PUT: api/categoria/update
        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] Categoria categoria)
        {
            _context.Categorias.Update(categoria);
            _context.SaveChanges();
            return Ok(categoria);
        }

  
  }
   
}