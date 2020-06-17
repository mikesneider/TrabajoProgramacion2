using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class cs_Libros
    {
        long id;
        string nameBook;
        int quantityBooks;
        string isbn;
        long editorial;
        List<string> EditorialList;

        private static string NombreTabla = "Libros";
        private static string T_id = "id";
        private static string T_nombre = "nombre2";
        private static string T_cantidad = "cantidad";
        private static string T_isbn = "isbn";
        private static string T_editorial = "editorial";

        /// <summary>
        /// Constructor de la clase libros
        /// </summary>
        /// <param name="NombreLibro"></param>
        /// <param name="CantidadLibros"></param>
        /// <param name="ISBN"></param>
        /// <param name="EditorialLibro"></param>
        public cs_Libros (string NombreLibro, int CantidadLibros, string ISBN, long EditorialLibro)
        {
            this.NameBook = NombreLibro;
            this.Isbn = ISBN;
            this.Editorial = EditorialLibro;
            this.quantityBooks = CantidadLibros;
        }
        /// <summary>
        /// El constructor de la clase Libros de la BD
        /// </summary>
        /// <param name="id"></param>
        /// <param name="NombreLibro"></param>
        /// <param name="CantidadLibros"></param>
        /// <param name="ISBN"></param>
        /// <param name="EditorialLibro"></param>
        public cs_Libros(long id, string NombreLibro, int CantidadLibros, string ISBN, long EditorialLibro)
        {
            this.id = id;
            this.NameBook = NombreLibro;
            this.Isbn = ISBN;
            this.Editorial = EditorialLibro;
            this.quantityBooks = CantidadLibros;
        }

        /// <summary>
        /// Esta función permite incluir y obtener información de cada Nombre del libro
        /// </summary>
        public string NameBook { 
            get => nameBook; 
            set => nameBook = value; }
        /// <summary>
        /// Esta función permite incluir y obtener información de la cantidad de libros
        /// </summary>
        public int QuantityBooks { 
            get => quantityBooks;
            set => quantityBooks = value;
            }
        /// <summary>
        /// Esta función permite incluir y obtener información de cada ISBN del libro
        /// </summary>
        public string Isbn { get => isbn; 
            set => isbn = value; }
        /// <summary>
        /// Esta función permite incluir y obtener información de cada Editorial del libro
        /// </summary>
        public long Editorial { get => editorial; 
            set => editorial = value; }
        /// <summary>
        /// Función para obtener el Id de la info de la BD
        /// </summary>
        public long Id { get => id; }


        /// <summary>
        /// Función para escribir en la BD en la tabla Libros
        /// </summary>
        /// <param name="nombre">Nombre del libro</param>
        /// <param name="cantidad">Cantidad de libros</param>
        /// <param name="isbn">ISBN del libro</param>
        /// <param name="editorial">Editorial del libro</param>
        /// <returns></returns>
        public bool IngresarDatos(string nombre, int cantidad, string isbn, long editorial)
        {
            string SQL = "INSERT INTO "+NombreTabla+" (" + T_nombre + "," + T_cantidad + "," + T_isbn + "," + T_editorial + ") VALUES ( '" +
                nombre + "'," + cantidad.ToString() + ",'" + isbn + "','" + editorial + "')";

            string QUERY = "INSERT INTO "+NombreTabla+" (" + T_nombre + "," + T_cantidad + "," + T_isbn + "," + T_editorial + ") VALUES ( @" +
                T_nombre + ",@" + T_cantidad + ",@" + T_isbn + ",@" + T_editorial + ")";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@" + T_nombre, nombre);
            parameters.Add("@" + T_cantidad, cantidad);
            parameters.Add("@" + T_isbn, isbn);
            parameters.Add("@" + T_editorial, editorial);
            bool Rta = DB_conexion.EjecutarBusqueda(QUERY, parameters);
            long catId = DB_conexion.getLastIndex();
            //cs_libros_editor.intresar(catId,id_Editoriales)
            return Rta;
            //return DB_conexion.EjecutarBusqueda(SQL);

        }
        
        /// <summary>
        /// Función para solicitar todos los datos de mi objeto. [Libros]
        /// </summary>
        /// <param name="where">Condicional para la consulta </param>
        /// <param name="parameters">Parametros para la búsqueda por Default is null</param>
        /// <returns></returns>
        public static List<cs_Libros> getAllFromBD(string where = "", Dictionary<string, object> parameters = null)
        {
            string strSQL = "SELECT * FROM " + NombreTabla;
            if (where != "") strSQL += " WHERE " + where; 
            List<cs_Libros> ListaDeLibros = new List<cs_Libros>();

            using (OleDbDataReader MATER = DB_conexion.EjecutarLecturaR(strSQL, parameters))
            {
                while (MATER.Read() == true)
                {
                    long BD_ID = MATER.GetInt32(MATER.GetOrdinal(T_id));
                    string BD_NOMBRE = MATER.IsDBNull(MATER.GetOrdinal(T_nombre)) ? "mIKE" : MATER.GetString(MATER.GetOrdinal(T_nombre));
                    int BD_CANTIDAD = MATER.GetInt32(MATER.GetOrdinal(T_cantidad));
                    string BD_ISBN = MATER.IsDBNull(MATER.GetOrdinal(T_isbn)) ? "MiKE" : MATER.GetString(MATER.GetOrdinal(T_isbn));
                    long BD_EDITORIAL =  MATER.GetInt32(MATER.GetOrdinal(T_editorial));
                    //(condition) ? [true path] : [false path];

                    ListaDeLibros.Add(new cs_Libros(BD_ID,BD_NOMBRE,BD_CANTIDAD,BD_ISBN,BD_EDITORIAL));
                }

            }
            return ListaDeLibros;
        }

        public static DataTable traerTablita(string MyQuery = "SELECT * FROM Libros")
        {
            return DB_conexion.EjecutarLectura(MyQuery);
        }
        /// <summary>
        /// Función para actualizar información de la base de datos
        /// </summary>
        /// <param name="Id">Id</param>
        /// <param name="cant">cantidad de libros</param>
        public static void UpdateBD_cantidad(long Id, int cant)
        {
            string QUERY = "UPDATE solicitudcompra_productos SET " + T_cantidad + "=@" + T_cantidad;
            //QUERY += " , " + T_last_user + "=@" + T_last_user + ", " + T_last_update + "=@" + T_last_update;
            QUERY += " WHERE " + T_id + "=@" + T_id;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@" + T_cantidad, cant);
            //parameters.Add("@" + T_last_user, cs_Global.UsuarioActual);
            //parameters.Add("@" + T_last_update, DateTime.Now);
            parameters.Add("@" + T_id, Id);
            DB_conexion.EjecutarBusqueda(QUERY, parameters);
        }
        //public static void RemoveforID_BD(long Id)
        //{
        //    string QUERY = "DELETE FROM solicitudcompra_productos WHERE " + T_Id + "=" + Id;
        //    BD_conexion.EjecutarBusqueda(QUERY);
        //}
    }
}
