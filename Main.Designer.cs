namespace C968_Richard_Menz
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.mainPartsLabel = new System.Windows.Forms.Label();
            this.mainProductsLabel = new System.Windows.Forms.Label();
            this.mainTopLabel = new System.Windows.Forms.Label();
            this.partSearchButton = new System.Windows.Forms.Button();
            this.partSearchBox = new System.Windows.Forms.TextBox();
            this.productSearchButton = new System.Windows.Forms.Button();
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.addPartButton = new System.Windows.Forms.Button();
            this.modifyPartButton = new System.Windows.Forms.Button();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.exitProgramButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.Location = new System.Drawing.Point(20, 126);
            this.partsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.RowHeadersWidth = 72;
            this.partsDataGridView.RowTemplate.Height = 31;
            this.partsDataGridView.Size = new System.Drawing.Size(557, 264);
            this.partsDataGridView.TabIndex = 0;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(638, 126);
            this.productsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 72;
            this.productsDataGridView.RowTemplate.Height = 31;
            this.productsDataGridView.Size = new System.Drawing.Size(557, 264);
            this.productsDataGridView.TabIndex = 1;
            // 
            // mainPartsLabel
            // 
            this.mainPartsLabel.AutoSize = true;
            this.mainPartsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPartsLabel.Location = new System.Drawing.Point(17, 101);
            this.mainPartsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainPartsLabel.Name = "mainPartsLabel";
            this.mainPartsLabel.Size = new System.Drawing.Size(49, 19);
            this.mainPartsLabel.TabIndex = 2;
            this.mainPartsLabel.Text = "Parts";
            // 
            // mainProductsLabel
            // 
            this.mainProductsLabel.AutoSize = true;
            this.mainProductsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainProductsLabel.Location = new System.Drawing.Point(638, 101);
            this.mainProductsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainProductsLabel.Name = "mainProductsLabel";
            this.mainProductsLabel.Size = new System.Drawing.Size(79, 19);
            this.mainProductsLabel.TabIndex = 3;
            this.mainProductsLabel.Text = "Products";
            // 
            // mainTopLabel
            // 
            this.mainTopLabel.AutoSize = true;
            this.mainTopLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTopLabel.Location = new System.Drawing.Point(20, 18);
            this.mainTopLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainTopLabel.Name = "mainTopLabel";
            this.mainTopLabel.Size = new System.Drawing.Size(244, 19);
            this.mainTopLabel.TabIndex = 4;
            this.mainTopLabel.Text = "Inventory Management System";
            // 
            // partSearchButton
            // 
            this.partSearchButton.Location = new System.Drawing.Point(275, 85);
            this.partSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.partSearchButton.Name = "partSearchButton";
            this.partSearchButton.Size = new System.Drawing.Size(75, 25);
            this.partSearchButton.TabIndex = 5;
            this.partSearchButton.Text = "Search";
            this.partSearchButton.UseVisualStyleBackColor = true;
            this.partSearchButton.Click += new System.EventHandler(this.partSearchButton_Click);
            // 
            // partSearchBox
            // 
            this.partSearchBox.Location = new System.Drawing.Point(375, 88);
            this.partSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.partSearchBox.Name = "partSearchBox";
            this.partSearchBox.Size = new System.Drawing.Size(202, 20);
            this.partSearchBox.TabIndex = 6;
            // 
            // productSearchButton
            // 
            this.productSearchButton.Location = new System.Drawing.Point(891, 85);
            this.productSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.productSearchButton.Name = "productSearchButton";
            this.productSearchButton.Size = new System.Drawing.Size(75, 25);
            this.productSearchButton.TabIndex = 7;
            this.productSearchButton.Text = "Search";
            this.productSearchButton.UseVisualStyleBackColor = true;
            this.productSearchButton.Click += new System.EventHandler(this.productSearchButton_Click);
            // 
            // productSearchBox
            // 
            this.productSearchBox.Location = new System.Drawing.Point(986, 85);
            this.productSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(202, 20);
            this.productSearchBox.TabIndex = 8;
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(314, 413);
            this.addPartButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(75, 25);
            this.addPartButton.TabIndex = 9;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // modifyPartButton
            // 
            this.modifyPartButton.Location = new System.Drawing.Point(393, 413);
            this.modifyPartButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyPartButton.Name = "modifyPartButton";
            this.modifyPartButton.Size = new System.Drawing.Size(75, 25);
            this.modifyPartButton.TabIndex = 10;
            this.modifyPartButton.Text = "Modify";
            this.modifyPartButton.UseVisualStyleBackColor = true;
            this.modifyPartButton.Click += new System.EventHandler(this.modifyPartButton_Click);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Location = new System.Drawing.Point(472, 413);
            this.deletePartButton.Margin = new System.Windows.Forms.Padding(2);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(75, 25);
            this.deletePartButton.TabIndex = 11;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.deletePartButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(939, 413);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(75, 25);
            this.addProductButton.TabIndex = 12;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.Location = new System.Drawing.Point(1018, 413);
            this.modifyProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(75, 25);
            this.modifyProductButton.TabIndex = 13;
            this.modifyProductButton.Text = "Modify";
            this.modifyProductButton.UseVisualStyleBackColor = true;
            this.modifyProductButton.Click += new System.EventHandler(this.modifyProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(1097, 413);
            this.deleteProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(75, 25);
            this.deleteProductButton.TabIndex = 14;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // exitProgramButton
            // 
            this.exitProgramButton.Location = new System.Drawing.Point(1097, 518);
            this.exitProgramButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitProgramButton.Name = "exitProgramButton";
            this.exitProgramButton.Size = new System.Drawing.Size(75, 25);
            this.exitProgramButton.TabIndex = 15;
            this.exitProgramButton.Text = "Exit";
            this.exitProgramButton.UseVisualStyleBackColor = true;
            this.exitProgramButton.Click += new System.EventHandler(this.exitProgramButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 590);
            this.Controls.Add(this.exitProgramButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.modifyProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.deletePartButton);
            this.Controls.Add(this.modifyPartButton);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.productSearchBox);
            this.Controls.Add(this.productSearchButton);
            this.Controls.Add(this.partSearchBox);
            this.Controls.Add(this.partSearchButton);
            this.Controls.Add(this.mainTopLabel);
            this.Controls.Add(this.mainProductsLabel);
            this.Controls.Add(this.mainPartsLabel);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.partsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView partsDataGridView;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Label mainPartsLabel;
        private System.Windows.Forms.Label mainProductsLabel;
        private System.Windows.Forms.Label mainTopLabel;
        private System.Windows.Forms.Button partSearchButton;
        private System.Windows.Forms.TextBox partSearchBox;
        private System.Windows.Forms.Button productSearchButton;
        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button modifyPartButton;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button exitProgramButton;
    }
}

