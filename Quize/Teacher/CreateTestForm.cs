using Newtonsoft.Json;
using Quize.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Quize.Teacher
{
    public partial class CreateTestForm : Form
    {
        public CreateTestForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (cbFanlar.SelectedItem != null && cbIshlashVat.SelectedItem != null
                && cbTestDarajasi.SelectedItem != null && cbTestsSoni.SelectedItem   != null)
            {
                string jsonFilePath="DATABASE\\";
                string jsonFileName = $"{cbFanlar.SelectedItem.ToString()} {cbTestDarajasi.SelectedItem.ToString()}-daraja.json";
                string Main_path = Path.Combine(jsonFilePath, jsonFileName);
                if (!File.Exists(Main_path))
                {
                    //---------------------------------------------------------------------------Enable-false
                    ComboBox[] Parda_1 = { cbFanlar, cbIshlashVat, cbTestDarajasi, cbTestsSoni };
                    foreach (var obj in Parda_1)
                    {
                        obj.Enabled = false;
                    }
                    btCrtTestGo.Enabled = false;

                    //---------------------------------------------------------------------------Enable-true
                    TextBox[] textBoxArr = { tbAwrite, tbBwrite, tbCwrite, tbDwrite,tbCorrect };
                    foreach (var textBox in textBoxArr) { textBox.Enabled = true; }
                    btAdd.Enabled = true;
                    btClear.Enabled = true;
                    rtbTestWrite.Enabled = true;

                    //----------------------------------------------------------------------------
                }
                else 
                {
                    UpdateForm updateForm = new UpdateForm();
                    updateForm.cbUpFanlar.Text= cbFanlar.SelectedItem.ToString();
                    updateForm.cbUpTestDarajasi.Text=cbTestDarajasi.SelectedItem.ToString();
                    updateForm.cbUpTestsSoni.Text=cbTestsSoni.SelectedItem.ToString();
                    this.Hide();
                    updateForm.Show();
                                        
                }
            }
            else
            {
                MessageBox.Show("Barchasini to'ldiring","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
      
        private void cbTestsSoni_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void cbFanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCreatTestBack_Click(object sender, EventArgs e)
        {

            if (cbFanlar.Enabled == true)
            {
                this.Close();
            }
            else
            {
                string message = "Agar chiqsangiz Testingiz Saqlanmaydi!";
                string title = "Ogohlantirish!";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    string jsonFilePath = "DATABASE\\";
                    string jsonFileName = $"{cbFanlar.SelectedItem.ToString()} {cbTestDarajasi.SelectedItem.ToString()}-daraja.json";
                    string Main_path = Path.Combine(jsonFilePath, jsonFileName);
                    if (File.Exists(Main_path))
                    {
                        var fileDel = new FileInfo(Main_path);
                        fileDel.Delete();
                    }
                    this.Close();
                }
                else
                {
                    // Do something  
                }

            }
        }

        private void CreateTestForm_Load(object sender, EventArgs e)
        {
            TextBox[] textBoxArr = { tbAwrite, tbBwrite, tbCwrite, tbDwrite,tbCorrect};
            foreach(var textBox in textBoxArr) { textBox.Enabled = false; }
            btAdd.Enabled = false;
            btClear.Enabled = false;
            rtbTestWrite.Enabled = false;

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxArr = { tbAwrite, tbBwrite, tbCwrite, tbDwrite };

            string jsonFilePath = "DATABASE\\";
            string jsonFileName = $"{cbFanlar.SelectedItem.ToString()} {cbTestDarajasi.SelectedItem.ToString()}-daraja.json";
            string Main_path = Path.Combine(jsonFilePath, jsonFileName);
            
            //Correct bilan variantlardan biri bilan bir xil ekanligi tekshirish uchun
            bool ishora=false;
            foreach (var item in textBoxArr) { if (item.Text.ToLower() == tbCorrect.Text.ToLower()) { ishora = true;break; } }

            if (rtbTestWrite.Text!="" && tbAwrite.Text!="" && tbBwrite.Text!=""
                && tbCwrite.Text!="" && tbDwrite.Text != ""&&tbCorrect.Text!=""&&ishora)
            {
                // Jsonga Test Yozish

                if (File.Exists(Main_path))
                { 
                    string jsonContent = File.ReadAllText(Main_path);
                    var fan_test_list=JsonConvert.DeserializeObject<List<Fan_test>>(jsonContent);
                    Fan_test fan_Test = new Fan_test();
                    fan_Test.Quize = rtbTestWrite.Text;
                    fan_Test.A = tbAwrite.Text;
                    fan_Test.B = tbBwrite.Text;
                    fan_Test.C = tbCwrite.Text;
                    fan_Test.D = tbDwrite.Text;
                    fan_Test.Correct = tbCorrect.Text;
                    fan_Test.Vaqt=int.Parse(cbIshlashVat.SelectedItem.ToString());
                    fan_test_list.Add(fan_Test);
                    string updatedJsonContent = JsonConvert.SerializeObject(fan_test_list,Formatting.Indented);
                    File.WriteAllText(Main_path, updatedJsonContent);
                }
                else
                {

                    List<Fan_test> fan_test_list2 = new List<Fan_test>();
                    Fan_test fan_Test2 = new Fan_test();
                    fan_Test2.Quize = rtbTestWrite.Text;
                    fan_Test2.A=tbAwrite.Text;
                    fan_Test2.B=tbBwrite.Text;
                    fan_Test2.C=tbCwrite.Text;
                    fan_Test2.D=tbDwrite.Text;
                    fan_Test2.Correct=tbCorrect.Text;
                    fan_Test2.Vaqt = int.Parse(cbIshlashVat.SelectedItem.ToString());

                    fan_test_list2.Add(fan_Test2);
                    string updatedJsonContent = JsonConvert.SerializeObject(fan_test_list2,Formatting.Indented);
                    
                    File.WriteAllText(Main_path, updatedJsonContent);
                }
                //---------------------------------------------------------------------------------------------------------------

                // Test_1 ni o'zgartirish uchun
                string lbText = lbTest_num.Text;
                int lb_num = int.Parse(Regex.Match(lbText, @"\d+").Value);
                lb_num += 1;
                //-------------------------------------------------------

                //Text boxlar bo'shatish uchun
                
                foreach (var textBox in textBoxArr) { textBox.Text = "";}
                tbCorrect.Text = "";
                rtbTestWrite.Text = "";

                //-----------------------------------------------------------

                int cm_num = int.Parse(cbTestsSoni.SelectedItem.ToString());

                //Agar Test_num bilan Testlar sonidan oshsa To'xtaydi va yangitdan Test ochishga qaytadi
                if (lb_num > cm_num)
                {
                    MessageBox.Show("!!! Test Yaratildi !!!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    //ComboBoxlarni Asliga qaytarish uchun va tanlangan qiymatlarni nullga qaytarish uchun
                    ComboBox[] Parda_1 = { cbFanlar, cbIshlashVat, cbTestDarajasi, cbTestsSoni };
                    foreach (var obj in Parda_1)
                    {
                        obj.Enabled = true;
                        obj.SelectedItem = null;
                    }
                    cbFanlar.Text = "Fan:";
                    cbIshlashVat.Text = "Ishlash vaqti:";
                    cbTestDarajasi.Text = "Test darajasi:";
                    cbTestsSoni.Text = "Testlar Soni:";
                    btCrtTestGo.Enabled = true;
                    
                    //Test_num ni Test_1 ga qaytarib qo'yish

                    lbTest_num.Text = $"Test-1:";

                    //TextBoxlarni bo'shatish va quluflash uchun
                    foreach (var textBox in textBoxArr) { textBox.Text = ""; }
                    rtbTestWrite.Text = "";
                    foreach (var textBox in textBoxArr) { textBox.Enabled = false; }
                    btAdd.Enabled = false;
                    btClear.Enabled = false;
                    rtbTestWrite.Enabled = false;
                    //Test_num ni Test_1 qilish uchun
                    lb_num = 1;

                }
                lbTest_num.Text = $"Test-{lb_num}:";
            }
            else
            {
                MessageBox.Show("Iltimos to'g'ri tartibda to'diring!","Warning!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxArr = { tbAwrite, tbBwrite, tbCwrite, tbDwrite,tbCorrect };
            foreach (var textBox in textBoxArr) { textBox.Text = ""; }
            rtbTestWrite.Text = "";
        }

        private void cbIshlashVat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (cbFanlar.Enabled == true)
            {
                this.Close();
            }
            else 
            {
                string message = "Agar chiqsangiz Testingiz Saqlanmaydi!";
                string title = "Ogohlantirish!";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    string jsonFilePath = "DATABASE\\";
                    string jsonFileName = $"{cbFanlar.SelectedItem.ToString()} {cbTestDarajasi.SelectedItem.ToString()}-daraja.json";
                    string Main_path = Path.Combine(jsonFilePath, jsonFileName);
                    if (File.Exists(Main_path))
                    {
                        var fileDel = new FileInfo(Main_path);
                        fileDel.Delete();
                    }
                    this.Close();
                }
                else
                {
                    // Do something  
                }             
                
            }
        }
    }
}
