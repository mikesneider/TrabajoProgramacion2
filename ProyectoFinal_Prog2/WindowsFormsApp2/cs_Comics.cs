using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class cs_Comics : cs_Libros
    {
        bool MarvelComics;
        bool DCComics;

        public cs_Comics(string NombreLibro, int CantidadLibros, string ISBN, int EditorialLibro) : base(NombreLibro, CantidadLibros, ISBN, EditorialLibro)
        {

        }

        public bool DCComics1 { get => DCComics; set => DCComics = value; }
        public bool MarvelComics1 { get => MarvelComics; set => MarvelComics = value; }
    }
}
