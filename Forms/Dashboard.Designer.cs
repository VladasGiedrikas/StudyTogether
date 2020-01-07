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
            this.button1 = new System.Windows.Forms.Button();
            this.PaskaitacomboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dg = new System.Windows.Forms.DataGridView();
            this.LoadQuestionsBtn = new System.Windows.Forms.Button();
            this.exportQuestionsbtn = new System.Windows.Forms.Button();
            this.questionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionMainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corectAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incorectFirstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incorectSecondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incorectThirdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnds = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnds)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1193, 150);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start the Quiz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaskaitacomboBox
            // 
            this.PaskaitacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaskaitacomboBox.FormattingEnabled = true;
            this.PaskaitacomboBox.Location = new System.Drawing.Point(116, 12);
            this.PaskaitacomboBox.Name = "PaskaitacomboBox";
            this.PaskaitacomboBox.Size = new System.Drawing.Size(257, 24);
            this.PaskaitacomboBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(448, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(538, 204);
            this.dataGridView1.TabIndex = 2;
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
            this.questionIdDataGridViewTextBoxColumn,
            this.questionMainDataGridViewTextBoxColumn,
            this.corectAnswerDataGridViewTextBoxColumn,
            this.incorectFirstDataGridViewTextBoxColumn,
            this.incorectSecondDataGridViewTextBoxColumn,
            this.incorectThirdDataGridViewTextBoxColumn,
            this.hintDataGridViewTextBoxColumn});
            this.dg.DataSource = this.bnds;
            this.dg.Location = new System.Drawing.Point(26, 258);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 51;
            this.dg.RowTemplate.Height = 24;
            this.dg.Size = new System.Drawing.Size(1354, 391);
            this.dg.TabIndex = 4;
            // 
            // LoadQuestionsBtn
            // 
            this.LoadQuestionsBtn.Location = new System.Drawing.Point(1193, 672);
            this.LoadQuestionsBtn.Name = "LoadQuestionsBtn";
            this.LoadQuestionsBtn.Size = new System.Drawing.Size(187, 62);
            this.LoadQuestionsBtn.TabIndex = 5;
            this.LoadQuestionsBtn.Text = "Load Questions From File";
            this.LoadQuestionsBtn.UseVisualStyleBackColor = true;
            this.LoadQuestionsBtn.Click += new System.EventHandler(this.LoadQuestionsBtn_Click);
            // 
            // exportQuestionsbtn
            // 
            this.exportQuestionsbtn.Location = new System.Drawing.Point(764, 672);
            this.exportQuestionsbtn.Name = "exportQuestionsbtn";
            this.exportQuestionsbtn.Size = new System.Drawing.Size(175, 62);
            this.exportQuestionsbtn.TabIndex = 6;
            this.exportQuestionsbtn.Text = "Export to database";
            this.exportQuestionsbtn.UseVisualStyleBackColor = true;
            this.exportQuestionsbtn.Click += new System.EventHandler(this.exportQuestionsbtn_Click);
            // 
            // questionIdDataGridViewTextBoxColumn
            // 
            this.questionIdDataGridViewTextBoxColumn.DataPropertyName = "QuestionId";
            this.questionIdDataGridViewTextBoxColumn.HeaderText = "QuestionId";
            this.questionIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.questionIdDataGridViewTextBoxColumn.Name = "questionIdDataGridViewTextBoxColumn";
            this.questionIdDataGridViewTextBoxColumn.Width = 125;
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
            // bnds
            // 
            this.bnds.DataSource = typeof(StudyTogether.Models.QuestionList);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 753);
            this.Controls.Add(this.exportQuestionsbtn);
            this.Controls.Add(this.LoadQuestionsBtn);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PaskaitacomboBox);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox PaskaitacomboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource bnds;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button LoadQuestionsBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionMainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corectAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incorectFirstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incorectSecondDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incorectThirdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hintDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button exportQuestionsbtn;
    }
}