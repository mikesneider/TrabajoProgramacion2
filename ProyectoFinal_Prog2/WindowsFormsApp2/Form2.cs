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
    public partial class Form2 : f_base
    {
        CheckBox CKB_Global = new CheckBox();
        cs_Libros LibrosGlobal;
        UserControl Uc_Global = new UserControl();

        public Form2()
        {
            InitializeComponent();
        }
        private void renombrar()
        {
            LB_NombreLibro.Text = Res.tx_NombreLibro;
            LB_CantidadLibro.Text = Res.tx_CantidadLibros;
            BTN_Actualizar.Text = Res.tx_Actualizar;
            CKB_Activar.Text = Res.tx_activar;
        }
        /// <summary>
        /// Constructor del Formulario 2
        /// </summary>
        /// <param name="LibroLocal">Clase de tipo cs_Libros con información</param>
        /// <param name="CKB_local">objeto checkBox para activarlo si el usuario lo hace desde el Form2</param>
         internal Form2(UserControl UCRecibo, cs_Libros LibroLocal, CheckBox CKB_local, Form MiNewFBase, Color mifondo)
        {
            //base.BackColor = MiNewFBase.BackColor;
            InitializeComponent();
            this.BackColor = mifondo;
            

            CKB_Global = CKB_local;
            TB_Name.Text = LibroLocal.NameBook;
            TB_ISBN.Text = LibroLocal.Isbn;
            TB_CantLibros.Text = LibroLocal.QuantityBooks.ToString();
            CB_Editorial.Text = LibroLocal.Editorial.ToString();
            LibrosGlobal = LibroLocal;
            Uc_Global = UCRecibo;


        }
        private void Form2_Load(object sender, EventArgs e)
        {
            renombrar();
            this.BackColor = cs_Validaciones.colorFondo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LibrosGlobal.Editorial = CB_Editorial.Text;
            LibrosGlobal.Isbn = TB_ISBN.Text;
            LibrosGlobal.NameBook = TB_Name.Text;
            LibrosGlobal.QuantityBooks = int.Parse(TB_CantLibros.Text);
            Uc_Global.Controls["LB_NombreLibro"].Text = TB_Name.Text;
            CKB_Global.Checked = CKB_Activar.Checked;
            this.Close();



        }

        private void TB_CantLibros_Leave(object sender, EventArgs e)
        {
            cs_Validaciones.EsUnNumero(TB_CantLibros.Text);
        }
    }
}
