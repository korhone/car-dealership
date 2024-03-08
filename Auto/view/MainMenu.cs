using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CarDealership.model;
using CarDealership.controller;
using System.Diagnostics;


namespace CarDealership.view
{
    public partial class MainMenu : Form
    {
        private ShopLogic registerHandler;
        private Auto a;
        private List<Auto> cars;
        private List<Auto> autot;
        private int currentAuto;
        private bool addcarmode = false;
        private bool editmode = false;
        int arvo = 0;

        public MainMenu()
        {
            InitializeComponent();
            registerHandler = new ShopLogic();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            SearchAllCars_idASC();

        }

        // metodit testata kantayhteys ja ohjelman sulkeminen: 
        private void test_DataBase_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (registerHandler.TestDatabaseConnection() == true)
            {
                MessageBox.Show("Database connection working!");
            }
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //jos haluttaisiin näyttää autot hinnanmukaan, eikä id mukaan, voitaisiin käyttää tätä.
        private void SearchAllCars_byprice()
        {
            autot = registerHandler.GetAllAutosbyPrice(); //täytetään autolista
            currentAuto = 0;
            a = autot[currentAuto];
            DisplayAuto(); //täytetään auton tiedot Fromiin, edullisin eka
        }

        // Metodi joka hakee Formiin autot ID mukaan
        private void SearchAllCars_idASC()
        {
            cars = registerHandler.GetAllAutos(); //täytetään autolista
            currentAuto = 0;
            a = cars[currentAuto];
            DisplayAuto(); //täytetään auton tiedot sen id perusteella Formiin
            SetEditable(false);
        }
        private void DisplayAuto()
        {
            // täytetään pääikkunan tekstikentät auto-listan tiedoilla.
            tbId.Text = a.car_id.ToString();
            tb_price.Text = a.price.ToString();
            dtp_reg_date.Text = a.registration_date.ToString();
            tb_eng_cap.Text = a.engine_capacity.ToString();
            tb_mileage.Text = a.mileage.ToString();

            // combobox brand täyttäminen id mukaan.
            cb_Brand.DataSource = registerHandler.GetAllBrands();
            cb_Brand.ValueMember = "brand_id";
            cb_Brand.DisplayMember = "brand_name";
            cb_Brand.SelectedValue = a.brand_id;

            // combobox model täyttäminen id mukaan.
            cb_Model.DataSource = registerHandler.GetAutoModels(a.brand_id);
            cb_Model.ValueMember = "model_id";
            cb_Model.DisplayMember = "model_name";
            cb_Model.SelectedValue = a.model_id;

            // combobox color täyttäminen id mukaan.
            cb_Color.DataSource = registerHandler.GetColors();
            cb_Color.ValueMember = "color_id";
            cb_Color.DisplayMember = "color_name";
            cb_Color.SelectedValue = a.color_id;

            // combobox fuel täyttäminen id mukaan.
            cb_Fuel.DataSource = registerHandler.GetFuels();
            cb_Fuel.ValueMember = "fuel_id";
            cb_Fuel.DisplayMember = "fuel_name";
            cb_Fuel.SelectedValue = a.fuel_id;
        }

        private void cb_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            // näytetään mallit valmistajan mukaan
            if (cb_Brand.SelectedValue != null &&
                cb_Brand.SelectedValue.GetType().ToString().Equals("System.Int32"))
            {
                int brand_id = Convert.ToInt32(cb_Brand.SelectedValue.ToString());
                cb_Model.DataSource = registerHandler.GetAutoModels(brand_id);
                cb_Model.ValueMember = "model_id";
                cb_Model.DisplayMember = "model_name";
                cb_Model.SelectedValue = a.model_id;
            }
        }
        private void SetEditable(Boolean yesnno) //määritettään muokattavat kentät
        {
            tb_price.ReadOnly = !yesnno;
            tb_mileage.ReadOnly = !yesnno;
            tb_eng_cap.ReadOnly = !yesnno;
            dtp_reg_date.Enabled = yesnno;

            cb_Brand.Enabled = yesnno;
            cb_Model.Enabled = yesnno;
            cb_Color.Enabled = yesnno;
            cb_Fuel.Enabled = yesnno;

            btnEdellinen.Enabled = !yesnno;
            btnSeuraava.Enabled = !yesnno;
            btn_Edit.Enabled = !yesnno;
            btn_Add_Car.Enabled = !yesnno;
            btn_SaveChange.Enabled = yesnno;
            btn_CancelChange.Enabled = yesnno;
            btn_DeleteCar.Enabled = !yesnno;
        }

