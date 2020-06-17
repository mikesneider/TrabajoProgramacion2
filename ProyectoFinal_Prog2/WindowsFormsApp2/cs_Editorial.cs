using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class cs_Editorial
    {
        long id;
        string name;
        int anno;
        string duenno;

        private static string NombreTabla = "editoriales";
        private static string T_id = "id";
        private static string T_duenno = "dueno";
        private static string T_anno = "ano_inicio";
        private static string T_nombre = "nombre";

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Anno { get => anno; set => anno = value; }
        public string Duenno { get => duenno; set => duenno = value; }

        /// <summary>
        /// Funcion constructora
        /// </summary>
        /// <param name="id"></param>
        /// <param name="duennoEdito"></param>
        /// <param name="annoEdito"></param>
        /// <param name="nombreEdito"></param>
        public cs_Editorial (long id, string duennoEdito, int annoEdito, string nombreEdito)
        {
            this.Id = id;
            this.Name = nombreEdito;
            this.Anno = annoEdito;
            this.Duenno = duennoEdito;
        }
        public static DataTable traerTablita(string MyQuery = "")
        {
            MyQuery = "SELECT * FROM " + NombreTabla;
            return DB_conexion.EjecutarLectura(MyQuery);
        }

        /// <summary>
        /// Funcion para acceder a toda la info de la bd
        /// </summary>
        /// <param name="where"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static List<cs_Editorial> getAllFromBD(string where = "", Dictionary<string, object> parameters = null)
        {
            string strSQL = "SELECT * FROM " + NombreTabla;
            if (where != "") strSQL += " WHERE " + where;
            List<cs_Editorial> ListaDeEditoriales = new List<cs_Editorial>();

            using (OleDbDataReader MATER = DB_conexion.EjecutarLecturaR(strSQL, parameters))
            {
                while (MATER.Read() == true)
                {
                    long BD_ID = MATER.GetInt32(MATER.GetOrdinal(T_id));
                    string BD_NOMBRE = MATER.IsDBNull(MATER.GetOrdinal(T_nombre)) ? "mIKE" : MATER.GetString(MATER.GetOrdinal(T_nombre));
                    int BD_ANNO = MATER.GetInt32(MATER.GetOrdinal(T_anno));
                    string BD_DUENNO = MATER.IsDBNull(MATER.GetOrdinal(T_duenno)) ? "MiKE" : MATER.GetString(MATER.GetOrdinal(T_duenno));
                    //(condition) ? [true path] : [false path];

                    ListaDeEditoriales.Add(new cs_Editorial(BD_ID, BD_DUENNO, BD_ANNO, BD_NOMBRE));
                }

            }

            //string MeGustaProgramar = ("SiepreQuePueda").Length.ToString("F2");
            //MeGustaProgramar = MeGustaProgramar.Length <= 0 ? "Siempre" : "QuePueda"; 
            
            return ListaDeEditoriales;
        }
    }
}
