

namespace Nomina
{
    public class EmpleadoBaseComision : Empleado
    {
        public int salarioBase {  get; set; }
        public int ventasBrutas { get; set; }
        public int salariobase { get; set; }

        public EmpleadoBaseComision(string primerNombre, string apellidoMaterno, string numeroSegurosocial) : base (primerNombre, apellidoMaterno, numeroSegurosocial)
        {


        }
    }
}
