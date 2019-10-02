using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;

namespace ClubineTimothy_dbsreview
{
    class Database
    {
        private MySqlConnection _conn = null;

        public Database()
        {
            _conn = new MySqlConnection();            
        }

        public void Connect()
        {
            
            BuildConnectionString();


            try
            {
                
                _conn.Open();
                Console.WriteLine("Connection Successful!");
                
            }
            catch (MySqlException e)
            {
                string msg = "";
                switch (e.Number)
                {
                    case 0:
                        msg = e.ToString();
                        break;
                    case 1042:
                        msg = "Can't resolve host address. \r\n" +
                            $"{_conn.ConnectionString}";
                        break;
                    case 1045:
                        msg = "Invalid username/password";
                        break;
                    default:
                        msg = e.ToString();
                        break;
                }
                Console.WriteLine(msg);
                Console.ReadKey();
            }
            
        }
        public void CloseConnection()
        {
            _conn.Close();
        }
        public void BuildConnectionString()
        {
            string ip = "";

            using (StreamReader sr = new StreamReader(@"c:\VFW\connection.txt"))
            {
                ip = sr.ReadLine();
            }

            string connString = $"Server={ip};";
            connString += "uid=dbsAdmin;";
            connString += "pwd=password;";
            connString += "database=sampleapidata;";
            connString += "port=8889";

            _conn.ConnectionString = connString;
        }

        public Weather Query(Weather w, string query)
        {            
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, _conn);
            DataTable data = new DataTable();
            

            adapter.SelectCommand.CommandType = CommandType.Text;
            adapter.Fill(data);

            DataRowCollection rows = data.Rows;
            foreach (DataRow row in rows)
            {
                w.CityName = row["city"].ToString();
                w.Temp = row["temp"].ToString();
                w.Pressure = row["pressure"].ToString();
                w.Humidity = row["humidity"].ToString();
            }
            return w;
        }

        public void AddWeather(string stm)
        {

        }
    }
}
