using CarDealership.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.controller
{
    public class ShopLogic
    {
        DatabaseControl dbModel = new DatabaseControl();

        public bool TestDatabaseConnection()
        {
            bool doesItWork = dbModel.ConnectDatabase();
            return doesItWork; // palauttaa true or false.
        }

        public bool SaveAuto(model.Auto newAuto) 
        {
            bool success = dbModel.SaveAutoIntoDatabase(newAuto);
            return success;
        }

        public List<Brand> GetAllBrands() {

            return dbModel.GetAllBrands();
        }

        public List<Model> GetAutoModels(int brand_id) {

            return dbModel.GetModelsByBrandId(brand_id);
        }
        public List<Auto> GetAllAutosbyPrice()
        {
            return dbModel.GetAllAutosbyPrice();
        }
        public List<Auto> GetAllAutos()
        {
            return dbModel.GetAllAutos();
        }
        public List<Color> GetColors()
        {
            return dbModel.GetAllColors();
        }
        public List<Fuel> GetFuels() 
        { 
            return dbModel.GetAllFuels(); 
        }

        public bool updateAuto(Auto editedcar)
        {
            return dbModel.updateAuto(editedcar);
        }

        public bool DeleteCarFromDB(Auto deletedcar)
        {
            return dbModel.DeleteCarFromDB(deletedcar);
        }

    }
}
