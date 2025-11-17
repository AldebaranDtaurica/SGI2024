using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.CL_Model.Pers
{
    public class CL_PersSaludObSocial
    {
        public int IdPersSaludObSocial { get; set; }
        public int IdPersona { get; set; }
        public bool PoseeOS { get; set; }
        public string DescripcionOS { get; set; }
        public string NumAfiliadoOS { get; set; }
    }
}
