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
using dll_soloClase;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int mivalor = 0;
        int contador = 0;
        List<UserControl> TodosMisUC = new List<UserControl>();
        //en Form1

        private void Renombrar()
        {
            //Renombrar Objetos Form1
            #region Renombrar Labels
            LB_CantidadLibros.Text = Res.tx_CantidadLibros;
            LB_NombreLibro.Text = Res.tx_NombreLibro;
            #endregion
            #region Renombrar Botones
            BTN_Importar.Text = Res.tx_importar;
            Btn_Calcular.Text = Res.tx_Ingresar;
            #endregion
            #region Renombrar GroupBox
            this.GB_IngresarDatos.Text = Res.tx_IngresarDatos;
            #endregion

            //Recorrer cada UserControl1 y Renombrar 
            foreach (UserControl1 UC in TodosMisUC)
            {
                UC.RenombrarTodo();
            }

            //Renombrar Form2.
        }
        public Form1()
        {
            InitializeComponent();
            int[] mivec = new int[5];
            int a = 0;

            for(int k = 0; k < 5; k++)
            {
                mivec[k] = 5 + k;
            }
            for(int i=0; i<5;i++)
            {
                mivec[i] = mivec[a] + mivec[i];

            }
            for(int h=0;h<=4;h++)
            {
                a = a + mivec[h];
            }
            int b = a;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IncluirNuevoUsuario();
           
            //for(int i= 0;i<checkedListBox1.Items.Count;i++)
            //{
            //    checkedListBox1.SetItemChecked(i, false);
            //}
        }
        private void IncluirNuevoUsuario()
        {
            if (TodosLosValoresAgregados())
            {
                chart1.Visible = true;
                cs_Libros LibroCreado = new cs_Libros(TB_Name.Text, int.Parse(TB_CantLibros.Text), TB_ISBN.Text, 2);
                cs_Comics Comm = new cs_Comics("spiderman", 75, "ERC-B45D", 2);
                Comm.MarvelComics1 = true;
                Comm.DCComics1 = false;

                UserControl1 MiUC;// = new UserControl1(LibroCreado, contador+1);
               // panel1.Controls.Add(MiUC);
                //TodosMisUC.Add(MiUC);


                
                chart1.Series[0].Points.AddXY(TB_Name.Text, int.Parse(TB_CantLibros.Text));
                if(contador % 2 == 0)
                    chart1.Series[0].Points[contador].Color = Color.BlueViolet;
                else
                    chart1.Series[0].Points[contador].Color = Color.AliceBlue;
                contador++;
                LimpiarDatos(); //Esta función se encarga de limpiar las cajas de texto
                //chart1.ChartAreas[0].AxisY.Maximum = 6+1;
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

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            int EdadDigitada = int.Parse(TB_Raiz.Text);
            dll_soloClase.cs_Calcular Cal = new cs_Calcular();
            TB_Raiz.Text =  (Cal.calcularSalarioPersona(EdadDigitada)).ToString("F2");
        }

        private void TB_CantLibros_Leave(object sender, EventArgs e)
        {

           cs_Validaciones.EsUnNumero(TB_CantLibros.Text);
           //MessageBox.Show( Res.mjsMensajeSoloNumeros, Res.mjsError,MessageBoxButtons.OK,MessageBoxIcon.Error);
           //TB_CantLibros.Clear();
           //TB_CantLibros.Focus();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            //series.ChartType = SeriesChartType.Spline;

            //series.Points.AddXY("September", 100);
        }
        private void LimpiarDatos()
        {
            TB_ISBN.Clear();
            CB_Editorial.Text = "";
            TB_Name.Clear();
            TB_CantLibros.Clear();
        }

        private void TB_ISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TB_ISBN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TB_ISBN_Leave(object sender, EventArgs e)
        {
            TB_ISBN.Text = TB_ISBN.Text.ToUpperInvariant();// .ToUpper();
        }

        private void CB_Idioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Por Default es Idioma español
            if (CB_Idioma.SelectedIndex == 1)
            {
                //Idioma Ingles
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                Renombrar();
                //CB_Idioma.Items.Clear();
                //CB_Idioma.Items.Add("")
            }
            else
            {
                //opcion 0 (cero)
                //Idioma Español
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-CO");
                Renombrar();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //backgroundcolor.color 
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //messagebox
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //loading
        }
    }
}
