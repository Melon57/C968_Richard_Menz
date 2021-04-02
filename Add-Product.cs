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
    public partial class Add_Product : Form
    {
        BindingList<Part> parts = new BindingList<Part>();
        public Add_Product()
        {
            InitializeComponent();
            
            AddProductPartsDataGridView.DataSource = Inventory.AllParts;
            PartsAssctdPrdDataGridView.DataSource = parts;
            addProductIDText.Enabled = false;
        }

        private void addProductSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int partToSearch = int.Parse(addProductSearchText.Text);
                if (partToSearch < 0)
                {
                    MessageBox.Show("Enter a valid part number;");
                    return;
                }
                else
                {
                    Part partToFind = Inventory.lookupPart(partToSearch);
                    foreach (DataGridViewRow row in AddProductPartsDataGridView.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        if (part.PartID == partToFind.PartID)
                        {
                            UnselectEverything(AddProductPartsDataGridView);
                            row.Selected = true;
                            addProductSearchText.Text = "";
                            return;
                        }
                    }
                    // If part not found
                    MessageBox.Show("Part not found");
                    addProductSearchText.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Enter a valid part number.\n{ex}");
            }
        }

        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void UnselectEverything(DataGridView dataGridView)
        {
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                item.Selected = false;
            }
        }

        private void addProductDeleteButton_Click(object sender, EventArgs e)
        {
            // J. Exception handling requirements:
            // "Confirm “Delete” actions"
            DialogResult result = MessageBox.Show("Are you sure that you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // J. Exception handling requirements:
                // "Prevent the user from deleting a product that has a Part associated with it"
                foreach (DataGridViewRow row in PartsAssctdPrdDataGridView.SelectedRows)
                {
                    PartsAssctdPrdDataGridView.Rows.RemoveAt(row.Index);
                }
            }

        }

        private void addProductAddButton_Click(object sender, EventArgs e)
        {
            Part part = (Part)AddProductPartsDataGridView.CurrentRow.DataBoundItem;
            parts.Add(part);
        }

        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            string name = addProductNameText.Text;
            int min;
            int max;
            int inStock;
            decimal price;
            // J. Exception handling requirements:
            // "Detect non-numeric values in textboxes that expect numeric values"
            try
            {
                min = int.Parse(addProductMinText.Text);
                max = int.Parse(addProductMaxText.Text);
                inStock = int.Parse(addProductInventoryText.Text);
                price = decimal.Parse(addProductPriceText.Text);
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
                

            Product product = new Product(generateUniqueNumber(), name, price, inStock, min, max);
            foreach (var part in parts)
            {
                product.AssociatedParts.Add(part);
            }
            Inventory.addProduct(product);
            MessageBox.Show($"{name} added correctly.");
            Close();
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
