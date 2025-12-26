//AddPizzaForm.cs
using EmptyProject.Bussiness_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmptyProject.Database_Layer;
using System.Data.SqlClient;

namespace EmptyProject.Application_Layer
{
    public partial class AddPizzaForm : Form
    {
        public AddPizzaForm()
        {
            InitializeComponent();
        }
        private void RefreshGrid()
        {
            dataGridViewaddpizza.DataSource = DatabaseClass.GetPizzaList();
        }
        private void button1_Click(object sender, EventArgs e)
        {  
            
            Owner obj1 = new Owner(txtpizzaid.Text, txtpizzaname.Text, cmbselect.Text, txtpizzaprice.Text, txtpizzadescription.Text);
            DatabaseClass.AddPizza(obj1);

         
            txtpizzaname.Clear();
            txtpizzaprice.Clear();
            txtpizzadescription.Clear();
            cmbselect.Text = "--Select--";

            RefreshGrid(); 
            GenerateID();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Owner obj1 = new Owner(txtpizzaid.Text, txtpizzaname.Text, cmbselect.Text, txtpizzaprice.Text, txtpizzadescription.Text, "", "", "", "", "");
            DatabaseClass.update(obj1);
            RefreshGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtpizzaname.Clear();
            txtpizzaprice.Clear();
            txtpizzadescription.Clear();
            cmbselect.Text = "--Select--";
        }
        private void AddPizzaForm_Load(object sender, EventArgs e)
        {
            
            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            RefreshGrid(); 
            GenerateID();  
        }
        private void GenerateID()
        {
            try
            {
                using (SqlConnection con = DatabaseClass.GetConnection())
                {
                    string str1 = "select isnull(max(id), 0) + 1 from addpiza;";
                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    txtpizzaid.Text = cmd1.ExecuteScalar().ToString();
                }
            }
            catch { txtpizzaid.Text = "1"; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
