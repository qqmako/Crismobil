
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Crismobil
{
    class Connect
    {
        SqlConnection conectare;

        public Connect()
        {
            conectare = new SqlConnection
                ("Data Source = ASUS; Initial Catalog = Crismobil; Integrated Security = True;");
        }

        public SqlConnection DeschidereConectare()
        {
            try
            {
                conectare.Open();
            }
            catch (Exception)
            {

            }

            return conectare;
        }

        public void InchidereConectare()
        {
            try
            {
                conectare.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
