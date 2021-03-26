
namespace StrongaGlownaUI
{
    partial class LogowanieUC
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
            this.loginLogowanieUCLabel = new System.Windows.Forms.Label();
            this.hasloLogowanieUCLabel = new System.Windows.Forms.Label();
            this.loginLogowaniueUCValue = new System.Windows.Forms.TextBox();
            this.hasloLogowanieUCValue = new System.Windows.Forms.TextBox();
            this.zalogujLogowanieUCButton = new System.Windows.Forms.Button();
            this.pokazHasloLogowanieCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loginLogowanieUCLabel
            // 
            this.loginLogowanieUCLabel.AutoSize = true;
            this.loginLogowanieUCLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLogowanieUCLabel.Location = new System.Drawing.Point(22, 37);
            this.loginLogowanieUCLabel.Name = "loginLogowanieUCLabel";
            this.loginLogowanieUCLabel.Size = new System.Drawing.Size(46, 16);
            this.loginLogowanieUCLabel.TabIndex = 1;
            this.loginLogowanieUCLabel.Text = "Login:";
            // 
            // hasloLogowanieUCLabel
            // 
            this.hasloLogowanieUCLabel.AutoSize = true;
            this.hasloLogowanieUCLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasloLogowanieUCLabel.Location = new System.Drawing.Point(22, 119);
            this.hasloLogowanieUCLabel.Name = "hasloLogowanieUCLabel";
            this.hasloLogowanieUCLabel.Size = new System.Drawing.Size(48, 16);
            this.hasloLogowanieUCLabel.TabIndex = 2;
            this.hasloLogowanieUCLabel.Text = "Hasło:";
            // 
            // loginLogowaniueUCValue
            // 
            this.loginLogowaniueUCValue.Location = new System.Drawing.Point(118, 37);
            this.loginLogowaniueUCValue.Name = "loginLogowaniueUCValue";
            this.loginLogowaniueUCValue.Size = new System.Drawing.Size(273, 20);
            this.loginLogowaniueUCValue.TabIndex = 8;
            // 
            // hasloLogowanieUCValue
            // 
            this.hasloLogowanieUCValue.Location = new System.Drawing.Point(118, 119);
            this.hasloLogowanieUCValue.Name = "hasloLogowanieUCValue";
            this.hasloLogowanieUCValue.Size = new System.Drawing.Size(273, 20);
            this.hasloLogowanieUCValue.TabIndex = 9;
            this.hasloLogowanieUCValue.UseSystemPasswordChar = true;
            // 
            // zalogujLogowanieUCButton
            // 
            this.zalogujLogowanieUCButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.zalogujLogowanieUCButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zalogujLogowanieUCButton.ForeColor = System.Drawing.SystemColors.Control;
            this.zalogujLogowanieUCButton.Location = new System.Drawing.Point(260, 265);
            this.zalogujLogowanieUCButton.Name = "zalogujLogowanieUCButton";
            this.zalogujLogowanieUCButton.Size = new System.Drawing.Size(131, 51);
            this.zalogujLogowanieUCButton.TabIndex = 19;
            this.zalogujLogowanieUCButton.Text = "Zaloguj";
            this.zalogujLogowanieUCButton.UseVisualStyleBackColor = false;
            this.zalogujLogowanieUCButton.Click += new System.EventHandler(this.zalogujLogowanieUCButton_Click);
            // 
            // pokazHasloLogowanieCheckBox
            // 
            this.pokazHasloLogowanieCheckBox.AutoSize = true;
            this.pokazHasloLogowanieCheckBox.Location = new System.Drawing.Point(305, 163);
            this.pokazHasloLogowanieCheckBox.Name = "pokazHasloLogowanieCheckBox";
            this.pokazHasloLogowanieCheckBox.Size = new System.Drawing.Size(86, 17);
            this.pokazHasloLogowanieCheckBox.TabIndex = 21;
            this.pokazHasloLogowanieCheckBox.Text = "Pokaż hasło";
            this.pokazHasloLogowanieCheckBox.UseVisualStyleBackColor = true;
            this.pokazHasloLogowanieCheckBox.CheckedChanged += new System.EventHandler(this.pokazHasloLogowanieCheckBox_CheckedChanged);
            // 
            // LogowanieUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pokazHasloLogowanieCheckBox);
            this.Controls.Add(this.zalogujLogowanieUCButton);
            this.Controls.Add(this.hasloLogowanieUCValue);
            this.Controls.Add(this.loginLogowaniueUCValue);
            this.Controls.Add(this.hasloLogowanieUCLabel);
            this.Controls.Add(this.loginLogowanieUCLabel);
            this.Name = "LogowanieUC";
            this.Size = new System.Drawing.Size(430, 360);
            this.Load += new System.EventHandler(this.LogowanieUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLogowanieUCLabel;
        private System.Windows.Forms.Label hasloLogowanieUCLabel;
        private System.Windows.Forms.TextBox loginLogowaniueUCValue;
        private System.Windows.Forms.TextBox hasloLogowanieUCValue;
        private System.Windows.Forms.Button zalogujLogowanieUCButton;
        private System.Windows.Forms.CheckBox pokazHasloLogowanieCheckBox;
    }
}
