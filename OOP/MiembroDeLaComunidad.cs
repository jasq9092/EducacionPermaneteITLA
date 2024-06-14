using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class MiembroDeLaComunidad
    {

        public int Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Edad {  get; set; }
        public string? Telefono { get; set; }
        public string? Rol {  get; set; }

        protected MiembroDeLaComunidad(int codigo, string nombre, string apellido, int edad, string telefono, string rol) 
        { 
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Telefono = telefono;
            Rol = rol;

        
        }


    }
}
