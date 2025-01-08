using System.ComponentModel;

namespace CarSales;

partial class FormSellCar
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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

    private System.Windows.Forms.ComboBox comboBoxCars;
    private System.Windows.Forms.TextBox txtSearchCustomer;
    private ListBox listBoxCustomers;
    private Button btnSearchCustomer;
    private System.Windows.Forms.Button btnSellCar;
    private System.Windows.Forms.Button btnAddCustomer;
    private System.Windows.Forms.TextBox txtSalePrice;
    private System.Windows.Forms.Label lblSalePrice;

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        comboBoxCars = new System.Windows.Forms.ComboBox();
        txtSearchCustomer = new System.Windows.Forms.TextBox();
        listBoxCustomers = new System.Windows.Forms.ListBox();
        btnSearchCustomer = new System.Windows.Forms.Button();
        btnSellCar = new System.Windows.Forms.Button();
        btnAddCustomer = new System.Windows.Forms.Button();
        lblSalePrice = new System.Windows.Forms.Label();
        txtSalePrice = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // comboBoxCars
        // 
        comboBoxCars.FormattingEnabled = true;
        comboBoxCars.Location = new System.Drawing.Point(20, 30);
        comboBoxCars.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        comboBoxCars.Name = "comboBoxCars";
        comboBoxCars.Size = new System.Drawing.Size(431, 33);
        comboBoxCars.TabIndex = 0;
        // 
        // txtSearchCustomer
        // 
        txtSearchCustomer.Location = new System.Drawing.Point(20, 121);
        txtSearchCustomer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        txtSearchCustomer.Name = "txtSearchCustomer";
        txtSearchCustomer.Size = new System.Drawing.Size(431, 31);
        txtSearchCustomer.TabIndex = 1;
        // 
        // listBoxCustomers
        // 
        listBoxCustomers.FormattingEnabled = true;
        listBoxCustomers.Location = new System.Drawing.Point(20, 173);
        listBoxCustomers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        listBoxCustomers.Name = "listBoxCustomers";
        listBoxCustomers.Size = new System.Drawing.Size(431, 179);
        listBoxCustomers.TabIndex = 2;
        // 
        // btnSearchCustomer
        // 
        btnSearchCustomer.Location = new System.Drawing.Point(20, 385);
        btnSearchCustomer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        btnSearchCustomer.Name = "btnSearchCustomer";
        btnSearchCustomer.Size = new System.Drawing.Size(200, 44);
        btnSearchCustomer.TabIndex = 3;
        btnSearchCustomer.Text = "Search Customer";
        btnSearchCustomer.UseVisualStyleBackColor = true;
        btnSearchCustomer.Click += btnSearchCustomer_Click;
        // 
        // btnSellCar
        // 
        btnSellCar.Location = new System.Drawing.Point(112, 514);
        btnSellCar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        btnSellCar.Name = "btnSellCar";
        btnSellCar.Size = new System.Drawing.Size(236, 63);
        btnSellCar.TabIndex = 4;
        btnSellCar.Text = "Sell Car";
        btnSellCar.UseVisualStyleBackColor = true;
        btnSellCar.Click += btnSellCar_Click;
        // 
        // btnAddCustomer
        // 
        btnAddCustomer.Location = new System.Drawing.Point(230, 385);
        btnAddCustomer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        btnAddCustomer.Name = "btnAddCustomer";
        btnAddCustomer.Size = new System.Drawing.Size(200, 44);
        btnAddCustomer.TabIndex = 5;
        btnAddCustomer.Text = "Add New Customer";
        btnAddCustomer.UseVisualStyleBackColor = true;
        btnAddCustomer.Click += btnAddCustomer_Click;
        // 
        // lblSalePrice
        // 
        lblSalePrice.Location = new System.Drawing.Point(20, 447);
        lblSalePrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        lblSalePrice.Name = "lblSalePrice";
        lblSalePrice.Size = new System.Drawing.Size(149, 44);
        lblSalePrice.TabIndex = 6;
        lblSalePrice.Text = "Sale Price";
        // 
        // txtSalePrice
        // 
        txtSalePrice.Location = new System.Drawing.Point(179, 447);
        txtSalePrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        txtSalePrice.Name = "txtSalePrice";
        txtSalePrice.Size = new System.Drawing.Size(251, 31);
        txtSalePrice.TabIndex = 7;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(18, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(51, 24);
        label1.TabIndex = 8;
        label1.Text = "Car";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(18, 89);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(312, 32);
        label2.TabIndex = 9;
        label2.Text = "Customer Search by phone or email";
        // 
        // FormSellCar
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(473, 598);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(btnAddCustomer);
        Controls.Add(btnSellCar);
        Controls.Add(btnSearchCustomer);
        Controls.Add(listBoxCustomers);
        Controls.Add(txtSearchCustomer);
        Controls.Add(comboBoxCars);
        Controls.Add(lblSalePrice);
        Controls.Add(txtSalePrice);
        Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        Text = "Sell Car";
        Load += FormSellCar_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    #endregion
}