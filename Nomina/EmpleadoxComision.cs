

using System.Security.Cryptography.X509Certificates;

namespace Nomina
{
    public class EmpleadoxComision : Empleado
    {

        public int ventasBrutas {  get; set; }
        public int tarifaComision {  get; set; }

        public EmpleadoxComision(string primerNombre, string apellidoMaterno, string numeroSegurosocial) : base(primerNombre, apellidoMaterno, numeroSegurosocial)
        {
            this.ventasBrutas = ventasBrutas;
            this.tarifaComision = tarifaComision;
        }
    }
}
