using Newtonsoft.Json;
using Quize.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quize
{
    public partial class SignUpForm : Form
    {
        public string info_path = @"DATABASE\UserData\userInfo.json";
        public List<TeacherInfo> teacherInfo_list = new List<TeacherInfo>();
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { tbSignUpParol.UseSystemPasswordChar = false; }
            if (!checkBox2.Checked) { tbSignUpParol.UseSystemPasswordChar = true; }
        }

        private void tbQaytaParol_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { tbQaytaParol.UseSystemPasswordChar = false; }
            if (!checkBox1.Checked) { tbQaytaParol.UseSystemPasswordChar = true; }
        }
        
        private void btSignUp_Click(object sender, EventArgs e)
        {

            Regex rxemail = new Regex(@"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+");
            Regex rxname = new Regex(@"^[A-Za-z0-9_-]{3,15}$");
            Regex rxage = new Regex(@"^[1-9_-]{1,2}$");
            Regex rxpasw = new Regex(@"^(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{5,}$");

            if (tbEmail.Text!="" && tbQaytaParol.Text!="" && tbIsm.Text != "" && tbSignUpParol.Text != "" && tbSurname.Text != "" && tbQaytaParol.Text != "")  
            {
                if (!rxname.IsMatch(tbCreateUser.Text)) 
                {
                    MessageBox.Show("Siz Usernameni noto'g'ri shakilida kiritdengiz!\n(3 tada 15 ta gacha harf yoki raqam)", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!rxname.IsMatch(tbIsm.Text)) 
                {
                    MessageBox.Show("Siz ismengizni noto'g'ri shakilida kiritdengiz!\n(3 tada 15 ta gacha harf yoki raqam)", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!rxname.IsMatch(tbSurname.Text)) 
                {
                    MessageBox.Show("Siz familiyangizni noto'g'ri shakilida kiritdengiz!\n(3 tada 15 ta gacha harf yoki raqam)", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!rxemail.IsMatch(tbEmail.Text))
                {
                    MessageBox.Show("Siz Emailingizni noto'g'ri shakilida kiritdengiz!\n(Namuna: ism@gmail.com)", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!rxpasw.IsMatch(tbSignUpParol.Text)) 
                {
                    MessageBox.Show("Siz parolni noto'g'ri shakilida kiritdengiz!\n(uzunligi 5 tadan ko'p bolishi va raqam, belgi va harfalar)", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (tbQaytaParol.Text != tbSignUpParol.Text)
                {
                    MessageBox.Show("Yozgan parollaringiz bir xil emas!", "Password Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (File.Exists(info_path))
                    {
                        string jsonContent = File.ReadAllText(info_path);
                        teacherInfo_list = JsonConvert.DeserializeObject<List<TeacherInfo>>(jsonContent);

                        TeacherInfo teacherInfo = new TeacherInfo();
                        teacherInfo.UserName = tbCreateUser.Text;
                        teacherInfo.Name = tbIsm.Text;
                        teacherInfo.Surname = tbSurname.Text;
                        teacherInfo.Email = tbEmail.Text;
                        teacherInfo.Parol = tbSignUpParol.Text;
                        if (teacherInfo != null)
                        {
                            teacherInfo_list.Add(teacherInfo);
                        }

                        string jsonContent_list = JsonConvert.SerializeObject(teacherInfo_list, Formatting.Indented);
                        File.WriteAllText(info_path, jsonContent_list);
                        MessageBox.Show("Siz Ro'yxatdan o'tdengiz!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        TeacherInfo teacherInfo = new TeacherInfo();
                        teacherInfo.UserName = tbCreateUser.Text;
                        teacherInfo.Name = tbIsm.Text;
                        teacherInfo.Surname = tbSurname.Text;
                        teacherInfo.Email = tbEmail.Text;
                        teacherInfo.Parol = tbSignUpParol.Text;
                        if (teacherInfo != null)
                        {
                            teacherInfo_list.Add(teacherInfo);
                        }

                        string jsonContent_list = JsonConvert.SerializeObject(teacherInfo_list, Formatting.Indented);
                        File.WriteAllText(info_path, jsonContent_list);
                        MessageBox.Show("Siz Ro'yxatdan o'tdengiz!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Hamma qatorlarni to'ldiring!", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btSignUpBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
