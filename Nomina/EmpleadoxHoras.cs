using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    public class EmpleadoxHoras:Empleado
    {
        public int sueldoxHoras {  get; set; }
        public int horasTrabajadas { get; set;}

        public EmpleadoxHoras( string primerNombre, string apellidoMaterno, string numeroSegurosocial): base(primerNombre, apellidoMaterno, numeroSegurosocial)
        {
        } 
        
       

    }
}
