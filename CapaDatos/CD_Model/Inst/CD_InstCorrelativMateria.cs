using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.CD_Model.Inst
{
    public class CD_InstCorrelativMateria
    {
       public int  IdCorrelatividad { get; set; }
       public int IdMateria { get; set; }
       public int IdMateriaCorrelativ { get; set; }
       public bool Activo { get; set; }
    }
}
