using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_Idwall.Domain
{
    public class ModelInterpol
    {
        [Key]
        public int InterpolId { get; set; }

        public string InterpolPictureUrl { get; set; }

        public string InterpolFullname { get; set; }

        public DateTime InterpolDateOfBirth { get; set; }

        public string InterpolNationality { get; set; }

        public string InterpolDetails { get; set; }

        // public IEnumerable<FiapIdwall> FiapIdwalls { get; set; }
    }
}
