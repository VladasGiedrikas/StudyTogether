using StudyTogether.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudyTogether.Forms
{
    public partial class AllQuizes : Form
    {
        private readonly ApiClient apiClient = new ApiClient();
        private  Student student;
        private List<Question> questions;
        private int questioId;
        public AllQuizes(Student student)
        {
            this.student = student;
            InitializeComponent();
            LoadData();
        }

        //Užkraunami duomenys gauti iš API
        private void LoadData()
        {
            try
            {
                var quizzes = apiClient.QuizService.GetAllQuizesAsync().GetAwaiter().GetResult();
                bnds.DataSource = quizzes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        //gaunami klausimai iš Api pagal testoId 
        private void buttonStart_Click(object sender, EventArgs e)
        {       
            try
            {                 
                questions = apiClient.QuestionsService.GetQuestionByIdAsync(questioId).GetAwaiter().GetResult().ToList();                
                if (questions != null)
                {
                    //atidaroma naujas langas ir perduodami klausimai ir prisijungusio studento informacija
                    DoQuiz frm = new DoQuiz(questions, student);
                    frm.Show();
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //gaunas pasirinkto testo numeris
        private void dg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dg.Rows[e.RowIndex];
                questioId = Convert.ToInt32( row.Cells[0].Value.ToString());
            }
        }
    }
}
