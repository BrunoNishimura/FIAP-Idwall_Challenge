using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using FIAP_Idwall.Persistence;
using FIAP_Idwall.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FIAP_Idwall.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FiapIdwallController : ControllerBase
    {
        public readonly FIAP_IdwallContext _context;
        public FiapIdwallController(FIAP_IdwallContext context)
        {
            _context = context;
        }

       [HttpGet]
        public IEnumerable<FiapIdwall> Get()
        {
           return _context.FiapIdwalls;
        }

        [HttpGet("{id}")]
        public FiapIdwall GetById(int id)
        {
            return _context.FiapIdwalls.FirstOrDefault(evento => evento.Id == id); //retorna com os ids
        }


        [HttpPost]
        public string Post()
        {
           return "Exemplo de Post";
        }

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
