using Newtonsoft.Json;
using Quize.Models;
using Quize.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Quize
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            SignUpForm form = new SignUpForm();
            form.Show();
        }

        private void btSignIn_Click(object sender, EventArgs e)
        {
            string info_path = @"DATABASE\UserData\userInfo.json";
            string jsonString=File.ReadAllText(info_path);
            string json_content = File.ReadAllText(info_path);

            var User_list = JsonConvert.DeserializeObject<List<TeacherInfo>>(json_content);
            if (tbSignInPasw.Text != "" && tbSignInUser.Text != "")
            {
                bool ishora_user = false;
                bool ishora_parol = false;
                foreach (var item in User_list)
                {
                    if (item.UserName == tbSignInUser.Text)
                    {
                        ishora_user = true;
                        if (item.Parol == tbSignInPasw.Text)
                        {
                            ishora_parol = true;
                        }
                    }
                }
                if (ishora_parol && ishora_user)
                {
                    this.Close();
                    CreateTestForm createTest = new CreateTestForm();
                    createTest.Show();
                }
                else if (ishora_user && (ishora_parol == false))
                {
                    MessageBox.Show("Siz parolni noto'gri kiritdengiz!", "Erorr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSignInPasw.Text = "";
                }
                else
                {
                    MessageBox.Show("Bunday foydalanuvchi topilmadi!", "Erorr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSignInPasw.Text = "";
                    tbSignInUser.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Siz barcha qatorlarni to'ldirmadengiz!","Erorr!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tbSignInPasw_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void btSignInBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { tbSignInPasw.UseSystemPasswordChar = false; }
            if (!checkBox1.Checked) { tbSignInPasw.UseSystemPasswordChar = true; }
        }
    }
}
