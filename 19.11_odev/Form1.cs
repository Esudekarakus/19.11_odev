using _19._11_odev.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace _19._11_odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            db = new NorthwindContext();

            //dgvSiparisler.Columns.Add("Column1", "OrderID");
            //dgvSiparisler.Columns.Add("Column2", "Order Date");
            //dgvSiparisler.Columns.Add("Column3", "Ship City");

        }
        NorthwindContext db;
        int index;
        int orderid;

        private void btnGetOrder_Click(object sender, EventArgs e)
        {
            List<Order> orders = db.Orders.ToList();
            dgvSiparisler.DataSource = orders;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            List<Employee> employees = db.Employees.ToList();
            List<Shipper> shippers = db.Shippers.ToList();

            foreach (Employee employee in employees)
            {
                lstCustomer.Items.Add(employee.FirstName);
            }
            foreach (Shipper shipper in shippers)

            {
                lstShipper.Items.Add(shipper.CompanyName);
            }

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.ShowDialog();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.ShowDialog(orderid);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index >= 0 && dgvSiparisler.Rows.Count > 0)
            {
                
                orderid = int.Parse(dgvSiparisler[0, index].Value.ToString());

                
                Order order = db.Orders.Include(o => o.OrderDetails).FirstOrDefault(a => a.OrderId == orderid);

                
                if (order != null)
                {
                    
                    db.Orders.Remove(order);
                    db.SaveChanges();

                    
                    MessageBox.Show("Sipariþ baþarýyla silindi.");

                    // silindikten sonra
                    orderid = 0;
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
            }
        }

        private void dgvSiparisler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvSiparisler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            index = e.RowIndex;
            orderid = int.Parse(dgvSiparisler[0, index].Value.ToString());
            //Form2 form2 = new Form2(orderid);
            // Check if the selected row index is valid

        }



    }
}
