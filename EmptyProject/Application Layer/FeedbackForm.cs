//FeedbackForm.cs
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

namespace EmptyProject.Application_Layer
{
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void FeddbackForm_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);

            this.Size = new Size(w, h);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtcustname.Text) || string.IsNullOrWhiteSpace(txtfeedback.Text))
            {
                MessageBox.Show("Please enter both your Name and Feedback.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            Customer obj = new Customer(txtcustname.Text, txtfeedback.Text);

            
            DatabaseClass.feedback(obj);

            
            ClearForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        
        private void ClearForm()
        {
            txtcustname.Clear();
            txtfeedback.Clear();
            txtcustname.Focus(); 
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
