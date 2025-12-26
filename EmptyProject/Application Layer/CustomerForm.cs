//CustomerForm.cs
using EmptyProject.Bussiness_Layer;
using EmptyProject.Database_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace EmptyProject.Application_Layer
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void RefreshGrid()
        {
            dataGridViewcustform.DataSource = DatabaseClass.GetCustomerList();
        }
        private void GenerateNextID()
        {
            try
            {
                using (SqlConnection con = DatabaseClass.GetConnection())
                {
                    
                    string query = "select isnull(max(c_id), 0) + 1 from customer;";

                    SqlCommand cmd1 = new SqlCommand(query, con);
                    txtcustid.Text = cmd1.ExecuteScalar().ToString();
                }
            }
            catch { txtcustid.Text = "1"; }
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            
            
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);

            this.Size = new Size(w, h);
            RefreshGrid();
            GenerateNextID();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner obj = new Owner(txtcustname.Text, txtcustname.Text, txtcustmobile.Text, txtcustaddress.Text);
            DatabaseClass.saveCustomer(obj);

            txtcustid.Text = "";
            txtcustname.Text = "";
            txtcustmobile.Text = "";
            txtcustaddress.Text = "";
            RefreshGrid();
            GenerateNextID();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcustid.Text = "";
            txtcustname.Text = "";
            txtcustmobile.Text = "";
            txtcustaddress.Text = "";
            GenerateNextID();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
