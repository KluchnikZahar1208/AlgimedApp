namespace AlgimedApp
{
    partial class Registration
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
            this.button_SignUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.linkLabel_Authentication = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_SignUp
            // 
            this.button_SignUp.Location = new System.Drawing.Point(319, 281);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(122, 34);
            this.button_SignUp.TabIndex = 9;
            this.button_SignUp.Text = "Sign Up";
            this.button_SignUp.UseVisualStyleBackColor = true;
            this.button_SignUp.Click += new System.EventHandler(this.button_SignUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(295, 153);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(183, 23);
            this.textBox_Password.TabIndex = 6;
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(295, 80);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(183, 23);
            this.textBox_Login.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Confirm Password";
            // 
            // textBox_ConfirmPassword
            // 
            this.textBox_ConfirmPassword.Location = new System.Drawing.Point(295, 225);
            this.textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            this.textBox_ConfirmPassword.PasswordChar = '*';
            this.textBox_ConfirmPassword.Size = new System.Drawing.Size(183, 23);
            this.textBox_ConfirmPassword.TabIndex = 10;
            // 
            // linkLabel_Authentication
            // 
            this.linkLabel_Authentication.AutoSize = true;
            this.linkLabel_Authentication.Location = new System.Drawing.Point(419, 339);
            this.linkLabel_Authentication.Name = "linkLabel_Authentication";
            this.linkLabel_Authentication.Size = new System.Drawing.Size(75, 15);
            this.linkLabel_Authentication.TabIndex = 13;
            this.linkLabel_Authentication.TabStop = true;
            this.linkLabel_Authentication.Text = "Authenticate";
            this.linkLabel_Authentication.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Registration_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "If you have account you can";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel_Authentication);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ConfirmPassword);
            this.Controls.Add(this.button_SignUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Login);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_SignUp;
        private Label label2;
        private Label label1;
        private TextBox textBox_Password;
        private TextBox textBox_Login;
        private Label label3;
        private TextBox textBox_ConfirmPassword;
        private LinkLabel linkLabel_Authentication;
        private Label label4;
    }
}