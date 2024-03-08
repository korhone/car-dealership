using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.model
{
    public class Brand
    {
        public int brand_id {  get; set; }
        public string brand_name { get; set; }

        public Brand(SqlDataReader reader)
        {
            brand_id = Convert.ToInt32(reader["brand_id"]);
            brand_name = reader["brand_name"].ToString();
        }
    }
}
