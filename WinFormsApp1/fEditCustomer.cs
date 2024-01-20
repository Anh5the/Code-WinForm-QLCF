using QLBH.Models;
using System.Text.RegularExpressions;

namespace QLBH
{
    public partial class fEditCustomer : Form
    {
        Customer customer;
        long CustomerID;
        EFDbContext db = new EFDbContext();
        public fEditCustomer(long CustomerID)
        {
            InitializeComponent();
            this.CustomerID = CustomerID;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên khách hàng?", txtName, 0, 0,
               1000);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ khách hàng?", txtAddress,
               0, 0, 1000);
                txtAddress.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                toolTip1.Show("Hãy nhập điện thoại?", txtPhone, 0, 0,
               1000);
                txtPhone.Focus();
                return;
            }
            try
            {
                customer.Name = txtName.Text;
                customer.Address = txtAddress.Text;
                customer.Phone = txtPhone.Text;
                customer.Email = txtEmail.Text;
                customer.BirthDay = dateTimePicker1.Value.Date;
                customer.Gender = ckGender.CheckState == CheckState.Indeterminate ? (bool?)null : ckGender.Checked;
                customer.Status = ckStatus.Checked;
                db.SaveChanges(); //Lưu các thay đổi vào csdl
                toolTip1.Show("Lưu thành công!", btSave, 0, 0, 1000);
                btClose.Focus();
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message,
               btSave, 0, 0, 1000);
            }
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên khách hàng?", txtName, 0, 0,
               1000);
                e.Cancel = true;
            }
            else if (txtName.Text.Length > 100)
            {
                toolTip1.Show("Tên khách hàng <= 100 ký tự?", txtName, 0,
               0, 1000);
                e.Cancel = true;
            }
        }

        private void txtAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ?", txtAddress, 0, 0,
               1000);
                e.Cancel = true;
            }
            else if (txtAddress.Text.Length > 250)
            {
                toolTip1.Show("Địa chỉ <= 250 ký tự?", txtAddress, 0, 0,
               1000);
                e.Cancel = true;
            }
        }

        private void txtPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Regex.IsMatch(txtPhone.Text, @"\d{10}") && txtPhone.Text.Length == 10)
                return;
            //if (Regex.IsMatch(txtPhone.Text, @"\d{11}") && txtPhone.Text.Length == 11)
            // return;
            toolTip1.Show("Không đúng dạng số điện thoại?", txtPhone, 0, 0, 1000);
            e.Cancel = true;

        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                return;
            if (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                toolTip1.Show("Không đúng dạng địa chỉ email?", txtEmail,
               0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtEmail.Text.Length > 100)
            {
                toolTip1.Show("Địa chỉ email <= 100 ký tự?", txtEmail, 0,
               0, 1000);
                e.Cancel = true;
            }
        }
        private void dateTimePicker1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dateTimePicker1.Value.Date > DateTime.Now.Date)
            {
                toolTip1.Show("Ngày/tháng/năm <= hiện tại?", dateTimePicker1, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void fEditCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;

        }

        private void fEditCustomer_Load(object sender, EventArgs e)
        {
            customer = db.Customers.Single(p => p.CustomerID == CustomerID);
            Text += " - Mã KH " + customer.CustomerID.ToString();
            txtName.Text = customer.Name;
            txtAddress.Text = customer.Address;
            txtPhone.Text = customer.Phone;
            txtEmail.Text = customer.Email;
            dateTimePicker1.Text = customer.BirthDay.ToString();
            ckGender.CheckState = customer.Gender == null ? CheckState.Indeterminate : (customer.Gender == true ? CheckState.Checked : CheckState.Unchecked);
            ckStatus.Checked = customer.Status;
        }
    }
}