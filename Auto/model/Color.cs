using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.model
{
    public class Color
    {
        public int color_id {  get; set; }
        public string color_name { get; set; }

        public Color(SqlDataReader reader) 
        {
            color_id = Convert.ToInt32(reader["color_id"]);
            color_name = reader["color_name"].ToString();
        }
    }
}
