using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class cs_empleado : cs_usuario
    {
        DateTime FechaIngreso;
        private string cargo;
        int rangosalarial;

        public DateTime FechaIngreso1 { get => FechaIngreso; set => FechaIngreso = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int Rangosalarial { 
            //no se puede modificar el rango, solo el software lo hará
            //de manera automática
            get => rangosalarial;  
        }
    }
}
