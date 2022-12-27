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
    public partial class Authentification : Form
    {
        private UsersContext context;
        public Authentification()
        {
            InitializeComponent();
            context = new UsersContext();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Registration registration = new Registration();
            registration.ShowDialog();
            this.Visible = true;

        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {

            using (UsersContext db = new UsersContext())
            {
                var user = db.Users.Where(u => u.Login == textBox_Login.Text && u.Password == textBox_Password.Text);
                if (user != null)
                {
                    MainForm form = new MainForm();
                    form.ShowDialog();
                }
            }
            
        }
    }
}
