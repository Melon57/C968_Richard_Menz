using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Richard_Menz
{
    public partial class Add_Part : Form
    {
        public Add_Part()
        {
            InitializeComponent();
            addPartIDText.Enabled = false;
        }

        private void inHouseAddPartRadio_CheckedChanged(object sender, EventArgs e)
        {
            addPartCompanyNameLabel.Text = "Machine ID";
        }

        private void outsourcedAddPartRadio_CheckedChanged(object sender, EventArgs e)
        {
            addPartCompanyNameLabel.Text = "Company Name";
        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addPartSaveButton_Click(object sender, EventArgs e)
        {
            string name = addPartNameText.Text;
            int min;
            int max;
            int inStock;
            decimal price;
            int machineID = 0;
            string companyName = "";
            // J. Exception handling requirements:
            // "Detect non-numeric values in textboxes that expect numeric values"
            try
            {
                min = int.Parse(addPartMinText.Text);
                max = int.Parse(addPartMaxText.Text);
                inStock = int.Parse(addPartInventoryText.Text);
                price = decimal.Parse(addPartPriceText.Text);
                if(inHouseAddPartRadio.Checked)
                {
                    machineID = int.Parse(addPartCompanyNameText.Text);
                }
                if (outsourcedAddPartRadio.Checked)
                {
                    companyName = addPartCompanyNameText.Text;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Check your input to make sure that all are valid numbers\\dollar amounts\n{ex.ToString()}");
                return;
            }

            // J. Exception handling requirements:
            // "Min should be less than Max; and Inv should be between those two values"
            if (min > max)
            {
                MessageBox.Show("Max must be greater than Min");
                return;
            }
            if(inStock > max || inStock < min)
            {
                if (inStock > max)
                {
                    MessageBox.Show("Inventory cannot be greater than Max");
                    return;
                }
                else
                {
                    MessageBox.Show("Inventory cannot be less than Min");
                    return;
                }

            }


            if(inHouseAddPartRadio.Checked)
            {
                Inhouse part = new Inhouse(generateUniqueNumber(), name, price, inStock, min, max, machineID);
                Inventory.addPart(part);
                MessageBox.Show($"{name} added correctly.");
                Close();
            }

            if (outsourcedAddPartRadio.Checked)
            {
                Outsourced part = new Outsourced(generateUniqueNumber(), name, price, inStock, min, max, companyName);
                Inventory.addPart(part);
                MessageBox.Show($"{name} added correctly.");
                Close();
            }

        }
        private int generateUniqueNumber()
        {
            Random random1 = new Random();
            Random random2 = new Random();
            string tempString = random1.Next(100, 333).ToString() + random2.Next(334, 666).ToString() + Inventory.AllParts.Count.ToString();
            return int.Parse(tempString);

        }
    }
}
