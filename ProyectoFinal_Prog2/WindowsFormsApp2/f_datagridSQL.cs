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
    public partial class f_datagridSQL : Form
    {
        public f_datagridSQL()
        {
            InitializeComponent();
        }

        private void f_datagridSQL_Load(object sender, EventArgs e)
        {
            DataTable libros = cs_Libros.traerTablita();
            dataGridView1.DataSource = libros;


            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                switch (column.Name)
                {
                    case "Id":
                        column.Visible = false;
                        column.ReadOnly = true;
                        break;
                    case "nombre2":
                    case "cantidad":
                        column.ReadOnly = false;
                        break;
                    default:
                        column.ReadOnly = true;
                        break;
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string data = (dataGridView1[e.ColumnIndex, e.RowIndex].Value).ToString();
            long IdSeleccionadoItem = Convert.ToInt64(dataGridView1[0, e.RowIndex].Value);

            switch (dataGridView1.Columns[e.ColumnIndex].Name)
            {
                case "nombre2":
                    //cs_Libros .UpdateBD_nombre(IdSeleccionadoItem, data);
                    break;
                case "cantidad":
                    try
                    {
                        int cant = Convert.ToInt32(Convert.ToUInt32(data));
                        //cs_Libros.UpdateBD_cantidad(IdSeleccionadoItem, cant);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("El campo cantidad debe ser un número positivo, el cambio no ha sido guardado", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                default:
                    break;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly)
            {
                e.CellStyle.ForeColor = Color.Red;
            }
        }
    }
}
