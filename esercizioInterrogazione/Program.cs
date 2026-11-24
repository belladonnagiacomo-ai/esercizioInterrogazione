namespace esercizioInterrogazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parruchieria parrucchieria = new Parruchieria("Parrucchieria dei boccoli d'oro");
            Cliente c1 = new Cliente("Gianmarco", "Vivaldi");
            Cliente c2 = new Cliente("Luca", "Bianchi");
            TipoServizio t1 = TipoServizio.SHAMPOO;
            TipoServizio t2 = TipoServizio.TAGLIO;
            TipoServizio t3 = TipoServizio.TAGLIO_BARBA;
            Servizio s1 = new Servizio(t1, 5, 20);
            Servizio s2 = new Servizio(t3, 30, 30);
            Servizio s3 = new Servizio(t2, 15, 25);
            parrucchieria.gestionePrenotazioni(c1, s1, t1);
            parrucchieria.gestionePrenotazioni(c1, s2, t3);
            parrucchieria.gestionePrenotazioni(c2, s3, t2);
            Console.WriteLine("Il tempo impiegato dal cliente " + c1.GetNome() + " " + c1.GetCognome() + " e: " + (s1.GetTempoImpiegato()+s2.GetTempoImpiegato())+ " minuti");
            Console.WriteLine("Il prezzo totale e: " + (s1.GetPrezzo()+s2.GetPrezzo()) + " euro");
            Console.WriteLine("Il numero di servizi effettuati dal cliente e: " + parrucchieria.getNumeroServizi(c1));
            Console.WriteLine();
            c1.Stato();
            Console.WriteLine();
            Console.WriteLine("Il tempo impiegato dal cliente " + c2.GetNome() + " " + c2.GetCognome() + " e: " + s3.GetTempoImpiegato() + " minuti");
            Console.WriteLine("Il prezzo totale e: " + s3.GetPrezzo() + " euro");
            Console.WriteLine("Il numero di servizi effettuati dal cliente e: " + parrucchieria.getNumeroServizi(c2));
            Console.WriteLine();
            c2.Stato();
        }
    }
}
