using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_Graficadora;

namespace WindowsFormsApp2
{
    public partial class UserControl1 : UserControl 
    {
        cs_Libros LibGlobal;
        UC_PanelGrafica GrafGlobal;
        Form MiFGlobal;
        Color micolorglobal;

        public UserControl1()
        {
            InitializeComponent();
        }
        public UserControl1(int TipoElegido, int Contador)
        {
            InitializeComponent();
            LB_Nombre.Text = Contador.ToString();
            
        }
        /// <summary>
        /// Contructor UserControl para incluir clases de LIbros
        /// </summary>
        /// <param name="LibLocal"></param>
        /// <param name="Contador"></param>
        internal UserControl1(cs_Libros LibLocal, int Contador, UC_PanelGrafica GrafLocal, Form MiFPrincipal)
        {
            InitializeComponent();
            LB_Contador.Text = Contador.ToString();
            LB_NombreLibro.Text = LibLocal.NameBook;
            LibGlobal = LibLocal;
            GrafGlobal = GrafLocal;
            MiFGlobal = MiFPrincipal;
            micolorglobal = MiFPrincipal.BackColor;
            RenombrarTodo();
            
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BTN_1_Click(object sender, EventArgs e)
        {
            micolorglobal = MiFGlobal.BackColor;
            Form2 F2 = new Form2(this,LibGlobal, CKB_Activado, MiFGlobal,micolorglobal);
            F2.ShowDialog();
            //enviar dato modificado al chart1
            GrafGlobal.UpdateChart(int.Parse(LB_Contador.Text)-1, LibGlobal.NameBook, LibGlobal.QuantityBooks);
            //this.CKB_Activado = CKB_Activado;
        }
        public void RenombrarTodo()
        {
            LB_Nombre.Text = Res.tx_NombreLibro;
            BTN_Editar.Text = Res.tx_Editar;
            CKB_Activado.Text = Res.tx_activar;

        }
    }
}
