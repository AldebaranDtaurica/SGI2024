using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.CD_Model.Mst
{
    public class CD_MstInstitucional
    {
        public int IdParametro { get; set; }
        public string DescripcionParam { get; set; }
        public string ValorParam { get; set; }
        public bool Activo { get; set; }
    }
}
