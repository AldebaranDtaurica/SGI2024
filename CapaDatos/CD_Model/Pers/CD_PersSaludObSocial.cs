using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.CD_Model.Pers
{
    public class CD_PersSaludObSocial
    {
        public int IdPersSaludObSocial { get; set; }
        public int IdPersona { get; set; }
        public bool PoseeOS { get; set; }
        public string DescripcionOS { get; set; }
        public string NumAfiliadoOS { get; set; }
    }
}
