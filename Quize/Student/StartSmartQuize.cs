using Newtonsoft.Json;
using Quize.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quize.Student
{
    public partial class StartSmartQuize : Form
    {
        //Failni oq'ib olish uchun path
        public string jsonFilePath = "DATABASE\\";

        //Javoblarni yozish uchun path
        public string resultFilePath = @"DATABASE\Student\";

        //Bitta Testlarni o'qib olib Listga yozib olish uchun List
        public List<Fan_test> Test_list = new List<Fan_test>();

        //Result form result failni pathini berib yuborish uchun o'zgaruvchi
        public string Fan_name = "";
        
        // daqiqa va sekundni hsoblab borish uchun
        int m, s;

        public StartSmartQuize()
        {
            InitializeComponent();
        }
        System.Timers.Timer Timer;
       
        //Form Show bo'lganida ishlobchi funksiya
        private void SelectTests_Load(object sender, EventArgs e)
        {
            // RadioButtonlarni qulufalsh uchun
            RadioButton[] radiobuttons = { rbA, rbB, rbC, rbD, };
            foreach (RadioButton radiobutton in radiobuttons)
            {
                radiobutton.Enabled = false;
            }                                 
         
            //Fanlarni nomini ComboBoxga joylashtisrish uchun
            string[] fileArray = Directory.GetFiles(jsonFilePath, "*.json");
            foreach (string file in fileArray)
            {
                int index = 0;
                for (int i = 0; i < file.Length; i++) { if (file[i] == '\\') { index = i; } }
                string fan_nomi= file.Substring(index+1);
                fan_nomi = fan_nomi.Substring(0, fan_nomi.Length - 5);
                cbSelectFan.Items.Add(fan_nomi);
            }
            
        }
       
        // Start buttonni bosganida
        private void btSatart_Click(object sender, EventArgs e)
        {
            //comboboxda fan tanlanganligini tekshirish
            if (cbSelectFan.SelectedItem != null)
            {
                //Timerni boshlanish uchun
                Timer = new System.Timers.Timer();
                Timer.Interval = 1000;
                Timer.Elapsed += Timer_Elapsed;
                Timer.Start();

                //ComboBox larni qulufalsh uchun
                cbSelectFan.Enabled = false;
                btStart.Enabled = false;
                                                   
                //radiobuttonlarni qulufdan chiqarish
                RadioButton[] radiobuttons = { rbA, rbB, rbC, rbD, };
                foreach (RadioButton radiobutton in radiobuttons)
                {
                    radiobutton.Enabled = true;

                }

                //Next Buttonni qulufdan chiqarish
                btNext.Enabled = true;
                
                //Fileni olish va uni o'qib Listaga joylashtirish 
                string file_name = $"{cbSelectFan.SelectedItem.ToString()}.json";
                string path = Path.Combine(jsonFilePath, file_name);
                string test_json = File.ReadAllText(path);
                Test_list = JsonConvert.DeserializeObject<List<Fan_test>>(test_json);
                
                //Berilgan vaqtni labelga joylashtirish
                lbTtime.Text = $"{Test_list[0].Vaqt.ToString()}";

                //Savolni va variantlarga textBoxga va radioButtonlarga joylashtirish
                tbSavolText.Text = Test_list[0].Quize;
                rbA.Text = Test_list[0].A;
                rbB.Text = Test_list[0].B;
                rbC.Text = Test_list[0].C;
                rbD.Text = Test_list[0].D;
            }
            
        }

        //Timerni oshirib borish uchun funksiya
        private  void  Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() => {
                s = s + 1;
                if (s == 60)
                {
                    m = m + 1;
                    s = 0;
                }
                lbRtimer.Text = m + ":" + s;            
            }));
            
        }

        public int n = 1; //Testni tartib raqamin va Listdan birin ketin o'qib olish uchun

        public void btNext_Click(object sender, EventArgs e)
        {
            // Variantlarni birini tanlaganligini tekshirish uchun shart
            if (rbA.Checked || rbB.Checked || rbC.Checked || rbD.Checked)
            {
                //Failni nomini yaratish va Main_path ni yaratib olish uchun bu fayl Natijalarni yozib borish uchun               
                StudentLoginForm studentLogin = new StudentLoginForm();
                string jsonFileName = $@"{cbSelectFan.SelectedItem.ToString()} ({studentLogin.Student_Fulname}).json";
                string Main_path = Path.Combine(resultFilePath, jsonFileName);
                
                //File nameni olish uchun public o'zgaruvchiga
                Fan_name = $@"{cbSelectFan.SelectedItem.ToString()} ({studentLogin.Student_Fulname}).json";
                
                //Agar File yaratilgan bo'lsa
                if (File.Exists(Main_path))
                {
                    //Fayil yaratib bo'lingan bo'lsa uni o'qib Listga joylashtirish uchun
                    string jsonContent = File.ReadAllText(Main_path);

                    //json failni oqib uni listga joylashtish
                    var result_test_list = JsonConvert.DeserializeObject<List<DetectAnswer>>(jsonContent);

                    //Fayilga yozish uchun Obeyekt Feildlariga qiymat kiritish
                    DetectAnswer detect_Test = new DetectAnswer();
                    detect_Test.dateTime = DateTime.Now; //1
                    detect_Test.Fan=cbSelectFan.SelectedItem.ToString(); //2
                    detect_Test.Test_number = n; //3
                    detect_Test.Quize=tbSavolText.Text; //4
                    detect_Test.A = rbA.Text; //5
                    detect_Test.B=rbB.Text; //6
                    detect_Test.C = rbC.Text;  //7
                    detect_Test.D = rbD.Text; //8
                    detect_Test.Correct = Test_list[n - 1].Correct; //9

                    //User tanlagan variantni aniqlash uchun va fieldaga yuklash
                    string variant = "";
                    RadioButton[] radioButton_list = new RadioButton[] { rbA, rbB, rbC, rbD };
                    foreach (var item in radioButton_list) 
                    {
                        if (item.Checked) {variant= item.Text;}
                    }

                    detect_Test.Student_answear = variant; //10
                    
                    //User to'g'ri tanlaganmi yoki yo'qligini aniqlash va fieldga yuklash
                    if (variant.ToLower() == Test_list[n - 1].Correct.ToLower())
                    {
                        detect_Test.True_answ = true; //11
                    }
                    else { detect_Test.True_answ = false; } //11?

                    //obyektni Listga joylashtish
                    result_test_list.Add(detect_Test);

                    //Listni jsonga o'tkazish
                    string updatedJsonContent = JsonConvert.SerializeObject(result_test_list, Formatting.Indented);

                    //Main_pathga json Contentlarni yozish
                    File.WriteAllText(Main_path, updatedJsonContent);
                }

                //Agar File yaratilmagan bo'lsa
                else
                {
                    //Fail nomini yaratib va uni Main_path2 ni yaratib olish uchun
                    string jsonFileName2 = $@"{cbSelectFan.SelectedItem.ToString()} ({studentLogin.Student_Fulname}).json";
                    string Main_path2 = Path.Combine(resultFilePath, jsonFileName2);

                    //List yaratib olish
                    List<DetectAnswer> result_test_list2 = new List<DetectAnswer>();

                    //Obyekt yaratamiz va Fieldlarga qiymat kiritamiz
                    DetectAnswer detect_Test2 = new DetectAnswer();
                    detect_Test2.dateTime = DateTime.Now; //1
                    detect_Test2.Fan = cbSelectFan.SelectedItem.ToString(); //2
                    detect_Test2.Test_number = n; //3
                    detect_Test2.Quize = tbSavolText.Text; //4
                    detect_Test2.A = rbA.Text; //5
                    detect_Test2.B = rbB.Text; //6
                    detect_Test2.C = rbC.Text;  //7
                    detect_Test2.D = rbD.Text; //8
                    detect_Test2.Correct = Test_list[n - 1].Correct; //9

                    //User tanlagan variantni aniqlash uchun va fieldga yuklash
                    string variant = "";
                    RadioButton[] radioButton_list = new RadioButton[] { rbA, rbB, rbC, rbD };
                    foreach (var item in radioButton_list)
                    {
                        if (item.Checked) { variant = item.Text; }
                    }
                    detect_Test2.Student_answear = variant; //10

                    //User to'g'ri tanlaganmi yoki yo'qligini aniqlash va fieldga yuklash
                    if (variant.ToLower() == Test_list[n - 1].Correct.ToLower())
                    {
                        detect_Test2.True_answ = true; //11
                    }
                    else { detect_Test2.True_answ = false; } //11?

                    //obyektni Listga joylashtish
                    result_test_list2.Add(detect_Test2);

                    //Listni jsonga o'tkazish
                    string updatedJsonContent = JsonConvert.SerializeObject(result_test_list2, Formatting.Indented);

                    //Main_pathga json Contentlarni yozish
                    File.WriteAllText(Main_path2, updatedJsonContent);
                }
                
                //Test ishlab bo'lgan bo'lsa to'xtatish uchun shart
                if (Test_list.Count < n + 1)
                {
                    //Timerni to'xtatish
                    Timer.Stop();               
                    m = 0;s = 0;

                    //Timerlarni qiymatini 0 ga qaytarish uchun
                    lbRtimer.Text = m + ":" + s;
                    lbTtime.Text = "0";
                    
                    //File pathini ResultFormga yuborish uchun
                    ResultForm resultForm = new ResultForm();
                    resultForm.lbFilePath.Text = Fan_name;

                    //ResultForm ni ochish
                    
                    resultForm.Show();

                    //Savol va variantlarni tozzalash 
                    tbSavolText.Text = "";
                    rbA.Text = ""; rbA.Enabled = false;
                    rbB.Text = ""; rbB.Enabled = false;
                    rbC.Text = ""; rbC.Enabled = false;
                    rbD.Text = ""; rbD.Enabled = false;

                    //RadioButtonlarni quluflash
                    rbA.Checked = false; rbB.Checked = false;
                    rbC.Checked = false; rbD.Checked = false;
                    
                    btNext.Enabled = false;

                    //Test tartib raqamini 1 ga qaytarish
                    lbTestNumb.Text = "TEST-1";
                    
                    //Fanni tanlash comboboxisini qulufdan chiqarish va textini Fan: qaytarish
                    cbSelectFan.Enabled = true;
                    cbSelectFan.Text = "Fan:";

                    //Start buttonni qulufdan chiqarish
                    btStart.Enabled = true;
                    
                    //n ni qiymatini 1 ga qaytarib qo'yish
                    n = 1;

                }
                //Agar Test ishlab bo'lmagan bo'lsa
                else
                {
                    //Test tartib raqamini 1 ga oshirish
                    lbTestNumb.Text = $"TEST-{1 + n}";

                    //Savol va variyantlarni radioButton va textBoxlarga joylashtirish
                    tbSavolText.Text = Test_list[n].Quize;
                    rbA.Text = Test_list[n].A;
                    rbB.Text = Test_list[n].B;
                    rbC.Text = Test_list[n].C;
                    rbD.Text = Test_list[n].D;

                    //radio buttonlarni tanlanganini o'chirish
                    rbA.Checked = false; rbB.Checked = false;
                    rbC.Checked = false; rbD.Checked = false;

                    // Button har bosilganda n qiymatini bittaga oshirib borish
                    n++;
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (Timer != null)
            {
                Timer.Stop();
                m = 0; s = 0;
                lbRtimer.Text = m + ":" + s;
                lbTtime.Text = "0";
            }
            //Fail yaratilgan bo'lsa ochirib chiqib ketadi
            if (cbSelectFan.SelectedItem != null)
            {
                StudentLoginForm studentLogin = new StudentLoginForm();
                string jsonFileName = $@"{cbSelectFan.SelectedItem.ToString()} ({studentLogin.Student_Fulname}).json";
                string Main_path = Path.Combine(resultFilePath, jsonFileName);
                if (File.Exists(Main_path))
                {
                    var fileDel = new FileInfo(Main_path);
                    fileDel.Delete();
                }

            }
            //Formni yopadi
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

        //Back Button metodi Formni yopish uchun
        private void btBack_Click(object sender, EventArgs e)
        {
            //Timerni to'xtatib ketadi

            if (Timer != null)
            {
                Timer.Stop();
                m = 0; s = 0;
                lbRtimer.Text = m + ":" + s;
                lbTtime.Text = "0";
            }
            //Fail yaratilgan bo'lsa ochirib chiqib ketadi
            if(cbSelectFan.SelectedItem!= null) 
            {
                StudentLoginForm studentLogin = new StudentLoginForm();
                string jsonFileName = $@"{cbSelectFan.SelectedItem.ToString()} ({studentLogin.Student_Fulname}).json";
                string Main_path = Path.Combine(resultFilePath, jsonFileName);
                if (File.Exists(Main_path))
                {
                    var fileDel = new FileInfo(Main_path);
                    fileDel.Delete();
                }

            }
            
            //Formni yopadi
            this.Close();

            //Aynan Hide bo'lgan Formni show qiladi
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














