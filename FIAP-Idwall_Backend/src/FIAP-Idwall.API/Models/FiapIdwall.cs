using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP_Idwall.API.Models
{
    public class FiapIdwall
    {
        [Key]
        public int WantedId { get; set; }
       
        public string PictureUrl { get; set; }

        public string Fullname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Nationality { get; set; }

        public string Details { get; set; }

    }
}