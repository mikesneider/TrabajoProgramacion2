using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Class1
    {
        static private string DireccionBD;
        static private OleDbConnection getConexion;
        static private string PasswordBD = "M1K3";
        static private string Stringconeccion = string.Format(@"PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source={0}; Jet OLEDB:Database Password={1}", DireccionBD, PasswordBD);


        static public void SetDir()
        {

        }
        static public void ConectarDB()
        {
            string gsPathUbicar = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            gsPathUbicar = gsPathUbicar.Substring(6);
            DireccionBD = gsPathUbicar + "\\Arenamiento.mdb";
            getConexion = new OleDbConnection(Stringconeccion);
            getConexion.Open();
        }
        static public void ConectarDB2()
        {
            var conn = new SqlConnection(Stringconeccion);

            conn.Open();
        }
    }
}
