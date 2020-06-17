using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_soloClase
{
    public class cs_Calcular
    {
        int edad;
        string nombre;
        double salario;

        public double CalcularSalario(int edad)
        {
            return edad * 13500;
        }
        public double calcularSalarioPersona(int edad)
        {
            cs_Persona Persona = new cs_Persona();
            return 5; // Persona.calcularSalario(edad);
        }

    }
}
