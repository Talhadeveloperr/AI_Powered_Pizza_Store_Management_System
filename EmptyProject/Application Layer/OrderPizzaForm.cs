//OderPizzaForm.cs
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
    public partial class OrderPizzaForm : Form
    {
        public OrderPizzaForm()
        {
            InitializeComponent();
            this.Activated += new EventHandler(OrderPizzaForm_Activated);
        }
        private void OrderPizzaForm_Activated(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            try
            {
                
                dataGridVieworderpizzaform.DataSource = null;
                dataGridVieworderpizzaform.AutoGenerateColumns = true;

                DataTable dt = DatabaseClass.GetOrderList();
                dataGridVieworderpizzaform.DataSource = dt;

                if (dataGridVieworderpizzaform.Columns.Count > 0)
                {
                    dataGridVieworderpizzaform.AutoResizeColumns();

                    
                    if (dataGridVieworderpizzaform.Columns.Contains("o_id"))
                        dataGridVieworderpizzaform.Columns["o_id"].HeaderText = "Order ID";
                    if (dataGridVieworderpizzaform.Columns.Contains("d_order"))
                        dataGridVieworderpizzaform.Columns["d_order"].HeaderText = "Date";
                    if (dataGridVieworderpizzaform.Columns.Contains("total_price"))
                        dataGridVieworderpizzaform.Columns["total_price"].HeaderText = "Total Bill";
                }
            }
            catch (Exception ex)
            {
               
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpizzaquant.Text == "") { MessageBox.Show("Please enter Quantity!"); return; }

            try
            {
                Owner obj = new Owner(txtpizzaid.Text, txtpizzaname.Text, txtpizzaquant.Text, txtpizzaprice.Text, txtpizzedesc.Text,
                                      txtcustid.Text, txtcustname.Text, txtcustmobile.Text, txtcustaddress.Text);

                DatabaseClass.order(obj);
                RefreshGrid(); // Refresh immediately after ordering
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Order Error: If you see Primary Key error, use a unique Customer ID.");
            }
        }
        private void ClearAll()
        {
            txtpizzaid.Clear(); txtpizzaname.Clear(); txtpizzaquant.Clear();
            txtpizzaprice.Clear(); txtpizzedesc.Clear(); txtcustid.Clear();
            txtcustname.Clear(); txtcustmobile.Clear(); txtcustaddress.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            bill_Form bform = new bill_Form();
            bform.Show();
        }

        private void OrderPizzaForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            RefreshGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpizzaid.Text)) return;
            try
            {
                using (SqlConnection con = DatabaseClass.GetConnection())
                {
                    string query = "SELECT name, price, descr FROM addpiza WHERE id = '" + txtpizzaid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtpizzaname.Text = dr["name"].ToString();
                        txtpizzaprice.Text = dr["price"].ToString();
                        txtpizzedesc.Text = dr["descr"].ToString();
                    }
                }
            }
            catch {  }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtcustid.Text))
            {
                txtcustname.Clear(); txtcustmobile.Clear(); txtcustaddress.Clear();
                return;
            }

            try
            {
                using (SqlConnection con = DatabaseClass.GetConnection())
                {
                    
                    string query = "SELECT name, mobi, addr FROM customer WHERE c_id = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", txtcustid.Text); 

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtcustname.Text = dr["name"].ToString();   
                        txtcustmobile.Text = dr["mobi"].ToString();   
                        txtcustaddress.Text = dr["addr"].ToString();   
                    }
                    else
                    {
                        
                        txtcustname.Clear(); txtcustmobile.Clear(); txtcustaddress.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
