using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Form1 : formularioBase
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formularioBase FA = new formularioBase();
            FA.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f_llenarDatos FLL = new f_llenarDatos();
            FLL.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f_informacion FI = new f_informacion();
            FI.Show();
        }
    }
}
