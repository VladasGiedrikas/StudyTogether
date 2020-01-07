using StudyTogether.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTogether.Forms
{
    public partial class DoQuiz : Form
    {
       public List<QuestionList> rows;
        public int Qid = 1;

        public DoQuiz(List<QuestionList> questionLists)
        {
            rows = questionLists;
            InitializeComponent();
            ShowQuestion(Qid);
        }

        private void ShowQuestion(int id)
        {
            var qestion = rows.Where(x => x.QuestionId == id).FirstOrDefault();
            labelQuestion.Text = qestion.QuestionMain.ToString();
            answer1.Text = qestion.CorectAnswer.ToString();
            answer2.Text = qestion.IncorectFirst.ToString();
            answer3.Text = qestion.IncorectSecond.ToString();
            answer4.Text = qestion.IncorectThird.ToString();
            hintLabel.Text = qestion.Hint.ToString();
        }

        private void hintBtn_Click(object sender, EventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Qid += 1;
            ShowQuestion(Qid);
        }
    }
}
