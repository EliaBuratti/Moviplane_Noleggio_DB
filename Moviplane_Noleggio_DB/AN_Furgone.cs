using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Moviplane_Noleggio_DB
{
    internal class AN_Furgone : Veicolo
    {
        public AN_Furgone(string codice, string descrizione, string targa, string marca, int posti, int porte, decimal prezzo, bool disponibile) : base(codice, descrizione, targa, marca, posti, porte, prezzo, disponibile)
        {
        }

        public AN_Furgone()
        {
        }

        public override bool NuovoMezzo()
        {

            try
            {

                SqlConnection cn = new SqlConnection(accessoDB);
                SqlCommand cmd = new();
                cn.Open();

                string query = "INSERT INTO Anagrafica_Furgoni VALUES  (@Codice, @Descrizione, @Targa, @Marca, @Posti, @Porte, @Prezzo, @Disponibile)"; //(Codice, Descrizione, Targa, Marca, Posti, Porte, [Prezzo GG],Disponibile)
                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Codice", Codice);
                cmd.Parameters.AddWithValue("@Descrizione", Descrizione);
                cmd.Parameters.AddWithValue("@Targa", Targa);
                cmd.Parameters.AddWithValue("@Marca", Marca);
                cmd.Parameters.AddWithValue("@Posti", Posti);
                cmd.Parameters.AddWithValue("@Porte", Porte);
                cmd.Parameters.AddWithValue("@Prezzo", Prezzo);
                cmd.Parameters.AddWithValue("@Disponibile", Disponibile);
                cmd.ExecuteNonQuery();

                Console.WriteLine($"{Targa}. E stato aggiunto!");
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Not connected." + ex.Message);
                return false;
            }
        }
        public override bool CancellaMezzo(string CodiceMezzo)
        {
            try
            {

                SqlConnection cn = new(accessoDB);
                SqlCommand cmd = new();
                cn.Open();

                //query db
                string query = $"DELETE FROM Anagrafica_Furgoni WHERE Codice LIKE '{CodiceMezzo}'";
                cmd = new SqlCommand(query, cn);
                int rowDeleted = cmd.ExecuteNonQuery();

                cn.Close();
                return (rowDeleted > 0);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }


    }

}
