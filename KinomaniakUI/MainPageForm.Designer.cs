
namespace StrongaGlownaUI
{
    partial class MainPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuSkokPanel = new System.Windows.Forms.Panel();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.searchRateButton = new System.Windows.Forms.Button();
            this.quizButton = new System.Windows.Forms.Button();
            this.topRatedButton = new System.Windows.Forms.Button();
            this.mainPageButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.quizUC = new StrongaGlownaUI.QuizUC();
            this.searchRateUC = new StrongaGlownaUI.SearchRateUC();
            this.addMovieUC = new StrongaGlownaUI.AddMovieUC();
            this.topRatedUC = new StrongaGlownaUI.RankingUC();
            this.mainPageUC = new StrongaGlownaUI.MainPageUC();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.menuSkokPanel);
            this.panel1.Controls.Add(this.addMovieButton);
            this.panel1.Controls.Add(this.searchRateButton);
            this.panel1.Controls.Add(this.quizButton);
            this.panel1.Controls.Add(this.topRatedButton);
            this.panel1.Controls.Add(this.mainPageButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 538);
            this.panel1.TabIndex = 0;

            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.DimGray;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(0, 424);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(163, 55);
            this.logOutButton.TabIndex = 6;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkRed;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(0, 476);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(163, 55);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuSkokPanel
            // 
            this.menuSkokPanel.BackColor = System.Drawing.Color.Silver;
            this.menuSkokPanel.Location = new System.Drawing.Point(0, 41);
            this.menuSkokPanel.Name = "menuSkokPanel";
            this.menuSkokPanel.Size = new System.Drawing.Size(14, 55);
            this.menuSkokPanel.TabIndex = 4;

            // 
            // addMovieButton
            // 
            this.addMovieButton.FlatAppearance.BorderSize = 0;
            this.addMovieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMovieButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovieButton.ForeColor = System.Drawing.Color.White;
            this.addMovieButton.Location = new System.Drawing.Point(3, 285);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(163, 55);
            this.addMovieButton.TabIndex = 4;
            this.addMovieButton.Text = "Add movie";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // searchRateButton
            // 
            this.searchRateButton.FlatAppearance.BorderSize = 0;
            this.searchRateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchRateButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRateButton.ForeColor = System.Drawing.Color.White;
            this.searchRateButton.Location = new System.Drawing.Point(0, 224);
            this.searchRateButton.Name = "searchRateButton";
            this.searchRateButton.Size = new System.Drawing.Size(163, 55);
            this.searchRateButton.TabIndex = 3;
            this.searchRateButton.Text = "Search/Rate";
            this.searchRateButton.UseVisualStyleBackColor = true;
            this.searchRateButton.Click += new System.EventHandler(this.searchRateUCButton_Click);
            // 
            // quizButton
            // 
            this.quizButton.FlatAppearance.BorderSize = 0;
            this.quizButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quizButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizButton.ForeColor = System.Drawing.Color.White;
            this.quizButton.Location = new System.Drawing.Point(0, 163);
            this.quizButton.Name = "quizButton";
            this.quizButton.Size = new System.Drawing.Size(163, 55);
            this.quizButton.TabIndex = 2;
            this.quizButton.Text = "Quiz";
            this.quizButton.UseVisualStyleBackColor = true;
            this.quizButton.Click += new System.EventHandler(this.quizButton_Click);
            // 
            // topRatedButton
            // 
            this.topRatedButton.FlatAppearance.BorderSize = 0;
            this.topRatedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topRatedButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topRatedButton.ForeColor = System.Drawing.Color.White;
            this.topRatedButton.Location = new System.Drawing.Point(0, 102);
            this.topRatedButton.Name = "topRatedButton";
            this.topRatedButton.Size = new System.Drawing.Size(163, 55);
            this.topRatedButton.TabIndex = 1;
            this.topRatedButton.Text = "Top Rated";
            this.topRatedButton.UseVisualStyleBackColor = true;
            this.topRatedButton.Click += new System.EventHandler(this.topRatedButton_Click);
            // 
            // mainPageButton
            // 
            this.mainPageButton.FlatAppearance.BorderSize = 0;
            this.mainPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainPageButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPageButton.ForeColor = System.Drawing.Color.White;
            this.mainPageButton.Location = new System.Drawing.Point(0, 41);
            this.mainPageButton.Name = "mainPageButton";
            this.mainPageButton.Size = new System.Drawing.Size(163, 55);
            this.mainPageButton.TabIndex = 0;
            this.mainPageButton.Text = "Main Page";
            this.mainPageButton.UseVisualStyleBackColor = true;
            this.mainPageButton.Click += new System.EventHandler(this.stronaGlownaButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 18);
            this.panel2.TabIndex = 1;

            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(230, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(105, 99);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(-4, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CINEPHILE";

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(0, -5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 25);
            this.panel4.TabIndex = 3;

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(590, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Welcome";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(662, 21);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(71, 16);
            this.userNameLabel.TabIndex = 10;
            this.userNameLabel.Text = "userName";
            // 
            // quizUC
            // 
            this.quizUC.Id = 0;
            this.quizUC.Location = new System.Drawing.Point(163, 117);
            this.quizUC.Name = "quizUC";
            this.quizUC.Size = new System.Drawing.Size(641, 412);
            this.quizUC.TabIndex = 12;
            // 
            // searchRateUC
            // 
            this.searchRateUC.Id = 0;
            this.searchRateUC.Location = new System.Drawing.Point(163, 117);
            this.searchRateUC.Name = "searchRateUC";
            this.searchRateUC.Size = new System.Drawing.Size(641, 412);
            this.searchRateUC.TabIndex = 11;
            // 
            // addMovieUC
            // 
            this.addMovieUC.Location = new System.Drawing.Point(163, 117);
            this.addMovieUC.Name = "addMovieUC";
            this.addMovieUC.Size = new System.Drawing.Size(641, 412);
            this.addMovieUC.TabIndex = 7;

            // 
            // topRatedUC
            // 
            this.topRatedUC.BackColor = System.Drawing.SystemColors.Control;
            this.topRatedUC.Location = new System.Drawing.Point(163, 117);
            this.topRatedUC.Name = "topRatedUC";
            this.topRatedUC.Size = new System.Drawing.Size(641, 414);
            this.topRatedUC.TabIndex = 4;
            // 
            // mainPageUC
            // 
            this.mainPageUC.Id = 0;
            this.mainPageUC.Location = new System.Drawing.Point(163, 117);
            this.mainPageUC.Name = "mainPageUC";
            this.mainPageUC.Size = new System.Drawing.Size(641, 412);
            this.mainPageUC.TabIndex = 3;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 531);
            this.Controls.Add(this.quizUC);
            this.Controls.Add(this.searchRateUC);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.addMovieUC);
            this.Controls.Add(this.topRatedUC);
            this.Controls.Add(this.mainPageUC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";

            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mainPageButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.Button searchRateButton;
        private System.Windows.Forms.Button quizButton;
        private System.Windows.Forms.Button topRatedButton;
        private MainPageUC mainPageUC;
        private System.Windows.Forms.Panel menuSkokPanel;
        private RankingUC topRatedUC;
        private AddMovieUC addMovieUC;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label userNameLabel;
        private SearchRateUC searchRateUC;
        private QuizUC quizUC;
    }
}

