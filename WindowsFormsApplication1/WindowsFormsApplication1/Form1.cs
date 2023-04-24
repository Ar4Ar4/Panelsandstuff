using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       // public string registrationPanelInputs{ }
        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void HomButt_Click(object sender, EventArgs e)
        {
            home1.Show();
            home1.BringToFront();
            regis1.Hide();
            login1.Hide();
        }

        private void Regisbutt_Click(object sender, EventArgs e)
        {
            regis1.Show();
            regis1.BringToFront();
            home1.Hide();
            login1.Hide();
        }

        private void LogButt_Click(object sender, EventArgs e)
        {
            login1.Show();
            login1.BringToFront();
            regis1.Hide();
            home1.Hide();
        }
        public string RegEmailInp {
            set
            {
                emailout.Text = value;
            }
        }
        public string RegUserInp
        {
            set
            {
                userout.Text = value;
            }
        }

        public string RegPassInp
        {
            set
            {
                passout.Text = value;
            }
        }


       
    }
}
