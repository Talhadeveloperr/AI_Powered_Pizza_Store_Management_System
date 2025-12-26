//MainForm.cs
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addPizzaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddPizzaForm obj = new AddPizzaForm();
            obj.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderPizzaForm obj = new OrderPizzaForm();
            obj.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PaymentForm obj = new PaymentForm();
            obj.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FeedbackForm obj = new FeedbackForm();
            obj.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CustomerForm obj = new CustomerForm();
            obj.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            bill_Form obj = new bill_Form();
            obj.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            delete_Details delete_Details = new delete_Details();
            delete_Details.Show();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        { 
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);

            this.Size = new Size(w, h);
        }

        private void aIAssistanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AiAssist obj = new AiAssist();
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
