using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.CD_Model.Pers
{
    public class CD_PersContacto
    {
        public int IdContacto { get; set; }
        public int IdPersona { get; set; }
        public int IdTipoContacto { get; set; }
        public string DescripcionContact { get; set; }
        public string CodArea { get; set; }
    }
}
