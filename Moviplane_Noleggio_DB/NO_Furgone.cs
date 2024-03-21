using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Moviplane_Noleggio_DB
{
    internal class NO_Furgone : Noleggio
    {
        public NO_Furgone(string nome, string cognome, DateOnly data_inizio, int giorni) : base(nome, cognome, data_inizio, giorni)
        {
        }

        public NO_Furgone () { }

        public override bool ConsegnaMezzo(string codiceMezzo)
        {
            return true;
/*            try    DA CAPIRE!!!!
            {

                SqlConnection cn = new SqlConnection(accessoDB);
                SqlCommand cmd = new();
                cn.Open();

                string query = "INSERT INTO Anagrafica_Furgoni VALUES  (@Codice, @Descrizione, @Targa, @Marca, @Posti, @Porte, @Prezzo)";
                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Codice", Codice);
                cmd.Parameters.AddWithValue("@Descrizione", Descrizione);
                cmd.Parameters.AddWithValue("@Targa", Targa);
                cmd.Parameters.AddWithValue("@Marca", Marca);
                cmd.Parameters.AddWithValue("@Posti", Posti);
                cmd.Parameters.AddWithValue("@Porte", Porte);
                cmd.Parameters.AddWithValue("@Prezzo", Prezzo);
                cmd.ExecuteNonQuery();

                Console.WriteLine($"{Targa}. Was added!");
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Not connected." + ex.Message);
                return false;
            }*/
        }

        public override bool RitiroMezzo(string codiceMezzo)
        {
            throw new NotImplementedException();
        }
    }
}
