namespace ClassManagementSystemWinForms
{
    partial class StudentRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNIU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCariNIU = new System.Windows.Forms.Button();
            this.txtOtherProdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbTE = new System.Windows.Forms.RadioButton();
            this.rbTIF = new System.Windows.Forms.RadioButton();
            this.rbTB = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(90, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username*";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(90, 141);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(446, 33);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(90, 456);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(446, 33);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(90, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(132, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 70);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Register";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(424, 582);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(112, 41);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Daftar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(90, 304);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(446, 33);
            this.txtName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(90, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nama";
            // 
            // txtNIU
            // 
            this.txtNIU.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNIU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNIU.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNIU.Location = new System.Drawing.Point(90, 226);
            this.txtNIU.Name = "txtNIU";
            this.txtNIU.Size = new System.Drawing.Size(298, 33);
            this.txtNIU.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(90, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "NIU";
            // 
            // btnCariNIU
            // 
            this.btnCariNIU.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCariNIU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariNIU.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCariNIU.ForeColor = System.Drawing.Color.White;
            this.btnCariNIU.Location = new System.Drawing.Point(424, 226);
            this.btnCariNIU.Name = "btnCariNIU";
            this.btnCariNIU.Size = new System.Drawing.Size(112, 33);
            this.btnCariNIU.TabIndex = 11;
            this.btnCariNIU.Text = "Cari";
            this.btnCariNIU.UseVisualStyleBackColor = false;
            this.btnCariNIU.Click += new System.EventHandler(this.btnCariNIU_Click);
            // 
            // txtOtherProdi
            // 
            this.txtOtherProdi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOtherProdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtherProdi.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOtherProdi.Location = new System.Drawing.Point(371, 384);
            this.txtOtherProdi.Name = "txtOtherProdi";
            this.txtOtherProdi.Size = new System.Drawing.Size(165, 33);
            this.txtOtherProdi.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(90, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Prodi";
            // 
            // rbTE
            // 
            this.rbTE.AutoSize = true;
            this.rbTE.Location = new System.Drawing.Point(90, 380);
            this.rbTE.Name = "rbTE";
            this.rbTE.Size = new System.Drawing.Size(57, 40);
            this.rbTE.TabIndex = 14;
            this.rbTE.TabStop = true;
            this.rbTE.Text = "TE";
            this.rbTE.UseVisualStyleBackColor = true;
            // 
            // rbTIF
            // 
            this.rbTIF.AutoSize = true;
            this.rbTIF.Location = new System.Drawing.Point(182, 380);
            this.rbTIF.Name = "rbTIF";
            this.rbTIF.Size = new System.Drawing.Size(62, 40);
            this.rbTIF.TabIndex = 15;
            this.rbTIF.TabStop = true;
            this.rbTIF.Text = "TIF";
            this.rbTIF.UseVisualStyleBackColor = true;
            // 
            // rbTB
            // 
            this.rbTB.AutoSize = true;
            this.rbTB.Location = new System.Drawing.Point(268, 380);
            this.rbTB.Name = "rbTB";
            this.rbTB.Size = new System.Drawing.Size(59, 40);
            this.rbTB.TabIndex = 16;
            this.rbTB.TabStop = true;
            this.rbTB.Text = "TB";
            this.rbTB.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(348, 392);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(17, 16);
            this.rbOther.TabIndex = 17;
            this.rbOther.TabStop = true;
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRepeatPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRepeatPassword.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRepeatPassword.Location = new System.Drawing.Point(90, 536);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.Size = new System.Drawing.Size(446, 33);
            this.txtRepeatPassword.TabIndex = 19;
            this.txtRepeatPassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(90, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ulangi Password*";
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 635);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbTB);
            this.Controls.Add(this.rbTIF);
            this.Controls.Add(this.rbTE);
            this.Controls.Add(this.txtOtherProdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCariNIU);
            this.Controls.Add(this.txtNIU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentRegistration";
            this.Text = "Register Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Button btnRegister;
        private TextBox txtName;
        private Label label4;
        private TextBox txtNIU;
        private Label label5;
        private Button btnCariNIU;
        private TextBox textBox3;
        private Label label6;
        private RadioButton rbTE;
        private RadioButton rbTIF;
        private RadioButton rbTB;
        private RadioButton rbOther;
        private TextBox txtRepeatPassword;
        private Label label7;
        private TextBox txtOtherProdi;
    }
}