        // Alla buttonien metodit: 
        private void btnSeuraava_Click(object sender, EventArgs e) //auton vaihtaminen eteenpäin
        {
            SetEditable(false);
            currentAuto++;
            if (currentAuto == cars.Count) { currentAuto = 0; }
            a = cars[currentAuto];
            DisplayAuto();
        }
        private void btnEdellinen_Click(object sender, EventArgs e) // auton vaihto takaisinpäin
        {
            SetEditable(false);
            currentAuto--;
            if (currentAuto < 0) { currentAuto = cars.Count - 1; }
            a = cars[currentAuto];
            DisplayAuto();
        }
        private void btn_CancelChange_Click(object sender, EventArgs e)
        {
            SetEditable(false);
            DisplayAuto();
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            editmode = true;
            SetEditable(true);
        }
        private void btn_Add_Car_Click(object sender, EventArgs e)
        {
            addcarmode = true;
            SetEditable(true);

            ClearText(); //kaikki kentät tyhjiksi lisäystä varten
        }
        private void btn_SaveChange_Click(object sender, EventArgs e)
        {
            // EDIT CAR MODE:
            if (editmode == true)
            {
                EditCarMode();
            }
            // ADD CAR MODE:
            else if (addcarmode == true)
            {
                AddCarMode();
            }
        }
        private void btn_DeleteCar_Click(object sender, EventArgs e)
        {
            registerHandler.DeleteCarFromDB(a);
            int poistoid = a.car_id;
            // rivi poistettu tietokannasta
            MessageBox.Show("Delete Car with id " + poistoid +" success."); // kerrotaan että poisto onnistui.
            SearchAllCars_idASC();
            // näytetään nollasauto poiston jälkeen
            DisplayAuto();
        }

        // btn_SaveChange_Click sisällä olevat metodit EditCarMode ja AddCarMode (ettei btn tulisi liian pitkä)
        private void EditCarMode()
        {
            Auto edited_car = new Auto();

            edited_car.car_id = int.Parse(tbId.Text); // No revision, presumed to be of correct form

            // Price check editcarmode
            int price;
            if (int.TryParse(tb_price.Text, out price))
            {
                if (price < 0)
                {
                    MessageBox.Show("The price cannot be negative.");
                    return;
                }
                else
                {
                    edited_car.price = price;
                }
            }
            else
            {
                // Incorrect price, notification to the user
                MessageBox.Show("Incorrect price. Enter the price as an integer.");
                return;
            }

            // Date is set as default Date Now, can be in futue or in pass
            edited_car.registration_date = dtp_reg_date.Value;

            // Engine Capacity check editcarmode
            decimal engineCapacity;
            if (decimal.TryParse(tb_eng_cap.Text, out engineCapacity))
            {
                if (decimal.Parse(tb_eng_cap.Text) > 10 || decimal.Parse(tb_eng_cap.Text) < 0)
                {
                    MessageBox.Show("Incorrect engine capacity. Should be more than 0, less than 10.");
                    return;
                }
                else
                {
                    edited_car.engine_capacity = engineCapacity;
                }
            }
            else
            {
                // Incorrect engine capacity, notification to the user
                MessageBox.Show("Incorrect engine volume. Enter the volume in numbers in range 0,1 - 9,9 seperated with comma.");
                return;
            }

            //Mileage Check editcarmode
            int mileage;
            if (int.TryParse(tb_mileage.Text, out mileage))
            {

                if (int.Parse(tb_mileage.Text) < 0)
                {
                    MessageBox.Show("Incorrect mileage, cannot be negative.");
                    return;
                }
                else
                {
                    edited_car.mileage = mileage;
                }
            }
            else
            {
                // Incorrect mileage, notification to the user
                MessageBox.Show("Incorrect mileage. Enter the mileage in numbers.");
                return;
            }

            // brand, model, color, fuel, check that the value is not null. editcarmode
            if (cb_Brand.SelectedValue != null)
            {
                edited_car.brand_id = (int)cb_Brand.SelectedValue;
            }
            else
            {
                MessageBox.Show("Car Brand not selected, try again");
                return;
            }
            if (cb_Model.SelectedValue != null)
            {
                edited_car.model_id = (int)cb_Model.SelectedValue;
            }
            else
            {
                MessageBox.Show("Car Model not selected, try again");
                return;
            }
            if (cb_Color.SelectedValue != null)
            {

                edited_car.color_id = (int)cb_Color.SelectedValue;
            }
            else
            {
                MessageBox.Show("Color not selected, try again");
                return;
            }
            if (cb_Fuel.SelectedValue != null)
            {
                edited_car.fuel_id = (int)cb_Fuel.SelectedValue;
            }
            else
            {
                MessageBox.Show("Fuel type not selected, try again");
                return;
            }

            // If all checks passed, car can be updated
            registerHandler.updateAuto(edited_car);
            SetEditable(false);
            editmode = false;
            cars[currentAuto] = edited_car;
        }

