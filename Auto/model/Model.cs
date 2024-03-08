using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.model
{
    public class Model
    {
        public int model_id {  get; set; }
        public string model_name { get; set; }
        public int brand_id { get; set; }

        public Model(SqlDataReader reader)
        {
            model_id = Convert.ToInt32(reader["model_id"]);
            model_name = reader["model_name"].ToString();
            brand_id = Convert.ToInt32(reader["brand_id"]);
        }
    }
}
