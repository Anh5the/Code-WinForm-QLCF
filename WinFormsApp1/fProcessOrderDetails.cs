using Microsoft.EntityFrameworkCore;
using QLBH.Models;

namespace QLBH
{
    public partial class fProcessOrderDetails : Form
    {
        private EFDbContext db = new EFDbContext();

        private void loadOrderDetails()
        {
            long? OrderID = Convert.ToInt64(cbOrders.SelectedValue);
            var details = db.OrderDetails.Where(d => d.OrderID == OrderID).Select(d => new { d.OrderID, d.ProductID, d.Quantity, d.Price, d.Product.Name, d.OrderDetailID }).ToList();
            List<OrderDetailsAndProduct> list = new List<OrderDetailsAndProduct>();
            foreach (var d in details)
            {
                OrderDetailsAndProduct detail = new OrderDetailsAndProduct();

                detail.OrderDetailID = d.OrderDetailID;
                detail.Name = d.Name;
                detail.ProductID = d.ProductID;
                detail.OrderID = d.OrderID;
                detail.Quantity = d.Quantity;
                detail.Price = d.Price;
                list.Add(detail);
            }
            dataGridView1.DataSource = list;
            cbOrders.Focus();
        }
        public fProcessOrderDetails()
        {

            InitializeComponent();

        }
        private void fProcessOrderDetails_Load(object sender, EventArgs e)
        {
            cbProducts.DisplayMember = "Name";
            cbProducts.ValueMember = "ProductID";
            cbProducts.DataSource = db.Products.Select(p => new
            {
                p.ProductID,
                p.Name
            }).ToList();
            cbProducts.Text = null;
            cbOrders.DataSource = db.Orders.Select(o => o.OrderID).ToList();
            cbOrders.Text = null;
            mQuantity.ValidatingType = typeof(Int32);
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fProcessOrderDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
        private void cbOrders_SelectionChangeCommitted(object sender, EventArgs e)
        {
            long? OrderID = Convert.ToInt64(cbOrders.SelectedValue);
            Order order = db.Orders.Include(o => o.Customer).Single(o => o.OrderID == OrderID);
            Text = "Xử lý chi tiết đơn hàng " + order.OrderID.ToString();
            txtReceiveAddress.Text = order.ReceiveAddress;
            dtOrderDate.Text = order.OrderDate.ToShortDateString();
            dtReceiveDate.Text = order.ReceiveDate.ToString();
            mOrderTime.Text = order.OrderTime.ToString();
            mReceiveTime.Text = order.ReceiveTime.ToString();
            cbProgresses.Text = order.ProgressID.ToString();
            cbCustomers.Text = order.Customer.Name;
            cbProducts.Text = null;
            mQuantity.Text = null;
            loadOrderDetails();

            dataGridView1.Columns["ProductID"].ReadOnly = true;
            dataGridView1.Columns["OrderID"].ReadOnly = true;
            dataGridView1.Columns["Name"].ReadOnly = true;
            
        }
        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            long ProductID = Convert.ToInt32(cbProducts.SelectedValue);
            mPrice.Text = db.Products.Where(p => p.ProductID == ProductID).Select(p => p.Price).SingleOrDefault().ToString();//lỗi với Single
            mQuantity.Focus();
        }
        private void cbProducts_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbProducts.Text))
            {

                toolTip1.Show("Hãy nhập hoặc chọn sản phẩm?", cbProducts, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (cbProducts.FindStringExact(cbProducts.Text) < 0)
            {
                toolTip1.Show("Nhập sai loại sản phẩm?", cbProducts, 0, 0, 1000);
                e.Cancel = true;
            }
            else //Kiểm tra chọn mã số trùng
            {
                long? OrderID = Convert.ToInt64(cbOrders.SelectedValue);
                long ProductID = ProductID = Convert.ToInt64(cbProducts.SelectedValue);
                if (db.OrderDetails.SingleOrDefault(o => o.OrderID == OrderID && o.ProductID == ProductID) != null)//không dùng Single
                {
                    toolTip1.Show("Hãy chọn sản phẩm khác. Đơn hàng đã có sản phẩm này ? ", cbProducts, 0, 0, 1000);


                    e.Cancel = true;
                }
            }
        }
        private void btAddOrderDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbProducts.Text))
            {
                toolTip1.Show("Hãy nhập sản phẩm?", cbProducts, 0, 0, 1000);
                cbProducts.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mQuantity.Text))
            {
                toolTip1.Show("Hãy nhập số lượng?", mQuantity, 0, 0, 1000);
                mQuantity.Focus();
                return;
            }

            try
            {

                long? OrderID = Convert.ToInt64(cbOrders.SelectedValue);
                OrderDetail orderdetail = new OrderDetail();
                orderdetail.OrderID = (long)OrderID;
                orderdetail.ProductID = Convert.ToInt64(cbProducts.SelectedValue);
                orderdetail.Quantity = Convert.ToInt32(mQuantity.Text);
                orderdetail.Price = Convert.ToDecimal(mPrice.Text);
                
                db.OrderDetails.Add(orderdetail);
                db.SaveChanges();
                cbProducts.Text = null;
                mQuantity.Text = null;
                //mPrice.Text = null;
                loadOrderDetails();
                toolTip1.Show("Thêm thành công.", btAddOrderDetail, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Thêm thất bại? Error: " + ex.Message, btAddOrderDetail,
               0, 0, 1000);
            }
        }
        private void mQuantity_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.Show("Dữ liệu sai kiểu số nguyên?", mQuantity, 0, 0, 1000);
                e.Cancel = true;
            }
            else
            if ((Int32)e.ReturnValue < 0)
            {
                toolTip1.Show("Số lượng phải >= 0?", mQuantity, 0, 0, 1000);
                e.Cancel = true;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderDetail orderdetail;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long? OrderID = Convert.ToInt64(cbOrders.SelectedValue);
                    long ProductID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value);
                    orderdetail = db.OrderDetails.Single(o => o.ProductID == ProductID && o.OrderID == OrderID);
                    if (MessageBox.Show("Bạn muốn xóa đơn hàng: " + ProductID + "?", "Xóa",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.OrderDetails.Remove(orderdetail);
                        db.SaveChanges();
                        loadOrderDetails();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            OrderDetail orderdetail;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToDateTime(dtOrderDate.Value.ToShortDateString() + " " + Convert.ToDateTime(mOrderTime.Text).TimeOfDay) > Convert.ToDateTime(dtReceiveDate.Value.ToShortDateString() + " " + Convert.ToDateTime(mReceiveTime.Text).TimeOfDay))
                {
                    toolTip1.Show("Thời điểm đặt hàng phải <= Thời điểm nhận hàng?",
                   mReceiveTime, 0, 0, 1000);
                    mOrderTime.Focus();
                    return;
                }
                try
                {
                    long? OrderID = Convert.ToInt64(cbOrders.SelectedValue);
                    orderdetail = new OrderDetail();
                    long ProductID = Convert.ToInt64(dataGridView1.Rows[i].Cells["ProductID"].Value);
                    orderdetail = db.OrderDetails.Single(o => o.OrderID == OrderID && o.ProductID == ProductID);
                    orderdetail.Quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells["Quantity"].Value);
                    orderdetail.Price = Convert.ToDecimal(dataGridView1.Rows[i].Cells["Price"].Value);

                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0,
                   1000);
                    return;
                }
            }
            loadOrderDetails();
            toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
        }
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Quantity")
            {
                if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Hãy nhập số lượng?";
                    e.Cancel = true;
                    return;
                }
                else
                {
                    try
                    {
                        if (Convert.ToInt32(e.FormattedValue) < 0)
                        {
                            dataGridView1.Rows[e.RowIndex].ErrorText = "Số lượng phải >= 0 ? ";
                            e.Cancel = true;
                        }
                        else
                            dataGridView1.Rows[e.RowIndex].ErrorText = "";
                    }
                    catch

                    {
                        dataGridView1.Rows[e.RowIndex].ErrorText = "Dữ liệu sai kiểu số nguyên ? ";
                        e.Cancel = true;
                        return;
                    }
                }
                dataGridView1.Rows[e.RowIndex].Cells["Amount"].Selected = true;
                dataGridView1.Rows[e.RowIndex].Cells["Amount"].Selected = false;
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Price")
            {
                if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Hãy nhập giá bán?";
                    e.Cancel = true;
                    return;
                }
                else
                {
                    try
                    {
                        if (Convert.ToDecimal(e.FormattedValue) < 0)
                        {
                            dataGridView1.Rows[e.RowIndex].ErrorText = "Giá bán phải >= 0 ? ";

                            e.Cancel = true;
                        }
                        else
                            dataGridView1.Rows[e.RowIndex].ErrorText = "";
                    }
                    catch
                    {
                        dataGridView1.Rows[e.RowIndex].ErrorText = "Dữ liệu sai kiểu số thực ? ";

                        e.Cancel = true;
                        return;

                    }
                }
                dataGridView1.Rows[e.RowIndex].Cells["Amount"].Selected = true;
                dataGridView1.Rows[e.RowIndex].Cells["Amount"].Selected = false;
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            mQuantity.Text = "0";
            cbOrders.Focus();
            mQuantity.Text = null;
        }

        

        private void cbOrders_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cbOrders.FindStringExact(cbOrders.Text) < 0)
            {
                toolTip1.Show("Nhập sai Đơn hàng?", cbOrders, 0, 0, 1000);
                e.Cancel = true;
            }
        }
    }
}