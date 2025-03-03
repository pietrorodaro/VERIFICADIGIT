using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppVERIFICADIGIT
{
    public class Libro
    {
        private string casa_editrice;
        private int lugnhezza;
        private string titolo;

        public string Casa_editrice { get { return casa_editrice; } set { casa_editrice = value; } }
        public int Lugnhezza { get { return lugnhezza; } set { lugnhezza = value; } }
        public string Titolo { get { return titolo; } set { titolo = value; } }

        public Libro(string casa_editrice, int lunghezza, string titolo)
        {
            this.casa_editrice = casa_editrice;
            this.lugnhezza = lunghezza;
            this.titolo = titolo;
        }

    }
}
