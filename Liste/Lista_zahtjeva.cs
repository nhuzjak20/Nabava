using Nabava.Podaci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace Nabava.Liste
{
    public class Lista_zahtjeva : Zahtjev
    {
        public static List<Zahtjev> PovuciZahtjeve()

        {
            DB.SetConfiguration("huzjaknikola_baza", "huzjaknikola_baza", "nikola55");
            List<Zahtjev> zahtjev_lista = new List<Zahtjev>();
            string sql = "SELECT * FROM dbo.zahtjev";
            DB.OpenConnection();
            var podaci = DB.GetDataReader(sql);
            while (podaci.Read())
            {
                Zahtjev zahtjev = StvoriZahtjev(podaci);
                zahtjev_lista.Add(zahtjev);
            }
            podaci.Close();
            DB.CloseConnection();
            return zahtjev_lista;
        }

        private static Zahtjev StvoriZahtjev(System.Data.SqlClient.SqlDataReader podaci)
        {
            int id = int.Parse(podaci["id"].ToString());
            string podnositelj_ime = podaci["naziv_podnositelja"].ToString();
            string financiranje_nacin = podaci["nacin_financiranja"].ToString();
            int potvrda = int.Parse(podaci["dekan_potvrda"].ToString());

            var zahtjev = new Zahtjev
            {
                id = id,
                Ime_podnositelja = podnositelj_ime,
                Nacin_financiranja = financiranje_nacin,
                Potvrda_dekana = potvrda,
            };

            return zahtjev;

           
        }
    }
}
