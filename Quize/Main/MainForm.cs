using Quize.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quize
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUpForm logiForm = new SignUpForm();
            logiForm.ShowDialog();
        }

        private void btTeacher_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btStudent_Click(object sender, EventArgs e)
        {
            StartSmartQuize selectTests = new StartSmartQuize();
            selectTests.ShowDialog();
        }

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {

            SignUpForm logiForm = new SignUpForm();
            logiForm.ShowDialog();
        }

        private void xuiSuperButton2_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();           
        }

        private void btStudent_Click_1(object sender, EventArgs e)
        {

           this.Hide();
           StudentLoginForm studentLogin =new StudentLoginForm();
           studentLogin.Show();
            
        }
    }
}
