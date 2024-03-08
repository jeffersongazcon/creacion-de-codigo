using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVotacion.ENTITY
{
    public class Persona
    {
        public Persona()
        {
            Cedula=string.Empty;
            Nombre=string.Empty;
            Telefono=string.Empty;
            Sexo=string.Empty;
            Edad = 0;
        }

        public Persona(string cedula, string nombre, string telefono, string sexo, int edad)
        {
            Cedula = cedula;
            Nombre = nombre;
            Telefono = telefono;
            Sexo = sexo;
            Edad = edad;
        }

        public string Cedula{ get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }

    }
}
