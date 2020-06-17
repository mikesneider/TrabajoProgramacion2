using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class cs_Personas
    {
        string nombrePersona;

        public cs_Personas(string nombrePersona)
        {
            NombrePersona = nombrePersona;
        }

        public string NombrePersona { get => nombrePersona; set => nombrePersona = value; }
    }
}
