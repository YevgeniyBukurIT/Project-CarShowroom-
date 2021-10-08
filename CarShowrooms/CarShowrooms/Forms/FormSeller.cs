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
    public partial class FormSeller : Form
    {
        public FormSeller()
        {
            InitializeComponent();
        }

        

        private void FormSeller_Load(object sender, EventArgs e)
        {
            lbShowrooms2.DataSource = Shwrm.Items;
            lbShowrooms2.DisplayMember = "NameShowroom";

            comboBoxSex.DataSource = Enum.GetValues(typeof(Sex)).Cast<Sex>();

            if (File.Exists("Sobj.xml"))
            {


                var dcs = new DataContractSerializer(typeof(Serialization));
                var xmlr = XmlReader.Create("Sobj.xml");
                Serialization.Instance = (Serialization)dcs.ReadObject(xmlr);
                xmlr.Close();

                LbSellerRefresh();

                LbShwrmRefresh();

            }

        }

        private void LbShwrmRefresh()
        {
            lbShowrooms2.DataSource = null;
            lbShowrooms2.DataSource = Shwrm.Items;
        }
        
        private void LbSellerRefresh()
        {
            lbSellers.DataSource = null;
            lbSellers.DataSource = Seller.Items;
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
           

            Seller sel = new Seller
            {

                Name = tbName.Text,
                SurName = tbSurName.Text,
                Sex = (Sex)comboBoxSex.SelectedItem,
                Age = (int)numericUpDownAge.Value,
                PhoneNumber = maskedTextBoxPhoneNumber.Text,
                                               

            };


            //SellersInShwrm sis = new SellersInShwrm() { Seller = sel, Shwrm = (Shwrm)lbShowrooms2.SelectedItem };

            foreach (var shwrm in lbShowrooms2.SelectedItems)
            {
                SellersInShwrm sis = new SellersInShwrm() { Seller = sel, Shwrm = (Shwrm)shwrm };



                DB<SellersInShwrm>.Insert($"'{sis.Id}', " +
                                     $"'{sis.Shwrm.Id}', " +
                                     $"'{sis.Seller.Id}' ");

            }

            DB<Seller>.Insert($"'{sel.Id}', " +
                                     $"'{sel.Name}', " +
                                     $"'{sel.SurName}', " +
                                     $"'{sel.Sex}', " +
                                     $"'{sel.Age}', " +
                                     $"'{sel.PhoneNumber}' ");

            LbSellerRefresh();

           


        }

        private void btnAddSellerTo_Click(object sender, EventArgs e)
        {

            //SellersInShwrm(new SellersInShwrm() { Seller = (Seller)lbSellers.SelectedItem, Shwrm = (Shwrm)checkedListBox1.CheckedItems });

        }



        private void btnExitSeller_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnEditSeller_Click(object sender, EventArgs e)
        {
                        
            Seller sel = (Seller)lbSellers.SelectedItem;


            sel.Name = tbName.Text;
            sel.SurName = tbSurName.Text;
            sel.Sex = (Sex)comboBoxSex.SelectedItem;
            sel.Age = (int)numericUpDownAge.Value;
            sel.PhoneNumber = maskedTextBoxPhoneNumber.Text;

            
            
            LbSellerRefresh();

            DB<Seller>.Update($"Id='{sel.Id}'", $"Name='{sel.Name}', " + $"Surname='{sel.SurName}', " +  $"Sex='{sel.Sex}', " +  $"Age='{sel.Age}', " + $"Phone_number='{sel.PhoneNumber}' ");




        }

        private void btnDeleteSeller_Click(object sender, EventArgs e)
        {
            Seller.Items.Remove((Seller)lbSellers.SelectedItem);

            Seller s = (Seller)lbSellers.SelectedItem;
            LbSellerRefresh();

            
            DB<SellersInShwrm>.Delete($"id_seller='{s.Id}'");

            DB<Seller>.Delete($"Id='{s.Id}'");

        }

        private void btnGetSallary_Click(object sender, EventArgs e)
        {
            Seller s = new Seller();

            labelGetSalaryMounth.Text = s.GetSalaryMounth(numericUpDownnumberOfCarsSold.Value);

            labelGetSalaryYear.Text = s.GetSalaryYear(numericUpDownnumberOfCarsSold.Value);

        }

        private void btnTotalSellers_Click(object sender, EventArgs e)
        {
            labelTotalSellers.Text = lbSellers.Items.Count.ToString();
        }

        private void FormSeller_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dcs = new DataContractSerializer(typeof(Serialization));
            var xmlw = XmlWriter.Create("Sobj.xml");
            dcs.WriteObject(xmlw, Serialization.Instance);
            xmlw.Close();
        }

        private void lbShowrooms2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
