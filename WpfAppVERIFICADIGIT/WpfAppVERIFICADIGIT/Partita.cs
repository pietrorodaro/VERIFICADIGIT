using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppVERIFICADIGIT
{
    public class Partita
    {
        private string squadra_casa;
        private string squadra_trasferta;
        private int anno;
        

        public string Squadra_casa { get { return squadra_casa; } set { squadra_casa = value; } }
        public int Lugnhezza { get { return anno; } set { anno = value; } }
        public string Squadra_trasferta { get { return squadra_trasferta; } set { squadra_trasferta = value; } }

        public Partita(string squdra_casa,  string squadra_trasferta, int anno)
        {
            this.squadra_casa = squdra_casa;
            this.squadra_trasferta= squadra_trasferta;
            this.anno = anno;
        }

    }
}
