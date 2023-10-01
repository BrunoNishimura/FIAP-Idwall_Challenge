using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP_Idwall.Domain
{
    public class FiapIdwall
    {
        public int Id { get; set; }

        public string PictureUrl { get; set; }

        public string Fullname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Nationality { get; set; }

        public string Details { get; set; }

        // public int? InterpolId { get; set; }

        public ModelInterpol ModelInterpol { get; set; }

        // public int? FbiId { get; set; }

        public ModelFbi ModelFbi { get; set; }
    }
}