        private void AddCarMode()
        {
            Auto newcar = new Auto();
            newcar.car_id = GetLastAutoId();

            // Price check addcarmode
            int price;
            if (int.TryParse(tb_price.Text, out price))
            {
                if (int.Parse(tb_price.Text) < 0)
                {
                    MessageBox.Show("The price cannot be less than zero.");
                    return;
                }
                else
                {
                    newcar.price = price;
                }
            }
            else
            {
                // Incorrect price, notification to the user
                MessageBox.Show("Incorrect price. Enter the price as an integer.");
                return;
            }

            // Date is set as default Date Now, can be in futue or in pass, addcarmode
            newcar.registration_date = dtp_reg_date.Value;

            // Engine Capacity check addcarmode
            decimal engineCapacity;
            if (decimal.TryParse(tb_eng_cap.Text, out engineCapacity))
            {
                if (decimal.Parse(tb_eng_cap.Text) > 10 || decimal.Parse(tb_eng_cap.Text) < 0)
                {
                    MessageBox.Show("Incorrect engine capacity. Must be in rage 0,1 - 9,9.");
                    return;
                }
                else
                {
                    newcar.engine_capacity = engineCapacity;
                }
            }
            else
            {
                // Incorrect engine capacity, notification to the user
                MessageBox.Show("Incorrect engine volume. Enter the volume in numbers in range 0,1 - 9,9 seperated with comma.");
                return;
            }

            // Mileage Check addcarmode
            int mileage;
            if (int.TryParse(tb_mileage.Text, out mileage))
            {
                if (mileage < 0)
                {
                    MessageBox.Show("Incorrect mileage, cannot be negative.");
                    return;
                }
                else
                {
                    newcar.mileage = mileage;
                }
            }
            else
            {
                // Incorrect mileage, user notification 
                MessageBox.Show("Incorrect mileage. Enter the mileage in numbers.");
                return;
            }

            // brand, model, color, fuel, if-else != null check, addcarmode
            if (cb_Brand.SelectedValue != null)
            {
                newcar.brand_id = (int)cb_Brand.SelectedValue;
            }
            else
            {
                MessageBox.Show("Car Brand not selected, try again");
            }
            if (cb_Model.SelectedValue != null)
            {
                newcar.model_id = (int)cb_Model.SelectedValue;
            }
            else
            {
                MessageBox.Show("Car Model not selected, try again");
            }
            if (cb_Color.SelectedValue != null)
            {
                newcar.color_id = (int)cb_Color.SelectedValue;
            }
            else
            {
                MessageBox.Show("Color not selected, try again");
            }
            if (cb_Fuel.SelectedValue != null)
            {
                newcar.fuel_id = (int)cb_Fuel.SelectedValue;
            }
            else
            {
                MessageBox.Show("Fuel type not selected, try again");
            }

            registerHandler.SaveAuto(newcar);
            MessageBox.Show("Car added to Database with id " + newcar.car_id + ".", "The addition was successful", MessageBoxButtons.OK);
            SetEditable(false);
            addcarmode = false;
            cars[currentAuto] = newcar;
        }

        // haetaan viimeisen auton id, johon määritetään uuden lisättävän auton id
        private int GetLastAutoId()
        {
            if (cars != null && cars.Count > 0)
            {
                arvo += 1; //jokaisella session lisäyksellä kasvatetaan lukua
                Auto lastcar = cars[cars.Count - 1];
                int lastAutoId = lastcar.car_id + arvo; // määritetään uudelle autolle id
                return lastAutoId;
            }
            else {return 0; }
        }

        // metodi tyhjentää kentät uuden auton lisäystä varten
        private void ClearText()
        {
            cb_Model.Text = null;
            cb_Model.SelectedIndex = -1;

            cb_Brand.Text = null;
            cb_Brand.SelectedIndex = -1;

            cb_Fuel.Text = null;
            cb_Fuel.SelectedIndex = -1;

            cb_Color.Text = null;
            cb_Color.SelectedIndex = -1;

            tb_price.Text = null;
            tbId.Text = null;
            tb_eng_cap.Text = null;
            tb_mileage.Text = null;

            dtp_reg_date.Text = DateTime.Now.ToString(); //uuden auton rekisteröinti pvm DateTime.Now by default
        }
    }
}
