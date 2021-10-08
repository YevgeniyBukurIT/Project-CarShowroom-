using CarShowrooms.Data;
using System;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Xml;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace CarShowrooms
{
    public partial class FormShowroom : Form
    {
        
        public FormShowroom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Sobj.xml"))
            {
                var dcs = new DataContractSerializer(typeof(Serialization));
                var xmlr = XmlReader.Create("Sobj.xml");
                Serialization.Instance = (Serialization)dcs.ReadObject(xmlr);
                xmlr.Close();

                LbShwrmRefresh();
            }
            


        }

        private void AppEx_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }




        public void BtShwrm_Click(object sender, EventArgs e)
        {
            
            Shwrm s =  new Shwrm() 
            { 
                NameShowroom = TbNameSwrms.Text,
                Address = tbAdress.Text,
                Raiting = (int)numericUpDownRaiting.Value,
                NumberPlaceOfCars = (int)numericUpDownNumberPlaceOfCars.Value

            };
            LbShwrmRefresh();

            DB<Shwrm>.Insert($"'{s.Id}', " +
                                     $"'{s.NameShowroom}', " +
                                     $"'{s.Address}', " +
                                     $"'{s.Raiting}', " +
                                     $"'{s.NumberPlaceOfCars}' ");

        }

        


        private void LbShwrmRefresh()
        {
            LbShwrm.DataSource = null;
            LbShwrm.DataSource = Shwrm.Items;
        }

             
                

        private void buttonTotalShwrm_Click(object sender, EventArgs e)
        {
            

            labelTatolShwrm.Text = LbShwrm.Items.Count.ToString();
        }

        

        private void btnRemoveShwrm_Click(object sender, EventArgs e)
        {
            

           Shwrm.Items.Remove((Shwrm)LbShwrm.SelectedItem);

            Shwrm s = (Shwrm)LbShwrm.SelectedItem;
            LbShwrmRefresh();

            DB<Shwrm>.Delete($"Id='{s.Id}'");

        }

        private void btnEditShwrm_Click(object sender, EventArgs e)
        {
                       
            Shwrm s = (Shwrm)LbShwrm.SelectedItem;

            s.NameShowroom = TbNameSwrms.Text;
            s.Address = tbAdress.Text;
            s.Raiting = (int)numericUpDownRaiting.Value;
            s.NumberPlaceOfCars = (int)numericUpDownNumberPlaceOfCars.Value;
                        
            LbShwrmRefresh();

            DB<Shwrm>.Update($"Id='{s.Id}'", $"name='{s.NameShowroom}', " + $"address='{s.Address}', " + $"raiting='{s.Raiting}', " + $"number_place_of_cars='{s.NumberPlaceOfCars}' ");
        }

       

        private void labelTatolShwrm_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

            var dcs = new DataContractSerializer(typeof(Serialization));
            var xmlw = XmlWriter.Create("Sobj.xml");
            dcs.WriteObject(xmlw, Serialization.Instance);
            xmlw.Close();

        }

        

       
    }
}
