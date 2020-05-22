using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_soloClase
{
    class cs_Persona
    {
        string nombre;
        int edad;
        string iD;
        double salario;

        /// <summary>
        /// Obtener y dar variable 
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string ID { get => iD; set => iD = value; }
        public double Salario { get => salario; set => salario = value; }

        public double Persona_CalcularSalario(int edad)
        {
            return edad * 13500;
        }
    }
}
