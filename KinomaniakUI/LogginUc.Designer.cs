
namespace StrongaGlownaUI
{
    partial class LogginUc
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
            this.userNameLoginUCLabel = new System.Windows.Forms.Label();
            this.passwordLoginUCLabel = new System.Windows.Forms.Label();
            this.usernameLogInUCValue = new System.Windows.Forms.TextBox();
            this.passwordLogInUCValue = new System.Windows.Forms.TextBox();
            this.logInLoginUCButton = new System.Windows.Forms.Button();
            this.showPasswordLoginUCCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // userNameLoginUCLabel
            // 
            this.userNameLoginUCLabel.AutoSize = true;
            this.userNameLoginUCLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLoginUCLabel.Location = new System.Drawing.Point(22, 37);
            this.userNameLoginUCLabel.Name = "userNameLoginUCLabel";
            this.userNameLoginUCLabel.Size = new System.Drawing.Size(76, 16);
            this.userNameLoginUCLabel.TabIndex = 1;
            this.userNameLoginUCLabel.Text = "Username:";
            // 
            // passwordLoginUCLabel
            // 
            this.passwordLoginUCLabel.AutoSize = true;
            this.passwordLoginUCLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginUCLabel.Location = new System.Drawing.Point(22, 119);
            this.passwordLoginUCLabel.Name = "passwordLoginUCLabel";
            this.passwordLoginUCLabel.Size = new System.Drawing.Size(72, 16);
            this.passwordLoginUCLabel.TabIndex = 2;
            this.passwordLoginUCLabel.Text = "Password:";
            // 
            // usernameLogInUCValue
            // 
            this.usernameLogInUCValue.Location = new System.Drawing.Point(118, 37);
            this.usernameLogInUCValue.Name = "usernameLogInUCValue";
            this.usernameLogInUCValue.Size = new System.Drawing.Size(273, 20);
            this.usernameLogInUCValue.TabIndex = 8;
            // 
            // passwordLogInUCValue
            // 
            this.passwordLogInUCValue.Location = new System.Drawing.Point(118, 119);
            this.passwordLogInUCValue.Name = "passwordLogInUCValue";
            this.passwordLogInUCValue.Size = new System.Drawing.Size(273, 20);
            this.passwordLogInUCValue.TabIndex = 9;
            this.passwordLogInUCValue.UseSystemPasswordChar = true;
            // 
            // logInLoginUCButton
            // 
            this.logInLoginUCButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logInLoginUCButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLoginUCButton.ForeColor = System.Drawing.SystemColors.Control;
            this.logInLoginUCButton.Location = new System.Drawing.Point(260, 265);
            this.logInLoginUCButton.Name = "logInLoginUCButton";
            this.logInLoginUCButton.Size = new System.Drawing.Size(131, 51);
            this.logInLoginUCButton.TabIndex = 19;
            this.logInLoginUCButton.Text = "Log in";
            this.logInLoginUCButton.UseVisualStyleBackColor = false;
            this.logInLoginUCButton.Click += new System.EventHandler(this.logInLoginUCButton_Click);
            // 
            // showPasswordLoginUCCheckBox
            // 
            this.showPasswordLoginUCCheckBox.AutoSize = true;
            this.showPasswordLoginUCCheckBox.Location = new System.Drawing.Point(305, 163);
            this.showPasswordLoginUCCheckBox.Name = "showPasswordLoginUCCheckBox";
            this.showPasswordLoginUCCheckBox.Size = new System.Drawing.Size(101, 17);
            this.showPasswordLoginUCCheckBox.TabIndex = 21;
            this.showPasswordLoginUCCheckBox.Text = "Show password";
            this.showPasswordLoginUCCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordLoginUCCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordLoginUCCheckBox_CheckedChanged);
            // 
            // LogginUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showPasswordLoginUCCheckBox);
            this.Controls.Add(this.logInLoginUCButton);
            this.Controls.Add(this.passwordLogInUCValue);
            this.Controls.Add(this.usernameLogInUCValue);
            this.Controls.Add(this.passwordLoginUCLabel);
            this.Controls.Add(this.userNameLoginUCLabel);
            this.Name = "LogginUc";
            this.Size = new System.Drawing.Size(430, 360);
            this.Load += new System.EventHandler(this.LogginUc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLoginUCLabel;
        private System.Windows.Forms.Label passwordLoginUCLabel;
        private System.Windows.Forms.TextBox usernameLogInUCValue;
        private System.Windows.Forms.TextBox passwordLogInUCValue;
        private System.Windows.Forms.Button logInLoginUCButton;
        private System.Windows.Forms.CheckBox showPasswordLoginUCCheckBox;
    }
}
