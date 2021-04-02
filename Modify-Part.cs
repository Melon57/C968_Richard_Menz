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
    public partial class Modify_Part : Form
    {
        public Modify_Part()
        {
            InitializeComponent();
            
        }

        public Modify_Part(Inhouse inhouse)
        {
            InitializeComponent();
            inHouseModifyPartRadio.Checked = true;
            outsourcedModifyPartRadio.Checked = false;
            modifyPartIDText.Enabled = false;
            modifyPartIDText.Text = inhouse.PartID.ToString();
            modifyPartNameText.Text = inhouse.Name;
            modifyPartInventoryText.Text = inhouse.InStock.ToString();
            modifyPartPriceText.Text = inhouse.Price.ToString();
            modifyPartMaxText.Text = inhouse.Max.ToString();
            modifyPartMinText.Text = inhouse.Min.ToString();
            modifyPartCompanyNameLabel.Text = "Machine ID";
            modifyPartCompanyNameText.Text = inhouse.MachineID.ToString();
        }
        public Modify_Part(Outsourced outsourced)
        {
            InitializeComponent();
            outsourcedModifyPartRadio.Checked = true;
            inHouseModifyPartRadio.Checked = false;
            modifyPartIDText.Enabled = false;
            modifyPartIDText.Text = outsourced.PartID.ToString();
            modifyPartNameText.Text = outsourced.Name;
            modifyPartInventoryText.Text = outsourced.InStock.ToString();
            modifyPartPriceText.Text = outsourced.Price.ToString();
            modifyPartMaxText.Text = outsourced.Max.ToString();
            modifyPartMinText.Text = outsourced.Min.ToString();
            modifyPartCompanyNameLabel.Text = "Company Name";
            modifyPartCompanyNameText.Text = outsourced.CompanyName.ToString();
        }

        private void inHouseModifyPartRadio_CheckedChanged(object sender, EventArgs e)
        {
            modifyPartCompanyNameLabel.Text = "Machine ID";
        }

        private void outsourcedModifyPartRadio_CheckedChanged(object sender, EventArgs e)
        {
            modifyPartCompanyNameLabel.Text = "Company Name";
        }

        private void modifyPartSaveButton_Click(object sender, EventArgs e)
        {
            int id;
            string name = modifyPartNameText.Text;
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
                id = int.Parse(modifyPartIDText.Text);
                min = int.Parse(modifyPartMinText.Text);
                max = int.Parse(modifyPartMaxText.Text);
                inStock = int.Parse(modifyPartInventoryText.Text);
                price = decimal.Parse(modifyPartPriceText.Text);
                if (inHouseModifyPartRadio.Checked)
                {
                    machineID = int.Parse(modifyPartCompanyNameText.Text);
                }
                if (outsourcedModifyPartRadio.Checked)
                {
                    companyName = modifyPartCompanyNameText.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Check your input to make sure that all are valid numbers\\dollar amounts\n{ex.ToString()}");
                return;
            }

            // J. Exception handling requirements:
            // "Min should be less than Max; and Inv should be between those values"
            if (min > max)
            {
                MessageBox.Show("Max must be greater than Min");
                return;
            }
            if (inStock > max || inStock < min)
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

            if (inHouseModifyPartRadio.Checked)
            {
                Inhouse part = new Inhouse(id, name, price, inStock, min, max, machineID);
                Inventory.updatePart(id, part);
                MessageBox.Show($"{name} updated correctly.");
                Close();
            }

            if (outsourcedModifyPartRadio.Checked)
            {
                Outsourced part = new Outsourced(id, name, price, inStock, min, max, companyName);
                Inventory.updatePart(id,part);
                MessageBox.Show($"{name} updated correctly.");
                Close();
            }
        }

        private void modifyPartCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
