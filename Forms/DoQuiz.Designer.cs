namespace StudyTogether.Forms
{
    partial class DoQuiz
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
            this.answer1 = new System.Windows.Forms.RadioButton();
            this.answer2 = new System.Windows.Forms.RadioButton();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.answer3 = new System.Windows.Forms.RadioButton();
            this.hintLabel = new System.Windows.Forms.Label();
            this.hintBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.answer4 = new System.Windows.Forms.RadioButton();
            this.labelFinish = new System.Windows.Forms.Label();
            this.finishBtn = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.gradeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradePercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnds = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnds)).BeginInit();
            this.SuspendLayout();
            // 
            // answer1
            // 
            this.answer1.AutoSize = true;
            this.answer1.Location = new System.Drawing.Point(516, 161);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(75, 21);
            this.answer1.TabIndex = 0;
            this.answer1.TabStop = true;
            this.answer1.Text = "Answer";
            this.answer1.UseVisualStyleBackColor = true;
            // 
            // answer2
            // 
            this.answer2.AutoSize = true;
            this.answer2.Location = new System.Drawing.Point(516, 201);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(75, 21);
            this.answer2.TabIndex = 1;
            this.answer2.TabStop = true;
            this.answer2.Text = "Answer";
            this.answer2.UseVisualStyleBackColor = true;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(622, 161);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(46, 17);
            this.labelQuestion.TabIndex = 3;
            this.labelQuestion.Text = "label2";
            // 
            // answer3
            // 
            this.answer3.AutoSize = true;
            this.answer3.Location = new System.Drawing.Point(516, 244);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(75, 21);
            this.answer3.TabIndex = 4;
            this.answer3.TabStop = true;
            this.answer3.Text = "Answer";
            this.answer3.UseVisualStyleBackColor = true;
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(295, 125);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(71, 17);
            this.hintLabel.TabIndex = 5;
            this.hintLabel.Text = "Užuomina";
            // 
            // hintBtn
            // 
            this.hintBtn.Location = new System.Drawing.Point(298, 161);
            this.hintBtn.Name = "hintBtn";
            this.hintBtn.Size = new System.Drawing.Size(135, 38);
            this.hintBtn.TabIndex = 6;
            this.hintBtn.Text = "Rodyti užuomina";
            this.hintBtn.UseVisualStyleBackColor = true;
            this.hintBtn.Click += new System.EventHandler(this.hintBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(86, 161);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(179, 38);
            this.nextBtn.TabIndex = 7;
            this.nextBtn.Text = "Kitas klausimas";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // answer4
            // 
            this.answer4.AutoSize = true;
            this.answer4.Location = new System.Drawing.Point(516, 282);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(75, 21);
            this.answer4.TabIndex = 8;
            this.answer4.TabStop = true;
            this.answer4.Text = "Answer";
            this.answer4.UseVisualStyleBackColor = true;
            // 
            // labelFinish
            // 
            this.labelFinish.AutoSize = true;
            this.labelFinish.Location = new System.Drawing.Point(83, 227);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(53, 17);
            this.labelFinish.TabIndex = 10;
            this.labelFinish.Text = "Finish?";
            // 
            // finishBtn
            // 
            this.finishBtn.Location = new System.Drawing.Point(86, 268);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(347, 36);
            this.finishBtn.TabIndex = 11;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // dg
            // 
            this.dg.AutoGenerateColumns = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gradeIdDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.gradeNumberDataGridViewTextBoxColumn,
            this.gradePercentDataGridViewTextBoxColumn,
            this.dateDoneDataGridViewTextBoxColumn,
            this.quizNumberDataGridViewTextBoxColumn,
            this.studentNumberDataGridViewTextBoxColumn});
            this.dg.DataSource = this.bnds;
            this.dg.Location = new System.Drawing.Point(86, 405);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 51;
            this.dg.RowTemplate.Height = 24;
            this.dg.Size = new System.Drawing.Size(1382, 315);
            this.dg.TabIndex = 12;
            // 
            // gradeIdDataGridViewTextBoxColumn
            // 
            this.gradeIdDataGridViewTextBoxColumn.DataPropertyName = "GradeId";
            this.gradeIdDataGridViewTextBoxColumn.HeaderText = "GradeId";
            this.gradeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradeIdDataGridViewTextBoxColumn.Name = "gradeIdDataGridViewTextBoxColumn";
            this.gradeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // gradeNumberDataGridViewTextBoxColumn
            // 
            this.gradeNumberDataGridViewTextBoxColumn.DataPropertyName = "GradeNumber";
            this.gradeNumberDataGridViewTextBoxColumn.HeaderText = "GradeNumber";
            this.gradeNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradeNumberDataGridViewTextBoxColumn.Name = "gradeNumberDataGridViewTextBoxColumn";
            this.gradeNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // gradePercentDataGridViewTextBoxColumn
            // 
            this.gradePercentDataGridViewTextBoxColumn.DataPropertyName = "GradePercent";
            this.gradePercentDataGridViewTextBoxColumn.HeaderText = "GradePercent";
            this.gradePercentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradePercentDataGridViewTextBoxColumn.Name = "gradePercentDataGridViewTextBoxColumn";
            this.gradePercentDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDoneDataGridViewTextBoxColumn
            // 
            this.dateDoneDataGridViewTextBoxColumn.DataPropertyName = "DateDone";
            this.dateDoneDataGridViewTextBoxColumn.HeaderText = "DateDone";
            this.dateDoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDoneDataGridViewTextBoxColumn.Name = "dateDoneDataGridViewTextBoxColumn";
            this.dateDoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // quizNumberDataGridViewTextBoxColumn
            // 
            this.quizNumberDataGridViewTextBoxColumn.DataPropertyName = "QuizNumber";
            this.quizNumberDataGridViewTextBoxColumn.HeaderText = "QuizNumber";
            this.quizNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quizNumberDataGridViewTextBoxColumn.Name = "quizNumberDataGridViewTextBoxColumn";
            this.quizNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentNumberDataGridViewTextBoxColumn
            // 
            this.studentNumberDataGridViewTextBoxColumn.DataPropertyName = "StudentNumber";
            this.studentNumberDataGridViewTextBoxColumn.HeaderText = "StudentNumber";
            this.studentNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNumberDataGridViewTextBoxColumn.Name = "studentNumberDataGridViewTextBoxColumn";
            this.studentNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // bnds
            // 
            this.bnds.DataSource = typeof(StudyTogether.Models.Grade);
            // 
            // DoQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 745);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.labelFinish);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.hintBtn);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.labelQuestion);
            this.Name = "DoQuiz";
            this.Text = "DoQuiz";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton answer1;
        private System.Windows.Forms.RadioButton answer2;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.RadioButton answer3;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Button hintBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.RadioButton answer4;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradePercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quizNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bnds;
    }
}