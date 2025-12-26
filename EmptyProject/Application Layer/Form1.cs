//Form1.cs
using EmptyProject.Application_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmptyProject
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);

            this.Size = new Size(w, h);

            
            Label label1 = new Label();
            label1.Text = "Auto size example";
            label1.AutoSize = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "Admin" && txtpassword.Text == "1234")
            {
                
                this.Hide();
                MainForm obj1 = new MainForm();
                obj1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter Valid Username and Password.");
                txtusername.Text = ""; txtpassword.Text = "";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblclearfields_Click(object sender, EventArgs e)
        {
            txtusername.Text = ""; txtpassword.Text = "";
            txtusername.Focus();
        }
    }
}
