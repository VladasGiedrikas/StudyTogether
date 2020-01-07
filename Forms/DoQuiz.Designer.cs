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
            this.answer1 = new System.Windows.Forms.RadioButton();
            this.answer2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.answer3 = new System.Windows.Forms.RadioButton();
            this.hintLabel = new System.Windows.Forms.Label();
            this.hintBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.answer4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // answer1
            // 
            this.answer1.AutoSize = true;
            this.answer1.Location = new System.Drawing.Point(572, 204);
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
            this.answer2.Location = new System.Drawing.Point(572, 244);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(75, 21);
            this.answer2.TabIndex = 1;
            this.answer2.TabStop = true;
            this.answer2.Text = "Answer";
            this.answer2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Klausimas";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(605, 162);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(46, 17);
            this.labelQuestion.TabIndex = 3;
            this.labelQuestion.Text = "label2";
            // 
            // answer3
            // 
            this.answer3.AutoSize = true;
            this.answer3.Location = new System.Drawing.Point(572, 287);
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
            this.hintLabel.Location = new System.Drawing.Point(573, 457);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(33, 17);
            this.hintLabel.TabIndex = 5;
            this.hintLabel.Text = "Hint";
            // 
            // hintBtn
            // 
            this.hintBtn.Location = new System.Drawing.Point(576, 404);
            this.hintBtn.Name = "hintBtn";
            this.hintBtn.Size = new System.Drawing.Size(112, 28);
            this.hintBtn.TabIndex = 6;
            this.hintBtn.Text = "ShowHint";
            this.hintBtn.UseVisualStyleBackColor = true;
            this.hintBtn.Click += new System.EventHandler(this.hintBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(754, 404);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(179, 38);
            this.nextBtn.TabIndex = 7;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // answer4
            // 
            this.answer4.AutoSize = true;
            this.answer4.Location = new System.Drawing.Point(572, 325);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(75, 21);
            this.answer4.TabIndex = 8;
            this.answer4.TabStop = true;
            this.answer4.Text = "Answer";
            this.answer4.UseVisualStyleBackColor = true;
            // 
            // DoQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 792);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.hintBtn);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Name = "DoQuiz";
            this.Text = "DoQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton answer1;
        private System.Windows.Forms.RadioButton answer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.RadioButton answer3;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Button hintBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.RadioButton answer4;
    }
}