using Nabava.Podaci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace Nabava.Liste
{
    public class RadniciRepozitorij
    {
        public static List<Radnik> PovuciRadnike()

        {
            DB.SetConfiguration("huzjaknikola_baza", "huzjaknikola_baza", "nikola55");
            List<Radnik> radnik_lista = new List<Radnik>();
            string sql = "SELECT * FROM dbo.LoginPodaci";
            DB.OpenConnection();
            var podaci = DB.GetDataReader(sql);
            while (podaci.Read())
            {
                Radnik radnik = StvoriRadnika(podaci);
                radnik_lista.Add(radnik);
            }
            podaci.Close();
            DB.CloseConnection();
            return radnik_lista;
        }

        private static Radnik StvoriRadnika(System.Data.SqlClient.SqlDataReader podaci)
        {
            string KorisnickoIme = podaci["korisnickoime"].ToString();
            string Lozinka = podaci["lozinka"].ToString();

            var radnik = new Radnik
            {
                KorisnickoIme = KorisnickoIme,
                Lozinka = Lozinka
            };

            return radnik;
        }
    }
}
