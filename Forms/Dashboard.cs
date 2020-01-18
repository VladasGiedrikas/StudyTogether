using StudyTogether.Forms;
using StudyTogether.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace StudyTogether
{
    public partial class Dashboard : Form
    {
        #region Properties
        static readonly HttpClient client = new HttpClient();
        readonly CommonThings common = new CommonThings();
        readonly Student student;
        List<Question> rows;
        private readonly QuestionsClient serviceQuestion;
        private readonly QuizClient serviceQuiz;
        #endregion
        public Dashboard(Student student)
        {
            serviceQuestion = new QuestionsClient("https://localhost:44353/", client);
            serviceQuiz = new QuizClient("https://localhost:44353/", client);
            InitializeComponent();
            this.student = student;  
            LoadData();         
        }

        private void LoadData()
        {
            dg.Columns[0].Visible = false;
            labelTestName.Visible = false;
            textBoxQuizName.Enabled = false;

            var quizes = serviceQuiz.GetQuizByIdAsync(student.StudentNumber).GetAwaiter().GetResult().ToList();
            var quizNames = new List<QuizName>();

            foreach (var item in quizes)
            {
                var quizName = new QuizName() { Name = item.QuizName, Value = item.QuizNumber };
                quizNames.Add(quizName);
            }

            //Setup data binding
            PaskaitacomboBox.DataSource = quizNames;
            PaskaitacomboBox.DisplayMember = "Name";
            PaskaitacomboBox.ValueMember = "Value";

            GetQuestions(quizes.FirstOrDefault().QuizNumber);
            bnds.DataSource = rows;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllQuizes frm = new AllQuizes();
            frm.ShowDialog();
        }
        private void LoadQuestionsBtn_Click(object sender, EventArgs e)
        {
            labelTestName.Visible = true;
            textBoxQuizName.Enabled = true;
            LoadQuestionsFromFile();
        }
       
        private void SaveQuestions(List<Question> rows)
        {
            Quiz quiz = new Quiz() {QuizNumber = rows.FirstOrDefault().QuizNumber, QuizName = textBoxQuizName.Text, StudentNumber = student.StudentNumber, Owner = student.StudentName};
            var result = serviceQuestion.InsertQuestionAsync(rows).GetAwaiter().GetResult();

            if (result)
            {
                MessageBox.Show("Išsaugota!");
            }
            if (result)
            {
               serviceQuestion.InsertQuizAsync(quiz).GetAwaiter().GetResult();
            }
        }

        private void exportQuestionsbtn_Click(object sender, EventArgs e)
        {
            if (dg.Rows == null || dg.Rows.Count == 0)
                return;          
            this.dg.CurrentCell = null;
            bnds.EndEdit();
            SaveQuestions(rows);
        }

        private void LoadQuestionsFromFile()
        {
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "CSV files |*.csv|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            OpenCsvFile(openFileDialog.FileName);
        }

        private void OpenCsvFile(string filePath)
        {
            try
            {
                bnds.Clear();
                rows = common.CSVToModel<List<Question>>(filePath, ',');
                bnds.DataSource = rows;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.ToString());
            }         
        }
        private void GetQuestions(int quizNumber)
        {
            try
            {          
                var result = serviceQuestion.GetQuestionByIdAsync(quizNumber).GetAwaiter().GetResult();
                rows = result.ToList();
                bnds.DataSource = rows;
                dg.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void PaskaitacomboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(PaskaitacomboBox.SelectedValue);
            GetQuestions(id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelTestName.Visible =  true;
            textBoxQuizName.Enabled = true;
            bnds.Clear();
            bnds.AddNew();
            buttonAddRow.Visible = true;         
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            bnds.AddNew();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            this.dg.CurrentCell = null;
            bnds.EndEdit();
            List<Question> entries = (List<Question>)bnds.DataSource;
            serviceQuestion.UpdateQuestionsListAsync(entries).GetAwaiter().GetResult();
        }
    }
}
