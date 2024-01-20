using QLBH;

namespace WinFormsApp1
{

    public partial class fMain : Form
    {


        public fMain()
        {

            InitializeComponent();
        }

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageCustomer"))
                return;
            fManageCustomer f = new fManageCustomer();
            f.MdiParent = this;
            f.Show();
        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageProduct"))
                return;
            fManageProduct f = new fManageProduct();
            f.MdiParent = this;
            f.Show();
        }

        private void manageOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageOrder"))
                return;
            fManageOrder f = new fManageOrder();
            f.MdiParent = this;
            f.Show();
        }

        private void processOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fProcessOD"))
                return;
            fProcessOrderDetails f = new fProcessOrderDetails();
            f.MdiParent = this;
            f.Show();
        }

        private void productByCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fReportCategoryProductGroupByCategory"))
                return;
            fReportCategoryProductGroupByCategory f = new fReportCategoryProductGroupByCategory();
            f.MdiParent = this;
            f.Show();
        }

        private void fManageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("Employees"))
                return;
            Employees f = new Employees();
            f.MdiParent = this;
            f.Show();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

            fLogin f = new fLogin();

            if (Utility.employee.RoleID != 1)
                foreach (ToolStripMenuItem t in menuStrip1.Items)
                    foreach (ToolStripItem c in t.DropDownItems)
                        if (t != reportToolStripMenuItem)
                        {
                            if (c.Name.Contains("new") && Utility.employee.RoleID == 2)
                                break;
                            c.Enabled = false; //hoặc c.Visible = false;
                        }
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}