using Newtonsoft.Json;
using Quize.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quize.Student
{
    public partial class ResultForm : Form
    {       
        public ResultForm()
        {
            InitializeComponent();
        }       
        //View Button uchun Funksiya
        private void ViewButton_Click(object sender, EventArgs e)
        {   
            //StartSmartQuize calssidan bitta obyekt yaratib public resultFilePath o'zgaruvchisini chaqiramiz
            StartSmartQuize startSmartQuize = new StartSmartQuize();
            string path_folder = startSmartQuize.resultFilePath;

            //File Pathni olamiz Yashirin Labeldan va Main Pathni yaratib olamiz
            string File_name = lbFilePath.Text;
            string Main_path=Path.Combine(path_folder, File_name);

            //Json failni o'qib uni jsonContentga joylashtiramiz
            string jsonContent=File.ReadAllText(Main_path);
            
            //JsonContentni Deserialeze qilib listga o'tkazib olamiz
            var resultList = JsonConvert.DeserializeObject<List<DetectAnswer>>(jsonContent);

            //Listdagi elementlarni Labelga joylashtiramiz
            foreach (var item in resultList)
            {
                string javob = "";
                if (item.True_answ) { javob = "CORRECT!"; }
                else { javob = "ERORR!"; }
                label2.Text += $"Test-{item.Test_number}\nSavol: {item.Quize}\nA) {item.A}\nB) {item.B}\n" +
                    $"C) {item.C}\nD) {item.D}\nYour answear: {item.Student_answear}\n{javob}\n\n";
                label2.Enabled = false;
            }
            //Resultni yozish uchun yaratilgan failni o'chiramiz keyingi ishlash ustiga yozib yubor,asligi uchun
            var fileDel = new FileInfo(Main_path);
            fileDel.Delete();

        }
        //Form ishga tushganda bajariladigan Funksiya
        private void ResultForm_Load(object sender, EventArgs e)
        {
            //StartSmartQuize calssidan bitta obyekt yaratib public resultFilePath o'zgaruvchisini chaqiramiz
            StartSmartQuize selectTests = new StartSmartQuize();
            string path_folder = selectTests.resultFilePath;

            //File Pathni olamiz Yashirin Labeldan va Main Pathni yaratib olamiz
            string File_name = lbFilePath.Text;
            string Main_path = Path.Combine(path_folder, File_name);

            //Json failni o'qib uni jsonContentga joylashtiramiz
            string jsonContent = File.ReadAllText(Main_path);

            //JsonContentni Deserialeze qilib listga o'tkazib olamiz
            var resultList = JsonConvert.DeserializeObject<List<DetectAnswer>>(jsonContent);
            
            //Test soni va hato, to'g'ri javoblar sonini saqlovchi o'zgaruvchilar
            int test_soni = 0;
            int false_answ = 0;
            int true_answ = 0;

            //Xato va to'g'ri javoblarni sanab boruvchi sikl
            foreach(var item in resultList) 
            {
                if(item.True_answ) {true_answ++; }
                else { false_answ++; }
                test_soni++;
            }

            //Testlar sonini va xato javoblarni va to'gri javoblarni labelga joylashtirish            
            lbTestlarSoni.Text = $"Testlar soni: {test_soni}";
            lbCorrects.Text = $"To'gri javoblar soni: {true_answ}";
            lbErrors.Text = $"Xato javoblar soni: {false_answ}";

            //ProgressBarni ishga tushirish
            int answ_foiz = 100 / test_soni;
            progressBar.Percentage -= answ_foiz * false_answ;

        }
        //Back Button uchun Funksiya
        private void BackButton_Click(object sender, EventArgs e)
        {
            StartSmartQuize selectTests = new StartSmartQuize();
            string path_folder = selectTests.resultFilePath;
            string File_name = lbFilePath.Text;
            string Main_path = Path.Combine(path_folder, File_name);
            if (File.Exists(Main_path)) 
            {
                var fileDel = new FileInfo(Main_path);
                fileDel.Delete();
            }


            this.Close();

            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            StartSmartQuize selectTests = new StartSmartQuize();
            string path_folder = selectTests.resultFilePath;
            string File_name = lbFilePath.Text;
            string Main_path = Path.Combine(path_folder, File_name);
            if (File.Exists(Main_path))
            {
                var fileDel = new FileInfo(Main_path);
                fileDel.Delete();
            }

           
            this.Close();

           
        }
    }
}
