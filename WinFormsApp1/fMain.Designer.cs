namespace WinFormsApp1
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            manageCategoryToolStripMenuItem = new ToolStripMenuItem();
            newCategoryToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            manageProductToolStripMenuItem = new ToolStripMenuItem();
            newProductToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            manageCustomerToolStripMenuItem = new ToolStripMenuItem();
            newCustomerToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            manageOrderToolStripMenuItem = new ToolStripMenuItem();
            newOrderToolStripMenuItem = new ToolStripMenuItem();
            processOrderDetailsToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            fManageEmployeeToolStripMenuItem = new ToolStripMenuItem();
            newEmployeeToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            productByCategoryToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { categoryToolStripMenuItem, productToolStripMenuItem, customerToolStripMenuItem, orderToolStripMenuItem, employeeToolStripMenuItem, reportToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(921, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageCategoryToolStripMenuItem, newCategoryToolStripMenuItem });
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(87, 24);
            categoryToolStripMenuItem.Text = "Category ";
            // 
            // manageCategoryToolStripMenuItem
            // 
            manageCategoryToolStripMenuItem.Name = "manageCategoryToolStripMenuItem";
            manageCategoryToolStripMenuItem.Size = new Size(206, 26);
            manageCategoryToolStripMenuItem.Text = "ManageCategory";
            // 
            // newCategoryToolStripMenuItem
            // 
            newCategoryToolStripMenuItem.Name = "newCategoryToolStripMenuItem";
            newCategoryToolStripMenuItem.Size = new Size(206, 26);
            newCategoryToolStripMenuItem.Text = "NewCategory";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageProductToolStripMenuItem, newProductToolStripMenuItem });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(74, 24);
            productToolStripMenuItem.Text = "Product";
            // 
            // manageProductToolStripMenuItem
            // 
            manageProductToolStripMenuItem.Name = "manageProductToolStripMenuItem";
            manageProductToolStripMenuItem.Size = new Size(197, 26);
            manageProductToolStripMenuItem.Text = "ManageProduct";
            manageProductToolStripMenuItem.Click += manageProductToolStripMenuItem_Click;
            // 
            // newProductToolStripMenuItem
            // 
            newProductToolStripMenuItem.Name = "newProductToolStripMenuItem";
            newProductToolStripMenuItem.Size = new Size(197, 26);
            newProductToolStripMenuItem.Text = "NewProduct";
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageCustomerToolStripMenuItem, newCustomerToolStripMenuItem });
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(86, 24);
            customerToolStripMenuItem.Text = "Customer";
            // 
            // manageCustomerToolStripMenuItem
            // 
            manageCustomerToolStripMenuItem.Name = "manageCustomerToolStripMenuItem";
            manageCustomerToolStripMenuItem.Size = new Size(209, 26);
            manageCustomerToolStripMenuItem.Text = "ManageCustomer";
            manageCustomerToolStripMenuItem.Click += manageCustomerToolStripMenuItem_Click;
            // 
            // newCustomerToolStripMenuItem
            // 
            newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            newCustomerToolStripMenuItem.Size = new Size(209, 26);
            newCustomerToolStripMenuItem.Text = "NewCustomer";
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageOrderToolStripMenuItem, newOrderToolStripMenuItem, processOrderDetailsToolStripMenuItem });
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(61, 24);
            orderToolStripMenuItem.Text = "Order";
            // 
            // manageOrderToolStripMenuItem
            // 
            manageOrderToolStripMenuItem.Name = "manageOrderToolStripMenuItem";
            manageOrderToolStripMenuItem.Size = new Size(225, 26);
            manageOrderToolStripMenuItem.Text = "ManageOrder";
            manageOrderToolStripMenuItem.Click += manageOrderToolStripMenuItem_Click;
            // 
            // newOrderToolStripMenuItem
            // 
            newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            newOrderToolStripMenuItem.Size = new Size(225, 26);
            newOrderToolStripMenuItem.Text = "NewOrder";
            // 
            // processOrderDetailsToolStripMenuItem
            // 
            processOrderDetailsToolStripMenuItem.Name = "processOrderDetailsToolStripMenuItem";
            processOrderDetailsToolStripMenuItem.Size = new Size(225, 26);
            processOrderDetailsToolStripMenuItem.Text = "ProcessOrderDetails";
            processOrderDetailsToolStripMenuItem.Click += processOrderDetailsToolStripMenuItem_Click;
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fManageEmployeeToolStripMenuItem, newEmployeeToolStripMenuItem });
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(89, 24);
            employeeToolStripMenuItem.Text = "Employee";
            // 
            // fManageEmployeeToolStripMenuItem
            // 
            fManageEmployeeToolStripMenuItem.Name = "fManageEmployeeToolStripMenuItem";
            fManageEmployeeToolStripMenuItem.Size = new Size(212, 26);
            fManageEmployeeToolStripMenuItem.Text = "ManageEmployee";
            fManageEmployeeToolStripMenuItem.Click += fManageEmployeeToolStripMenuItem_Click;
            // 
            // newEmployeeToolStripMenuItem
            // 
            newEmployeeToolStripMenuItem.Name = "newEmployeeToolStripMenuItem";
            newEmployeeToolStripMenuItem.Size = new Size(212, 26);
            newEmployeeToolStripMenuItem.Text = "NewEmployee";
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productByCategoryToolStripMenuItem });
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(68, 24);
            reportToolStripMenuItem.Text = "Report";
            // 
            // productByCategoryToolStripMenuItem
            // 
            productByCategoryToolStripMenuItem.Name = "productByCategoryToolStripMenuItem";
            productByCategoryToolStripMenuItem.Size = new Size(220, 26);
            productByCategoryToolStripMenuItem.Text = "productByCategory";
            productByCategoryToolStripMenuItem.Click += productByCategoryToolStripMenuItem_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(921, 360);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "fMain";
            Text = "Quản lí bán hàng";
            WindowState = FormWindowState.Maximized;
            FormClosing += fMain_FormClosing;
            Load += fMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem manageCategoryToolStripMenuItem;
        private ToolStripMenuItem newCategoryToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem manageProductToolStripMenuItem;
        private ToolStripMenuItem newProductToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem manageCustomerToolStripMenuItem;
        private ToolStripMenuItem newCustomerToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem manageOrderToolStripMenuItem;
        private ToolStripMenuItem newOrderToolStripMenuItem;
        private ToolStripMenuItem processOrderDetailsToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem productByCategoryToolStripMenuItem;
        private ToolStripMenuItem fManageEmployeeToolStripMenuItem;
        private ToolStripMenuItem newEmployeeToolStripMenuItem;
    }
}