namespace AlgimedApp
{
    partial class Authentification
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
            this.usersContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_SignIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel_Registration = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.usersContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usersContextBindingSource
            // 
            this.usersContextBindingSource.DataSource = typeof(AlgimedApp.AppContext.UsersContext);
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(279, 138);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(183, 23);
            this.textBox_Login.TabIndex = 0;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(279, 211);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(183, 23);
            this.textBox_Password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // button_SignIn
            // 
            this.button_SignIn.Location = new System.Drawing.Point(309, 271);
            this.button_SignIn.Name = "button_SignIn";
            this.button_SignIn.Size = new System.Drawing.Size(122, 34);
            this.button_SignIn.TabIndex = 4;
            this.button_SignIn.Text = "Sign In";
            this.button_SignIn.UseVisualStyleBackColor = true;
            this.button_SignIn.Click += new System.EventHandler(this.button_SignIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "If you don\'t have account you can";
            // 
            // linkLabel_Registration
            // 
            this.linkLabel_Registration.AutoSize = true;
            this.linkLabel_Registration.Location = new System.Drawing.Point(432, 347);
            this.linkLabel_Registration.Name = "linkLabel_Registration";
            this.linkLabel_Registration.Size = new System.Drawing.Size(49, 15);
            this.linkLabel_Registration.TabIndex = 6;
            this.linkLabel_Registration.TabStop = true;
            this.linkLabel_Registration.Text = "Register";
            this.linkLabel_Registration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel_Registration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_SignIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Login);
            this.Name = "Authentification";
            this.Text = "Authentification";
            ((System.ComponentModel.ISupportInitialize)(this.usersContextBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource usersContextBindingSource;
        private TextBox textBox_Login;
        private TextBox textBox_Password;
        private Label label1;
        private Label label2;
        private Button button_SignIn;
        private Label label3;
        private LinkLabel linkLabel_Registration;
    }
}