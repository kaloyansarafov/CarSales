using System.ComponentModel;

namespace CarSales;

partial class FormCustomerDetails
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

    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblPhone;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.DataGridView dataGridViewPurchases;

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblName = new System.Windows.Forms.Label();
        lblPhone = new System.Windows.Forms.Label();
        lblEmail = new System.Windows.Forms.Label();
        dataGridViewPurchases = new System.Windows.Forms.DataGridView();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize) dataGridViewPurchases).BeginInit();
        SuspendLayout();
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Location = new System.Drawing.Point(87, 24);
        lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        lblName.Name = "lblName";
        lblName.Size = new System.Drawing.Size(59, 25);
        lblName.TabIndex = 0;
        lblName.Text = "Name";
        // 
        // lblPhone
        // 
        lblPhone.AutoSize = true;
        lblPhone.Location = new System.Drawing.Point(87, 65);
        lblPhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new System.Drawing.Size(62, 25);
        lblPhone.TabIndex = 1;
        lblPhone.Text = "Phone";
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Location = new System.Drawing.Point(87, 106);
        lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new System.Drawing.Size(54, 25);
        lblEmail.TabIndex = 2;
        lblEmail.Text = "Email";
        // 
        // dataGridViewPurchases
        // 
        dataGridViewPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewPurchases.Location = new System.Drawing.Point(20, 189);
        dataGridViewPurchases.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        dataGridViewPurchases.Name = "dataGridViewPurchases";
        dataGridViewPurchases.RowHeadersWidth = 62;
        dataGridViewPurchases.Size = new System.Drawing.Size(1267, 677);
        dataGridViewPurchases.TabIndex = 3;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(22, 153);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(177, 36);
        label1.TabIndex = 4;
        label1.Text = "Purchases";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(9, 24);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(70, 28);
        label2.TabIndex = 5;
        label2.Text = "Name";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(9, 65);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(70, 28);
        label3.TabIndex = 6;
        label3.Text = "Phone";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(9, 106);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(70, 28);
        label4.TabIndex = 7;
        label4.Text = "Email";
        // 
        // FormCustomerDetails
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1307, 887);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(dataGridViewPurchases);
        Controls.Add(lblEmail);
        Controls.Add(lblPhone);
        Controls.Add(lblName);
        Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        Text = "Customer Details";
        ((System.ComponentModel.ISupportInitialize) dataGridViewPurchases).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    #endregion
}