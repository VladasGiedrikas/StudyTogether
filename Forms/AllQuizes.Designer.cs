namespace StudyTogether.Forms
{
    partial class AllQuizes
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.quizIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnds = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnds)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(1150, 497);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(170, 40);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start Quiz";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // dg
            // 
            this.dg.AutoGenerateColumns = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quizIdDataGridViewTextBoxColumn,
            this.quizNameDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn});
            this.dg.DataSource = this.bnds;
            this.dg.Location = new System.Drawing.Point(63, 35);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 51;
            this.dg.RowTemplate.Height = 24;
            this.dg.Size = new System.Drawing.Size(942, 187);
            this.dg.TabIndex = 3;
            this.dg.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_CellMouseClick);
            // 
            // quizIdDataGridViewTextBoxColumn
            // 
            this.quizIdDataGridViewTextBoxColumn.DataPropertyName = "QuizId";
            this.quizIdDataGridViewTextBoxColumn.HeaderText = "QuizId";
            this.quizIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quizIdDataGridViewTextBoxColumn.Name = "quizIdDataGridViewTextBoxColumn";
            this.quizIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // quizNameDataGridViewTextBoxColumn
            // 
            this.quizNameDataGridViewTextBoxColumn.DataPropertyName = "QuizName";
            this.quizNameDataGridViewTextBoxColumn.HeaderText = "QuizName";
            this.quizNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quizNameDataGridViewTextBoxColumn.Name = "quizNameDataGridViewTextBoxColumn";
            this.quizNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.Width = 125;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.ownerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.Width = 125;
            // 
            // bnds
            // 
            this.bnds.DataSource = typeof(StudyTogether.Models.Quiz);
            // 
            // AllQuizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 595);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.buttonStart);
            this.Name = "AllQuizes";
            this.Text = "AllQuizes";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn quizIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quizNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bnds;
    }
}