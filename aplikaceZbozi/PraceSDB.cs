using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikaceZbozi
{
    //Statická třída pro komunikaci s DB
    public static class PraceSDB
    {
        private static SqlConnection conn; //Připojení K DB
        private static SqlCommand cmd; //Příkazová řádka
        private static SqlDataReader sdr; //Čtečka výstupu

        //Otevření připojení k DB a připravení příkazové řádky
        public static bool PripojDB(string cesta)
        {
            conn = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={cesta};Integrated Security=True;Connect Timeout=30");
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("K databázi se nelze připojit!");
                return false;
            }

            cmd = new SqlCommand();
            cmd.Connection = conn;

            return true;
        }

        /// <summary>
        /// Volání příkazů do DB
        /// </summary>
        /// <param name="prikaz"> Příkaz z zavolání</param>
        /// <param name="jeToFunkce">Jestli je volán příkaz, nebo funkce </param>
        /// <param name="vraciNeco">Jestli je očekáván výstup</param>
        /// <param name="parametry">Parametry </param>
        /// <returns>Výstup z DB</returns>
        public static List<List<object>> ZavolejPrikaz(string prikaz, bool jeToFunkce, bool vraciNeco, params KeyValuePair<string, object>[] parametry)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = prikaz;
            cmd.CommandType = jeToFunkce ? CommandType.StoredProcedure : CommandType.Text;

            foreach(KeyValuePair<string, object> kvp in parametry)
            {
                cmd.Parameters.AddWithValue(kvp.Key, Convert.ChangeType(kvp.Value, kvp.Value.GetType()));
            }

            if (vraciNeco)
            {
                sdr = cmd.ExecuteReader();

                //Uložení výstupu do listu listů objektů, přetypování je pak starost konkrétní části kódu
                List<List<object>> vys = new List<List<object>>();
                while (sdr.Read())
                {
                    vys.Add(new List<object>());
                    for (int i = 0; i < sdr.FieldCount; ++i)
                    {
                        vys.Last().Add(sdr[i]);
                    }
                }

                sdr.Close();
                cmd.Cancel();

                return vys;
            }
            else
            {
                cmd.ExecuteNonQuery();
                return null;
            }
        }

    }
}
