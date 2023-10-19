namespace Quize.Teacher
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btCreatTestBack = new XanderUI.XUISuperButton();
            this.btCrtTestGo = new XanderUI.XUISuperButton();
            this.cbUpFanlar = new System.Windows.Forms.ComboBox();
            this.cbUpTestDarajasi = new System.Windows.Forms.ComboBox();
            this.tbCorrect = new System.Windows.Forms.TextBox();
            this.cbUpTestsSoni = new System.Windows.Forms.ComboBox();
            this.lbTest_num = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCorrect = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbIshlashVat = new System.Windows.Forms.ComboBox();
            this.rtbTestWrite = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBwrite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDwrite = new System.Windows.Forms.TextBox();
            this.tbCwrite = new System.Windows.Forms.TextBox();
            this.tbAwrite = new System.Windows.Forms.TextBox();
            this.btClear = new XanderUI.XUISuperButton();
            this.btAdd = new XanderUI.XUISuperButton();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(472, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "U p d a t e    Q u i z e";
            // 
            // btCreatTestBack
            // 
            this.btCreatTestBack.BackgroundColor = System.Drawing.Color.Coral;
            this.btCreatTestBack.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btCreatTestBack.ButtonImage")));
            this.btCreatTestBack.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btCreatTestBack.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btCreatTestBack.ButtonText = "Back";
            this.btCreatTestBack.CornerRadius = 5;
            this.btCreatTestBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCreatTestBack.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btCreatTestBack.HoverBackgroundColor = System.Drawing.Color.OrangeRed;
            this.btCreatTestBack.HoverTextColor = System.Drawing.Color.White;
            this.btCreatTestBack.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btCreatTestBack.Location = new System.Drawing.Point(12, 679);
            this.btCreatTestBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCreatTestBack.Name = "btCreatTestBack";
            this.btCreatTestBack.SelectedBackColor = System.Drawing.Color.Coral;
            this.btCreatTestBack.SelectedTextColor = System.Drawing.Color.White;
            this.btCreatTestBack.Size = new System.Drawing.Size(147, 53);
            this.btCreatTestBack.SuperSelected = false;
            this.btCreatTestBack.TabIndex = 43;
            this.btCreatTestBack.TextColor = System.Drawing.Color.White;
            this.btCreatTestBack.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btCreatTestBack.Click += new System.EventHandler(this.btCreatTestBack_Click);
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
            this.btCrtTestGo.Location = new System.Drawing.Point(1133, 71);
            this.btCrtTestGo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCrtTestGo.Name = "btCrtTestGo";
            this.btCrtTestGo.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btCrtTestGo.SelectedTextColor = System.Drawing.Color.White;
            this.btCrtTestGo.Size = new System.Drawing.Size(205, 47);
            this.btCrtTestGo.SuperSelected = false;
            this.btCrtTestGo.TabIndex = 42;
            this.btCrtTestGo.TextColor = System.Drawing.Color.White;
            this.btCrtTestGo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btCrtTestGo.Click += new System.EventHandler(this.btCrtTestGo_Click);
            // 
            // cbUpFanlar
            // 
            this.cbUpFanlar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbUpFanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbUpFanlar.FormattingEnabled = true;
            this.cbUpFanlar.Location = new System.Drawing.Point(69, 81);
            this.cbUpFanlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUpFanlar.Name = "cbUpFanlar";
            this.cbUpFanlar.Size = new System.Drawing.Size(185, 37);
            this.cbUpFanlar.TabIndex = 24;
            this.cbUpFanlar.Text = "Fan:";
            // 
            // cbUpTestDarajasi
            // 
            this.cbUpTestDarajasi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbUpTestDarajasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbUpTestDarajasi.FormattingEnabled = true;
            this.cbUpTestDarajasi.Location = new System.Drawing.Point(873, 81);
            this.cbUpTestDarajasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUpTestDarajasi.Name = "cbUpTestDarajasi";
            this.cbUpTestDarajasi.Size = new System.Drawing.Size(185, 37);
            this.cbUpTestDarajasi.TabIndex = 27;
            this.cbUpTestDarajasi.Text = "Test darajasi:";
            // 
            // tbCorrect
            // 
            this.tbCorrect.BackColor = System.Drawing.Color.DarkGray;
            this.tbCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCorrect.Location = new System.Drawing.Point(439, 598);
            this.tbCorrect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCorrect.MaxLength = 100;
            this.tbCorrect.Name = "tbCorrect";
            this.tbCorrect.Size = new System.Drawing.Size(553, 38);
            this.tbCorrect.TabIndex = 41;
            // 
            // cbUpTestsSoni
            // 
            this.cbUpTestsSoni.AutoCompleteCustomSource.AddRange(new string[] {
            "10"});
            this.cbUpTestsSoni.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbUpTestsSoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbUpTestsSoni.FormattingEnabled = true;
            this.cbUpTestsSoni.Items.AddRange(new object[] {
            "3",
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
            this.cbUpTestsSoni.Location = new System.Drawing.Point(349, 81);
            this.cbUpTestsSoni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUpTestsSoni.Name = "cbUpTestsSoni";
            this.cbUpTestsSoni.Size = new System.Drawing.Size(185, 37);
            this.cbUpTestsSoni.TabIndex = 26;
            this.cbUpTestsSoni.Text = "Testlar Soni:";
            // 
            // lbTest_num
            // 
            this.lbTest_num.AutoSize = true;
            this.lbTest_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTest_num.Location = new System.Drawing.Point(69, 134);
            this.lbTest_num.Name = "lbTest_num";
            this.lbTest_num.Size = new System.Drawing.Size(102, 32);
            this.lbTest_num.TabIndex = 28;
            this.lbTest_num.Text = "Test-1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(63, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 33);
            this.label6.TabIndex = 35;
            this.label6.Text = "C)";
            // 
            // lbCorrect
            // 
            this.lbCorrect.AutoSize = true;
            this.lbCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCorrect.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbCorrect.Location = new System.Drawing.Point(307, 598);
            this.lbCorrect.Name = "lbCorrect";
            this.lbCorrect.Size = new System.Drawing.Size(127, 33);
            this.lbCorrect.TabIndex = 40;
            this.lbCorrect.Text = "Correct:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(69, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 33);
            this.label3.TabIndex = 31;
            this.label3.Text = "A)";
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
            this.cbIshlashVat.Location = new System.Drawing.Point(607, 81);
            this.cbIshlashVat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIshlashVat.Name = "cbIshlashVat";
            this.cbIshlashVat.Size = new System.Drawing.Size(185, 37);
            this.cbIshlashVat.TabIndex = 25;
            this.cbIshlashVat.Text = "Ishlash vaqti:";
            // 
            // rtbTestWrite
            // 
            this.rtbTestWrite.BackColor = System.Drawing.Color.DarkGray;
            this.rtbTestWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbTestWrite.Location = new System.Drawing.Point(69, 169);
            this.rtbTestWrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbTestWrite.Name = "rtbTestWrite";
            this.rtbTestWrite.Size = new System.Drawing.Size(1268, 186);
            this.rtbTestWrite.TabIndex = 29;
            this.rtbTestWrite.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(701, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 33);
            this.label5.TabIndex = 37;
            this.label5.Text = "D)";
            // 
            // tbBwrite
            // 
            this.tbBwrite.BackColor = System.Drawing.Color.DarkGray;
            this.tbBwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBwrite.Location = new System.Drawing.Point(749, 405);
            this.tbBwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBwrite.MaxLength = 100;
            this.tbBwrite.Name = "tbBwrite";
            this.tbBwrite.Size = new System.Drawing.Size(588, 38);
            this.tbBwrite.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(701, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 33);
            this.label4.TabIndex = 33;
            this.label4.Text = "B)";
            // 
            // tbDwrite
            // 
            this.tbDwrite.BackColor = System.Drawing.Color.DarkGray;
            this.tbDwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDwrite.Location = new System.Drawing.Point(749, 506);
            this.tbDwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDwrite.MaxLength = 100;
            this.tbDwrite.Name = "tbDwrite";
            this.tbDwrite.Size = new System.Drawing.Size(588, 38);
            this.tbDwrite.TabIndex = 36;
            // 
            // tbCwrite
            // 
            this.tbCwrite.BackColor = System.Drawing.Color.DarkGray;
            this.tbCwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCwrite.Location = new System.Drawing.Point(117, 510);
            this.tbCwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCwrite.MaxLength = 100;
            this.tbCwrite.Name = "tbCwrite";
            this.tbCwrite.Size = new System.Drawing.Size(553, 38);
            this.tbCwrite.TabIndex = 34;
            // 
            // tbAwrite
            // 
            this.tbAwrite.BackColor = System.Drawing.Color.DarkGray;
            this.tbAwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAwrite.Location = new System.Drawing.Point(117, 405);
            this.tbAwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAwrite.MaxLength = 100;
            this.tbAwrite.Name = "tbAwrite";
            this.tbAwrite.Size = new System.Drawing.Size(553, 38);
            this.tbAwrite.TabIndex = 30;
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
            this.btClear.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btClear.HoverTextColor = System.Drawing.Color.White;
            this.btClear.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btClear.Location = new System.Drawing.Point(439, 663);
            this.btClear.Margin = new System.Windows.Forms.Padding(4);
            this.btClear.Name = "btClear";
            this.btClear.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btClear.SelectedTextColor = System.Drawing.Color.White;
            this.btClear.Size = new System.Drawing.Size(173, 65);
            this.btClear.SuperSelected = false;
            this.btClear.TabIndex = 44;
            this.btClear.TextColor = System.Drawing.Color.White;
            this.btClear.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btAdd.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btAdd.ButtonImage")));
            this.btAdd.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btAdd.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btAdd.ButtonText = "Next";
            this.btAdd.CornerRadius = 5;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAdd.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btAdd.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btAdd.HoverTextColor = System.Drawing.Color.White;
            this.btAdd.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btAdd.Location = new System.Drawing.Point(820, 663);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btAdd.Name = "btAdd";
            this.btAdd.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btAdd.SelectedTextColor = System.Drawing.Color.White;
            this.btAdd.Size = new System.Drawing.Size(173, 65);
            this.btAdd.SuperSelected = false;
            this.btAdd.TabIndex = 45;
            this.btAdd.TextColor = System.Drawing.Color.White;
            this.btAdd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btExit.Location = new System.Drawing.Point(1342, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(57, 40);
            this.btExit.TabIndex = 49;
            this.btExit.Text = "X";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 743);
            this.ControlBox = false;
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCreatTestBack);
            this.Controls.Add(this.btCrtTestGo);
            this.Controls.Add(this.cbUpFanlar);
            this.Controls.Add(this.cbUpTestDarajasi);
            this.Controls.Add(this.tbCorrect);
            this.Controls.Add(this.cbUpTestsSoni);
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
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private XanderUI.XUISuperButton btCreatTestBack;
        private XanderUI.XUISuperButton btCrtTestGo;
        public System.Windows.Forms.ComboBox cbUpFanlar;
        private System.Windows.Forms.TextBox tbCorrect;
        private System.Windows.Forms.Label lbTest_num;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCorrect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbIshlashVat;
        private System.Windows.Forms.RichTextBox rtbTestWrite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBwrite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDwrite;
        private System.Windows.Forms.TextBox tbCwrite;
        private System.Windows.Forms.TextBox tbAwrite;
        public System.Windows.Forms.ComboBox cbUpTestDarajasi;
        private XanderUI.XUISuperButton btClear;
        private XanderUI.XUISuperButton btAdd;
        public System.Windows.Forms.ComboBox cbUpTestsSoni;
        private System.Windows.Forms.Button btExit;
    }
}