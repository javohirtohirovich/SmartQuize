namespace Quize
{
    partial class SignIn
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
            this.lbSignIn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSignInUser = new System.Windows.Forms.TextBox();
            this.tbSignInPasw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btSignInBack = new System.Windows.Forms.Button();
            this.btSignIn = new System.Windows.Forms.Button();
            this.btSiInSignUp = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbSignIn
            // 
            this.lbSignIn.AutoSize = true;
            this.lbSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSignIn.Location = new System.Drawing.Point(130, 26);
            this.lbSignIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSignIn.Name = "lbSignIn";
            this.lbSignIn.Size = new System.Drawing.Size(126, 35);
            this.lbSignIn.TabIndex = 0;
            this.lbSignIn.Text = "Sign in:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(43, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // tbSignInUser
            // 
            this.tbSignInUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbSignInUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSignInUser.Location = new System.Drawing.Point(46, 129);
            this.tbSignInUser.Margin = new System.Windows.Forms.Padding(2);
            this.tbSignInUser.Name = "tbSignInUser";
            this.tbSignInUser.Size = new System.Drawing.Size(264, 26);
            this.tbSignInUser.TabIndex = 2;
            // 
            // tbSignInPasw
            // 
            this.tbSignInPasw.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbSignInPasw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSignInPasw.Location = new System.Drawing.Point(46, 210);
            this.tbSignInPasw.Margin = new System.Windows.Forms.Padding(2);
            this.tbSignInPasw.Name = "tbSignInPasw";
            this.tbSignInPasw.Size = new System.Drawing.Size(264, 26);
            this.tbSignInPasw.TabIndex = 4;
            this.tbSignInPasw.UseSystemPasswordChar = true;
            this.tbSignInPasw.TextChanged += new System.EventHandler(this.tbSignInPasw_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(43, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // btSignInBack
            // 
            this.btSignInBack.BackColor = System.Drawing.Color.Tomato;
            this.btSignInBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSignInBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSignInBack.Location = new System.Drawing.Point(0, 331);
            this.btSignInBack.Margin = new System.Windows.Forms.Padding(2);
            this.btSignInBack.Name = "btSignInBack";
            this.btSignInBack.Size = new System.Drawing.Size(77, 40);
            this.btSignInBack.TabIndex = 5;
            this.btSignInBack.Text = "<Back";
            this.btSignInBack.UseVisualStyleBackColor = false;
            this.btSignInBack.Click += new System.EventHandler(this.btSignInBack_Click);
            // 
            // btSignIn
            // 
            this.btSignIn.BackColor = System.Drawing.Color.Tomato;
            this.btSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSignIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSignIn.Location = new System.Drawing.Point(208, 260);
            this.btSignIn.Margin = new System.Windows.Forms.Padding(2);
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Size = new System.Drawing.Size(78, 41);
            this.btSignIn.TabIndex = 6;
            this.btSignIn.Text = "Sign in";
            this.btSignIn.UseVisualStyleBackColor = false;
            this.btSignIn.Click += new System.EventHandler(this.btSignIn_Click);
            // 
            // btSiInSignUp
            // 
            this.btSiInSignUp.BackColor = System.Drawing.Color.Tomato;
            this.btSiInSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSiInSignUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSiInSignUp.Location = new System.Drawing.Point(62, 260);
            this.btSiInSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btSiInSignUp.Name = "btSiInSignUp";
            this.btSiInSignUp.Size = new System.Drawing.Size(78, 41);
            this.btSiInSignUp.TabIndex = 7;
            this.btSiInSignUp.Text = "Sign up";
            this.btSiInSignUp.UseVisualStyleBackColor = false;
            this.btSiInSignUp.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(314, 210);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 28);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "👁";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(363, 373);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btSiInSignUp);
            this.Controls.Add(this.btSignIn);
            this.Controls.Add(this.btSignInBack);
            this.Controls.Add(this.tbSignInPasw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSignInUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSignIn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSignInUser;
        private System.Windows.Forms.TextBox tbSignInPasw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSignInBack;
        private System.Windows.Forms.Button btSignIn;
        private System.Windows.Forms.Button btSiInSignUp;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}