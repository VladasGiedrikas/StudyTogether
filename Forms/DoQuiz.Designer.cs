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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.answer3 = new System.Windows.Forms.RadioButton();
            this.hintLabel = new System.Windows.Forms.Label();
            this.hintBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.answer4 = new System.Windows.Forms.RadioButton();
            this.previousBtn = new System.Windows.Forms.Button();
            this.labelFinish = new System.Windows.Forms.Label();
            this.finishBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answer1
            // 
            this.answer1.AutoSize = true;
            this.answer1.Location = new System.Drawing.Point(521, 190);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(75, 21);
            this.answer1.TabIndex = 0;
            this.answer1.TabStop = true;
            this.answer1.Text = "Answer";
            this.answer1.UseVisualStyleBackColor = true;
            this.answer1.CheckedChanged += new System.EventHandler(this.answer_CheckedChanged);
            // 
            // answer2
            // 
            this.answer2.AutoSize = true;
            this.answer2.Location = new System.Drawing.Point(521, 230);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(75, 21);
            this.answer2.TabIndex = 1;
            this.answer2.TabStop = true;
            this.answer2.Text = "Answer";
            this.answer2.UseVisualStyleBackColor = true;
            this.answer2.CheckedChanged += new System.EventHandler(this.answer_CheckedChanged);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(518, 153);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(46, 17);
            this.labelQuestion.TabIndex = 3;
            this.labelQuestion.Text = "label2";
            // 
            // answer3
            // 
            this.answer3.AutoSize = true;
            this.answer3.Location = new System.Drawing.Point(521, 273);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(75, 21);
            this.answer3.TabIndex = 4;
            this.answer3.TabStop = true;
            this.answer3.Text = "Answer";
            this.answer3.UseVisualStyleBackColor = true;
            this.answer3.CheckedChanged += new System.EventHandler(this.answer_CheckedChanged);
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
            this.hintBtn.Location = new System.Drawing.Point(572, 404);
            this.hintBtn.Name = "hintBtn";
            this.hintBtn.Size = new System.Drawing.Size(135, 38);
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
            this.answer4.Location = new System.Drawing.Point(521, 311);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(75, 21);
            this.answer4.TabIndex = 8;
            this.answer4.TabStop = true;
            this.answer4.Text = "Answer";
            this.answer4.UseVisualStyleBackColor = true;
            this.answer4.CheckedChanged += new System.EventHandler(this.answer_CheckedChanged);
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(354, 404);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(179, 38);
            this.previousBtn.TabIndex = 9;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // labelFinish
            // 
            this.labelFinish.AutoSize = true;
            this.labelFinish.Location = new System.Drawing.Point(518, 354);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(53, 17);
            this.labelFinish.TabIndex = 10;
            this.labelFinish.Text = "Finish?";
            // 
            // finishBtn
            // 
            this.finishBtn.Location = new System.Drawing.Point(521, 543);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(179, 36);
            this.finishBtn.TabIndex = 11;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // DoQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 664);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.labelFinish);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.hintBtn);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.labelQuestion);
            this.Name = "DoQuiz";
            this.Text = "DoQuiz";
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
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.Button finishBtn;
    }
}