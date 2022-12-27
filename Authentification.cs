using AlgimedApp.AppContext;
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
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.context = new UsersContext();
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Registration registration = new Registration();
            registration.ShowDialog();
            this.Visible = true;

        }
    }
}
