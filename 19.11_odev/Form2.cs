using _19._11_odev.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19._11_odev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            db = new NorthwindContext();
        }
        public Form2(int id)
        {
            InitializeComponent();
            db = new NorthwindContext();
            this.id = id;
        }
        int id;
        NorthwindContext db;
        private void Form2_Load(object sender, EventArgs e)
        {
            var employees = db.Employees.Select(s => new { s.FirstName }).ToList();
            var shippers = db.Shippers.Select(s => new { s.CompanyName }).ToList();
            foreach ( var employee in employees)
            {
                cbEmployee.Items.Add(employee.FirstName);
            }
            foreach(var shipper in  shippers)
            {
                cbShipper.Items.Add(shipper.CompanyName);
            }
        }

        private void btn2Add_Click(object sender, EventArgs e)
        {
            if (id==null)
            {
                var order = new Order()
                {
                    ShipCity = txtCity.Text,
                    OrderDate = dtpOrderDate.Value,


                };
                var shipper = new Shipper()
                {
                    CompanyName = cbShipper.Text,
                };
                var employee = new Employee()
                {
                    FirstName = cbEmployee.Text,
                };
                db.Orders.Add(order);
                db.Shippers.Add(shipper);
                db.Employees.Add(employee);
                db.SaveChanges();
                this.Close();
           

            }


        }
       
    }
}
