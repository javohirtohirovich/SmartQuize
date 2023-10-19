using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quize.Student
{
    public partial class StudentLoginForm : Form
    {
        //Test ishlash Formidan foydalanish uchun o'zgaruvchilar
        public string Student_Fulname=String.Empty;
        public int Student_Age=0;
        public string Student_Email=String.Empty;
        public StudentLoginForm()
        {
            InitializeComponent();
        }

        //Regexlar kiritilgan ma'lumotlarni tekshirish uchun
        Regex rxemail = new Regex(@"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+");
        Regex rxname = new Regex(@"^[A-Za-z0-9_-]{3,15}$");
        Regex rxage = new Regex(@"^[0-9_-]{1,2}$");

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {
            //Hamma qatorlarni to'ldirilgan ekanligini tekshiramiz
            if (tbSFullName.Text != "" && tbEmail.Text != "" && tbAge.Text != "")
            {
                // Ismni to'g'ri to'ldirilgan ekanligini tekshiramiz
                if (!rxname.IsMatch(tbSFullName.Text))
                {
                    MessageBox.Show("Siz ismengizni noto'g'ri shakilida kiritdengiz!\n(3 tada 15 ta gacha harf yoki raqam)", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Yoshni to'g'ri to'ldirilgan ekanligini tekshiramiz
                else if (!rxage.IsMatch(tbAge.Text))
                {

                    MessageBox.Show("Siz yoshengizni noto'g'ri shakilida kiritdengiz!\n(faqat raqamlardan iborat va 1 dan 2 tagacha raqam)", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Email to'g'ri shakilda to'ldirilgan ekanligini tekshiramiz
                else if (!rxemail.IsMatch(tbEmail.Text))
                {
                    MessageBox.Show("Siz emailni noto'g'ri shakilda kiritdengiz!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Hamma shartlar bajarilganidan keyin bajaradigan amalimiz
                else
                {
                    //Public o'zgaruvchilarga ma'lumotlarni yuklaymiz
                    Student_Fulname = tbSFullName.Text;
                    Student_Age = int.Parse(tbAge.Text);
                    Student_Email = tbEmail.Text;

                    //Test ishlash formni ochamiz va bu oynani yopamiz
                    StartSmartQuize selectTests = new StartSmartQuize();
                    
                    this.Close();
                    selectTests.Show();
                    
                }

            }
            //Agarda hamma qatorni to'ldirmasdan turib buttonni bossa
            else 
            {
                MessageBox.Show("Iltimos hamma qatorlarni to'ldiring!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void xuiSuperButton1_Click_1(object sender, EventArgs e)
        {

            this.Close();
            MainForm mainForm = new MainForm();
            foreach (Form form in Application.OpenForms)
            {
                if (mainForm is MainForm)
                {
                    form.Show();
                    break;
                }
            }
        }

        private void btX_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            foreach (Form form in Application.OpenForms)
            {
                if (mainForm is MainForm)
                {
                    form.Show();
                    break;
                }
            }
        }

       

       
    }
}
