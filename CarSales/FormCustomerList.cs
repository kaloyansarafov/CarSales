using CarSales.Data;
using CarSales.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CarSales
{
    public partial class FormCustomerList : Form
    {
        private readonly ICustomerService _customerService;
        private readonly IServiceProvider _serviceProvider;
        private readonly ICarSaleService _carSaleService;

        public FormCustomerList(ICustomerService customerService, IServiceProvider serviceProvider, ICarSaleService carSaleService)
        {
            _customerService = customerService;
            _serviceProvider = serviceProvider;
            _carSaleService = carSaleService;
            InitializeComponent();
            LoadCustomersAsync();
        }
        
        private void dataGridViewCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var selectedCustomer = (Customer)dataGridViewCustomers.Rows[e.RowIndex].DataBoundItem;

            var formCustomerDetails = _serviceProvider.GetRequiredService<FormCustomerDetails>();
            formCustomerDetails.SetCustomer(selectedCustomer);
            formCustomerDetails.ShowDialog();
        }

        private async void LoadCustomersAsync()
        {
            var customers = await _customerService.GetAllCustomersAsync();
            dataGridViewCustomers.DataSource = customers;

            dataGridViewCustomers.Columns["Id"]!.Visible = false;
            dataGridViewCustomers.Columns["CarSales"]!.Visible = false;

            dataGridViewCustomers.ReadOnly = true;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var formAddCustomer = _serviceProvider.GetRequiredService<FormAddCustomer>();
            formAddCustomer.ShowDialog();
            LoadCustomersAsync();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a customer to edit.", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            
            var selectedCustomer = (Customer) dataGridViewCustomers.SelectedRows[0].DataBoundItem!;
            var formAddCustomer = _serviceProvider.GetRequiredService<FormAddCustomer>();
            formAddCustomer.SetCustomerData(selectedCustomer);
            formAddCustomer.ShowDialog();
            LoadCustomersAsync();
            
        }

        private async void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a customer to delete.", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            
            var selectedCustomer = (Customer) dataGridViewCustomers.SelectedRows[0].DataBoundItem!;

            if (selectedCustomer.CarSales.Count > 0)
            {
                var result = MessageBox.Show(
                    "This user has made purchases. Deleting them will also remove the purchases from the records. Are you sure you want to delete this customer?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    foreach (var sale in selectedCustomer.CarSales)
                    {
                        await _carSaleService.DeleteSaleAsync(sale.Id);
                    }

                    await _customerService.DeleteCustomerAsync(selectedCustomer.Id);
                    MessageBox.Show("Customer deleted successfully", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                var result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    await _customerService.DeleteCustomerAsync(selectedCustomer.Id);
                    MessageBox.Show("Customer deleted successfully", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            LoadCustomersAsync();
            
        }
    }
}