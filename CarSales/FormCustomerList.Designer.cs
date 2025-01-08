using System.ComponentModel;

namespace CarSales;

partial class FormCustomerList
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

    private System.Windows.Forms.DataGridView dataGridViewCustomers;
private System.Windows.Forms.Button btnAddCustomer;
private System.Windows.Forms.Button btnEditCustomer;
private System.Windows.Forms.Button btnDeleteCustomer;

/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent()
{
    dataGridViewCustomers = new System.Windows.Forms.DataGridView();
    btnAddCustomer = new System.Windows.Forms.Button();
    btnEditCustomer = new System.Windows.Forms.Button();
    btnDeleteCustomer = new System.Windows.Forms.Button();
    ((System.ComponentModel.ISupportInitialize) dataGridViewCustomers).BeginInit();
    SuspendLayout();
    // 
    // dataGridViewCustomers
    // 
    dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    dataGridViewCustomers.Location = new System.Drawing.Point(20, 23);
    dataGridViewCustomers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
    dataGridViewCustomers.Name = "dataGridViewCustomers";
    dataGridViewCustomers.RowHeadersWidth = 62;
    dataGridViewCustomers.Size = new System.Drawing.Size(1293, 762);
    dataGridViewCustomers.TabIndex = 0;
    dataGridViewCustomers.CellDoubleClick += dataGridViewCustomers_CellDoubleClick;
    // 
    // btnAddCustomer
    // 
    btnAddCustomer.Location = new System.Drawing.Point(20, 796);
    btnAddCustomer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
    btnAddCustomer.Name = "btnAddCustomer";
    btnAddCustomer.Size = new System.Drawing.Size(167, 44);
    btnAddCustomer.TabIndex = 1;
    btnAddCustomer.Text = "Add Customer";
    btnAddCustomer.UseVisualStyleBackColor = true;
    btnAddCustomer.Click += btnAddCustomer_Click;
    // 
    // btnEditCustomer
    // 
    btnEditCustomer.Location = new System.Drawing.Point(197, 796);
    btnEditCustomer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
    btnEditCustomer.Name = "btnEditCustomer";
    btnEditCustomer.Size = new System.Drawing.Size(167, 44);
    btnEditCustomer.TabIndex = 2;
    btnEditCustomer.Text = "Edit Customer";
    btnEditCustomer.UseVisualStyleBackColor = true;
    btnEditCustomer.Click += btnEditCustomer_Click;
    // 
    // btnDeleteCustomer
    // 
    btnDeleteCustomer.Location = new System.Drawing.Point(373, 796);
    btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
    btnDeleteCustomer.Name = "btnDeleteCustomer";
    btnDeleteCustomer.Size = new System.Drawing.Size(167, 44);
    btnDeleteCustomer.TabIndex = 3;
    btnDeleteCustomer.Text = "Delete Customer";
    btnDeleteCustomer.UseVisualStyleBackColor = true;
    btnDeleteCustomer.Click += btnDeleteCustomer_Click;
    // 
    // FormCustomerList
    // 
    AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
    AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    ClientSize = new System.Drawing.Size(1333, 865);
    Controls.Add(btnDeleteCustomer);
    Controls.Add(btnEditCustomer);
    Controls.Add(btnAddCustomer);
    Controls.Add(dataGridViewCustomers);
    Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
    Text = "Customer List";
    ((System.ComponentModel.ISupportInitialize) dataGridViewCustomers).EndInit();
    ResumeLayout(false);
}

    #endregion
}