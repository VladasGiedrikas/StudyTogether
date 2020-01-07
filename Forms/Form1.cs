using StudyTogether.Models;
using StudyTogether.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTogether
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();



        public Form1()
        {
            InitializeComponent();       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<Student> students = new List<Student>();
            RunAsync();

           // label1.Text = products.FirstOrDefault().Name.ToString();

        }

        //static void ShowProduct(Product product)
        //{
        //    Console.WriteLine($"Name: {product.Name}\tPrice: " +
        //        $"{product.Price}\tCategory: {product.Category}");
        //}

        static async Task<Uri> CreateProductAsync(Product product)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/weatherforecast", product);          
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        static async Task<List<Student>> GetProductAsync(string path)
        {
            //Product product = null;
            List<Student> students  = new List<Student>();
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                students = await response.Content.ReadAsAsync<List<Student>>();
                
            }
            return students;
        }

        static async Task<Product> UpdateProductAsync(Product product)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/weatherforecast/{product.Id}", product);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            product = await response.Content.ReadAsAsync<Product>();
            return product;
        }

        static async Task<HttpStatusCode> DeleteProductAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/products/{id}");
            return response.StatusCode;
        }
        static async Task RunAsync()
        {
           
            client.BaseAddress = new Uri("http://localhost:44353/");
        //https://localhost:44353/products
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
               List<Student> students = new List<Student>();
               students = await GetProductAsync("https://localhost:44353/products");
               
                // var url = await CreateProductAsync(product);
                // Console.WriteLine($"Created at {url}");

                // // Get the product
                // product = await GetProductAsync(url.PathAndQuery);
                // //ShowProduct(product);

                // // Update the product
                // //Console.WriteLine("Updating price...");
                // product.Price = 80;
                // await UpdateProductAsync(product);

                // //// Get the updated product
                // product = await GetProductAsync(url.PathAndQuery);
                // //ShowProduct(product);

                // // Delete the product
                // var statusCode = await DeleteProductAsync(product.Id);
                ////Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

          
        }

    }
}
