using StudyTogether.Models;
using System;
using System.Windows.Forms;

namespace StudyTogether.Forms
{
    public partial class Registration : Form
    {
        //sukuriamas ogjektas, kuris pasiket klase, kurioje yra sukuriami objektai tarininkavimui su api
        private readonly ApiClient apiClient = new ApiClient();
        public Registration()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            var student = apiClient.StudentService.GetStudentCheckAsync(nameBox.Text, paswordBox.Text).GetAwaiter().GetResult();

            if (student != null)
            {
                Dashboard frm = new Dashboard(student);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Vartotojas neegzistuota! Susikurkite nauja!");
            }
        }

        private void newStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student() 
            {
                StudentName = textBoxName.Text,
                Group = textBoxGroup.Text,
                Password = textBoxPassword.Text               
            };
         
           var result = apiClient.StudentService.InsertStudentAsync(student).GetAwaiter().GetResult();
            if (result)
            {
                MessageBox.Show("Vartotojas sukurtas!");
            }
        }
    }
}
