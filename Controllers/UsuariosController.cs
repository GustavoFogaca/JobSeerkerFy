using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.models; 
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
       [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly DataContext _context;

        //Construtor
        public UsuarioController(DataContext context) => _context = context;

        //POST: api/usuario/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return Created("", usuario);
        }

        //GET: api/usuario/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Usuarios.ToList());

        //GET: api/usuario/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {

            Usuario usuario = _context.Usuarios.Find(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }
          //DELETE: api/usuario/delete/piao
         [HttpDelete]
         [Route("delete/{name}")]
         public IActionResult Delete([FromRoute] string name)
         {
             Usuario usuario = _context.Usuarios.FirstOrDefault(
                 x => x.Nome == name
             );
             if (usuario == null)
             {
                 return NotFound();
             }
             _context.Usuarios.Remove(usuario);
             _context.SaveChanges();
             return Ok(_context.Usuarios.ToList());
         }
        //PUT: api/usuario/update
        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
            return Ok(usuario);
        }

  
  }
   
}