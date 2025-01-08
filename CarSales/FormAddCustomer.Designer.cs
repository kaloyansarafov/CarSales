using System.ComponentModel;

namespace CarSales;

partial class FormAddCustomer
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

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
   private System.Windows.Forms.TextBox txtName;
private System.Windows.Forms.TextBox txtPhone;
private System.Windows.Forms.TextBox txtAddress;
private System.Windows.Forms.TextBox txtZipCode;
private System.Windows.Forms.TextBox txtCity;
private System.Windows.Forms.Button btnSave;
private System.Windows.Forms.TextBox txtEmail;

private void InitializeComponent()
{
    this.txtName = new System.Windows.Forms.TextBox();
    this.txtPhone = new System.Windows.Forms.TextBox();
    this.txtAddress = new System.Windows.Forms.TextBox();
    this.txtZipCode = new System.Windows.Forms.TextBox();
    this.txtCity = new System.Windows.Forms.TextBox();
    this.txtEmail = new System.Windows.Forms.TextBox();
    this.btnSave = new System.Windows.Forms.Button();
    this.SuspendLayout();
    //
    // txtName
    //
    this.txtName.Location = new System.Drawing.Point(12, 12);
    this.txtName.Name = "txtName";
    this.txtName.Size = new System.Drawing.Size(260, 20);
    this.txtName.TabIndex = 0;
    this.txtName.PlaceholderText = "Name";
    //
    // txtPhone
    //
    this.txtPhone.Location = new System.Drawing.Point(12, 38);
    this.txtPhone.Name = "txtPhone";
    this.txtPhone.Size = new System.Drawing.Size(260, 20);
    this.txtPhone.TabIndex = 1;
    this.txtPhone.PlaceholderText = "Phone";
    //
    // txtAddress
    //
    this.txtAddress.Location = new System.Drawing.Point(12, 64);
    this.txtAddress.Name = "txtAddress";
    this.txtAddress.Size = new System.Drawing.Size(260, 20);
    this.txtAddress.TabIndex = 2;
    this.txtAddress.PlaceholderText = "Address";
    //
    // txtZipCode
    //
    this.txtZipCode.Location = new System.Drawing.Point(12, 90);
    this.txtZipCode.Name = "txtZipCode";
    this.txtZipCode.Size = new System.Drawing.Size(260, 20);
    this.txtZipCode.TabIndex = 3;
    this.txtZipCode.PlaceholderText = "Zip Code";
    //
    // txtCity
    //
    this.txtCity.Location = new System.Drawing.Point(12, 116);
    this.txtCity.Name = "txtCity";
    this.txtCity.Size = new System.Drawing.Size(260, 20);
    this.txtCity.TabIndex = 4;
    this.txtCity.PlaceholderText = "City";
    //
    // txtEmail
    //
    this.txtEmail.Location = new System.Drawing.Point(12, 142);
    this.txtEmail.Name = "txtEmail";
    this.txtEmail.Size = new System.Drawing.Size(260, 20);
    this.txtEmail.TabIndex = 5;
    this.txtEmail.PlaceholderText = "Email";
    //
    // btnSave
    //
    this.btnSave.Location = new System.Drawing.Point(197, 168);
    this.btnSave.Name = "btnSave";
    this.btnSave.Size = new System.Drawing.Size(75, 23);
    this.btnSave.TabIndex = 6;
    this.btnSave.Text = "Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
    //
    // FormAddCustomer
    //
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(284, 203);
    this.Controls.Add(this.btnSave);
    this.Controls.Add(this.txtEmail);
    this.Controls.Add(this.txtCity);
    this.Controls.Add(this.txtZipCode);
    this.Controls.Add(this.txtAddress);
    this.Controls.Add(this.txtPhone);
    this.Controls.Add(this.txtName);
    this.Name = "FormAddCustomer";
    this.Text = "Add Customer";
    this.ResumeLayout(false);
    this.PerformLayout();
}

    #endregion
}