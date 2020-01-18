using StudyTogether.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace StudyTogether.Forms
{
    public partial class DoQuiz : Form
    {
        static readonly HttpClient client = new HttpClient();
        public List<Question> rows = new List<Question>();
        public int questionId = 1;
        public List<Answer> answers = new List<Answer>();

        public DoQuiz(List<Question> questionLists)
        {
            rows = questionLists;
            InitializeComponent();
            PrepareAnswers(questionLists);
            ShowQuestion(questionId);          
        }

        private void PrepareAnswers(List<Question> questionLists)
        {
            foreach (var item in questionLists)
            {
                var answer = new Answer() { QuestionNumber = item.QuestionNumber, StudentAnswer = "" };
                answers.Add(answer);
            }
        }

        private void ShowQuestion(int questionId)
        {
            var total = rows.Count();
            var question = new Question();
            if (!(questionId > total))
            {
                question = rows.Where(x => x.QuestionNumber == questionId).FirstOrDefault();
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
            }
        }

        private void hintBtn_Click(object sender, EventArgs e)
        {
            hintLabel.Visible = true;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            questionId += 1;

            ShowQuestion(questionId);
            previousBtn.Enabled = true;
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            questionId -= 1;
            if (!(questionId < 1))
            {
                ShowQuestion(questionId);
            }
            else
            {
                previousBtn.Enabled = false;
                questionId = 1;
            }
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            int quizId = rows.FirstOrDefault().QuizNumber;
            var service = new QuestionsClient("https://localhost:44353/", client);        
            var result = service.GetGradeAsync(answers, quizId).GetAwaiter().GetResult();
            labelFinish.Text = "Tavo balas:  " + result.ToString();
        }
        private void answer_CheckedChanged(object sender, EventArgs e)
        {           
            string selectedAnswer = "";
            if (answer1.Checked) selectedAnswer = answer1.Text;
            if (answer2.Checked) selectedAnswer = answer2.Text;
            if (answer3.Checked) selectedAnswer = answer3.Text;
            if (answer4.Checked) selectedAnswer = answer4.Text;

            var test = answers.Where(x => x.QuestionNumber == questionId).FirstOrDefault();                      
            test.StudentAnswer = selectedAnswer;        
        }
    }
}
