using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioInterrogazione
{
    internal class Servizio
    {
        private TipoServizio tipo;
        private double tempoImpiegato;
        private double prezzo;
        public Servizio(TipoServizio t, double tempo, double p)
        {
            this.tipo = t;
            this.tempoImpiegato = tempo;
            this.prezzo = p;
        }
        public double GetTempoImpiegato()
        {
            return tempoImpiegato;
        }
        public double GetPrezzo()
        {
            return prezzo;
        }


    }
}
