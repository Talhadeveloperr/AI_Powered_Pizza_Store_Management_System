//delete Details.cs
using EmptyProject.Bussiness_Layer;
using EmptyProject.Database_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmptyProject.Application_Layer
{
    public partial class delete_Details : Form
    {
        public delete_Details()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtorderid.Text))
            {
                MessageBox.Show("Please enter an Order ID first.");
                return;
            }

            
            DialogResult dr = MessageBox.Show("Delete Order " + txtorderid.Text + "?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Owner obj = new Owner(txtorderid.Text, ""); 
                DatabaseClass.deleteOrder(obj);
                MessageBox.Show("Order Information Deleted Successfully");
                txtorderid.Clear();
            }
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpizzaid.Text))
            {
                MessageBox.Show("Please enter a Pizza ID.");
                return;
            }

            Owner obj = new Owner(txtpizzaid.Text);
            DatabaseClass.deletePizza(obj);
            MessageBox.Show("Pizza Information Deleted Successfully");
            txtpizzaid.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcustomerdetail.Text))
            {
                MessageBox.Show("Please enter a Customer ID.");
                return;
            }

            Owner obj = new Owner(txtcustomerdetail.Text, "", "");
            DatabaseClass.deleteCustomer(obj);
            MessageBox.Show("Customer Information Deleted Successfully");
            txtcustomerdetail.Clear();
        }

        
        private void delete_Details_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MainForm obj = new MainForm();
            obj.Show();
            this.Close(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrderPizzaForm obj = new OrderPizzaForm();
            obj.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bill_Form obj = new bill_Form();
            obj.Show();
            this.Close();
        }

        private void txtpizzaid_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpizzaid.Text)) return;

            try
            {
                using (SqlConnection con = DatabaseClass.GetConnection())
                {
                    
                    string query = "SELECT id FROM addpiza WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", txtpizzaid.Text);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                        {
                            MessageBox.Show("Sorry, this Pizza ID does not exist!", "Entry Error");
                            txtpizzaid.Clear();
                            txtpizzaid.Focus(); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error validating Pizza ID: " + ex.Message);
            }
        }

        private void txtorderid_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtorderid.Text)) return;

            try
            {
                using (SqlConnection con = DatabaseClass.GetConnection())
                {
                    
                    string query = "SELECT o_id FROM ordpiza WHERE o_id = @oid";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@oid", txtorderid.Text);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                        {
                            MessageBox.Show("Sorry, this Order ID does not exist!", "Entry Error");
                            txtorderid.Clear();
                            txtorderid.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error validating Order ID: " + ex.Message);
            }
        }

        private void txtcustomerdetail_Leave(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtcustomerdetail.Text)) return;

            try
            {
                using (SqlConnection con = DatabaseClass.GetConnection())
                {
                    
                    string getCust = "SELECT c_id FROM customer WHERE c_id = @cid";
                    SqlCommand cmd = new SqlCommand(getCust, con);
                    cmd.Parameters.AddWithValue("@cid", txtcustomerdetail.Text);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        
                        if (dr.Read())
                        {
                            
                        }
                        else
                        {
                            
                            MessageBox.Show("Sorry, This Customer ID does not exist!\nPlease enter a valid ID.", "Validation Error");
                            txtcustomerdetail.Clear();
                            txtcustomerdetail.Focus(); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking Customer: " + ex.Message);
            }
        }
    }
}
