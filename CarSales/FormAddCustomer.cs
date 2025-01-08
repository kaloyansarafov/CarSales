using CarSales.Data;
using CarSales.Services;

namespace CarSales
{
    public partial class FormAddCustomer : Form
    {
        private readonly ICustomerService _customerService;
        private int? _customerId = null;

        public FormAddCustomer(ICustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
        }
        
        public void SetCustomerData(Customer customer)
        {
            txtName.Text = customer.Name;
            txtPhone.Text = customer.Phone;
            txtAddress.Text = customer.Address;
            txtZipCode.Text = customer.ZipCode;
            txtCity.Text = customer.City;
            txtEmail.Text = customer.Email;
            _customerId = customer.Id;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Id = _customerId,
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text,
                ZipCode = txtZipCode.Text,
                City = txtCity.Text,
                Email = txtEmail.Text
            };

            if (_customerId.HasValue)
            {
                await _customerService.UpdateCustomerAsync(customer);
                MessageBox.Show("Customer updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                await _customerService.AddCustomerAsync(customer);
                MessageBox.Show("Customer added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtZipCode.Text = "";
            txtCity.Text = "";
            txtEmail.Text = "";
            _customerId = null;
            
            this.Close();
        }
    }
}