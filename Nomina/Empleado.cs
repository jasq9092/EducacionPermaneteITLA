

namespace Nomina
{
    public class Empleado
    {
        public string? primerNombre { get; set; }
        public string? apellidoMaterno { get; set; }
        public string? numeroSegurosocial { get; set; }

        public Empleado( string primernombre, string apellidomaterno, string numerosegurosocial) 
        
        {
            primerNombre = primernombre;
            apellidoMaterno = apellidomaterno;
            numeroSegurosocial = numerosegurosocial;
        }



    }
}
