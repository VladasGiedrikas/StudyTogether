using StudyTogether.Models;
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

namespace StudyTogether.Forms
{
    public partial class Registration : Form
    {
        static HttpClient client = new HttpClient();
        public Registration()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            nameBox.Text = "test";
            paswordBox.Text = "test123";
            var service = new StudentsClient("https://localhost:44353/", client);
            var student = service.GetStudentCheckAsync(nameBox.Text, paswordBox.Text).GetAwaiter().GetResult();
           // if (student != null)
           // {
                Dashboard frm = new Dashboard(student);
                frm.ShowDialog();
           // }
           // else
          //  {
                MessageBox.Show("Vartotojas neegzistuota! Susikurkite nauja!");
           // }
        }

        private void newStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student() 
            {
                StudentName = textBoxName.Text,
                Group = textBoxGroup.Text,
                Password = textBoxPassword.Text               
            };

            var service = new StudentsClient("https://localhost:44353/", client);
           var result =  service.InsertStudentAsync(student).GetAwaiter().GetResult();
            if (result)
            {
                MessageBox.Show("Vartotojas sukurtas!");
            }
        }
    }
}
