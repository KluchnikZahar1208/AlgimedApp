namespace AlgimedApp
{
    partial class DbAccess
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
            this.textBox_DbPassword = new System.Windows.Forms.TextBox();
            this.button_EnterPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_DbPassword
            // 
            this.textBox_DbPassword.Location = new System.Drawing.Point(88, 83);
            this.textBox_DbPassword.Name = "textBox_DbPassword";
            this.textBox_DbPassword.Size = new System.Drawing.Size(100, 23);
            this.textBox_DbPassword.TabIndex = 0;
            // 
            // button_EnterPassword
            // 
            this.button_EnterPassword.Location = new System.Drawing.Point(103, 124);
            this.button_EnterPassword.Name = "button_EnterPassword";
            this.button_EnterPassword.Size = new System.Drawing.Size(71, 28);
            this.button_EnterPassword.TabIndex = 1;
            this.button_EnterPassword.Text = "Enter";
            this.button_EnterPassword.UseVisualStyleBackColor = true;
            this.button_EnterPassword.Click += new System.EventHandler(this.button_EnterPassword_Click);
            // 
            // DbAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.button_EnterPassword);
            this.Controls.Add(this.textBox_DbPassword);
            this.Name = "DbAccess";
            this.Text = "DbAccess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_DbPassword;
        private Button button_EnterPassword;
    }
}