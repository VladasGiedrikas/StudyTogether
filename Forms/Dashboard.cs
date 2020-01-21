using StudyTogether.Forms;
using StudyTogether.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudyTogether
{
    public partial class Dashboard : Form
    {
        #region Properties
        readonly SharedFunctions sf = new SharedFunctions();
        private readonly ApiClient apiClient = new ApiClient();
        private List<Question> questions;
        private readonly Student student;
        #endregion
        public Dashboard(Student student)
        {
            InitializeComponent();
            this.student = student;
            ShowHide();
            LoadData();         
        }

        private void ShowHide()
        {
            dg.Columns[0].Visible = false;
            labelTestName.Visible = false;
            textBoxQuizName.Enabled = false;
        }

        private void LoadData()
        {
            //gaunama prisijungusio studento sukurtu testu pavadinimus iš API
            // ir juos sudedam i dropdow laukelį
            try
            {
                var quizes = apiClient.QuizService.GetQuizByIdAsync(student.StudentNumber).GetAwaiter().GetResult().ToList();
                var quizNames = new List<QuizName>();
                foreach (var item in quizes)
                {
                    var quizName = new QuizName() { Name = item.QuizName, Value = item.QuizNumber };
                    quizNames.Add(quizName);
                }
                PaskaitacomboBox.DataSource = quizNames;
                PaskaitacomboBox.DisplayMember = "Name";
                PaskaitacomboBox.ValueMember = "Value";
                GetQuestions(quizes.FirstOrDefault().QuizNumber);
                bnds.DataSource = questions;
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.ToString());
            }         
        }

        private void LoadQuestionsBtn_Click(object sender, EventArgs e)
        {
            labelTestName.Visible = true;
            textBoxQuizName.Enabled = true;
            LoadQuestionsFromFile();
        }

        private void SaveQuestions(List<Question> rows)
        {
            if (!string.IsNullOrWhiteSpace(textBoxQuizName.Text))
            {
                try
                {
                    var result = apiClient.QuestionsService.InsertQuestionAsync(rows).GetAwaiter().GetResult();

                    if (result)
                    {
                        MessageBox.Show("Išsaugota!");
                    }
                    if (result)
                    {
                        Quiz quiz = new Quiz()
                        {
                            QuizNumber = rows.FirstOrDefault().QuizNumber,
                            QuizName = textBoxQuizName.Text,
                            StudentNumber = student.StudentNumber,
                            Owner = student.StudentName
                        };
                        apiClient.QuestionsService.InsertQuizAsync(quiz).GetAwaiter().GetResult();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Iveskite pavadinimą");
                return;
            }
        }

        private void ExportQuestionsbtn_Click(object sender, EventArgs e)
        {
            if (dg.Rows == null || dg.Rows.Count == 0)
                return;          
            this.dg.CurrentCell = null;
            bnds.EndEdit();
            SaveQuestions(questions);
            LoadData();
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

                questions = sf.CSVToModel<List<Question>>(filePath, ',');

                bnds.DataSource = questions;
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
                var result = apiClient.QuestionsService.GetQuestionByIdAsync(quizNumber).GetAwaiter().GetResult();
                questions = result.ToList();
                bnds.DataSource = questions;
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

        private void ButtonAddRow_Click(object sender, EventArgs e)
        {
            bnds.AddNew();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                this.dg.CurrentCell = null;
                bnds.EndEdit();
                List<Question> entries = (List<Question>)bnds.DataSource;
                apiClient.QuestionsService.UpdateQuestionsListAsync(entries).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ShowAllQuiz_Click(object sender, EventArgs e)
        {
            AllQuizes frm = new AllQuizes(student);
            frm.ShowDialog();
        }

        private void ButtonCreatenew(object sender, EventArgs e)
        {
            labelTestName.Visible = true;
            textBoxQuizName.Enabled = true;
            bnds.Clear();
            bnds.AddNew();
            buttonAddRow.Visible = true;
        }
    }
}
