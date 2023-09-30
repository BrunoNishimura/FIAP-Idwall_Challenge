using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using FIAP_Idwall.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FIAP_Idwall.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FiapIdwallController : ControllerBase
    {
        public IEnumerable<FiapIdwall> _fiapIdwallArray = new FiapIdwall[]{
            new FiapIdwall() {
                WantedId = 1,
                PictureUrl = "https://ws-public.interpol.int/notices/v1/red/2023-14388/images/62681007",
                Fullname = "XUILI WANG",
                DateOfBirth = DateTime.Parse("1983/11/17"),
                Details = "https://www.interpol.int/How-we-work/Notices/Red-Notices/View-Red-Notices#2023-14388"
            },
            new FiapIdwall() {
                WantedId = 2,
                PictureUrl = "https://ws-public.interpol.int/notices/v1/red/2022-44424/images/62488111",
                Fullname = "ZHENG LING YAO",
                DateOfBirth = DateTime.Parse("1980/04/12"),
                Details = "https://www.interpol.int/How-we-work/Notices/Red-Notices/View-Red-Notices#2022-44424"
            },
        };

        public FiapIdwallController()
        {

        }

       [HttpGet]
        public IEnumerable<FiapIdwall> Get()
        {
           return _fiapIdwallArray;
        }

        [HttpGet("{id}")]
        public FiapIdwall GetById(int id)
        {
            return _fiapIdwallArray.FirstOrDefault(evento => evento.WantedId == id); //retorna com os ids
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
