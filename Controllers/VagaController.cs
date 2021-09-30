using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.models; 
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
       [ApiController]
    [Route("api/vaga")]
    public class VagaController : ControllerBase
    {
        private readonly DataContext _context;

        //Construtor
        public VagaController(DataContext context) => _context = context;

        //POST: api/vaga/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Vaga vaga)
        {
            _context.Vagas.Add(vaga);
            _context.SaveChanges();
            return Created("", vaga);
        }

        //GET: api/vaga/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Vagas.ToList());

        //GET: api/vaga/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {

            Vaga vaga = _context.Vagas.Find(id);
            if (vaga == null)
            {
                return NotFound();
            }
            return Ok(vaga);
        }
          //DELETE: api/vaga/delete/piao
         [HttpDelete]
         [Route("delete/{name}")]
         public IActionResult Delete([FromRoute] string name)
         {
             Vaga vaga = _context.Vagas.FirstOrDefault(
                 x => x.Nome == name
             );
             if (vaga == null)
             {
                 return NotFound();
             }
             _context.Vagas.Remove(vaga);
             _context.SaveChanges();
             return Ok(_context.Vagas.ToList());
         }
        //PUT: api/vaga/update
        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] Vaga vaga)
        {
            _context.Vagas.Update(vaga);
            _context.SaveChanges();
            return Ok(vaga);
        }

  
  }
   
}