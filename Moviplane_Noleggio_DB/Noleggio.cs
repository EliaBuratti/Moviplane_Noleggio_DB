using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviplane_Noleggio_DB
{
    internal abstract class Noleggio
    {
        public static string accessoDB = "Data Source =LAPTOP-TQHCDVHM\\SQLEXPRESS;Initial Catalog=Noleggi;Integrated Security = True; Trust Server Certificate=True";

        protected string? Nome { get; set; }
        protected string? Cognome { get; set; }
        protected DateOnly Data_inizio { get; set; }
        protected int Giorni { get; set; }
        protected DateOnly Data_fine { get; set; }

        public Noleggio(string nome, string cognome, DateOnly data_inizio, int giorni)
        {
            Nome = nome;
            Cognome = cognome;
            Data_inizio = data_inizio;
            Giorni = giorni;
            Data_fine = data_inizio.AddDays(giorni);
        }

        public Noleggio() { }

        public abstract bool RitiroMezzo(string codiceMezzo);
        public abstract bool ConsegnaMezzo(string codiceMezzo);
    }
}
