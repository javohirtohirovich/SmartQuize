namespace Quize
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.xuiSuperButton1 = new XanderUI.XUISuperButton();
            this.btTeacher = new XanderUI.XUISuperButton();
            this.btStudent = new XanderUI.XUISuperButton();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.xuiBanner1 = new XanderUI.XUIBanner();
            this.xuiGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiSuperButton1
            // 
            this.xuiSuperButton1.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.xuiSuperButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiSuperButton1.ButtonImage")));
            this.xuiSuperButton1.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton1.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton1.ButtonText = "Sign Up";
            this.xuiSuperButton1.CornerRadius = 10;
            this.xuiSuperButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xuiSuperButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton1.HoverBackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.xuiSuperButton1.HoverTextColor = System.Drawing.Color.Gold;
            this.xuiSuperButton1.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton1.Location = new System.Drawing.Point(997, 12);
            this.xuiSuperButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xuiSuperButton1.Name = "xuiSuperButton1";
            this.xuiSuperButton1.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.xuiSuperButton1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Size = new System.Drawing.Size(116, 49);
            this.xuiSuperButton1.SuperSelected = false;
            this.xuiSuperButton1.TabIndex = 4;
            this.xuiSuperButton1.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton1.Click += new System.EventHandler(this.xuiSuperButton1_Click);
            // 
            // btTeacher
            // 
            this.btTeacher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btTeacher.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btTeacher.ButtonImage")));
            this.btTeacher.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btTeacher.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btTeacher.ButtonText = "O\'qituvchi";
            this.btTeacher.CornerRadius = 15;
            this.btTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btTeacher.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btTeacher.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btTeacher.HoverTextColor = System.Drawing.Color.Gold;
            this.btTeacher.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btTeacher.Location = new System.Drawing.Point(639, 342);
            this.btTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTeacher.Name = "btTeacher";
            this.btTeacher.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btTeacher.SelectedTextColor = System.Drawing.Color.White;
            this.btTeacher.Size = new System.Drawing.Size(433, 177);
            this.btTeacher.SuperSelected = false;
            this.btTeacher.TabIndex = 5;
            this.btTeacher.TextColor = System.Drawing.Color.White;
            this.btTeacher.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btTeacher.Click += new System.EventHandler(this.xuiSuperButton2_Click);
            // 
            // btStudent
            // 
            this.btStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btStudent.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btStudent.ButtonImage")));
            this.btStudent.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btStudent.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btStudent.ButtonText = "O\'quvchi";
            this.btStudent.CornerRadius = 15;
            this.btStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStudent.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btStudent.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btStudent.HoverTextColor = System.Drawing.Color.White;
            this.btStudent.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btStudent.Location = new System.Drawing.Point(64, 342);
            this.btStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btStudent.Name = "btStudent";
            this.btStudent.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btStudent.SelectedTextColor = System.Drawing.Color.White;
            this.btStudent.Size = new System.Drawing.Size(433, 177);
            this.btStudent.SuperSelected = false;
            this.btStudent.TabIndex = 6;
            this.btStudent.TextColor = System.Drawing.Color.White;
            this.btStudent.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btStudent.Click += new System.EventHandler(this.btStudent_Click_1);
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.MediumSpringGreen;
            this.xuiGradientPanel1.Controls.Add(this.xuiBanner1);
            this.xuiGradientPanel1.Controls.Add(this.xuiSuperButton1);
            this.xuiGradientPanel1.Controls.Add(this.btTeacher);
            this.xuiGradientPanel1.Controls.Add(this.btStudent);
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(1128, 674);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 7;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // xuiBanner1
            // 
            this.xuiBanner1.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner1.BannerColor = System.Drawing.Color.MediumSeaGreen;
            this.xuiBanner1.BorderColor = System.Drawing.Color.LimeGreen;
            this.xuiBanner1.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiBanner1.ForeColor = System.Drawing.Color.White;
            this.xuiBanner1.Location = new System.Drawing.Point(216, 39);
            this.xuiBanner1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xuiBanner1.Name = "xuiBanner1";
            this.xuiBanner1.Size = new System.Drawing.Size(691, 146);
            this.xuiBanner1.TabIndex = 7;
            this.xuiBanner1.Text = "SmartQuize  ga  Xush kelibsiz! ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1127, 665);
            this.Controls.Add(this.xuiGradientPanel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartQuize";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.xuiGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private XanderUI.XUISuperButton xuiSuperButton1;
        private XanderUI.XUISuperButton btTeacher;
        private XanderUI.XUISuperButton btStudent;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private XanderUI.XUIBanner xuiBanner1;
    }
}

