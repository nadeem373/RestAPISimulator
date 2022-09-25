using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace RestAPISimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:65502/api/");
                    //HTTP GET
                    var responseTask = client.GetAsync("Customer");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    txtServerResponse.Text = result.StatusCode.ToString();
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsStringAsync();
                        readTask.Wait();

                        var customers = readTask.Result;
                        txtCustomerData.Text = customers;
                    }
                }

            }
            catch (Exception ex)
            {
                txtServerResponse.Text = ex.Message;
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            try
            {

                List<Customer> customers = GenerateData();
                Uri url = new Uri("http://localhost:65502/api/Customer");
                HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(customers), Encoding.UTF8);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                PostURI(url, httpContent);
            }
            catch (Exception ex)
            {
                txtServerResponse.Text = ex.Message;
            }
        }

        private async Task<string> PostURI(Uri url, HttpContent content)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.PostAsync(url, content);
                if (result.IsSuccessStatusCode)
                {
                    response = result.StatusCode.ToString();
                }
            }
            return response;
        }

        private List<Customer> GenerateData()
        {
            List<Customer> customers = new List<Customer>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:65502/api/");
                //HTTP GET
                var responseTask = client.GetAsync("customer/Generatedata");
                responseTask.Wait();

                var result = responseTask.Result;
                txtServerResponse.Text = result.StatusCode.ToString();
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    customers = JsonConvert.DeserializeObject<List<Customer>>(readTask.Result);
                }
            }
            return customers;
        }
    }
}
