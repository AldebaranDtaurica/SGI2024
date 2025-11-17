using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.CD_Model.Mst
{
    public class CD_InstCarrerasDivision
    {
        public int IdCarreraDivision { get; set; }
        public int IdCarrera { get; set; }
        public bool Activo { get; set; }
        public int Division { get; set; }
        public int Anio { get; set; }
    }
}
