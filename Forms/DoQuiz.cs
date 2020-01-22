using StudyTogether.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudyTogether.Forms
{
    public partial class DoQuiz : Form
    {
        private readonly ApiClient apiClient = new ApiClient();
        private List<Question> questionsList = new List<Question>();
        private  Student student;
        private int questionId = 1;
        private List<Answer> answers = new List<Answer>();

        public DoQuiz(List<Question> questionLists, Student student)
        {
            this.student = student;
            questionsList = questionLists;
            InitializeComponent();
            PrepareAnswers(questionsList);
            ShowQuestion(questionId);
            LoadData();
        }

        //uzkraunama lentelė su duomenimis iš Api apie jau atliktus testus
        private void LoadData()
        {
            var grades = apiClient.GradesService.GetAllGradesAsync().GetAwaiter().GetResult();
            bnds.DataSource = grades;
        }

        // pagal gautus klausimus paruosiams atsakymu sąrašas, kuri paskui redaguojamas atitinkamai pagal pasirinkta atsakyma
        private void PrepareAnswers(List<Question> questions)
        {
            foreach (var item in questions)
            {
                var answer = new Answer() { QuestionNumber = item.QuestionNumber, StudentAnswer = "", CorectAnswer = item.CorectAnswer };
                answers.Add(answer);
            }
        }
        //rodomas klausimas pagal jo numeri
        private void ShowQuestion(int questionId)
        {
            var total = questionsList.Count();
            var question = new Question();
            if (!(questionId > total))
            {
                question = questionsList.Where(x => x.QuestionNumber == questionId).FirstOrDefault();
                labelQuestion.Text = question.QuestionMain.ToString();
                answer1.Text = question.CorectAnswer.ToString();
                answer2.Text = question.IncorectFirst.ToString();
                answer3.Text = question.IncorectSecond.ToString();
                answer4.Text = question.IncorectThird.ToString();
                hintLabel.Visible = false;
                hintLabel.Text = question.Hint.ToString();                
            }
            else
            {
                labelFinish.Text = "Visi klausimai atsakyti! ";
                nextBtn.Enabled = false;
            }
        }
        // galimybe gauti užuomina
        private void hintBtn_Click(object sender, EventArgs e)
        {
            hintLabel.Visible = true;
        }

        //perėjimas prie sekančio klausimo
        private void NextBtn_Click(object sender, EventArgs e)
        {
            SaveSelectedAnswer();
            questionId += 1;
            answer1.Checked  = false;
            answer2.Checked = false;
            answer3.Checked = false;
            answer4.Checked = false;
            ShowQuestion(questionId);
        }

        private void SaveSelectedAnswer()
        {
            //pasikeitus klausimui išsaugomas pasirinkimas
            string selectedAnswer = "";
            if (answer1.Checked) selectedAnswer = answer1.Text;
            if (answer2.Checked) selectedAnswer = answer2.Text;
            if (answer3.Checked) selectedAnswer = answer3.Text;
            if (answer4.Checked) selectedAnswer = answer4.Text;
            var total = questionsList.Count();
            if (!(questionId > total))
            {
                var test = answers.Where(x => x.QuestionNumber == questionId).FirstOrDefault();
                test.StudentAnswer = selectedAnswer;
            }
        }

        //baigimas testas
        private void FinishBtn_Click(object sender, EventArgs e)
        {
            int quizId = questionsList.FirstOrDefault().QuizNumber;         
            // gaunas ivertinimas apskaičiuotas Api programoje
            var result = apiClient.GradesService.GetGradeAsync(answers, quizId).GetAwaiter().GetResult();
            labelFinish.Text = "Tavo balas:  " + result.ToString();

            Grade grade = new Grade() { DateDone = DateTime.Now, GradeNumber = 1, GradePercent = result, QuizNumber = quizId, StudentName = student.StudentName, StudentNumber = student.StudentNumber };
            //išsaugom informaciją apie apie atliktą testą
            var inserted = apiClient.GradesService.InsertGradeAsync(grade).GetAwaiter().GetResult();
            LoadData();
        }        
    }
}
