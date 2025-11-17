using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.CD_Model.Mst
{
    public class CD_MstTituloGrado
    {
        public int IdMstTituloGrado { get; set; }
        public string Tipo { get; set; }
        public bool Activo { get; set; }
        public string Descripcion { get; set; }
    }
}
