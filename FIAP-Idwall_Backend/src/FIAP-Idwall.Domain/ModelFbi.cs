using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_Idwall.Domain
{
    public class ModelFbi
    {
        [Key]
        public int FbiId { get; set; }

        public string FbiPictureUrl { get; set; }

        public string FbiFullname { get; set; }

        public DateTime FbiDateOfBirth { get; set; }

        //public string Nationality { get; set; }

        public string FbiDetails { get; set; }

        // public IEnumerable<FiapIdwall> FiapIdwalls { get; set; }
    }
}
