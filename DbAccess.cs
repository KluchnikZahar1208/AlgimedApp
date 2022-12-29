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
    public partial class DbAccess : Form
    {
        public bool access;
        public bool Access
        {
            get
            {
                return access;
            }
            set
            {
                access = value;
            }
        }
        public DbAccess()
        {
            InitializeComponent();
        }

        private void button_EnterPassword_Click(object sender, EventArgs e)
        {
            string password = "123";
            if(textBox_DbPassword.Text == password)
            {
                Access = true;
            }
            else
            {
                Access = false;
            }
            this.Close();
        }
    }
}
