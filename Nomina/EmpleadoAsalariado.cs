

namespace Nomina
{
    public class EmpleadoAsalariado : Empleado
    {
        public int salarioSemanal {  get; set; }

        public EmpleadoAsalariado(string primerNombre, string apellidoMaterno, string numeroSegurosocial ) : base( primerNombre, apellidoMaterno, numeroSegurosocial ) 
        {

        }
        
    
    }
}
