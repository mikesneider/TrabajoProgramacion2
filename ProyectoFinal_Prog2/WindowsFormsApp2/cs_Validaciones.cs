using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Drawing;

namespace WindowsFormsApp2
{
    public static class cs_Validaciones
    {
        public const double salario = 980897;
        public static Color colorFondo;
        
        public static bool EsUnNumero(string cadenaIngreso)
        {
            try
            {
                double Num = double.Parse(cadenaIngreso);
            }
            catch(Exception G)
            {
                MessageBox.Show(Res.mjsMensajeSoloNumeros, Res.mjsError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            return true;        
        }
        private static float NULO = 0.0F;

        /// <summary>
        /// Valida si el texto es un número o no
        /// </summary>
        /// <param name="text">Texto a verificar</param>
        /// <returns>true or false</returns>
        public static bool IsNumerico(string text)
        {
            bool isNumber;
            double isItNumeric;
            isNumber = Double.TryParse(Convert.ToString(text), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out isItNumeric);
            return isNumber;
        }
        /// <summary>
        /// Obtener la dirección donde está instalado el software
        /// </summary>
        /// <returns>Text con la dirección</returns>
        public static string GetMidirectorio()
        {
            string midireccion = System.IO.Directory.GetCurrentDirectory();
            return midireccion;
        }

        public static void AsignarNulo(float nulo)
        {
            NULO = nulo;
        }

        public static float RetornarNulo()
        {
            return NULO;
        }
        /// <summary>
        /// Crea una carpeta en el Directorio de la aplicación
        /// </summary>
        /// <param name="nombrecarp">Nombre de la carpeta a crear</param>
        public static void crearDirectorio(string nombrecarp)
        {
            string direccion = System.IO.Directory.GetCurrentDirectory();
            string dirImag = direccion + "\\" + nombrecarp;
            DirectoryInfo DIR = new DirectoryInfo(dirImag);
            if (!DIR.Exists)
            {
                DIR.Create();
            }
        }
        public static double[][] ReadFile(string fileName, char separador=';')
        {
            var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            List<string> L = new List<string>();

            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                if (line.Length > 3) L.Add(line);
            }

            sr.Close();
            fs.Close();

            // skip first row, reserved to titles

            double[][] result = new double[L.Count - 1][];
            int k = 0;
            for (int t = 1; t < L.Count; t++)
            {
                var spl = L[t].Split(separador);
                result[k] = new double[spl.Length];
                int Columnas = spl.Length;
                //              if (t % 5 != 0 && porcentaje)
                for (int j = 0; j < spl.Length; j++)
                {
                    var str = spl[j];
                    str = str.Replace("%", "");

                    result[k][j] = CambiarA_Double(str);
                }
                k++;
            }
            int Filas = L.Count - 1;

            return result;
        }
        public static double[][] InputFiles(double[][] ReadFile, int colums, int rows, int newrows)
        {
            double[][] DataInput = new double[newrows][];
            int contador = 0;
            if (rows == newrows)
            {
                for (int t = 0; t < rows; t++)
                {
                    // prepare input vector from matrix

                    double[] input = new double[colums];
                    DataInput[contador] = new double[colums];

                    for (int j = 0; j < colums; j++)
                    {
                        DataInput[contador][j] = ReadFile[contador][j];
                    }
                    contador++;

                }
            }
            else
            {
                for (int t = 0; t < rows; t++)
                {
                    // prepare input vector from matrix
                    if (t % 5 != 0)
                    {
                        double[] input = new double[colums];
                        DataInput[contador] = new double[colums];

                        for (int j = 0; j < colums; j++)
                        {
                            DataInput[contador][j] = ReadFile[t][j];
                        }
                        contador++;
                    }
                }
            }
            return DataInput;
        }
        public static double[] output(double[][] ReadFile, int colums, int rows, int newrows)
        {
            double[][] DataInput = new double[rows][];
            double[] DataOutput = new double[newrows];
            int contador = 0;
            if (rows == newrows)
            {
                for (int t = 0; t < rows; t++)
                {
                    DataOutput[contador] = (ReadFile[contador][colums]);
                    contador++;
                }
            }
            else
            {
                for (int t = 0; t < rows; t++)
                {
                    if (t % 5 != 0)
                    {
                        DataOutput[contador] = (ReadFile[t][colums]);
                        contador++;
                    }
                }
            }
            return DataOutput;
        }
        /// <summary>
        /// Cambia la cadena de caracteres a un número tipo Double, dependiendo de la Culture configurada en el equipo.
        /// </summary>
        /// <param name="Datoin">número tipo String</param>
        /// <returns>Número tipo Double</returns>
        static public double CambiarA_Double(string Datoin)
        {
            if (Datoin.Contains(","))
                Datoin = Datoin.Replace(",", ".");
            bool negativo = false;
            if (Datoin != "" || Datoin != null)
            {
                try
                {
                    if (Datoin[0] == '-')
                    {
                        negativo = true;
                        Datoin = Datoin.Substring(1);
                    }
                }
                catch (Exception e) { }
            }
            NumberStyles style;
            CultureInfo culture, culture2;
            double number;

            string value = Datoin;
            style = NumberStyles.AllowDecimalPoint;
            //culture2 = CultureInfo.CreateSpecificCulture("fr-FR");  //fr-FR - en _ US
            culture = CultureInfo.CreateSpecificCulture("en-US");
            culture2 = CultureInfo.CreateSpecificCulture("es-CO");
            Double.TryParse(value, style, culture, out number);

            if (Double.TryParse(value, style, culture, out number))
            {
                if (negativo == true) { number = number * (-1); }
                return number;
            }
            else
            {
                Double.TryParse(value, style, culture2, out number);

            }
            if (negativo == true) { number = number * (-1); }

            return number;
        }

    }
}
