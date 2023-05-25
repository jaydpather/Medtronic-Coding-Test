using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace Medtronic_Coding_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var employeeSvc = new EmployeeService();
                var employees = employeeSvc.LoadEmployees(); //in a real app, this would be an RPC
                dgvEmployees.DataSource = employees; //in a real app, I would give the columns friendly names (e.g., "First Name" instead of FirstName)
            }
            catch (Exception)
            {
                lblError.Text = "Error loading employees.";
                lblError.Visible = true;
            }
        }
    }
}
