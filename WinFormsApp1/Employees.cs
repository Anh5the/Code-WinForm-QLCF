using Microsoft.EntityFrameworkCore;
using QLBH.Models;
using System.Data;
using System.Windows.Forms;

namespace QLBH
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                db.Employees.Load();
                dataGridView1.DataSource = db.Employees.Local.ToList();
            }
        }



        private void btNew_Click(object sender, EventArgs e)
        {

            fNewEmployee f = new fNewEmployee();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            bool check = true;
            using (var db = new EFDbContext())
            {

                dataGridView1.DataSource = db.Employees.Where(c => c.Name.Contains(txtName.Text)).ToList();
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Hãy nhập tên nhân viên! ");
                    txtName.Focus();
                    return;
                }
                
                

            }
             
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long EmployeeID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["EmployeeID"].Value);
                    using (var db = new EFDbContext())
                    {
                        Employee employee = db.Employees.Single(c => c.EmployeeID == EmployeeID);
                        if (MessageBox.Show("Bạn muốn xóa nhân viên này? " + employee.Name, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                        {
                            db.Employees.Remove(employee);
                            db.SaveChanges();
                            Employees_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("fEditE"))
                    return;
                fEditEmployee f = new fEditEmployee(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["EmployeeID"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        
    }
}
