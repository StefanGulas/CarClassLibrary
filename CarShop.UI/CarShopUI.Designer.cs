namespace CarShop.UI
{
    partial class CarShopUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateCarButton = new System.Windows.Forms.Button();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MakeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CarsInInventoryListBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CarsInCartListBox = new System.Windows.Forms.ListBox();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateCarButton);
            this.groupBox1.Controls.Add(this.PriceBox);
            this.groupBox1.Controls.Add(this.ModelBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MakeBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a Car";
            // 
            // CreateCarButton
            // 
            this.CreateCarButton.Location = new System.Drawing.Point(47, 96);
            this.CreateCarButton.Name = "CreateCarButton";
            this.CreateCarButton.Size = new System.Drawing.Size(75, 23);
            this.CreateCarButton.TabIndex = 4;
            this.CreateCarButton.Text = "Create Car";
            this.CreateCarButton.UseVisualStyleBackColor = true;
            this.CreateCarButton.Click += new System.EventHandler(this.CreateCarButton_Click);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(47, 69);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(151, 20);
            this.PriceBox.TabIndex = 3;
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(47, 43);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(151, 20);
            this.ModelBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price";
            // 
            // MakeBox
            // 
            this.MakeBox.Location = new System.Drawing.Point(47, 17);
            this.MakeBox.Name = "MakeBox";
            this.MakeBox.Size = new System.Drawing.Size(151, 20);
            this.MakeBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CarsInInventoryListBox);
            this.groupBox2.Location = new System.Drawing.Point(223, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 282);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Inventory";
            // 
            // CarsInInventoryListBox
            // 
            this.CarsInInventoryListBox.FormattingEnabled = true;
            this.CarsInInventoryListBox.Location = new System.Drawing.Point(7, 20);
            this.CarsInInventoryListBox.Name = "CarsInInventoryListBox";
            this.CarsInInventoryListBox.Size = new System.Drawing.Size(187, 238);
            this.CarsInInventoryListBox.TabIndex = 0;
            this.CarsInInventoryListBox.SelectedIndexChanged += new System.EventHandler(this.CarsInInventoryListBox_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CarsInCartListBox);
            this.groupBox4.Location = new System.Drawing.Point(560, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 282);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Shopping Cart";
            // 
            // CarsInCartListBox
            // 
            this.CarsInCartListBox.FormattingEnabled = true;
            this.CarsInCartListBox.Location = new System.Drawing.Point(7, 20);
            this.CarsInCartListBox.Name = "CarsInCartListBox";
            this.CarsInCartListBox.Size = new System.Drawing.Size(187, 238);
            this.CarsInCartListBox.TabIndex = 0;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Location = new System.Drawing.Point(429, 125);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(125, 23);
            this.AddToCartButton.TabIndex = 2;
            this.AddToCartButton.Text = "Add to Cart  -->";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.Location = new System.Drawing.Point(567, 302);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(75, 23);
            this.CheckoutButton.TabIndex = 4;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(567, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Price";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(705, 364);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(49, 17);
            this.TotalPrice.TabIndex = 5;
            this.TotalPrice.Text = "0.00$";
            // 
            // CarShopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CarShopUI";
            this.Text = "CarShop";
            this.Load += new System.EventHandler(this.CarShopUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MakeBox;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CreateCarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox CarsInInventoryListBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox CarsInCartListBox;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalPrice;
    }
}

