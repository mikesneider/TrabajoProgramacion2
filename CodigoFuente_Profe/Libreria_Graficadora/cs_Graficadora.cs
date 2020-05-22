using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Graficadora
{
    public class cs_Graficadora
    {
        UC_PanelGrafica MiPanel = new UC_PanelGrafica();
        public void IngresarValores(string Nombre, int Cantidad)
        {
            MiPanel.AnadirDatos(Nombre, Cantidad);
        }

    }
}
