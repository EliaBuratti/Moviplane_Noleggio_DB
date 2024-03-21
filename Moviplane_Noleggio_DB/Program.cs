using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace Moviplane_Noleggio_DB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //AN_Furgone TestFurgone = new("F1", "FIORINO", "AX123", "FIAT", 2, 3, 130.00m);
            //TestFurgone.NuovoMezzo();
            //Funziona

            //AN_Furgone furgone = new();
            //if (!furgone.CancellaMezzo("F1")){ Console.WriteLine("Not found"); }
            //funziona

            Console.WriteLine("Scegli cosa vuoi fare:\n1 Gestisci mezzi.\n2 Gestisci noleggi.\n3 Stampa dettagli.");
            int sceltaAzione = Convert.ToInt32(Console.ReadLine());

            switch (sceltaAzione)
            {
                case 1:
                    Console.WriteLine("Quale mezzo vuoi gestire?\n1 Furgoni.\n2 Automobili.\n3 Moto.");
                    gestisci_mezzo(Convert.ToInt32(Console.ReadLine()));
                    break;


            }
        }

        public static void gestisci_mezzo(int scelta)
        {
            Console.WriteLine("Che azione vuoi fare?\n1 Nuovo mezzo.\n2 Cancella mezzo");
            int azione = Convert.ToInt32(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    if(azione == 1)
                    {
                        AggiungiMezzo(scelta);

                    } else if (azione == 2)
                    {
                        CancellaMezzo(scelta);
                    }
                    break;
                case 2:
                    if (azione == 1)
                    {
                        //AN_Furgone TestFurgone = new("F1", "FIORINO", "AX123", "FIAT", 2, 3, 130.00m);
                        //TestFurgone.NuovoMezzo();
                    }
                    else if (azione == 2)
                    {
                        //AN_Furgone furgone = new();
                        //if (!furgone.CancellaMezzo("F1")){ Console.WriteLine("Not found"); }
                    }
                    break;
                case 3:
                    if (azione == 1)
                    {
                        //AN_Furgone TestFurgone = new("F1", "FIORINO", "AX123", "FIAT", 2, 3, 130.00m);
                        //TestFurgone.NuovoMezzo();
                    }
                    else if (azione == 2)
                    {
                        //AN_Furgone furgone = new();
                        //if (!furgone.CancellaMezzo("F1")){ Console.WriteLine("Not found"); }
                    }
                    break;
            }

        }

        public static void AggiungiMezzo(int sceltaMezzo)
        {
            Console.WriteLine("Inserisci il codice del mezzo:");
            string codice = Console.ReadLine();
            Console.WriteLine("Inserisci la descrizione del mezzo:");
            string descizione = Console.ReadLine();
            Console.WriteLine("Inserisci la targa del mezzo:");
            string targa = Console.ReadLine();
            Console.WriteLine("Inserisci la marca:");
            string marca = Console.ReadLine();
            Console.WriteLine("inserisci il numero di posti:");
            int posti = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci numero porte");
            int porte = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il prezzo di un giorno di noleggio:");
            decimal prezzo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Vuoi renderlo immediatamente disponibile? (Y/N)");
            bool disponibilità = Console.ReadLine().ToLower() == "y" ? true : false;

            switch (sceltaMezzo)
            {
                case 1:
                    AN_Furgone NuovoFurgone = new(codice, descizione, targa, marca, posti, porte, prezzo, disponibilità);
                    NuovoFurgone.NuovoMezzo();
                    break;

            }

        }

        public static void CancellaMezzo(int sceltaMezzo)
        {
            Console.WriteLine("Inserisci il codice del mezzo che vuoi eliminare:");
            string codiceMezzo = Console.ReadLine();

            switch (sceltaMezzo)
            {
                case 1:
                    AN_Furgone furgone = new();
                    if (!furgone.CancellaMezzo(codiceMezzo)) { Console.WriteLine("Mezzo non trovato"); } else { Console.WriteLine($"{codiceMezzo}. Was deleted!"); }
                    break;

            }
        }
    }
}
