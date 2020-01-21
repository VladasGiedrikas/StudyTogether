namespace StudyTogether
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.showAllQuiz = new System.Windows.Forms.Button();
            this.PaskaitacomboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dg = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionMainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corectAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incorectFirstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incorectSecondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incorectThirdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnds = new System.Windows.Forms.BindingSource(this.components);
            this.LoadQuestionsBtn = new System.Windows.Forms.Button();
            this.exportQuestionsbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCreateNew = new System.Windows.Forms.Button();
            this.buttonAddRow = new System.Windows.Forms.Button();
            this.textBoxQuizName = new System.Windows.Forms.TextBox();
            this.labelTestName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnds)).BeginInit();
            this.SuspendLayout();
            // 
            // showAllQuiz
            // 
            this.showAllQuiz.Location = new System.Drawing.Point(1161, 72);
            this.showAllQuiz.Margin = new System.Windows.Forms.Padding(4);
            this.showAllQuiz.Name = "showAllQuiz";
            this.showAllQuiz.Size = new System.Drawing.Size(247, 59);
            this.showAllQuiz.TabIndex = 0;
            this.showAllQuiz.Text = "Rodyti visus Testus";
            this.showAllQuiz.UseVisualStyleBackColor = true;
            this.showAllQuiz.Click += new System.EventHandler(this.ShowAllQuiz_Click);
            // 
            // PaskaitacomboBox
            // 
            this.PaskaitacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaskaitacomboBox.FormattingEnabled = true;
            this.PaskaitacomboBox.Location = new System.Drawing.Point(209, 127);
            this.PaskaitacomboBox.Name = "PaskaitacomboBox";
            this.PaskaitacomboBox.Size = new System.Drawing.Size(257, 24);
            this.PaskaitacomboBox.TabIndex = 1;
            this.PaskaitacomboBox.SelectionChangeCommitted += new System.EventHandler(this.PaskaitacomboBox_SelectionChangeCommitted);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // dg
            // 
            this.dg.AutoGenerateColumns = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.questionNumberDataGridViewTextBoxColumn,
            this.questionMainDataGridViewTextBoxColumn,
            this.corectAnswerDataGridViewTextBoxColumn,
            this.incorectFirstDataGridViewTextBoxColumn,
            this.incorectSecondDataGridViewTextBoxColumn,
            this.incorectThirdDataGridViewTextBoxColumn,
            this.hintDataGridViewTextBoxColumn,
            this.quizNumberDataGridViewTextBoxColumn});
            this.dg.DataSource = this.bnds;
            this.dg.Location = new System.Drawing.Point(54, 168);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 51;
            this.dg.RowTemplate.Height = 24;
            this.dg.Size = new System.Drawing.Size(1354, 391);
            this.dg.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "QuestionId";
            this.dataGridViewTextBoxColumn1.HeaderText = "QuestionId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // questionNumberDataGridViewTextBoxColumn
            // 
            this.questionNumberDataGridViewTextBoxColumn.DataPropertyName = "QuestionNumber";
            this.questionNumberDataGridViewTextBoxColumn.HeaderText = "QuestionNumber";
            this.questionNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.questionNumberDataGridViewTextBoxColumn.Name = "questionNumberDataGridViewTextBoxColumn";
            this.questionNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // questionMainDataGridViewTextBoxColumn
            // 
            this.questionMainDataGridViewTextBoxColumn.DataPropertyName = "QuestionMain";
            this.questionMainDataGridViewTextBoxColumn.HeaderText = "QuestionMain";
            this.questionMainDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.questionMainDataGridViewTextBoxColumn.Name = "questionMainDataGridViewTextBoxColumn";
            this.questionMainDataGridViewTextBoxColumn.Width = 125;
            // 
            // corectAnswerDataGridViewTextBoxColumn
            // 
            this.corectAnswerDataGridViewTextBoxColumn.DataPropertyName = "CorectAnswer";
            this.corectAnswerDataGridViewTextBoxColumn.HeaderText = "CorectAnswer";
            this.corectAnswerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.corectAnswerDataGridViewTextBoxColumn.Name = "corectAnswerDataGridViewTextBoxColumn";
            this.corectAnswerDataGridViewTextBoxColumn.Width = 125;
            // 
            // incorectFirstDataGridViewTextBoxColumn
            // 
            this.incorectFirstDataGridViewTextBoxColumn.DataPropertyName = "IncorectFirst";
            this.incorectFirstDataGridViewTextBoxColumn.HeaderText = "IncorectFirst";
            this.incorectFirstDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incorectFirstDataGridViewTextBoxColumn.Name = "incorectFirstDataGridViewTextBoxColumn";
            this.incorectFirstDataGridViewTextBoxColumn.Width = 125;
            // 
            // incorectSecondDataGridViewTextBoxColumn
            // 
            this.incorectSecondDataGridViewTextBoxColumn.DataPropertyName = "IncorectSecond";
            this.incorectSecondDataGridViewTextBoxColumn.HeaderText = "IncorectSecond";
            this.incorectSecondDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incorectSecondDataGridViewTextBoxColumn.Name = "incorectSecondDataGridViewTextBoxColumn";
            this.incorectSecondDataGridViewTextBoxColumn.Width = 125;
            // 
            // incorectThirdDataGridViewTextBoxColumn
            // 
            this.incorectThirdDataGridViewTextBoxColumn.DataPropertyName = "IncorectThird";
            this.incorectThirdDataGridViewTextBoxColumn.HeaderText = "IncorectThird";
            this.incorectThirdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incorectThirdDataGridViewTextBoxColumn.Name = "incorectThirdDataGridViewTextBoxColumn";
            this.incorectThirdDataGridViewTextBoxColumn.Width = 125;
            // 
            // hintDataGridViewTextBoxColumn
            // 
            this.hintDataGridViewTextBoxColumn.DataPropertyName = "Hint";
            this.hintDataGridViewTextBoxColumn.HeaderText = "Hint";
            this.hintDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hintDataGridViewTextBoxColumn.Name = "hintDataGridViewTextBoxColumn";
            this.hintDataGridViewTextBoxColumn.Width = 125;
            // 
            // quizNumberDataGridViewTextBoxColumn
            // 
            this.quizNumberDataGridViewTextBoxColumn.DataPropertyName = "QuizNumber";
            this.quizNumberDataGridViewTextBoxColumn.HeaderText = "QuizNumber";
            this.quizNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quizNumberDataGridViewTextBoxColumn.Name = "quizNumberDataGridViewTextBoxColumn";
            this.quizNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // bnds
            // 
            this.bnds.DataSource = typeof(StudyTogether.Models.Question);
            // 
            // LoadQuestionsBtn
            // 
            this.LoadQuestionsBtn.Location = new System.Drawing.Point(54, 663);
            this.LoadQuestionsBtn.Name = "LoadQuestionsBtn";
            this.LoadQuestionsBtn.Size = new System.Drawing.Size(352, 62);
            this.LoadQuestionsBtn.TabIndex = 5;
            this.LoadQuestionsBtn.Text = "Įkelti naują testą iš failo";
            this.LoadQuestionsBtn.UseVisualStyleBackColor = true;
            this.LoadQuestionsBtn.Click += new System.EventHandler(this.LoadQuestionsBtn_Click);
            // 
            // exportQuestionsbtn
            // 
            this.exportQuestionsbtn.Location = new System.Drawing.Point(1233, 600);
            this.exportQuestionsbtn.Name = "exportQuestionsbtn";
            this.exportQuestionsbtn.Size = new System.Drawing.Size(175, 62);
            this.exportQuestionsbtn.TabIndex = 6;
            this.exportQuestionsbtn.Text = "Išsaugoti duonbazėje";
            this.exportQuestionsbtn.UseVisualStyleBackColor = true;
            this.exportQuestionsbtn.Click += new System.EventHandler(this.ExportQuestionsbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mano Testai";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(236, 584);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(170, 62);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Redaguoti";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCreateNew
            // 
            this.buttonCreateNew.Location = new System.Drawing.Point(54, 584);
            this.buttonCreateNew.Name = "buttonCreateNew";
            this.buttonCreateNew.Size = new System.Drawing.Size(160, 62);
            this.buttonCreateNew.TabIndex = 10;
            this.buttonCreateNew.Text = "Sukurti naują testą";
            this.buttonCreateNew.UseVisualStyleBackColor = true;
            this.buttonCreateNew.Click += new System.EventHandler(this.ButtonCreatenew);
            // 
            // buttonAddRow
            // 
            this.buttonAddRow.Location = new System.Drawing.Point(412, 617);
            this.buttonAddRow.Name = "buttonAddRow";
            this.buttonAddRow.Size = new System.Drawing.Size(195, 29);
            this.buttonAddRow.TabIndex = 11;
            this.buttonAddRow.Text = "Prideti dar vieną eilutę";
            this.buttonAddRow.UseVisualStyleBackColor = true;
            this.buttonAddRow.Visible = false;
            this.buttonAddRow.Click += new System.EventHandler(this.ButtonAddRow_Click);
            // 
            // textBoxQuizName
            // 
            this.textBoxQuizName.Location = new System.Drawing.Point(1022, 643);
            this.textBoxQuizName.Name = "textBoxQuizName";
            this.textBoxQuizName.Size = new System.Drawing.Size(190, 22);
            this.textBoxQuizName.TabIndex = 12;
            // 
            // labelTestName
            // 
            this.labelTestName.AutoSize = true;
            this.labelTestName.Location = new System.Drawing.Point(1037, 617);
            this.labelTestName.Name = "labelTestName";
            this.labelTestName.Size = new System.Drawing.Size(127, 17);
            this.labelTestName.TabIndex = 13;
            this.labelTestName.Text = "Testo pavadinimas";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 753);
            this.Controls.Add(this.labelTestName);
            this.Controls.Add(this.textBoxQuizName);
            this.Controls.Add(this.buttonAddRow);
            this.Controls.Add(this.buttonCreateNew);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportQuestionsbtn);
            this.Controls.Add(this.LoadQuestionsBtn);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.PaskaitacomboBox);
            this.Controls.Add(this.showAllQuiz);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showAllQuiz;
        private System.Windows.Forms.ComboBox PaskaitacomboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource bnds;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button LoadQuestionsBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button exportQuestionsbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionMainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corectAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incorectFirstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incorectSecondDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incorectThirdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quizNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCreateNew;
        private System.Windows.Forms.Button buttonAddRow;
        private System.Windows.Forms.TextBox textBoxQuizName;
        private System.Windows.Forms.Label labelTestName;
    }
}