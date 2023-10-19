namespace Quize.Student
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.WorkingArea = new System.Windows.Forms.Panel();
            this.lbFilePath = new System.Windows.Forms.Label();
            this.btView = new XanderUI.XUISuperButton();
            this.lbErrors = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbCorrects = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.progressBar = new XanderUI.XUICircleProgressBar();
            this.lbTestlarSoni = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btBack = new XanderUI.XUISuperButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xuiBanner1 = new XanderUI.XUIBanner();
            this.btExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkingArea
            // 
            this.WorkingArea.AutoScroll = true;
            this.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.WorkingArea.Location = new System.Drawing.Point(0, 48);
            this.WorkingArea.Margin = new System.Windows.Forms.Padding(4);
            this.WorkingArea.Name = "WorkingArea";
            this.WorkingArea.Size = new System.Drawing.Size(596, 704);
            this.WorkingArea.TabIndex = 0;
            // 
            // lbFilePath
            // 
            this.lbFilePath.AutoSize = true;
            this.lbFilePath.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbFilePath.Location = new System.Drawing.Point(50, 73);
            this.lbFilePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(47, 13);
            this.lbFilePath.TabIndex = 14;
            this.lbFilePath.Text = "file_path";
            // 
            // btView
            // 
            this.btView.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.btView.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btView.ButtonImage")));
            this.btView.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btView.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btView.ButtonText = "Testni taxlil qilish";
            this.btView.CornerRadius = 5;
            this.btView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btView.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btView.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btView.HoverTextColor = System.Drawing.Color.Gold;
            this.btView.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btView.Location = new System.Drawing.Point(308, 394);
            this.btView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btView.Name = "btView";
            this.btView.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btView.SelectedTextColor = System.Drawing.Color.DarkOrange;
            this.btView.Size = new System.Drawing.Size(209, 47);
            this.btView.SuperSelected = false;
            this.btView.TabIndex = 13;
            this.btView.TextColor = System.Drawing.Color.Gold;
            this.btView.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btView.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // lbErrors
            // 
            this.lbErrors.AutoSize = false;
            this.lbErrors.AutoSizeHeightOnly = true;
            this.lbErrors.AvoidGeometryAntialias = true;
            this.lbErrors.BackColor = System.Drawing.Color.Transparent;
            this.lbErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbErrors.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbErrors.Location = new System.Drawing.Point(42, 243);
            this.lbErrors.Name = "lbErrors";
            this.lbErrors.Size = new System.Drawing.Size(226, 32);
            this.lbErrors.TabIndex = 12;
            this.lbErrors.Text = "Xato javoblar soni:";
            // 
            // lbCorrects
            // 
            this.lbCorrects.AutoSize = false;
            this.lbCorrects.AutoSizeHeightOnly = true;
            this.lbCorrects.AvoidGeometryAntialias = true;
            this.lbCorrects.BackColor = System.Drawing.Color.Transparent;
            this.lbCorrects.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCorrects.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbCorrects.Location = new System.Drawing.Point(42, 320);
            this.lbCorrects.Name = "lbCorrects";
            this.lbCorrects.Size = new System.Drawing.Size(237, 32);
            this.lbCorrects.TabIndex = 11;
            this.lbCorrects.Text = "To\'gri javoblar soni:";
            // 
            // progressBar
            // 
            this.progressBar.AnimationSpeed = 5;
            this.progressBar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progressBar.FilledColor = System.Drawing.Color.Goldenrod;
            this.progressBar.FilledColorAlpha = 130;
            this.progressBar.FilledThickness = 40;
            this.progressBar.IsAnimated = true;
            this.progressBar.Location = new System.Drawing.Point(555, 119);
            this.progressBar.Name = "progressBar";
            this.progressBar.Percentage = 100;
            this.progressBar.ShowText = true;
            this.progressBar.Size = new System.Drawing.Size(267, 259);
            this.progressBar.TabIndex = 8;
            this.progressBar.TextColor = System.Drawing.Color.Goldenrod;
            this.progressBar.TextSize = 25;
            this.progressBar.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.progressBar.UnfilledThickness = 24;
            // 
            // lbTestlarSoni
            // 
            this.lbTestlarSoni.AutoSize = false;
            this.lbTestlarSoni.AutoSizeHeightOnly = true;
            this.lbTestlarSoni.AvoidGeometryAntialias = true;
            this.lbTestlarSoni.BackColor = System.Drawing.Color.Transparent;
            this.lbTestlarSoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTestlarSoni.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbTestlarSoni.Location = new System.Drawing.Point(42, 174);
            this.lbTestlarSoni.Name = "lbTestlarSoni";
            this.lbTestlarSoni.Size = new System.Drawing.Size(152, 32);
            this.lbTestlarSoni.TabIndex = 10;
            this.lbTestlarSoni.Text = "Testlar soni:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 15;
            // 
            // btBack
            // 
            this.btBack.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.btBack.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btBack.ButtonImage")));
            this.btBack.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btBack.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btBack.ButtonText = "Orqaga";
            this.btBack.CornerRadius = 10;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBack.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btBack.HoverBackgroundColor = System.Drawing.Color.Yellow;
            this.btBack.HoverTextColor = System.Drawing.Color.White;
            this.btBack.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btBack.Location = new System.Drawing.Point(9, 9);
            this.btBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBack.Name = "btBack";
            this.btBack.SelectedBackColor = System.Drawing.Color.Gold;
            this.btBack.SelectedTextColor = System.Drawing.Color.White;
            this.btBack.Size = new System.Drawing.Size(113, 40);
            this.btBack.SuperSelected = false;
            this.btBack.TabIndex = 16;
            this.btBack.TextColor = System.Drawing.Color.White;
            this.btBack.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btBack.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(32, 445);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 187);
            this.panel1.TabIndex = 17;
            // 
            // xuiBanner1
            // 
            this.xuiBanner1.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner1.BannerColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.xuiBanner1.BorderColor = System.Drawing.Color.Goldenrod;
            this.xuiBanner1.Font = new System.Drawing.Font("Javanese Text", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiBanner1.ForeColor = System.Drawing.Color.Goldenrod;
            this.xuiBanner1.Location = new System.Drawing.Point(169, 10);
            this.xuiBanner1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xuiBanner1.Name = "xuiBanner1";
            this.xuiBanner1.Size = new System.Drawing.Size(544, 76);
            this.xuiBanner1.TabIndex = 18;
            this.xuiBanner1.Text = "!!! Sizning Natijangiz !!!";
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExit.Location = new System.Drawing.Point(834, 0);
            this.btExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(30, 31);
            this.btExit.TabIndex = 20;
            this.btExit.Text = "X";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(865, 641);
            this.ControlBox = false;
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.xuiBanner1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.lbFilePath);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.lbErrors);
            this.Controls.Add(this.lbCorrects);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lbTestlarSoni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultForm";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel WorkingArea;
        public System.Windows.Forms.Label lbFilePath;
        private XanderUI.XUISuperButton btView;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbErrors;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbCorrects;
        private XanderUI.XUICircleProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTestlarSoni;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUISuperButton btBack;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIBanner xuiBanner1;
        private System.Windows.Forms.Button btExit;
    }
}