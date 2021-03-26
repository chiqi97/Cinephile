
using System.Drawing;
using System.Windows.Forms;

namespace StrongaGlownaUI
{
    partial class QuizUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.question = new System.Windows.Forms.Label();
            this.drawQuestionButton = new System.Windows.Forms.Button();
            this.drawMovieButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.quizResultLabel = new System.Windows.Forms.Label();
            this.answer1 = new System.Windows.Forms.RadioButton();
            this.answer2 = new System.Windows.Forms.RadioButton();
            this.answer3 = new System.Windows.Forms.RadioButton();
            this.answer4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.Location = new System.Drawing.Point(20, 11);
            this.question.MaximumSize = new System.Drawing.Size(650, 0);
            this.question.Name = "question";
            this.question.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.question.Size = new System.Drawing.Size(72, 18);
            this.question.TabIndex = 0;
            this.question.Text = "Question:";
            // 
            // drawQuestionButton
            // 
            this.drawQuestionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drawQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawQuestionButton.ForeColor = System.Drawing.SystemColors.Control;
            this.drawQuestionButton.Location = new System.Drawing.Point(23, 257);
            this.drawQuestionButton.Name = "drawQuestionButton";
            this.drawQuestionButton.Size = new System.Drawing.Size(116, 49);
            this.drawQuestionButton.TabIndex = 6;
            this.drawQuestionButton.Text = "Draw Question";
            this.drawQuestionButton.UseVisualStyleBackColor = false;
            this.drawQuestionButton.Click += new System.EventHandler(this.drawQuiz_Click);
            // 
            // drawMovieButton
            // 
            this.drawMovieButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drawMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawMovieButton.ForeColor = System.Drawing.SystemColors.Control;
            this.drawMovieButton.Location = new System.Drawing.Point(478, 257);
            this.drawMovieButton.Name = "drawMovieButton";
            this.drawMovieButton.Size = new System.Drawing.Size(116, 49);
            this.drawMovieButton.TabIndex = 7;
            this.drawMovieButton.Text = "Draw Movie";
            this.drawMovieButton.UseVisualStyleBackColor = false;
            this.drawMovieButton.Click += new System.EventHandler(this.drawMovieButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Movie for you:";
            // 
            // quizResultLabel
            // 
            this.quizResultLabel.AutoSize = true;
            this.quizResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizResultLabel.Location = new System.Drawing.Point(187, 351);
            this.quizResultLabel.Name = "quizResultLabel";
            this.quizResultLabel.Size = new System.Drawing.Size(102, 20);
            this.quizResultLabel.TabIndex = 9;
            this.quizResultLabel.Text = "Quiz Result";
            // 
            // answer1
            // 
            this.answer1.AutoSize = true;
            this.answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer1.Location = new System.Drawing.Point(23, 55);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(35, 22);
            this.answer1.TabIndex = 11;
            this.answer1.TabStop = true;
            this.answer1.Text = "A";
            this.answer1.UseVisualStyleBackColor = true;
            // 
            // answer2
            // 
            this.answer2.AutoSize = true;
            this.answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer2.Location = new System.Drawing.Point(23, 104);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(36, 22);
            this.answer2.TabIndex = 12;
            this.answer2.TabStop = true;
            this.answer2.Text = "B";
            this.answer2.UseVisualStyleBackColor = true;
            // 
            // answer3
            // 
            this.answer3.AutoSize = true;
            this.answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer3.Location = new System.Drawing.Point(23, 157);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(37, 22);
            this.answer3.TabIndex = 13;
            this.answer3.TabStop = true;
            this.answer3.Text = "C";
            this.answer3.UseVisualStyleBackColor = true;
            // 
            // answer4
            // 
            this.answer4.AutoSize = true;
            this.answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer4.Location = new System.Drawing.Point(23, 206);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(37, 22);
            this.answer4.TabIndex = 14;
            this.answer4.TabStop = true;
            this.answer4.Text = "D";
            this.answer4.UseVisualStyleBackColor = true;
            // 
            // QuizUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.quizResultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawMovieButton);
            this.Controls.Add(this.drawQuestionButton);
            this.Controls.Add(this.question);
            this.Name = "QuizUC";
            this.Size = new System.Drawing.Size(641, 412);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button drawQuestionButton;
        private System.Windows.Forms.Button drawMovieButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quizResultLabel;
        private RadioButton answer1;
        private RadioButton answer2;
        private RadioButton answer3;
        private RadioButton answer4;
    }
}
