//PaymentForm.cs
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmptyProject.Application_Layer
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtorderid.Text))
            {
                
                string result = DatabaseClass.GetPendingAmount(txtorderid.Text);

                if (result == "ALREADY_PAID")
                {
                    txtamount.Clear();
                    MessageBox.Show("This Order ID has already been paid!", "Payment Done", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (result == "NOT_FOUND")
                {
                    txtamount.Clear();
                   
                }
                else
                {
                    
                    txtamount.Text = result;
                }
            }
            else
            {
                txtamount.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtorderid.Text)) { MessageBox.Show("Enter Order ID"); return; }
            if (cmbselect.SelectedIndex < 0) { MessageBox.Show("Select Payment Type"); return; }
            if (string.IsNullOrEmpty(txtamount.Text) || txtamount.Text == "0") { MessageBox.Show("No pending bill."); return; }

            
            Owner obj = new Owner();
            obj.order_id = txtorderid.Text;
            obj.amount = txtamount.Text;
            obj.select_type = cmbselect.Text;

            
            if (DatabaseClass.ProcessPayment(obj))
            {
                MessageBox.Show("Payment Successful! Status changed to Paid.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                txtorderid.Clear();
                txtamount.Clear();
                cmbselect.SelectedIndex = 0;

                
                foreach (Form f in Application.OpenForms)
                {
                    if (f is OrderPizzaForm orderForm)
                    {
                        orderForm.RefreshGrid();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            txtamount.Text = "";
            txtorderid.Text = "";
            cmbselect.Text = "--Select--";
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            
            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);


            txtorderid.Clear();
            txtamount.Clear();
        }
    }
}
