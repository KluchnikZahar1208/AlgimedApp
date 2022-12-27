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
    }
}
