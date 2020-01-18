using StudyTogether.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace StudyTogether.Forms
{
    public partial class AllQuizes : Form
    {
        static readonly HttpClient client = new HttpClient();
        private readonly QuizClient serviceQuiz;
        List<Question> questions;
        int id;
        public AllQuizes()
        {
            serviceQuiz = new QuizClient("https://localhost:44353/", client);
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var quizzes = serviceQuiz.GetAllQuizesAsync().GetAwaiter().GetResult();
            bnds.DataSource = quizzes;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {       
            try
            {                 
                var service = new QuestionsClient("https://localhost:44353/", client);
                var result = service.GetQuestionByIdAsync(id).GetAwaiter().GetResult();
                questions = result.ToList();
                if (questions != null)
                {
                    DoQuiz frm = new DoQuiz(questions);
                    frm.ShowDialog();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dg.Rows[e.RowIndex];
                id = Convert.ToInt32( row.Cells[0].Value.ToString());
            }
        }
    }
}
