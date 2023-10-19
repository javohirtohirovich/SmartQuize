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

namespace Quize.Teacher
{
    public partial class UpdateForm : Form
    {
        
        public UpdateForm()
        {
            InitializeComponent();
        }
        public int indx=0;
        //Testni sonini qisqartirish uchun
        public int qisqartma = 0;
        private void UpdateForm_Load(object sender, EventArgs e)
        {            
            cbUpFanlar.Enabled = false;
            cbUpTestDarajasi.Enabled = false;
            cbUpTestsSoni.Enabled = false;
            TextBox[] textBoxArr = { tbAwrite, tbBwrite, tbCwrite, tbDwrite,tbCorrect };
            foreach (var textBox in textBoxArr) { textBox.Enabled = false; }
            btAdd.Enabled = false;
            btClear.Enabled = false;
            rtbTestWrite.Enabled = false;
        }

        private void btCrtTestGo_Click(object sender, EventArgs e)
        {
            cbIshlashVat.Enabled = false;
            TextBox[] textBoxArr = { tbAwrite, tbBwrite, tbCwrite, tbDwrite, tbCorrect };
            foreach (var textBox in textBoxArr) { textBox.Enabled = true; }
            btAdd.Enabled = true;
            btClear.Enabled = true;
            rtbTestWrite.Enabled = true;

            if (cbIshlashVat.SelectedItem != null)
            {
                string jsonFilePath = "DATABASE\\";
                string jsonFileName = $"{cbUpFanlar.Text} {cbUpTestDarajasi.Text}-daraja.json";
                string Main_path = Path.Combine(jsonFilePath, jsonFileName);
                string json_content = File.ReadAllText(Main_path);

                var Test_list = JsonConvert.DeserializeObject<List<Fan_test>>(json_content);

                rtbTestWrite.Text = Test_list[0].Quize;
                tbAwrite.Text = Test_list[0].A;
                tbBwrite.Text = Test_list[0].B;
                tbCwrite.Text= Test_list[0].C;
                tbDwrite.Text= Test_list[0].D;
                tbCorrect.Text = Test_list[0].Correct;

                //-------------------
                if (Test_list.Count > int.Parse(cbUpTestsSoni.Text))
                {
                    qisqartma += Test_list.Count - int.Parse(cbUpTestsSoni.Text);
                }
                else 
                {
                    qisqartma = 1;
                }

            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxArr = { tbAwrite, tbBwrite, tbCwrite, tbDwrite,tbCorrect };

            string jsonFilePath = "DATABASE\\";
            string jsonFileName = $"{cbUpFanlar.Text} {cbUpTestDarajasi.Text}-daraja.json";
            string Main_path = Path.Combine(jsonFilePath, jsonFileName);
            string json_content = File.ReadAllText(Main_path);

            var Test_list = JsonConvert.DeserializeObject<List<Fan_test>>(json_content);


            //-----------------------------------------------------------------------------

            //Correct bilan variantlardan biri bilan bir xil ekanligi tekshirish uchun
            bool ishora = false;
            foreach (var item in textBoxArr) { if (item.Text.ToLower() == tbCorrect.Text.ToLower()) { ishora = true; break; } }

            if (rtbTestWrite.Text != "" && tbAwrite.Text != "" && tbBwrite.Text != ""
                && tbCwrite.Text != "" && tbDwrite.Text != "" && tbCorrect.Text != "" && ishora)
            {
                try
                {
                    //---------------------------------------------------
                    string jsonContent = File.ReadAllText(Main_path);
                    var fan_test_list = JsonConvert.DeserializeObject<List<Fan_test>>(jsonContent);
                    Fan_test fan_Test = new Fan_test();
                    fan_Test.Quize = rtbTestWrite.Text;
                    fan_Test.A = tbAwrite.Text;
                    fan_Test.B = tbBwrite.Text;
                    fan_Test.C = tbCwrite.Text;
                    fan_Test.D = tbDwrite.Text;
                    fan_Test.Correct = tbCorrect.Text;
                    fan_Test.Vaqt = int.Parse(cbIshlashVat.SelectedItem.ToString());
                    fan_test_list[indx] = fan_Test;
                    string updatedJsonContent = JsonConvert.SerializeObject(fan_test_list, Formatting.Indented);
                    File.WriteAllText(Main_path, updatedJsonContent);
                    indx++;
                    //----------------------------------------------------------------------
                    rtbTestWrite.Text = Test_list[indx].Quize;
                    tbAwrite.Text = Test_list[indx].A;
                    tbBwrite.Text = Test_list[indx].B;
                    tbCwrite.Text = Test_list[indx].C;
                    tbDwrite.Text = Test_list[indx].D;
                    tbCorrect.Text = Test_list[indx].Correct;
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    string jsonContent = File.ReadAllText(Main_path);
                    var fan_test_list = JsonConvert.DeserializeObject<List<Fan_test>>(jsonContent);
                    Fan_test fan_Test = new Fan_test();
                    fan_Test.Quize = rtbTestWrite.Text;
                    fan_Test.A = tbAwrite.Text;
                    fan_Test.B = tbBwrite.Text;
                    fan_Test.C = tbCwrite.Text;
                    fan_Test.D = tbDwrite.Text;
                    fan_Test.Correct = tbCorrect.Text;
                    fan_Test.Vaqt = int.Parse(cbIshlashVat.SelectedItem.ToString());
                    fan_test_list.Add(fan_Test);
                    string updatedJsonContent = JsonConvert.SerializeObject(fan_test_list, Formatting.Indented);
                    File.WriteAllText(Main_path, updatedJsonContent);

                    rtbTestWrite.Text = "";
                    tbAwrite.Text = "";
                    tbBwrite.Text = "";
                    tbCwrite.Text = "";
                    tbDwrite.Text = "";
                    tbCorrect.Text ="";

                }
                

                
                int cm_num = int.Parse(cbUpTestsSoni.Text);

                //Agar Test_num bilan Testlar sonidan oshsa To'xtaydi va yangitdan Test ochishga qaytadi
                if (indx == cm_num)
                { 
                    //Test_num ni Test_1 ga qaytarib qo'yish

                    lbTest_num.Text = $"Test-1:";

                    //TextBoxlarni bo'shatish va quluflash uchun
                    foreach (var textBox in textBoxArr) { textBox.Text = ""; }
                    rtbTestWrite.Text = "";
                    foreach (var textBox in textBoxArr) { textBox.Enabled = false; }
                    btAdd.Enabled = false;
                    btClear.Enabled = false;
                    rtbTestWrite.Enabled = false;
                    string jsonContent = File.ReadAllText(Main_path);
                    var fan_test_list = JsonConvert.DeserializeObject<List<Fan_test>>(jsonContent);

                    fan_test_list.RemoveRange(fan_test_list.Count - qisqartma, qisqartma);
                    string updatedJsonContent = JsonConvert.SerializeObject(fan_test_list, Formatting.Indented);
                    File.WriteAllText(Main_path, updatedJsonContent);

                    MessageBox.Show("Siz muvafqiyatli testni o'zgartirdengiz", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();
                    CreateTestForm createTestForm = new CreateTestForm();
                    createTestForm.ShowDialog();
                    indx = 1;
                }
                lbTest_num.Text = $"Test-{indx + 1}";
            }

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxArr = { tbAwrite, tbBwrite, tbCwrite, tbDwrite, tbCorrect };
            foreach (var textBox in textBoxArr) { textBox.Text = ""; }
            rtbTestWrite.Text = "";
        }

        private void btCreatTestBack_Click(object sender, EventArgs e)
        {          
            this.Close();
            CreateTestForm createTestForm = new CreateTestForm();
            createTestForm.ShowDialog();   
          
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateTestForm createTestForm = new CreateTestForm();
            createTestForm.ShowDialog();
        }
    }
}
