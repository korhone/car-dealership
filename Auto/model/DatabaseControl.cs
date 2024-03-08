using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CarDealership.model
{
    public class DatabaseControl
    {
        string connectingString;
        SqlConnection dBconnection;

        public DatabaseControl()
        {
            // kun luodaan DatabaseControl, silloin luodaan myös yhteys
            connectingString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarDealership;Integrated Security=True;Pooling=False;Encrypt=False";
            dBconnection = new SqlConnection();
            dBconnection.ConnectionString = connectingString;
        }

        public bool ConnectDatabase() // avataan kantayhteys
        {
            try
            { 
                dBconnection.Open();
                return true;
            }
            catch(Exception e)
            { 
                Console.WriteLine("Error message: " + e);
                dBconnection.Close();
                return false;
            }
        }

        public void DisconnectDatabase() // tällä suljetaan kantayhteys
        {
            dBconnection.Close();
        }

        // alla haetaan listat kannasta pääohjelman käyttöön (brand, model, cars, fuels, colors)
        public List<Brand> GetAllBrands() // haetaan autojen merkit
        {
            List<Brand> brands = new List<Brand>() ;
            ConnectDatabase(); // avataan kantayhteys

            string brandquery = "SELECT * FROM Brand ;";
            SqlCommand cmd = new SqlCommand(brandquery, dBconnection);
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Brand merkki = new Brand(reader);
                brands.Add(merkki);
            }
            DisconnectDatabase(); // suljetaan kantayhteys
            return brands; // palautetaan lista merkeistä
        }

        public List<Model> GetModelsByBrandId(int brand_id) // haetaan automallit perustuen merkkiin
        {
            List<Model> models = new List<Model>() ;
            ConnectDatabase();

            SqlParameter makerid = new SqlParameter("@makerid", System.Data.SqlDbType.Int, 4); // 4bytes, 32bit
            makerid.Value = brand_id; //automerkki joka tullut 

            //määritetään parametri (SQLi)
            string query = "SELECT * FROM Model WHERE brand_id = @makerid;";

            SqlCommand command = new SqlCommand(query, dBconnection);
            command.Parameters.Add(makerid);

            using SqlDataReader reader = command.ExecuteReader(); //olio jolla luetaan tietoja kannasta
            while (reader.Read()) // silmukka, joka lukee kantaa till end
            {
                Model olio = new Model(reader); 
                models.Add(olio); //lisää malli listalle
            }
            DisconnectDatabase();
            return models; // palautetaan mallilista
        }

        public List<Auto> GetAllAutos()
        {
            List<Auto> cars = new List<Auto>(); //luodaan cars-lista
            ConnectDatabase();

            string sqlLause = "SELECT * FROM Car;"; // tämä palauttaa PK id mukaan autot  
            SqlCommand command = new SqlCommand(sqlLause, dBconnection); //olio jolle luetaan tiedot
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Auto auto = new Auto(reader);   //olio jonka nimi on auto, tiedot sille tulee readerista
                cars.Add(auto);                 //auto olio lisätään cars-listaan
            }
            DisconnectDatabase();
            return cars;                        // palauttaa pääohjelmalle cars-lista
        }
        public List<Fuel> GetAllFuels()
        {
            List<Fuel> fuels = new List<Fuel>();
            ConnectDatabase();

            string fuelquery = "SELECT * FROM Fuel ; ";
            SqlCommand command = new SqlCommand(fuelquery, dBconnection);
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Fuel poltaine = new Fuel(reader);
                fuels.Add(poltaine);
            }
            DisconnectDatabase();
            return fuels; // palautetaan polttoainelista pääohjelman käyttöön
        }
        public List<Color> GetAllColors()
        {
            List <Color> colors = new List<Color>();
            ConnectDatabase();
            string colorquery = "SELECT * FROM Color ;";
            SqlCommand command = new SqlCommand(colorquery, dBconnection);
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Color vari = new Color(reader);
                colors.Add(vari);
            }
            DisconnectDatabase();
            return colors; //palautetaan värilista pääohjelman käyttöön
        }

        // tätä ei käytetä tässä versiossa pääohjelmassa, sillä autot haetaan id mukaan(yllä)
        public List<Auto> GetAllAutosbyPrice() 
        {
            List<Auto> autot = new List<Auto>(); //luodaan autot lista
            ConnectDatabase();

            string queryByPrice = "SELECT * FROM Car ORDER BY price ASC;"; // haetaan halvimmat autot listaan
            SqlCommand command = new SqlCommand(queryByPrice, dBconnection); //olio jolle luetaan tietoja kannasta
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Auto olio = new Auto(reader);   //olio jonka nimi on olio, tiedot sille tulee readerista
                autot.Add(olio);                 //auto olio lisätään autot-listaan
            }
            DisconnectDatabase();
            return autot; // palautetaan hinnan mukaan lista pääohjelmaan
        }

        // alla ylläpitometodit (insert, update, delete)
        public bool SaveAutoIntoDatabase(Auto newAuto)
        {
            ConnectDatabase();

            //määritetään parametrit (SQLi)
            SqlParameter carid = new SqlParameter("@carid", System.Data.SqlDbType.Int, 4);
            carid.Value = newAuto.car_id;
            SqlParameter brandid = new SqlParameter("@brandid", System.Data.SqlDbType.Int, 4);
            brandid.Value = newAuto.brand_id;
            SqlParameter modelid = new SqlParameter("@modelid", System.Data.SqlDbType.Int, 4);
            modelid.Value = newAuto.model_id;
            SqlParameter colorid = new SqlParameter("@colorid", System.Data.SqlDbType.Int, 4);
            colorid.Value = newAuto.color_id;
            SqlParameter fuelid = new SqlParameter("@fuelid", System.Data.SqlDbType.Int, 4);
            fuelid.Value = newAuto.fuel_id;
            SqlParameter pricee = new SqlParameter("@pricee", System.Data.SqlDbType.Decimal);
            pricee.Value = newAuto.price;
            SqlParameter registrationDatee = new SqlParameter("@registrationDatee", System.Data.SqlDbType.DateTime);
            registrationDatee.Value = newAuto.registration_date;
            SqlParameter engineCapacity = new SqlParameter("@engineCapacity", System.Data.SqlDbType.Decimal);
            engineCapacity.Value = newAuto.engine_capacity;
            SqlParameter mileagee = new SqlParameter("@mileagee", System.Data.SqlDbType.Int, 4);
            mileagee.Value = newAuto.mileage;


            string insertQuery = "SET IDENTITY_INSERT Car ON; INSERT INTO Car " +
            "(car_id, price, registration_date, engine_capacity, mileage,brand_id,model_id, color_id, fuel_id) " +
            "VALUES (@carid ,@pricee,@registrationDatee,@engineCapacity,@mileagee,@brandid,@modelid,@colorid,@fuelid);SET IDENTITY_INSERT Car OFF; ";

            SqlCommand command = new SqlCommand(insertQuery, dBconnection);
            command.Parameters.Add(carid);
            command.Parameters.Add(brandid);
            command.Parameters.Add(modelid);
            command.Parameters.Add(colorid);
            command.Parameters.Add(fuelid);
            command.Parameters.Add(pricee);
            command.Parameters.Add(registrationDatee);
            command.Parameters.Add(engineCapacity);
            command.Parameters.Add(mileagee);

            command.ExecuteNonQuery();
            DisconnectDatabase(); // suljetaan kantayhteys

            bool success = true;
            return success;
        }

        public bool updateAuto(Auto editedcar)
        {
            ConnectDatabase();

            //määritetään parametrit (SQLi)
            SqlParameter carid = new SqlParameter("@carid", System.Data.SqlDbType.Int, 4);
            carid.Value = editedcar.car_id;
            SqlParameter brandid = new SqlParameter("@brandid", System.Data.SqlDbType.Int, 4);
            brandid.Value = editedcar.brand_id;
            SqlParameter modelid = new SqlParameter("@modelid", System.Data.SqlDbType.Int, 4);
            modelid.Value = editedcar.model_id;
            SqlParameter colorid = new SqlParameter("@colorid", System.Data.SqlDbType.Int, 4);
            colorid.Value = editedcar.color_id;
            SqlParameter fuelid = new SqlParameter("@fuelid", System.Data.SqlDbType.Int, 4);
            fuelid.Value = editedcar.fuel_id;
            SqlParameter pricee = new SqlParameter("@pricee", System.Data.SqlDbType.Decimal);
            pricee.Value = editedcar.price;
            SqlParameter registrationDatee = new SqlParameter("@registrationDatee", System.Data.SqlDbType.DateTime);
            registrationDatee.Value = editedcar.registration_date;
            SqlParameter engineCapacity = new SqlParameter("@engineCapacity", System.Data.SqlDbType.Decimal);
            engineCapacity.Value = editedcar.engine_capacity;
            SqlParameter mileagee = new SqlParameter("@mileagee", System.Data.SqlDbType.Int, 4);
            mileagee.Value = editedcar.mileage;

            // query jolla päivitetään auton tiedot saaduilla parametreillä
            string updateQuery =
                "UPDATE Car SET " +
                "price = @pricee , " +
                "registration_date = @registrationDatee , " +
                "engine_capacity = @engineCapacity , " +
                "mileage = @mileagee , " + 
                "model_id = @modelid, " +
                "brand_id = @brandid, " +
                "color_id = @colorid , " +
                "fuel_id = @fuelid " +
                "WHERE car_id = @carid ;";
            
            SqlCommand command = new SqlCommand(updateQuery, dBconnection);
            command.Parameters.Add(carid);
            command.Parameters.Add(brandid);
            command.Parameters.Add(modelid);
            command.Parameters.Add(colorid);
            command.Parameters.Add(fuelid);
            command.Parameters.Add(pricee);
            command.Parameters.Add(registrationDatee);
            command.Parameters.Add(engineCapacity);
            command.Parameters.Add(mileagee);

            // ajetaan SQL updata kantaan
            int rows = command.ExecuteNonQuery(); 
            DisconnectDatabase();

            if (rows != 1)
                return false;
            return true; 
        }

        public bool DeleteCarFromDB(Auto deletecar)
        {
            ConnectDatabase(); // avataan kantayhteys 

            //määritetään parametrit (SQLi)
            SqlParameter carid = new SqlParameter("@carid", System.Data.SqlDbType.Int, 4);
            carid.Value = deletecar.car_id;

            // query jolla poistetaan id mukaan auto kannasta
            string deleteQuery = "DELETE FROM Car WHERE car_id = @carid ;";

            SqlCommand command = new SqlCommand(deleteQuery, dBconnection);
            command.Parameters.Add(carid);
            int rows = command.ExecuteNonQuery();

            DisconnectDatabase(); // suljetaan kantayhteys

            if (rows != 1)
                return false;
            return true;
        }


    }
}
