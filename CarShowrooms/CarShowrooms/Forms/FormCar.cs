using CarShowrooms.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CarShowrooms
{
    public partial class CreateCare : Form
    {
       
        
        public CreateCare()

        {
            InitializeComponent();
        }

        private void CreateCare_Load(object sender, EventArgs e)
        {
            lbSHWRM.DataSource = Shwrm.Items;
            lbSHWRM.DisplayMember = "NameShowroom";

            lbSellers1.DataSource = Seller.Items;
            lbSellers1.DisplayMember = "Name";

            CbModel.DataSource = Enum.GetValues(typeof(Model)).Cast<Model>();
            CbOccasion.DataSource = Enum.GetValues(typeof(Occasion)).Cast<Occasion>();

            if(File.Exists("Sobj.xml"))
            {
                            
                var dcs = new DataContractSerializer(typeof(Serialization));
                var xmlr = XmlReader.Create("Sobj.xml");
                Serialization.Instance = (Serialization)dcs.ReadObject(xmlr);
                xmlr.Close();

                LbCarRefresh();

                LbShwrmRefresh();

                LbSellerRefresh();
            }
            
        } 
        
        private void LbCarRefresh()
        {
            LbCars.DataSource = null;
            LbCars.DataSource = Car.Items;
        }

        private void LbSellerRefresh()
        {
            lbSellers1.DataSource = null;
            lbSellers1.DataSource = Seller.Items;
        }

        private void LbShwrmRefresh()
        {
            lbSHWRM.DataSource = null;
            lbSHWRM.DataSource = Shwrm.Items;
        }



        private void BtnCreateCar_Click(object sender, EventArgs e)
        {
            
            Car c = new  Car()
            {

                Model = (Model)CbModel.SelectedItem,
                licensePlate = tbLicensePlate.Text,
                VINnumber = TbVINnumber.Text,
                occasion = (Occasion)CbOccasion.SelectedItem,
                NumberOfSeats = (int)numericUpDownNumberOfSeats.Value,
                Shwrm = (Shwrm)lbSHWRM.SelectedItem,
                Seller = (Seller)lbSellers1.SelectedItem


            };

            LbCarRefresh();

            DB<Car>.Insert($"'{c.Id}', " +
                                     $"'{c.Seller.Id}', " +
                                     $"'{c.Shwrm.Id}', " +
                                     $"'{c.Model}', " +
                                     $"'{c.licensePlate}', " +
                                     $"'{c.VINnumber}', " +
                                     $"'{c.occasion}', " + 
                                     $"'{c.NumberOfSeats}' ");


        }

        
                               

        private void buttonExitCreateCar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        

        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            Car.Items.Remove((Car)LbCars.SelectedItem);

            Car c = (Car)LbCars.SelectedItem;
            LbCarRefresh();

            DB<Car>.Delete($"Id='{c.Id}'");

        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            Car c = (Car)LbCars.SelectedItem;

            c.Model = (Model)CbModel.SelectedItem;
            c.licensePlate = tbLicensePlate.Text;
            c.VINnumber = TbVINnumber.Text;
            c.occasion = (Occasion)CbOccasion.SelectedItem;
            c.NumberOfSeats = (int)numericUpDownNumberOfSeats.Value;

            LbCarRefresh();

            DB<Car>.Update($"Id='{c.Id}'", $"Id_showroom='{c.Shwrm.Id}', " + $"id_seller='{c.Seller.Id}', " + $"model_name='{c.Model}', " + $"license_plate='{c.licensePlate}', " + $"VIN_number='{c.VINnumber}', " + $"occasion='{c.occasion}', " + $"number_of_seats='{c.NumberOfSeats}' ");
       
        }

        

        public void buttonTotalPrice_Click(object sender, EventArgs e)
        {

            Car car = new Car();

            if (LbCars.Text == "")
            {
                MessageBox.Show("Buy car");
                
            }
             
            Model words = ((Car)LbCars.SelectedItem).Model;

            labelTotalPrice.Text = car.GetSumModel(words.ToString());

            labelGetCredit.Text = car.GetCredit();


            
        }

        private void buttonTotalCars_Click(object sender, EventArgs e)
        {
            labelTatolCars.Text = LbCars.Items.Count.ToString();
        }

        private void labelTatolCars_Click(object sender, EventArgs e)
        {

        }

        private void CreateCare_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dcs = new DataContractSerializer(typeof(Serialization));
            var xmlw = XmlWriter.Create("Sobj.xml");
            dcs.WriteObject(xmlw, Serialization.Instance);
            xmlw.Close();
        }

        
    }
}
