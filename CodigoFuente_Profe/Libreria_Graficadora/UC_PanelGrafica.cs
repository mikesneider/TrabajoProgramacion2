using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Libreria_Graficadora
{
    public partial class UC_PanelGrafica : UserControl
    {
        public UC_PanelGrafica()
        {
             InitializeComponent();
        }
        /// <summary>
        /// Se añaden datos a la gráfica
        /// </summary>
        /// <param name="Nombre">Variable eje x o nombre del libro</param>
        /// <param name="cantidad">Variable eje Y o cantidad de libros</param>
        public void AnadirDatos(string Nombre, int cantidad)
        {
            chart1.Series[0].Points.AddXY(Nombre, cantidad);
            if (chart1.Series[0].Points.Count % 2 == 0)
                chart1.Series[0].Points[chart1.Series[0].Points.Count-1].Color = Color.BlueViolet;
            else
                chart1.Series[0].Points[chart1.Series[0].Points.Count-1].Color = Color.Aquamarine;
        }
        /// <summary>
        /// Función para actualizar los valores de la gráfica cuando actualicen los valores desde
        /// el Form2
        /// </summary>
        /// <param name="posicionDato">El orden en que se incluyó el dato</param>
        /// <param name="DatoName">Valor X (nombre del libro)</param>
        /// <param name="NumData">Valor numérico o cantidad de libros</param>
        public void UpdateChart(int posicionDato, string DatoName, int NumData)
        {
            //double actualMaximo = chart1.ChartAreas[0].AxisY.Maximum;
            chart1.Series[0].Points.ElementAt(posicionDato).SetValueXY(DatoName,NumData);
            chart1.ChartAreas[0].RecalculateAxesScale(); //RoundAxisValues();
            
            
            //chart1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(chart1.Series[0].IsValueShownAsLabel)
                chart1.Series[0].IsValueShownAsLabel = false;
            else
                chart1.Series[0].IsValueShownAsLabel = true;
        }
        public void Idioma(string Cultura)
        {
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo(Cultura);
            Renombrar();
        }
        private void Renombrar()
        {
            button1.Text = Res.Etiquetas;
        }
    }
}
