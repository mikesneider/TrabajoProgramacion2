using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp2
{
    class DB_conexion
    {
        static private string DireccionBD;
        static private string PasswordBD = ConfigurationSettings.AppSettings["contrasenaDB"];
        static private string NombreDB = ConfigurationSettings.AppSettings["nombreDB"];

        static private OleDbConnection getConexion;


        static public void SetDireccionBD(string dirBD)
        {
            cs_Logger.Log(string.Format("dirBD = {0}", dirBD), cs_Logger.LogLevel.INFO);
            DireccionBD = dirBD;
        }

        static public void conectar()
        {
            try
            {
                string gsPathUbicar = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                gsPathUbicar = gsPathUbicar.Substring(6);
                string micadena = "C:\\Users\\mikes\\OneDrive\\UDI\\Mis Crusos\\2020-I\\Programacion 2\\ProyectoFinal_Prog2\\WindowsFormsApp2\\bin\\Debug";
                DireccionBD = gsPathUbicar + "\\" + NombreDB;
                string Stringconeccion = string.Format(@"PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source={0}; Jet OLEDB:Database Password={1}", DireccionBD, PasswordBD);
                getConexion = new OleDbConnection(Stringconeccion);
                getConexion.Open();
                //MessageBox.Show("Genial! habemus conexion", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception H)
            {
                MessageBox.Show("Hay un error en la conexión a la BD");
            }
        }
        static public void conectarRecursos()
        {
            string gsPathUbicar = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            gsPathUbicar = gsPathUbicar.Substring(6);
            DireccionBD = gsPathUbicar + "\\Recursos.mdb";
            string Stringconeccion = string.Format(@"PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source={0}; Jet OLEDB:Database Password={1}", DireccionBD, PasswordBD);
            getConexion = new OleDbConnection(Stringconeccion);
            getConexion.Open();
        }
        static public void conectarExterno(string DirBD)
        {
            DireccionBD = DirBD;
            string Stringconeccion = string.Format(@"PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source={0}; Jet OLEDB:Database Password={1}", DireccionBD, PasswordBD);
            getConexion = new OleDbConnection(Stringconeccion);
            getConexion.Open();
            MessageBox.Show("Conexión a Base de Datos, exitosa!!!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        static public void desconectar()
        {
            getConexion.Close();
            getConexion.Dispose();
        }

        static public long EjecutarEscalar(string SQL)
        {
            try
            {
                //cs_Logger.Log(string.Format("string SQL = {0}", SQL), cs_Logger.LogLevel.INFO);
                OleDbCommand Secuencia_Bus; //secuencia de busqueda a ejecutar
                Secuencia_Bus = new OleDbCommand(SQL, getConexion);
                Secuencia_Bus.CommandType = CommandType.Text;
                return Convert.ToInt64(Secuencia_Bus.ExecuteScalar());
            }
            catch (Exception ex)
            {
                //cs_Logger.Log(string.Format("Excepcion: {0}", ex), cs_Logger.LogLevel.ERROR);
                return -1;
            }
        }

        static public long getLastIndex()
        {
            return EjecutarEscalar("SELECT @@IDENTITY;");
        }


        static public bool EjecutarBusqueda(string SQL)
        {
            try
            {
                //cs_Logger.Log(string.Format("string SQL = {0}", SQL), cs_Logger.LogLevel.INFO);
                OleDbCommand Secuencia_Bus; //secuencia de busqueda a ejecutar
                Secuencia_Bus = new OleDbCommand(SQL, getConexion);
                Secuencia_Bus.CommandType = CommandType.Text;
                Secuencia_Bus.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //cs_Logger.Log(string.Format("Excepcion: {0}", ex), cs_Logger.LogLevel.ERROR);
                return false;
            }
        }

        static OleDbType GetDBType(object o)
        {
            switch (o.GetType().ToString())
            {
                case "System.Int32": return OleDbType.Integer;
                case "System.Int64": return OleDbType.BigInt;
                case "System.Double": return OleDbType.Double;
                case "System.String": return OleDbType.Char;
                case "System.DateTime": return OleDbType.Date;
                case "System.Boolean": return OleDbType.Boolean;
                default: return OleDbType.Char;
            }
        }

        static public bool EjecutarBusqueda(string SQL, Dictionary<string, object> dict)
        {
            try
            {
                //cs_Logger.Log(string.Format("string SQL = {0}", SQL), cs_Logger.LogLevel.INFO);
                OleDbCommand Secuencia_Bus; //secuencia de busqueda a ejecutar
                Secuencia_Bus = new OleDbCommand(SQL, getConexion);
                dict.ToList().ForEach(kv => {
                    Secuencia_Bus.Parameters.Add(new OleDbParameter(kv.Key, GetDBType(kv.Value)));
                    Secuencia_Bus.Parameters[kv.Key].Value = kv.Value;
                    //Secuencia_Bus.Parameters.AddWithValue(kv.Key, kv.Value);
                });
                Secuencia_Bus.CommandType = CommandType.Text;
                Secuencia_Bus.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //cs_Logger.Log(string.Format("Excepcion: {0}", ex), cs_Logger.LogLevel.ERROR);
                return false;
            }
        }


        static public OleDbDataReader EjecutarLecturaR(string SQL, Dictionary<string, object> dict)
        {
            try
            {
                //cs_Logger.Log(string.Format("string SQL = {0}", SQL), cs_Logger.LogLevel.INFO);
                //conectar();
                OleDbCommand Secuencia_Bus;
                Secuencia_Bus = new OleDbCommand(SQL, getConexion);
                if (dict != null)
                {
                    dict.ToList().ForEach(kv =>
                    {
                        Secuencia_Bus.Parameters.Add(new OleDbParameter(kv.Key, GetDBType(kv.Value)));
                        Secuencia_Bus.Parameters[kv.Key].Value = kv.Value;
                    });
                }
                OleDbDataReader Leer = Secuencia_Bus.ExecuteReader();
                return Leer;
            }
            catch (Exception ex)
            {
                cs_Logger.Log(string.Format("Excepcion: {0}", ex), cs_Logger.LogLevel.ERROR);
                // desconectar();
                return null;
            }
        }


        static public DataTable EjecutarLectura(string SQL, Dictionary<string, object> dict)
        {
            try
            {
                cs_Logger.Log(string.Format("string SQL = {0}", SQL), cs_Logger.LogLevel.INFO);
                //conectar();
                OleDbCommand Secuencia_Bus = new OleDbCommand(SQL, getConexion);
                if (dict != null)
                {
                    dict.ToList().ForEach(kv =>
                    {
                        Secuencia_Bus.Parameters.Add(new OleDbParameter(kv.Key, GetDBType(kv.Value)));
                        Secuencia_Bus.Parameters[kv.Key].Value = kv.Value;
                    });
                }
                OleDbDataAdapter canal = new OleDbDataAdapter(Secuencia_Bus);
                DataTable t = new DataTable();
                canal.Fill(t);
                //desconectar();
                return t;
            }
            catch (Exception ex)
            {
                cs_Logger.Log(string.Format("Excepcion: {0}", ex), cs_Logger.LogLevel.ERROR);
                //desconectar();
                return null;
            }
        }

        static public DataView EjecutarLectura(string SQL, string stabla)
        {
            try
            {
                cs_Logger.Log(string.Format("string SQL = {0}", SQL), cs_Logger.LogLevel.INFO);

                //conectar();
                OleDbDataAdapter canal = new OleDbDataAdapter(SQL, getConexion);
                DataSet DS = new DataSet();
                canal.Fill(DS, stabla);
                //desconectar();
                return DS.Tables[stabla].DefaultView;
            }
            catch (Exception ex)
            {
                cs_Logger.Log(string.Format("Excepcion: {0}", ex), cs_Logger.LogLevel.ERROR);
                //desconectar();
                return null;
            }
        }

        static public DataTable EjecutarLectura(string SQL)
        {
            try
            {
                cs_Logger.Log(string.Format("string SQL = {0}", SQL), cs_Logger.LogLevel.INFO);
                //conectar();
                OleDbDataAdapter canal = new OleDbDataAdapter(SQL, getConexion);
                DataTable t = new DataTable();
                canal.Fill(t);
                //desconectar();
                return t;
            }
            catch (Exception ex)
            {
                cs_Logger.Log(string.Format("Excepcion: {0}", ex), cs_Logger.LogLevel.ERROR);
                //desconectar();
                return null;
            }
        }

        static public OleDbDataReader EjecutarLecturaR(string SQL, string stabla)
        {
            try
            {
                cs_Logger.Log(string.Format("string SQL = {0}", SQL), cs_Logger.LogLevel.INFO);
                //conectar();
                OleDbCommand Secuencia_Bus;
                Secuencia_Bus = new OleDbCommand(SQL, getConexion);
                OleDbDataReader Leer = Secuencia_Bus.ExecuteReader();
                return Leer;
            }
            catch (Exception ex)
            {
                cs_Logger.Log(string.Format("Excepcion: {0}", ex), cs_Logger.LogLevel.ERROR);
                // desconectar();
                return null;
            }
        }

        static public OleDbDataAdapter EjecutarLecturaRR(string SQL)
        {
            cs_Logger.Log(string.Format("string SQL : {0}", SQL), cs_Logger.LogLevel.INFO);
            OleDbDataAdapter adp = new OleDbDataAdapter(SQL, getConexion);
            return adp;
        }
    }
}
