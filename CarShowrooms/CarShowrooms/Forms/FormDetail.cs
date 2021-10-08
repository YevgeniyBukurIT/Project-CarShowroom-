using CarShowrooms.Data;
using CarShowrooms.Data.Classes;
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

namespace CarShowrooms.Forms
{
    public partial class FormDetail : Form
    {
        public FormDetail()
        {
            InitializeComponent();
        }

        
        private void FormDetail_Load(object sender, EventArgs e)
        {
            lbCars2.DataSource = Shwrm.Items;
            lbCars2.DisplayMember = "Model";

            comboBoxDetailModel.DataSource = Enum.GetValues(typeof(Model)).Cast<Model>();

            if(File.Exists("Sobj.xml"))
            {
                          
                var dcs = new DataContractSerializer(typeof(Serialization));
                var xmlr = XmlReader.Create("Sobj.xml");
                Serialization.Instance = (Serialization)dcs.ReadObject(xmlr);
                xmlr.Close();

                LbDetailRefresh();

                LbCarRefresh();
            }
            

        }

        private void LbCarRefresh()
        {
            lbCars2.DataSource = null;
            lbCars2.DataSource = Car.Items;
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {

            

            Detail d = new Detail 
            {
                
                DeteilType = TbDeteilType.Text,
                DetailNumber = TbDetailNumber.Text,
                Mass = (int)numericUpDownDetailMass.Value,
                DetailModel = (Model)comboBoxDetailModel.SelectedItem,
                Car = (Car)lbCars2.SelectedItem

            };
            
            LbDetailRefresh();

            DB<Detail>.Insert($"'{d.Id}', " +
                                     $"'{d.Car.Id}', " +
                                     $"'{d.DeteilType}', " +
                                     $"'{d.DetailNumber}', " +
                                     $"'{d.Mass}', " +
                                     $"'{d.DetailModel}' ");


        }

       

        private void LbDetailRefresh()
        {
            LbDetails.DataSource = null;
            LbDetails.DataSource = Detail.Items;
        }

        private void BtnExitDetails_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnRenoveDetail_Click(object sender, EventArgs e)
        {
            Detail.Items.Remove((Detail)LbDetails.SelectedItem);

            Detail d = (Detail)LbDetails.SelectedItem;
            LbDetailRefresh();

            DB<Detail>.Delete($"Id='{d.Id}'");
        }

        private void btnEditDetail_Click(object sender, EventArgs e)
        {
            
            Detail d = (Detail)LbDetails.SelectedItem;

            d.DeteilType = TbDeteilType.Text;
            d.DetailNumber = TbDetailNumber.Text;
            d.Mass = (int)numericUpDownDetailMass.Value;
            d.DetailModel = (Model)comboBoxDetailModel.SelectedItem;

            
            LbDetailRefresh();

            DB<Detail>.Update($"Id='{d.Id}'", $"Id_car='{d.Car.Id}', " + $"detail_type='{d.DeteilType}', " + $"detail_number='{d.DetailNumber}', " + $"mass='{d.Mass}', " + $"to_model='{d.DetailModel}' ");
        }

       

        private void btnTotalDetails_Click(object sender, EventArgs e)
        {
            labelTotalDetails.Text = LbDetails.Items.Count.ToString();
        }

        private void FormDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dcs = new DataContractSerializer(typeof(Serialization));
            var xmlw = XmlWriter.Create("Sobj.xml");
            dcs.WriteObject(xmlw, Serialization.Instance);
            xmlw.Close();
        }
    }
    
}
