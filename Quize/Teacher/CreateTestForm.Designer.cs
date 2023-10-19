namespace Quize.Teacher
{
    partial class CreateTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTestForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cbFanlar = new System.Windows.Forms.ComboBox();
            this.cbIshlashVat = new System.Windows.Forms.ComboBox();
            this.cbTestsSoni = new System.Windows.Forms.ComboBox();
            this.cbTestDarajasi = new System.Windows.Forms.ComboBox();
            this.lbTest_num = new System.Windows.Forms.Label();
            this.rtbTestWrite = new System.Windows.Forms.RichTextBox();
            this.tbAwrite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBwrite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDwrite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCwrite = new System.Windows.Forms.TextBox();
            this.lbCorrect = new System.Windows.Forms.Label();
            this.tbCorrect = new System.Windows.Forms.TextBox();
            this.btCrtTestGo = new XanderUI.XUISuperButton();
            this.btCreatTestBack = new XanderUI.XUISuperButton();
            this.btAdd = new XanderUI.XUISuperButton();
            this.btClear = new XanderUI.XUISuperButton();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(464, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "! ! ! Creating Test ! ! !";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbFanlar
            // 
            this.cbFanlar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbFanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFanlar.FormattingEnabled = true;
            this.cbFanlar.Items.AddRange(new object[] {
            "Matematika",
            "Ona tili",
            "Adabiyot",
            "Rus tili",
            "Ingiliz tili",
            "Tarix",
            "Kimyo",
            "Fizika",
            "Biologiya",
            "Informatika"});
            this.cbFanlar.Location = new System.Drawing.Point(56, 97);
            this.cbFanlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFanlar.Name = "cbFanlar";
            this.cbFanlar.Size = new System.Drawing.Size(185, 37);
            this.cbFanlar.TabIndex = 1;
            this.cbFanlar.Text = "Fan:";
            this.cbFanlar.SelectedIndexChanged += new System.EventHandler(this.cbFanlar_SelectedIndexChanged);
            // 
            // cbIshlashVat
            // 
            this.cbIshlashVat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbIshlashVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbIshlashVat.FormattingEnabled = true;
            this.cbIshlashVat.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.cbIshlashVat.Location = new System.Drawing.Point(573, 97);
            this.cbIshlashVat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIshlashVat.Name = "cbIshlashVat";
            this.cbIshlashVat.Size = new System.Drawing.Size(185, 37);
            this.cbIshlashVat.TabIndex = 2;
            this.cbIshlashVat.Text = "Ishlash vaqti:";
            this.cbIshlashVat.SelectedIndexChanged += new System.EventHandler(this.cbIshlashVat_SelectedIndexChanged);
            // 
            // cbTestsSoni
            // 
            this.cbTestsSoni.AutoCompleteCustomSource.AddRange(new string[] {
            "10"});
            this.cbTestsSoni.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbTestsSoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTestsSoni.FormattingEnabled = true;
            this.cbTestsSoni.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.cbTestsSoni.Location = new System.Drawing.Point(309, 97);
            this.cbTestsSoni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTestsSoni.Name = "cbTestsSoni";
            this.cbTestsSoni.Size = new System.Drawing.Size(185, 37);
            this.cbTestsSoni.TabIndex = 3;
            this.cbTestsSoni.Text = "Testlar Soni:";
            this.cbTestsSoni.SelectedIndexChanged += new System.EventHandler(this.cbTestsSoni_SelectedIndexChanged);
            // 
            // cbTestDarajasi
            // 
            this.cbTestDarajasi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbTestDarajasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTestDarajasi.FormattingEnabled = true;
            this.cbTestDarajasi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbTestDarajasi.Location = new System.Drawing.Point(840, 97);
            this.cbTestDarajasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTestDarajasi.Name = "cbTestDarajasi";
            this.cbTestDarajasi.Size = new System.Drawing.Size(185, 37);
            this.cbTestDarajasi.TabIndex = 4;
            this.cbTestDarajasi.Text = "Test darajasi:";
            // 
            // lbTest_num
            // 
            this.lbTest_num.AutoSize = true;
            this.lbTest_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTest_num.Location = new System.Drawing.Point(56, 150);
            this.lbTest_num.Name = "lbTest_num";
            this.lbTest_num.Size = new System.Drawing.Size(102, 32);
            this.lbTest_num.TabIndex = 7;
            this.lbTest_num.Text = "Test-1:";
            // 
            // rtbTestWrite
            // 
            this.rtbTestWrite.BackColor = System.Drawing.Color.DarkGray;
            this.rtbTestWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbTestWrite.Location = new System.Drawing.Point(56, 185);
            this.rtbTestWrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbTestWrite.Name = "rtbTestWrite";
            this.rtbTestWrite.Size = new System.Drawing.Size(1268, 186);
            this.rtbTestWrite.TabIndex = 8;
            this.rtbTestWrite.Text = "";
            // 
            // tbAwrite
            // 
            this.tbAwrite.BackColor = System.Drawing.Color.DarkGray;
            this.tbAwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAwrite.Location = new System.Drawing.Point(104, 421);
            this.tbAwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAwrite.MaxLength = 100;
            this.tbAwrite.Name = "tbAwrite";
            this.tbAwrite.Size = new System.Drawing.Size(553, 38);
            this.tbAwrite.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(56, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "A)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(688, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "B)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbBwrite
            // 
            this.tbBwrite.BackColor = System.Drawing.Color.DarkGray;
            this.tbBwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBwrite.Location = new System.Drawing.Point(736, 421);
            this.tbBwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBwrite.MaxLength = 100;
            this.tbBwrite.Name = "tbBwrite";
            this.tbBwrite.Size = new System.Drawing.Size(588, 38);
            this.tbBwrite.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(688, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "D)";
            // 
            // tbDwrite
            // 
            this.tbDwrite.BackColor = System.Drawing.Color.DarkGray;
            this.tbDwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDwrite.Location = new System.Drawing.Point(736, 526);
            this.tbDwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDwrite.MaxLength = 100;
            this.tbDwrite.Name = "tbDwrite";
            this.tbDwrite.Size = new System.Drawing.Size(588, 38);
            this.tbDwrite.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(51, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "C)";
            // 
            // tbCwrite
            // 
            this.tbCwrite.BackColor = System.Drawing.Color.DarkGray;
            this.tbCwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCwrite.Location = new System.Drawing.Point(104, 528);
            this.tbCwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCwrite.MaxLength = 100;
            this.tbCwrite.Name = "tbCwrite";
            this.tbCwrite.Size = new System.Drawing.Size(553, 38);
            this.tbCwrite.TabIndex = 13;
            // 
            // lbCorrect
            // 
            this.lbCorrect.AutoSize = true;
            this.lbCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCorrect.Location = new System.Drawing.Point(264, 614);
            this.lbCorrect.Name = "lbCorrect";
            this.lbCorrect.Size = new System.Drawing.Size(114, 32);
            this.lbCorrect.TabIndex = 19;
            this.lbCorrect.Text = "Correct:";
            // 
            // tbCorrect
            // 
            this.tbCorrect.BackColor = System.Drawing.Color.DarkGray;
            this.tbCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCorrect.Location = new System.Drawing.Point(384, 614);
            this.tbCorrect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCorrect.MaxLength = 100;
            this.tbCorrect.Name = "tbCorrect";
            this.tbCorrect.Size = new System.Drawing.Size(553, 38);
            this.tbCorrect.TabIndex = 20;
            // 
            // btCrtTestGo
            // 
            this.btCrtTestGo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btCrtTestGo.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btCrtTestGo.ButtonImage")));
            this.btCrtTestGo.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btCrtTestGo.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btCrtTestGo.ButtonText = "Start";
            this.btCrtTestGo.CornerRadius = 5;
            this.btCrtTestGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCrtTestGo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btCrtTestGo.HoverBackgroundColor = System.Drawing.Color.LimeGreen;
            this.btCrtTestGo.HoverTextColor = System.Drawing.Color.White;
            this.btCrtTestGo.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btCrtTestGo.Location = new System.Drawing.Point(1119, 97);
            this.btCrtTestGo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCrtTestGo.Name = "btCrtTestGo";
            this.btCrtTestGo.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btCrtTestGo.SelectedTextColor = System.Drawing.Color.White;
            this.btCrtTestGo.Size = new System.Drawing.Size(205, 47);
            this.btCrtTestGo.SuperSelected = false;
            this.btCrtTestGo.TabIndex = 21;
            this.btCrtTestGo.TextColor = System.Drawing.Color.White;
            this.btCrtTestGo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btCrtTestGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCreatTestBack
            // 
            this.btCreatTestBack.BackgroundColor = System.Drawing.Color.Coral;
            this.btCreatTestBack.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btCreatTestBack.ButtonImage")));
            this.btCreatTestBack.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btCreatTestBack.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btCreatTestBack.ButtonText = "SuperButton";
            this.btCreatTestBack.CornerRadius = 5;
            this.btCreatTestBack.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btCreatTestBack.HoverBackgroundColor = System.Drawing.Color.OrangeRed;
            this.btCreatTestBack.HoverTextColor = System.Drawing.Color.White;
            this.btCreatTestBack.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btCreatTestBack.Location = new System.Drawing.Point(11, 705);
            this.btCreatTestBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCreatTestBack.Name = "btCreatTestBack";
            this.btCreatTestBack.SelectedBackColor = System.Drawing.Color.Coral;
            this.btCreatTestBack.SelectedTextColor = System.Drawing.Color.White;
            this.btCreatTestBack.Size = new System.Drawing.Size(147, 53);
            this.btCreatTestBack.SuperSelected = false;
            this.btCreatTestBack.TabIndex = 22;
            this.btCreatTestBack.TextColor = System.Drawing.Color.White;
            this.btCreatTestBack.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btCreatTestBack.Click += new System.EventHandler(this.btCreatTestBack_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btAdd.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btAdd.ButtonImage")));
            this.btAdd.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btAdd.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btAdd.ButtonText = "Add";
            this.btAdd.CornerRadius = 5;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAdd.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btAdd.HoverBackgroundColor = System.Drawing.Color.LimeGreen;
            this.btAdd.HoverTextColor = System.Drawing.Color.White;
            this.btAdd.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btAdd.Location = new System.Drawing.Point(765, 678);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btAdd.Name = "btAdd";
            this.btAdd.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btAdd.SelectedTextColor = System.Drawing.Color.White;
            this.btAdd.Size = new System.Drawing.Size(173, 65);
            this.btAdd.SuperSelected = false;
            this.btAdd.TabIndex = 47;
            this.btAdd.TextColor = System.Drawing.Color.White;
            this.btAdd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btClear
            // 
            this.btClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btClear.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btClear.ButtonImage")));
            this.btClear.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btClear.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btClear.ButtonText = "CLEAR";
            this.btClear.CornerRadius = 5;
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btClear.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btClear.HoverBackgroundColor = System.Drawing.Color.LimeGreen;
            this.btClear.HoverTextColor = System.Drawing.Color.White;
            this.btClear.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btClear.Location = new System.Drawing.Point(384, 678);
            this.btClear.Margin = new System.Windows.Forms.Padding(4);
            this.btClear.Name = "btClear";
            this.btClear.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btClear.SelectedTextColor = System.Drawing.Color.White;
            this.btClear.Size = new System.Drawing.Size(173, 65);
            this.btClear.SuperSelected = false;
            this.btClear.TabIndex = 46;
            this.btClear.TextColor = System.Drawing.Color.White;
            this.btClear.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btExit.Location = new System.Drawing.Point(1321, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(57, 40);
            this.btExit.TabIndex = 48;
            this.btExit.Text = "X";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // CreateTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1379, 779);
            this.ControlBox = false;
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCreatTestBack);
            this.Controls.Add(this.btCrtTestGo);
            this.Controls.Add(this.cbFanlar);
            this.Controls.Add(this.cbTestDarajasi);
            this.Controls.Add(this.tbCorrect);
            this.Controls.Add(this.cbTestsSoni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTest_num);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbCorrect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbIshlashVat);
            this.Controls.Add(this.rtbTestWrite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbBwrite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDwrite);
            this.Controls.Add(this.tbCwrite);
            this.Controls.Add(this.tbAwrite);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateTestForm";
            this.Load += new System.EventHandler(this.CreateTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIshlashVat;
        private System.Windows.Forms.ComboBox cbTestDarajasi;
        public System.Windows.Forms.ComboBox cbTestsSoni;
        public System.Windows.Forms.ComboBox cbFanlar;
        private System.Windows.Forms.Label lbTest_num;
        private System.Windows.Forms.RichTextBox rtbTestWrite;
        private System.Windows.Forms.TextBox tbAwrite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBwrite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDwrite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCwrite;
        private System.Windows.Forms.Label lbCorrect;
        private System.Windows.Forms.TextBox tbCorrect;
        private XanderUI.XUISuperButton btCrtTestGo;
        private XanderUI.XUISuperButton btCreatTestBack;
        private XanderUI.XUISuperButton btAdd;
        private XanderUI.XUISuperButton btClear;
        private System.Windows.Forms.Button btExit;
    }
}