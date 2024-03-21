using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviplane_Noleggio_DB
{
    internal abstract class Veicolo
    {
        public static string accessoDB = "Data Source =LAPTOP-TQHCDVHM\\SQLEXPRESS;Initial Catalog=Noleggi;Integrated Security = True; Trust Server Certificate=True";

        public Veicolo() { }
        public Veicolo(string codice, string descrizione, string targa, string marca, int posti, int porte, decimal prezzo, bool disponibile)
        {
            Codice = codice;
            Descrizione = descrizione;
            Targa = targa;
            Marca = marca;
            Posti = posti;
            Porte = porte;
            Prezzo = prezzo;
            Disponibile = disponibile;
        }

        protected string? Codice { get; set; }
        protected string? Descrizione { get; set; }
        protected string? Targa { get; set; }
        protected string? Marca { get; set; }
        protected int Posti { get; set; }
        protected int Porte { get; set; }
        protected decimal Prezzo { get; set; }
        protected bool Disponibile { get; set; }

        public abstract bool NuovoMezzo();
        public abstract bool CancellaMezzo(string CodiceMezzo);

    }

}
