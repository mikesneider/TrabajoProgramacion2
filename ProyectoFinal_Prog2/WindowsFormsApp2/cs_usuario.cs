using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class cs_usuario
    {
         string cedula;
         string nombre;
         string apellido;
         DateTime FechaNaciemiento;

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNaciemiento1 { get => FechaNaciemiento; }
    }
}
