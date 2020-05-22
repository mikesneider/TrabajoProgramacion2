using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_Graficadora;
using System.Configuration;

namespace WindowsFormsApp2
{
    public partial class f_principal : f_base
    {
        int mivalor = 0;
        int contador = 0;
        List<UserControl> TodosMisUC = new List<UserControl>();
        UC_PanelGrafica MiGraf = new UC_PanelGrafica();

        public f_principal()
        {
            InitializeComponent();
            string val = ConfigurationManager.AppSettings["Mike"]; // .AppSettings["micadena"];
        }


        private void IncluirNuevoUsuario()
        {
            if (TodosLosValoresAgregados())
            {
                MiGraf.Visible = true;
                //chart1.Visible = true;
                cs_Libros LibroCreado = new cs_Libros(TB_Name.Text, int.Parse(TB_CantLibros.Text), TB_ISBN.Text, CB_Editorial.Text);
                cs_Comics Comm = new cs_Comics("spiderman", 75, "ERC-B45D", "Alpha");
                Comm.MarvelComics1 = true;
                Comm.DCComics1 = false;

                MiGraf.AnadirDatos(TB_Name.Text, int.Parse(TB_CantLibros.Text));
                LibroCreado.IngresarDatos(TB_Name.Text, int.Parse(TB_CantLibros.Text), TB_ISBN.Text, CB_Editorial.Text);
                UserControl1 MiUC = new UserControl1(LibroCreado, contador + 1, MiGraf,this);
                flowLayoutPanel1.Controls.Add(MiUC);
                //panel1.Controls.Add(MiUC);
                TodosMisUC.Add(MiUC);

                
                //uC_PanelGrafica1.AnadirDatos(TB_Name.Text, int.Parse(TB_CantLibros.Text));

                //MiUC.Location = new System.Drawing.Point(15, mivalor);
                //mivalor = MiUC.Size.Height + mivalor;
                
                contador++;
                LimpiarDatos(); //Esta función se encarga de limpiar las cajas de texto
               
            }
            else
                MessageBox.Show(Res.mjsLlenarCasillas, Res.mjsError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //MessageBox.Show("Debes incluir toda la información antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool TodosLosValoresAgregados()
        {
            if (TB_CantLibros.TextLength > 0 && TB_ISBN.TextLength > 0 && TB_Name.TextLength > 0 && CB_Editorial.Text.Length > 0)
                return true;
            return false;
        }
        private void Renombrar(string Cultura)
        {
            //Renombrar Objetos Form1
            #region Renombrar Labels
            LB_CantidadLibros.Text = Res.tx_CantidadLibros;
            LB_NombreLibro.Text = Res.tx_NombreLibro;
            Lbl_Elige_Idioma.Text = Res.tx_elige_idioma;
            LB_Editorial.Text = Res.Editorial;
            #endregion
            #region Renombrar Botones
            //BTN_Importar.Text = Res.tx_importar;
            BTN_Calcular.Text = Res.tx_Ingresar;
            #endregion
            #region Renombrar GroupBox
            this.GB_IngresarDatos.Text = Res.tx_IngresarDatos;
            #endregion
            #region Librerias
            MiGraf.Idioma(Cultura);
            base.renombrar();

            #endregion

            //Recorrer cada UserControl1 y Renombrar
            int contador = 0;
            foreach (UserControl1 UC in TodosMisUC)
            {
                UC.RenombrarTodo();
                contador += 1;
            }
            for(int i=0;i<=TodosMisUC.Count;i++)
            {
                contador++;
            }

            //Renombrar Form2.
        }
        private void LimpiarDatos()
        {
            TB_ISBN.Clear();
            CB_Editorial.Text = "";
            TB_Name.Clear();
            TB_CantLibros.Clear();
        }

        private void TB_CantLibros_Leave(object sender, EventArgs e)
        {
           try
            {
                int G = int.Parse(TB_CantLibros.Text);
            }
            catch(Exception K)
            {
                cs_Validaciones.EsUnNumero(TB_CantLibros.Text);
                //MessageBox.Show("Error");
            }

        }

        private void TB_ISBN_Leave(object sender, EventArgs e)
        {
            TB_ISBN.Text = TB_ISBN.Text.ToUpperInvariant();// .ToUpper();
        }

        private void BTN_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                IncluirNuevoUsuario();
                //int.Parse(TB_CantLibros.Text);
            }
            catch(Exception h)
            {
                //MessageBox.Show("Error");
            }
        }

        private void f_principal_Load(object sender, EventArgs e)
        {
            Panel_Grf.Controls.Add(MiGraf);
            MiGraf.Visible = false;
            //DB_conexion.conectar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Por Default es Idioma español
            if (CB_Idioma.SelectedIndex == 0)
            {
                //Idioma Español
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-CO");
                Renombrar("es-CO");
                
            }
            else if (CB_Idioma.SelectedIndex == 1)
            {
                //opcion 1 
                //Idioma Español
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                Renombrar("en-US");
            }
            else if (CB_Idioma.SelectedIndex == 2)
            { 
                //Idioma Frances
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
                Renombrar("fr-FR");
            }
            CB_Idioma.Items.Clear();
            CB_Idioma.Items.Add(Res.Espanol);
            CB_Idioma.Items.Add(Res.Ingles);
            CB_Idioma.Items.Add(Res.Frances);

        }

        private void BTN_Config_Click(object sender, EventArgs e)
        {
            modificarColorBase();
        }
        /// <summary>
        /// Función para modificar el color de fondo de los formularios
        /// </summary>
        private void modificarColorBase()
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //this -> objeto donde estoy
                //base -> obj de donde heredo "Yo soy tu padre"
                base.BackColor = colorDialog1.Color;
                cs_Validaciones.colorFondo = colorDialog1.Color;
                //MessageBox.Show(base.BackColor.Name.ToString(), base.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargaratosBD();
        }
        private void cargaratosBD()
        {
            MiGraf.Visible = true;
            List<cs_Libros> MiArrBD = cs_Libros.getAllFromBD();
            foreach (cs_Libros LibroCreado in MiArrBD)
            {
                //LibroCreado.IngresarDatos(TB_Name.Text, int.Parse(TB_CantLibros.Text), TB_ISBN.Text, CB_Editorial.Text);
                UserControl1 MiUC = new UserControl1(LibroCreado, contador + 1, MiGraf, this);
                flowLayoutPanel1.Controls.Add(MiUC);
                MiGraf.AnadirDatos(LibroCreado.NameBook, LibroCreado.QuantityBooks);
                //panel1.Controls.Add(MiUC);
                TodosMisUC.Add(MiUC);
                contador += 1;
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 FFFF = new Form2();
            FFFF.ShowDialog();
        }
    }
}
