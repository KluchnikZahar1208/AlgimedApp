using AlgimedApp.AppContext;
using AlgimedApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgimedApp
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void linkLabel_Registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            if(textBox_Login.Text == "" || textBox_Password.Text == "" || textBox_ConfirmPassword.Text == "")
            {
                MessageBox.Show("Fill in all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                if (textBox_Password.Text == textBox_ConfirmPassword.Text)
                {
                    DbAccess dbAccess = new DbAccess();
                    dbAccess.ShowDialog();
                    bool access = dbAccess.Access;
                    if (access)
                    {
                        using (UsersContext db = new UsersContext())
                        {

                            var user = db.Users.Where(u => u.Login == textBox_Login.Text && u.Password == textBox_Password.Text);
                            if (user.Count() > 0)
                            {
                                MessageBox.Show("Account already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                db.Users.Add(new User { Login = textBox_Login.Text, Password = textBox_Password.Text });
                                db.SaveChanges();
                                MainForm form = new MainForm();
                                this.Visible = false;
                                form.ShowDialog();
                                this.Visible = true;
                            }
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Wrong password to DB", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    

                }
                else
                {
                    MessageBox.Show("Wrong confirm password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            
            
            
        }
    }
}
