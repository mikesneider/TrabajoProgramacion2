using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class f_base : Form
    {
        public f_base()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Ayuda = new Form3();
            Ayuda.ShowDialog();
        }
        public void renombrar()
        {
            Btn_ayuda.Text = Res.tx_activar;
        }

        private void f_base_Load(object sender, EventArgs e)
        {
            renombrar();
        }
    }
}
