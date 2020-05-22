using System;
using System.Collections.Generic;
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
        string editorial;
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
        public cs_Libros (string NombreLibro, int CantidadLibros, string ISBN, string EditorialLibro)
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
        public cs_Libros(long id, string NombreLibro, int CantidadLibros, string ISBN, string EditorialLibro)
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
        public string Editorial { get => editorial; 
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
        public bool IngresarDatos(string nombre, int cantidad, string isbn, string editorial)
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
            return DB_conexion.EjecutarBusqueda(QUERY, parameters);
            
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
                    string BD_EDITORIAL = MATER.IsDBNull(MATER.GetOrdinal(T_editorial)) ? "KooL" : MATER.GetString(MATER.GetOrdinal(T_editorial));
                    //(condition) ? [true path] : [false path];

                    ListaDeLibros.Add(new cs_Libros(BD_ID,BD_NOMBRE,BD_CANTIDAD,BD_ISBN,BD_EDITORIAL));
                }

            }
            return ListaDeLibros;
        }

    }
}
