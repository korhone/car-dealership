using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.model
{
    public class Fuel
    {
        public int fuel_id { get; set; }
        public string fuel_name { get; set; }
        
        public Fuel(SqlDataReader reader)
        {
            fuel_id = Convert.ToInt32(reader["fuel_id"]);
            fuel_name = reader["fuel_name"].ToString();
        }
    }
}
