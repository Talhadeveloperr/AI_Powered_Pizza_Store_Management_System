using EmptyProject.Database_Layer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmptyProject.Application_Layer
{
    public partial class AiAssist : Form
    {
        private readonly string apiKey =
            "";
        public AiAssist()
        {
            InitializeComponent();
        }

        private void txtPrompt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblresponse_Click(object sender, EventArgs e)
        {

        }

        private void btnclearprompt_Click(object sender, EventArgs e)
        {
            txtPrompt.Clear();
            lblresponse.Text = "Ready for your question.";
        }

        private async void btnsend_Click(object sender, EventArgs e)
        {
            string userPrompt = txtPrompt.Text;
            if (string.IsNullOrWhiteSpace(userPrompt))
            {
                MessageBox.Show("Please enter a prompt.");
                return;
            }

            lblresponse.Text = "Generating AI response ...";
            btnsend.Enabled = false;

            try
            {
                
                string dbContext = DatabaseClass.GetDatabaseContext();

                
                string fullPrompt = "You are a database assistant for a Pizza Shop. Use this data to answer.\n" +
                                   "--- DATABASE CONTEXT ---\n" + dbContext + "\n" +
                                   "--- USER QUESTION ---\n" + userPrompt + "\n\n" +
                                   "--- RESPONSE ---";

               
                var requestBody = new
                {
                    model = "gpt-3.5-turbo-instruct",
                    prompt = fullPrompt,
                    max_tokens = 500,
                    temperature = 0.9
                };

                string jsonPayload = JsonConvert.SerializeObject(requestBody);

                using (HttpClient client = new HttpClient())
                {
                    
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                    var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                     
                    var response = await client.PostAsync("https://api.openai.com/v1/completions", content);
                    string result = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        dynamic dynamicResult = JsonConvert.DeserializeObject(result);
                        
                        string aiMessage = dynamicResult.choices[0].text;
                        lblresponse.Text = aiMessage.Trim();
                    }
                    else
                    {
                        
                        lblresponse.Text = "API Error: " + response.StatusCode + "\n" + result;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("System Error: " + ex.Message);
            }
            finally
            {
                btnsend.Enabled = true;
            }
        }

        private void AiAssist_Load(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized; 
            
        }
    }
}
