
using System.Windows.Forms;

namespace StrongaGlownaUI
{
    partial class RankingUC
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
            this.top100Label = new System.Windows.Forms.Label();
            this.rankingDataGridView = new System.Windows.Forms.DataGridView();
            this.showAllCheckBox = new System.Windows.Forms.CheckBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.alphabeticalOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.miejsceDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rankingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // top100Label
            // 
            this.top100Label.AutoSize = true;
            this.top100Label.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top100Label.Location = new System.Drawing.Point(228, 27);
            this.top100Label.Name = "top100Label";
            this.top100Label.Size = new System.Drawing.Size(150, 21);
            this.top100Label.TabIndex = 0;
            this.top100Label.Text = "Top Rated Movies:";

            // 
            // rankingDataGridView
            // 
            this.rankingDataGridView.ColumnHeadersHeight = 35;
            this.rankingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.miejsceDataGridView});
            this.rankingDataGridView.Location = new System.Drawing.Point(3, 56);
            this.rankingDataGridView.Name = "rankingDataGridView";
            this.rankingDataGridView.Size = new System.Drawing.Size(635, 353);
            this.rankingDataGridView.TabIndex = 2;
          
            // 
            // showAllCheckBox
            // 
            this.showAllCheckBox.AutoSize = true;
            this.showAllCheckBox.Location = new System.Drawing.Point(534, 32);
            this.showAllCheckBox.Name = "showAllCheckBox";
            this.showAllCheckBox.Size = new System.Drawing.Size(102, 17);
            this.showAllCheckBox.TabIndex = 4;
            this.showAllCheckBox.Text = "Show all movies";
            this.showAllCheckBox.UseVisualStyleBackColor = true;

            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refreshButton.ForeColor = System.Drawing.SystemColors.Control;
            this.refreshButton.Location = new System.Drawing.Point(432, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(92, 23);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // alphabeticalOrderCheckBox
            // 
            this.alphabeticalOrderCheckBox.AutoSize = true;
            this.alphabeticalOrderCheckBox.Location = new System.Drawing.Point(534, 9);
            this.alphabeticalOrderCheckBox.Name = "alphabeticalOrderCheckBox";
            this.alphabeticalOrderCheckBox.Size = new System.Drawing.Size(111, 17);
            this.alphabeticalOrderCheckBox.TabIndex = 7;
            this.alphabeticalOrderCheckBox.Text = "Alphabetical order";
            this.alphabeticalOrderCheckBox.UseVisualStyleBackColor = true;
        
            // 
            // miejsceDataGridView
            // 
            this.miejsceDataGridView.HeaderText = "Rank";
            this.miejsceDataGridView.Name = "miejsceDataGridView";
            this.miejsceDataGridView.Width = 60;
            // 
            // RankingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.alphabeticalOrderCheckBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.showAllCheckBox);
            this.Controls.Add(this.rankingDataGridView);
            this.Controls.Add(this.top100Label);
            this.Name = "RankingUC";
            this.Size = new System.Drawing.Size(641, 412);
            ((System.ComponentModel.ISupportInitialize)(this.rankingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label top100Label;
        private System.Windows.Forms.DataGridView rankingDataGridView;
        private CheckBox showAllCheckBox;
        private Button refreshButton;
        private CheckBox alphabeticalOrderCheckBox;
        private DataGridViewTextBoxColumn miejsceDataGridView;
    }
}
