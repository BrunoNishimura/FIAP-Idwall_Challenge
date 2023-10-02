using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using FIAP_Idwall.API.Data;
using FIAP_Idwall.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FIAP_Idwall.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FiapIdwallController : ControllerBase
    {
        public readonly DataContext _context;
        public FiapIdwallController(DataContext context)
        {
            _context = context;
        }

       [HttpGet]
        public IEnumerable<FiapIdwall> Get()
        {
           return _context.GetDbFiapIdwalls;
        }

        [HttpGet("{id}")]
        public FiapIdwall GetById(int id)
        {
            return _context.GetDbFiapIdwalls.FirstOrDefault(evento => evento.WantedId == id); //retorna com os ids
        }

        [HttpPost]
        public IActionResult Post([FromBody] FiapIdwall model)
        {
            if (model == null)
            {
                return BadRequest("Os dados postados são inválidos.");
            }

            return CreatedAtAction("Get", new { id = model.WantedId }, model);
        }

        // [HttpPost]
        // public string Post()
        // {
        //    return "Exemplo de Post";
        // }

        [HttpPut("{id}")]
        public string Put(int id)
        {
           return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return $"Exemplo de Delete com id = {id}";
        }        
    }
}
