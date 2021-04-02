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
    public partial class Modify_Product : Form
    {
        BindingList<Part> parts = new BindingList<Part>();

        public Modify_Product()
        {
            InitializeComponent();
        }
        public Modify_Product(Product product)
        {
            InitializeComponent();
            ModPartsAssctdPrdDGView.DataSource = parts;
            ModProductPartsDataGridView.DataSource = Inventory.AllParts;
            modProductIDText.Enabled = false;
            modProductIDText.Text = product.ProductID.ToString();
            modProductNameText.Text = product.Name.ToString();
            modProductInventoryText.Text = product.InStock.ToString();
            modProductPriceText.Text = product.Price.ToString();
            modProductMaxText.Text = product.Max.ToString();
            modProductMinText.Text = product.Min.ToString();
            foreach(Part part in product.AssociatedParts)
            {
                parts.Add(part);

            }
            ModPartsAssctdPrdDGView.Update();
            ModPartsAssctdPrdDGView.Refresh();
        }




        private void modifyProductSaveButton_Click(object sender, EventArgs e)
        {
            int id;
            string name = modProductNameText.Text;
            int min;
            int max;
            int inStock;
            decimal price;
            // J. Exception handling requirements:
            // "Detect non-numeric values in textboxes that expect numeric values"
            try
            {
                id = int.Parse(modProductIDText.Text);
                min = int.Parse(modProductMinText.Text);
                max = int.Parse(modProductMaxText.Text);
                inStock = int.Parse(modProductInventoryText.Text);
                price = decimal.Parse(modProductPriceText.Text);
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


            Product product = new Product(id, name, price, inStock, min, max);
            foreach (var part in parts)
            {
                product.AssociatedParts.Add(part);
            }
            Inventory.updateProduct(id,product);
            MessageBox.Show($"{name} modified correctly.");
            Close();
        }

        private void addProductDeleteButton_Click(object sender, EventArgs e)
        {
            // J. Exception handling requirements:
            // "Confirm “Delete” actions"
            DialogResult result = MessageBox.Show("Are you sure that you want to delete this part?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // J. Exception handling requirements:
                // "Prevent user from deleting a product that has a Part associated with it"
                if (ModPartsAssctdPrdDGView.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in ModPartsAssctdPrdDGView.SelectedRows)
                    {
                        ModPartsAssctdPrdDGView.Rows.RemoveAt(row.Index);
                    }
                }
                else
                {
                    MessageBox.Show("You must select at least one row to delete");
                }
            }

        }

        private void modifyProductAddButton_Click(object sender, EventArgs e)
        {
            Part part = (Part)ModProductPartsDataGridView.CurrentRow.DataBoundItem;
            parts.Add(part);
        }

        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modifyProductSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int partToSearch = int.Parse(modifyProductSearchText.Text);
                if (partToSearch < 0)
                {
                    MessageBox.Show("Enter a valid part number;");
                    return;
                }
                else
                {
                    Part partToFind = Inventory.lookupPart(partToSearch);
                    foreach (DataGridViewRow row in ModProductPartsDataGridView.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        if (part.PartID == partToFind.PartID)
                        {
                            UnselectEverything(ModProductPartsDataGridView);
                            row.Selected = true;
                            ModProductPartsDataGridView.CurrentCell = ModProductPartsDataGridView.Rows[row.Index].Cells[0];
                            modifyProductSearchText.Text = "";
                            return;
                        }
                    }
                    // If part not found
                    MessageBox.Show("Part not found");
                    modifyProductSearchText.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Enter a valid part number.\n{ex}");
            }
        }
        private void UnselectEverything(DataGridView dataGridView)
        {
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                item.Selected = false;

            }
        }
    }
}
