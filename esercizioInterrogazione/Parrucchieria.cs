using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioInterrogazione
{
    internal class Parruchieria
    {
        private string nome;

        public Parruchieria(string n)
        {
            this.nome = n;
        }

        public void gestionePrenotazioni(Cliente c, Servizio s, TipoServizio t)
        {
            if(c != null)
            {
                c.prenota(s,t);
            }
        }

        public int getNumeroServizi(Cliente c)
        {
            return c.GetServiziPrenotati();
        }
    }
}
