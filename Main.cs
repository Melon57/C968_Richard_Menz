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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            partsDataGridView.DataSource = Inventory.AllParts;
            productsDataGridView.DataSource = Inventory.Products;
            testData();
        }

        private void testData()
        {
            Part part1 = new Inhouse(1239082, "Capacitors", 0.12m, 34, 2, 45, 123);
            Part part2 = new Outsourced(2348922, "Bolt", 0.03m, 245, 2, 450, "Yakult");
            Part part3 = new Outsourced(7695232, "Wire", 1.55m, 105, 2 , 500, "Yakult");
            Inventory.AllParts.Add(part1);
            Inventory.AllParts.Add(part2);
            Inventory.AllParts.Add(part3);
            Product product1 = new Product(1119999, "Control Panel", 57.50m, 30, 1, 45);
            product1.addAssociatedPart(part1);
            product1.addAssociatedPart(part2);
            product1.addAssociatedPart(part3);
            Inventory.Products.Add(product1);

            Product product2 = new Product(1128888, "Control Board", 11.55m, 25, 1, 50);
            product2.addAssociatedPart(part1);
            Inventory.Products.Add(product2);
        }

        private void partSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int partToSearch = int.Parse(partSearchBox.Text);
                if (partToSearch < 0)
                {
                    MessageBox.Show("Enter a valid part number:");
                    return;
                }
                else
                {
                    Part partToFind = Inventory.lookupPart(partToSearch);
                    foreach (DataGridViewRow row in partsDataGridView.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        if(part.PartID == partToFind.PartID)
                        {
                            UnselectEverything(partsDataGridView);
                            row.Selected = true;
                            partsDataGridView.CurrentCell = partsDataGridView.Rows[row.Index].Cells[0];
                            partSearchBox.Text = "";
                            partsDataGridView.Update();
                            partsDataGridView.Refresh();
                            return;
                        }
                    }
                    // Part not found
                    MessageBox.Show("Part not found");
                    partSearchBox.Text = "";
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

        private void productSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int productToSearch = int.Parse(productSearchBox.Text);
                if (productToSearch < 0)
                {
                    MessageBox.Show("Enter a valid product number;");
                    return;
                }
                else
                {
                    Product productToFind = Inventory.lookupProduct(productToSearch);
                    foreach (DataGridViewRow row in productsDataGridView.Rows)
                    {
                        Product product = (Product)row.DataBoundItem;
                        if (product.ProductID == productToFind.ProductID)
                        {
                            UnselectEverything(productsDataGridView);
                            row.Selected = true;
                            productsDataGridView.CurrentCell = productsDataGridView.Rows[row.Index].Cells[0];
                            productSearchBox.Text = "";
                            return;
                        }
                    }
                    // If product not found
                    MessageBox.Show("Product not found");
                    productSearchBox.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Enter a valid product number.\n{ex}");
            }
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            new Add_Part().ShowDialog();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            new Add_Product().ShowDialog();
        }

        private void exitProgramButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            // J. Exception handling requirements:
            // "Confirm “Delete” actions"
            DialogResult result = MessageBox.Show("Are you sure that you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                // J. Exception handling requirements:
                // "Prevent the user from deleting a product that has a Part associated with it"
                Product product = (Product)productsDataGridView.CurrentRow.DataBoundItem;
                if (product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Remove all parts from product before attempting to delete");
                    return;
                }
                foreach(DataGridViewRow row in productsDataGridView.SelectedRows)
                {
                    productsDataGridView.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            // J. Exception handling requirements:
            // "Confirm “Delete” actions"
            DialogResult result = MessageBox.Show("Are you sure that you want to delete this part?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in partsDataGridView.SelectedRows)
                {
                    partsDataGridView.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void modifyPartButton_Click(object sender, EventArgs e)
        {

            if (partsDataGridView.CurrentRow.DataBoundItem.GetType() == typeof(Inhouse))
            {
                Inhouse inhouse = (Inhouse)partsDataGridView.CurrentRow.DataBoundItem;
                new Modify_Part(inhouse).ShowDialog();

            }
            else
            {
                Outsourced outsourced = (Outsourced)partsDataGridView.CurrentRow.DataBoundItem;
                new Modify_Part(outsourced).ShowDialog();
            }
            partsDataGridView.Update();
            partsDataGridView.Refresh();
        }

        private void modifyProductButton_Click(object sender, EventArgs e)
        {
            Product product = (Product)productsDataGridView.CurrentRow.DataBoundItem;
            new Modify_Product(product).ShowDialog();
            productsDataGridView.Update();
            productsDataGridView.Refresh();
        }
        private int generateUniqueID()
        {
            Random random1 = new Random();
            Random random2 = new Random();
            string tempString = random1.Next(100, 333).ToString() + random2.Next(334, 666).ToString() + Inventory.AllParts.Count.ToString();
            return int.Parse(tempString);

        }
    }
}
