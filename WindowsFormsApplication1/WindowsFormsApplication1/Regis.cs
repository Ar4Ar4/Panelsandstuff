using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Regis : UserControl
    {
        public Regis()
        {
            InitializeComponent();
        }

        private void RegSub_Click(object sender, EventArgs e)
        {
            var emailbox = this.emailbox.Text;
            var usernbox = this.usernbox.Text;
            var passbox = this.passbox.Text;

            var parent = this.Parent as Form1;
            parent.RegEmailInp = emailbox;
            parent.RegPassInp = passbox;
            parent.RegUserInp = usernbox;
        }
    }
}
