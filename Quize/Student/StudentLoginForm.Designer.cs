namespace Quize.Student
{
    partial class StudentLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLoginForm));
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbSFullName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btSatart = new XanderUI.XUISuperButton();
            this.xuiSuperButton1 = new XanderUI.XUISuperButton();
            this.btX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.ForeColor = System.Drawing.Color.Gold;
            this.lbLogin.Location = new System.Drawing.Point(191, 11);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(250, 36);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Ro\'yxatdan o\'tish!";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFullName.ForeColor = System.Drawing.Color.Gold;
            this.lbFullName.Location = new System.Drawing.Point(31, 102);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(123, 29);
            this.lbFullName.TabIndex = 1;
            this.lbFullName.Text = "To\'liq Ism:";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAge.ForeColor = System.Drawing.Color.Gold;
            this.lbAge.Location = new System.Drawing.Point(31, 186);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(74, 29);
            this.lbAge.TabIndex = 2;
            this.lbAge.Text = "Yosh:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEmail.ForeColor = System.Drawing.Color.Gold;
            this.lbEmail.Location = new System.Drawing.Point(31, 270);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(80, 29);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Email:";
            // 
            // tbSFullName
            // 
            this.tbSFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSFullName.Location = new System.Drawing.Point(167, 102);
            this.tbSFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSFullName.Name = "tbSFullName";
            this.tbSFullName.Size = new System.Drawing.Size(437, 34);
            this.tbSFullName.TabIndex = 4;
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAge.Location = new System.Drawing.Point(167, 183);
            this.tbAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(437, 34);
            this.tbAge.TabIndex = 5;
            
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmail.Location = new System.Drawing.Point(167, 263);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(437, 34);
            this.tbEmail.TabIndex = 6;
            // 
            // btSatart
            // 
            this.btSatart.BackgroundColor = System.Drawing.Color.Gold;
            this.btSatart.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btSatart.ButtonImage")));
            this.btSatart.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btSatart.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btSatart.ButtonText = "START";
            this.btSatart.CornerRadius = 10;
            this.btSatart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSatart.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btSatart.HoverBackgroundColor = System.Drawing.Color.Yellow;
            this.btSatart.HoverTextColor = System.Drawing.Color.White;
            this.btSatart.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btSatart.Location = new System.Drawing.Point(288, 321);
            this.btSatart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSatart.Name = "btSatart";
            this.btSatart.SelectedBackColor = System.Drawing.Color.Gold;
            this.btSatart.SelectedTextColor = System.Drawing.Color.White;
            this.btSatart.Size = new System.Drawing.Size(145, 49);
            this.btSatart.SuperSelected = false;
            this.btSatart.TabIndex = 7;
            this.btSatart.TextColor = System.Drawing.Color.White;
            this.btSatart.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btSatart.Click += new System.EventHandler(this.xuiSuperButton1_Click);
            // 
            // xuiSuperButton1
            // 
            this.xuiSuperButton1.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.xuiSuperButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiSuperButton1.ButtonImage")));
            this.xuiSuperButton1.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton1.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton1.ButtonText = "BACK";
            this.xuiSuperButton1.CornerRadius = 10;
            this.xuiSuperButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xuiSuperButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton1.HoverBackgroundColor = System.Drawing.Color.Yellow;
            this.xuiSuperButton1.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton1.Location = new System.Drawing.Point(12, 362);
            this.xuiSuperButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xuiSuperButton1.Name = "xuiSuperButton1";
            this.xuiSuperButton1.SelectedBackColor = System.Drawing.Color.Gold;
            this.xuiSuperButton1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Size = new System.Drawing.Size(116, 49);
            this.xuiSuperButton1.SuperSelected = false;
            this.xuiSuperButton1.TabIndex = 8;
            this.xuiSuperButton1.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton1.Click += new System.EventHandler(this.xuiSuperButton1_Click_1);
            // 
            // btX
            // 
            this.btX.BackColor = System.Drawing.Color.Red;
            this.btX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btX.Location = new System.Drawing.Point(596, 0);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(42, 35);
            this.btX.TabIndex = 9;
            this.btX.Text = "X";
            this.btX.UseVisualStyleBackColor = false;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // StudentLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(641, 415);
            this.ControlBox = false;
            this.Controls.Add(this.btX);
            this.Controls.Add(this.xuiSuperButton1);
            this.Controls.Add(this.btSatart);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbSFullName);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.lbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentLoginForm";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbEmail;
        private XanderUI.XUISuperButton btSatart;
        public System.Windows.Forms.TextBox tbSFullName;
        private XanderUI.XUISuperButton xuiSuperButton1;
        private System.Windows.Forms.Button btX;
    }
}