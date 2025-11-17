using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.CL_Model.Inst
{
    public class CL_InstCorrelativMateria
    {
       public int  IdCorrelatividad { get; set; }
       public int IdMateria { get; set; }
       public int IdMateriaCorrelativ { get; set; }
       public bool Activo { get; set; }
    }
}
