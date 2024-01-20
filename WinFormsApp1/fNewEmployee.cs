using QLBH.Models;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace QLBH
{
    public partial class fNewEmployee : Form
    {
        Employee employee;
        long EmployeeID;
        public fNewEmployee()
        {
            InitializeComponent();
        }
        private void fNewEmployee_Load(object sender, EventArgs e)
        {
            EFDbContext db = new EFDbContext();
            
            
            cbRoleID.DisplayMember = "Name";
            cbRoleID.ValueMember = "RoleID";
            cbRoleID.DataSource = db.Roles.ToList();
            
            cbRoleID.DataSource = db.Roles.Select(c => new
            {
                c.RoleID,
                c.Name
            }).ToList();
            
        }
        private void fNewEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên nhân viên?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ nhân viên?", txtAddress, 0, 0, 1000);
                txtAddress.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                toolTip1.Show("Hãy nhập điện thoại?", txtPhone, 0, 0, 1000);
                txtPhone.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                toolTip1.Show("Hãy nhập mật khẩu?", txtPassword, 0, 0, 1000);
                txtPassword.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbRoleID.Text))
            {
                toolTip1.Show("Hãy nhập phân quyền?", cbRoleID, 0, 0, 1000);
                cbRoleID.Focus();
                return;
            }
            try
            {
                employee = new Employee();
                employee.Name = txtName.Text;
                employee.Address = txtAddress.Text;
                employee.Phone = txtPhone.Text;
                employee.Email = txtEmail.Text;
                employee.Password = txtPassword.Text;
                employee.BirthDay = dateTimePicker1.Value.Date;
                employee.Gender = ckGender.CheckState == CheckState.Indeterminate ? (bool?)null : ckGender.Checked;
                employee.Status = ckStatus.Checked;
                employee.RoleID = Convert.ToInt64(cbRoleID.SelectedValue);
                using (var db = new EFDbContext())
                {
                    db.Employees.Add(employee); //Thêm nhân viên vào csdl
                    db.SaveChanges(); //Lưu các thay đổi vào csdl
                }
                //Xóa trống và thiết lập lại các điều khiển
                txtName.Text = null;
                txtAddress.Text = null;
                txtPhone.Text = null;
                txtEmail.Text = null;
                txtPassword.Text = null;
                cbRoleID.Text = null;

                //dateTimePicker1.Text = null;//Không tác dụng
                ckGender.CheckState = CheckState.Indeterminate;
                ckStatus.Checked = true;
                toolTip1.Show("Lưu thành công!", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0,
               1000);
            }
            txtName.Focus();
        }



        private void cbRoleID_Validating(object sender, CancelEventArgs e)
        {
            if (cbRoleID.FindStringExact(cbRoleID.Text) < 0)
            {
                toolTip1.Show("Nhập sai phân quyền!", cbRoleID, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên nhân viên?", txtName, 0, 0,
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

        private void txtAddress_Validating(object sender, CancelEventArgs e)
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

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(txtPhone.Text, @"\d{10}") && txtPhone.Text.Length == 10)
                return;
            //if (Regex.IsMatch(txtPhone.Text, @"\d{11}") && txtPhone.Text.Length == 11)
            // return;
            toolTip1.Show("Không đúng dạng số điện thoại?", txtPhone, 0, 0, 1000);
            e.Cancel = true;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                return;
            if (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                toolTip1.Show("Không đúng dạng địa chỉ email?", txtEmail, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtEmail.Text.Length > 100)
            {
                toolTip1.Show("Địa chỉ email <= 100 ký tự?", txtEmail, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker1.Value.Date > DateTime.Now.Date)
            {
                toolTip1.Show("Ngày/tháng/năm <= hiện tại?", dateTimePicker1, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Length > 15)
            {
                toolTip1.Show("Phải nhập mật khẩu dưới 15 ký tự!", txtPassword, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        
    }
}
