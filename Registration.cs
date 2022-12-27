﻿using AlgimedApp.AppContext;
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
            if(textBox_Password.Text == textBox_ConfirmPassword.Text)
            {
                using (UsersContext db = new UsersContext())
                {
                    db.Users.Add(new User { Login = textBox_Login.Text, Password = textBox_Password.Text });
                    db.SaveChanges();
                }
                MainForm form = new MainForm();
                form.ShowDialog();
            }
            
        }
    }
}
