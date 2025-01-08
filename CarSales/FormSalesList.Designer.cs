using System.ComponentModel;

namespace CarSales;

partial class FormSalesList
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
    private DataGridView dataGridViewSales;
    private Button btnExportSales;

    private void InitializeComponent()
    {
        this.dataGridViewSales = new DataGridView();
        this.btnExportSales = new Button();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
        this.SuspendLayout();

        // dataGridViewSales
        this.dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridViewSales.Location = new Point(12, 12);
        this.dataGridViewSales.Name = "dataGridViewSales";
        this.dataGridViewSales.Size = new Size(760, 400);
        this.dataGridViewSales.TabIndex = 0;

        // btnExportSales
        this.btnExportSales.Location = new Point(12, 420);
        this.btnExportSales.Name = "btnExportSales";
        this.btnExportSales.Size = new Size(120, 23);
        this.btnExportSales.TabIndex = 1;
        this.btnExportSales.Text = "Export Sales";
        this.btnExportSales.UseVisualStyleBackColor = true;
        this.btnExportSales.Click += new EventHandler(this.btnExportSales_Click);

        // FormSalesList
        this.AutoScaleDimensions = new SizeF(6F, 13F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(784, 461);
        this.Controls.Add(this.btnExportSales);
        this.Controls.Add(this.dataGridViewSales);
        this.Name = "FormSalesList";
        this.Text = "Sales List";
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
        this.ResumeLayout(false);
    }

    #endregion
}