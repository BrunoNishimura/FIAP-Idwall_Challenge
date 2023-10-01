using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_Idwall.Domain
{
    public class ModelInterpolFbi
    {
        [Key]
        public int InterpolId { get; set; }

        public ModelInterpol ModelInterpol { get; set; }

        public int FbiId { get; set; }

        public ModelFbi ModelFbi { get; set; }
    }
}
