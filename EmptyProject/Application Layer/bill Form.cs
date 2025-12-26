//bill Form.cs
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
    public partial class bill_Form : Form
    {
        string a, b, f, g, h, i;
        int c, d, total;



        private void button4_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtorderid.Text)) return;

            try
            {
                using (SqlConnection con = DatabaseClass.GetConnection())
                {
                   
                    string query = "SELECT name, qnt, price, c_name, mobile, d_order, status FROM ordpiza WHERE o_id = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", txtorderid.Text);
                    SqlDataReader dr = cmd.ExecuteReader();

                    StringBuilder itemsList = new StringBuilder();
                    int grandTotal = 0;
                    string customerName = "";
                    string mobile = "";
                    string orderDate = "";
                    string billStatus = ""; 
                    bool hasData = false;

                    while (dr.Read())
                    {
                        hasData = true;
                        customerName = dr["c_name"].ToString();
                        mobile = dr["mobile"].ToString();
                        orderDate = Convert.ToDateTime(dr["d_order"]).ToString("f");
                        billStatus = dr["status"].ToString().ToUpper();

                        string pName = dr["name"].ToString();
                        int qty = Convert.ToInt32(dr["qnt"]);
                        int price = Convert.ToInt32(dr["price"]);
                        int rowTotal = qty * price;
                        grandTotal += rowTotal;

                        itemsList.AppendLine($"{pName.PadRight(15)} {qty} x {price} = {rowTotal}");
                    }

                    if (hasData)
                    {
                        lblshowbill.Text = "------------------------------------------\n" +
                                      "          FORK N KNIVES PIZZA           \n" +
                                      "------------------------------------------\n" +
                                      $"Date: {orderDate}\n" +
                                      $"Cust ID: {txtorderid.Text} | Name: {customerName}\n" +
                                      $"Contact: {mobile}\n" +
                                      "------------------------------------------\n" +
                                      "Item            Qty x Price   Total\n" +
                                      itemsList.ToString() +
                                      "------------------------------------------\n" +
                                      $"GRAND TOTAL: {grandTotal} \n" +
                                      $"STATUS:      {billStatus} \n" + 
                                      "------------------------------------------\n" +
                                      (billStatus == "PAID" ? "     Payment Received - Thank You!    " : "     Please proceed to counter to pay    ");
                    }
                    else
                    {
                        MessageBox.Show("Order ID Not Found!");
                        lblshowbill.Text = "No Bill Data";
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Bill Error: " + ex.Message); }
        }
        private void bill_Form_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);


            SqlConnection con = DatabaseClass.GetConnection();

            string getCust = "select max(c_id) from ordpiza";

            SqlCommand cmd = new SqlCommand(getCust, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtorderid.Text = dr[0].ToString();
            }
            else
            {
                MessageBox.Show(" Sorry, This ID Doesnot Selected Successfully");
            }
        }

        
        public bill_Form()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
