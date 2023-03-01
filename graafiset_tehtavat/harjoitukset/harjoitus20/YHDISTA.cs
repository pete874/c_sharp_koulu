using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace harjoitus20
{
    class YHDISTA
    {
        public string yhteyslause()
        {
            return "datasource=localhost; port=3306;username=root;password=;database=opiskelijat";
        }
        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=opiskelijat");
        //funktio yhteyttä varten
        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }
        //funktio yhteyden avaamista varten
        public void avaaYhteys()
        {
            if(yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }
        //funktio yhteyden sulkemiseen
        public void suljeYhteys()
        {
            if(yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
