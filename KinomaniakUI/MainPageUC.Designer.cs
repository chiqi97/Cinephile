
namespace StrongaGlownaUI
{
    partial class MainPageUC
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
            this.topPicksForYouLabel = new System.Windows.Forms.Label();
            this.najlepiejOcenianeLabel = new System.Windows.Forms.Label();
            this.topPicksListBox = new System.Windows.Forms.ListBox();
            this.trendingNowListBox = new System.Windows.Forms.ListBox();
            this.nowosciLabel = new System.Windows.Forms.Label();
            this.newRealeasesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // topPicksForYouLabel
            // 
            this.topPicksForYouLabel.AutoSize = true;
            this.topPicksForYouLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPicksForYouLabel.Location = new System.Drawing.Point(41, 8);
            this.topPicksForYouLabel.Name = "topPicksForYouLabel";
            this.topPicksForYouLabel.Size = new System.Drawing.Size(141, 21);
            this.topPicksForYouLabel.TabIndex = 0;
            this.topPicksForYouLabel.Text = "Top Picks for you:";
            // 
            // najlepiejOcenianeLabel
            // 
            this.najlepiejOcenianeLabel.AutoSize = true;
            this.najlepiejOcenianeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.najlepiejOcenianeLabel.Location = new System.Drawing.Point(41, 143);
            this.najlepiejOcenianeLabel.Name = "najlepiejOcenianeLabel";
            this.najlepiejOcenianeLabel.Size = new System.Drawing.Size(122, 21);
            this.najlepiejOcenianeLabel.TabIndex = 1;
            this.najlepiejOcenianeLabel.Text = "Trending Now:";
            // 
            // topPicksListBox
            // 
            this.topPicksListBox.FormattingEnabled = true;
            this.topPicksListBox.Location = new System.Drawing.Point(45, 32);
            this.topPicksListBox.Name = "topPicksListBox";
            this.topPicksListBox.Size = new System.Drawing.Size(519, 108);
            this.topPicksListBox.TabIndex = 2;
            this.topPicksListBox.SelectedIndexChanged += new System.EventHandler(this.topPicksListBox_SelectedIndexChanged);
            // 
            // trendingNowListBox
            // 
            this.trendingNowListBox.FormattingEnabled = true;
            this.trendingNowListBox.Location = new System.Drawing.Point(45, 167);
            this.trendingNowListBox.Name = "trendingNowListBox";
            this.trendingNowListBox.Size = new System.Drawing.Size(519, 108);
            this.trendingNowListBox.TabIndex = 3;
            this.trendingNowListBox.SelectedIndexChanged += new System.EventHandler(this.trendingNowListBox_SelectedIndexChanged);
            // 
            // nowosciLabel
            // 
            this.nowosciLabel.AutoSize = true;
            this.nowosciLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowosciLabel.Location = new System.Drawing.Point(41, 278);
            this.nowosciLabel.Name = "nowosciLabel";
            this.nowosciLabel.Size = new System.Drawing.Size(133, 21);
            this.nowosciLabel.TabIndex = 4;
            this.nowosciLabel.Text = "New Realeases:";
            // 
            // newRealeasesListBox
            // 
            this.newRealeasesListBox.FormattingEnabled = true;
            this.newRealeasesListBox.Location = new System.Drawing.Point(45, 302);
            this.newRealeasesListBox.Name = "newRealeasesListBox";
            this.newRealeasesListBox.Size = new System.Drawing.Size(519, 108);
            this.newRealeasesListBox.TabIndex = 5;
            // 
            // MainPageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newRealeasesListBox);
            this.Controls.Add(this.nowosciLabel);
            this.Controls.Add(this.trendingNowListBox);
            this.Controls.Add(this.topPicksListBox);
            this.Controls.Add(this.najlepiejOcenianeLabel);
            this.Controls.Add(this.topPicksForYouLabel);
            this.Name = "MainPageUC";
            this.Size = new System.Drawing.Size(663, 412);
            this.Load += new System.EventHandler(this.MainPageUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topPicksForYouLabel;
        private System.Windows.Forms.Label najlepiejOcenianeLabel;
        private System.Windows.Forms.ListBox topPicksListBox;
        private System.Windows.Forms.ListBox trendingNowListBox;
        private System.Windows.Forms.Label nowosciLabel;
        private System.Windows.Forms.ListBox newRealeasesListBox;
    }
}
