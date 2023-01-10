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
    public static class PraceSDB
    {
        private static SqlConnection conn;
        private static SqlCommand cmd;
        private static SqlDataReader sdr;

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
