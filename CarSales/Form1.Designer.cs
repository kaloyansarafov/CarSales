namespace CarSales;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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

    private System.Windows.Forms.DataGridView dataGridViewCars;
private System.Windows.Forms.Button btnImportCars;
private System.Windows.Forms.TextBox txtBrand;
private System.Windows.Forms.TextBox txtModel;
private System.Windows.Forms.TextBox txtPrice;
private System.Windows.Forms.Button btnSearch;
private System.Windows.Forms.Button btnAddCustomer;

/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent()
{
    dataGridViewCars = new System.Windows.Forms.DataGridView();
    btnImportCars = new System.Windows.Forms.Button();
    txtBrand = new System.Windows.Forms.TextBox();
    txtModel = new System.Windows.Forms.TextBox();
    txtPrice = new System.Windows.Forms.TextBox();
    btnSearch = new System.Windows.Forms.Button();
    btnAddCustomer = new System.Windows.Forms.Button();
    btnSales = new System.Windows.Forms.Button();
    ((System.ComponentModel.ISupportInitialize) dataGridViewCars).BeginInit();
    SuspendLayout();
    // 
    // dataGridViewCars
    // 
    dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    dataGridViewCars.Location = new System.Drawing.Point(20, 23);
    dataGridViewCars.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
    dataGridViewCars.Name = "dataGridViewCars";
    dataGridViewCars.RowHeadersWidth = 62;
    dataGridViewCars.Size = new System.Drawing.Size(843, 762);
    dataGridViewCars.TabIndex = 0;
    dataGridViewCars.CellDoubleClick += dataGridViewCars_CellDoubleClick;
    // 
    // btnImportCars
    // 
    btnImportCars.Location = new System.Drawing.Point(20, 796);
    btnImportCars.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
    btnImportCars.Name = "btnImportCars";
    btnImportCars.Size = new System.Drawing.Size(125, 44);
    btnImportCars.TabIndex = 1;
    btnImportCars.Text = "Import Cars";
    btnImportCars.UseVisualStyleBackColor = true;
    btnImportCars.Click += btnImportCars_Click;
    // 
    // txtBrand
    // 
    txtBrand.Location = new System.Drawing.Point(167, 800);
    txtBrand.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
    txtBrand.Name = "txtBrand";
    txtBrand.PlaceholderText = "Brand";
    txtBrand.Size = new System.Drawing.Size(164, 31);
    txtBrand.TabIndex = 2;
    // 
    // txtModel
    // 
    txtModel.Location = new System.Drawing.Point(350, 800);
    txtModel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
    txtModel.Name = "txtModel";
    txtModel.PlaceholderText = "Model";
    txtModel.Size = new System.Drawing.Size(164, 31);
    txtModel.TabIndex = 3;
    // 
    // txtPrice
    // 
    txtPrice.Location = new System.Drawing.Point(533, 800);
    txtPrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
    txtPrice.Name = "txtPrice";
    txtPrice.PlaceholderText = "Price";
    txtPrice.Size = new System.Drawing.Size(164, 31);
    txtPrice.TabIndex = 4;
    // 
    // btnSearch
    // 
    btnSearch.Location = new System.Drawing.Point(717, 796);
    btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
    btnSearch.Name = "btnSearch";
    btnSearch.Size = new System.Drawing.Size(125, 44);
    btnSearch.TabIndex = 5;
    btnSearch.Text = "Search";
    btnSearch.UseVisualStyleBackColor = true;
    btnSearch.Click += btnSearch_Click;
    // 
    // btnAddCustomer
    // 
    btnAddCustomer.Location = new System.Drawing.Point(873, 23);
    btnAddCustomer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
    btnAddCustomer.Name = "btnAddCustomer";
    btnAddCustomer.Size = new System.Drawing.Size(167, 44);
    btnAddCustomer.TabIndex = 6;
    btnAddCustomer.Text = "Customers";
    btnAddCustomer.UseVisualStyleBackColor = true;
    btnAddCustomer.Click += btnAddCustomer_Click;
    // 
    // btnSales
    // 
    btnSales.Location = new System.Drawing.Point(1073, 23);
    btnSales.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
    btnSales.Name = "btnSales";
    btnSales.Size = new System.Drawing.Size(167, 44);
    btnSales.TabIndex = 7;
    btnSales.Text = "Sales";
    btnSales.UseVisualStyleBackColor = true;
    btnSales.Click += btnSales_Click;
    // 
    // Form1
    // 
    AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
    AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    ClientSize = new System.Drawing.Size(1333, 865);
    Controls.Add(btnSales);
    Controls.Add(btnSearch);
    Controls.Add(txtPrice);
    Controls.Add(txtModel);
    Controls.Add(txtBrand);
    Controls.Add(btnImportCars);
    Controls.Add(dataGridViewCars);
    Controls.Add(btnAddCustomer);
    Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
    Text = "Car Sales";
    ((System.ComponentModel.ISupportInitialize) dataGridViewCars).EndInit();
    ResumeLayout(false);
    PerformLayout();
}

private System.Windows.Forms.Button btnSales;

#endregion
}