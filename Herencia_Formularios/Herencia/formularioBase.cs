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
    public partial class formularioBase : Form
    {
        public formularioBase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Rta = MessageBox.Show("Segura desea la ayuda", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rta == DialogResult.Yes)
            {
                f_about F = new f_about();
                F.Show();
            }
        }
    }
}
