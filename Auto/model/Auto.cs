using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.model
{
    public class Auto
    {
        public int car_id {  get; set; }
        public decimal price { get; set; }
        public DateTime registration_date { get; set; }
        public decimal engine_capacity {  get; set; }
        public int mileage { get; set; }
        public int brand_id { get; set; }
        public int model_id { get; set; }
        public int color_id { get; set; }
        public int fuel_id { get; set; }

        public Auto() { }

        public Auto(int car_id, decimal price, DateTime registration_date, decimal engine_capacity, int mileage, int brand_id, int model_id, int color_id, int fuel_id)
        {
            this.car_id = car_id;
            this.price = price;
            this.registration_date = registration_date;
            this.engine_capacity = engine_capacity;
            this.mileage = mileage;
            this.brand_id = brand_id;
            this.model_id = model_id;
            this.color_id = color_id;
            this.fuel_id = fuel_id;
        }

        public Auto(SqlDataReader reader)
        {
            car_id = Convert.ToInt32(reader["car_id"]);
            price = Convert.ToDecimal(reader["price"]);
            registration_date = Convert.ToDateTime(reader["registration_date"]);
            engine_capacity = Convert.ToDecimal(reader["engine_capacity"]);
            mileage = Convert.ToInt32(reader["mileage"]);
            brand_id = Convert.ToInt32(reader["brand_id"]);
            model_id = Convert.ToInt32(reader["model_id"]);
            color_id = Convert.ToInt32(reader["color_id"]);
            fuel_id = Convert.ToInt32(reader["fuel_id"]);
        }
    }
}
