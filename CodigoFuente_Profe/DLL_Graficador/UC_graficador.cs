using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLL_Graficador
{
    public partial class UC_graficador : UserControl
    {
        public UC_graficador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chart1.Series[0].Label.visi
            if (chart1.Series[0].IsValueShownAsLabel)
                chart1.Series[0].IsValueShownAsLabel = false;
            else
                chart1.Series[0].IsValueShownAsLabel = true;
        }
    }
}
