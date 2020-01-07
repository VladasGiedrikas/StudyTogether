using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StudyTogether.Forms;
using StudyTogether.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTogether
{
    public partial class Dashboard : Form
    {
        #region Properties
        private string FilePath;
        private long? ImportId;
        List<QuestionList> rows;
        #endregion
        public Dashboard()
        {
            InitializeComponent();    
            SeedData();
        }

        private void SeedData()
        {

            var dataSourcePaskaita = new List<Paskaita>();
            dataSourcePaskaita.Add(new Paskaita() { Name = "Objectinis", Value = 1 });
            dataSourcePaskaita.Add(new Paskaita() { Name = "Matematika", Value = 2 });
            dataSourcePaskaita.Add(new Paskaita() { Name = "Vadyba", Value = 3 });

            //Setup data binding
            PaskaitacomboBox.DataSource = dataSourcePaskaita;
            PaskaitacomboBox.DisplayMember = "Name";
            PaskaitacomboBox.ValueMember = "Value";

            ////////////////////////////////
            var dataSourceQuiz = new List<Quiz>();
            dataSourceQuiz.Add(new Quiz() { QuizId = 1, QuizName = "quiz1", Course = "Objektinis", Owner = "Vladas" });
            dataSourceQuiz.Add(new Quiz() { QuizId = 2, QuizName = "quiz2", Course = "Vadyba", Owner = "Tomas" });
            dataSourceQuiz.Add(new Quiz() { QuizId = 3, QuizName = "quiz3", Course = "Matematika", Owner = "Vladas" });

            dataGridView1.DataSource = dataSourceQuiz;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoQuiz frm = new DoQuiz(rows);
            frm.ShowDialog();
        }


        private void LoadQuestionsFromFile()
        {
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "CSV files |*.csv|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            FilePath = openFileDialog.FileName;
            OpenCsvFile(openFileDialog.FileName);
        }

        private void OpenCsvFile(string filePath)
        {
            bnds.Clear();
            rows = CSVToModel<List<QuestionList>>(filePath, ',');
            bnds.DataSource = rows;            
        }
        public T CSVToModel<T>(string filePath, char seperator)
        {
            string lines = File.ReadAllText(filePath);

            return CSVToModelFromString<T>(lines, seperator);
        }
        public T CSVToModelFromString<T>(string fileContent, char seperator)
        {
            JArray array = new JArray();
            try
            {
                fileContent = System.Text.RegularExpressions.Regex.Replace(fileContent, @"\r\n?|\n", "\r");
                string[] lines = fileContent.Split('\r');
                string[] objProperties = GetCSVHeader(seperator, lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(lines[i]))
                        continue;
                    JObject obj = new JObject();
                    string[] values = lines[i].Split(seperator);

                    for (int j = 0; j < values.Length; j++)
                    {

                        obj.Add(objProperties[j], values[j]);
                    }

                    array.Add(obj);
                }
            }
            catch (Exception ex)
            {
                
            }

            return JsonConvert.DeserializeObject<T>(array.ToString());
        }
        private string[] GetCSVHeader(char seperator, string line)
        {
            return line.Split(seperator);
        }

        private void LoadQuestionsBtn_Click(object sender, EventArgs e)
        {
            LoadQuestionsFromFile();
        }
        private void ImportQuestions(bool isCheckingOnly)
        {
            if (dg.Rows == null || dg.Rows.Count == 0)
                return;

            Cursor.Current = Cursors.WaitCursor;

            //this.dg.DisplayLayout.Bands[0].Columns["Result"].Hidden = false;

            this.dg.CurrentCell = null;
            bnds.EndEdit();
            try
            {
                List<QuestionList> entries = (List<QuestionList>)bnds.DataSource;
               
            }
            catch (Exception ex)
            {
                //sf.Logs.ErrorNotification(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void exportQuestionsbtn_Click(object sender, EventArgs e)
        {
            ImportQuestions(false);
        }
    }
}
