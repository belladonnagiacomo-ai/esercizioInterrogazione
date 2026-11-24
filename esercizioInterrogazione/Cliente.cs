using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioInterrogazione
{
    internal class Cliente
    {
        private string nome;
        private string cognome;
        private int index = 0;
        private List<TipoServizio> tipiServizi = new List<TipoServizio>();
        public Cliente(string n, string c)
        {
            this.nome = n;
            this.cognome = c;
        }

        public void prenota(Servizio servizio, TipoServizio t)
        {
            if(servizio != null)
            {
                tipiServizi.Add(t);
                index++;
            }
        }
        public string GetNome()
        {
            return nome;
        }
        public string GetCognome()
        {
            return cognome;
        }
        public int GetServiziPrenotati()
        {
            return index;
        }
        public void Stato()
        {
            for(int i = 0; i < index; i++)
            {
                Console.WriteLine("Il tipo di servizio e: " + tipiServizi[i]);
            }
        }


    }
}
