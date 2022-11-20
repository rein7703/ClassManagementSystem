namespace ClassManagementSystemWinForms
{
    partial class StudentChooseMode
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnToClass = new System.Windows.Forms.Button();
            this.btnToTask = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(99, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(560, 70);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mau Manage apa hari ini?";
            // 
            // btnToClass
            // 
            this.btnToClass.BackColor = System.Drawing.Color.ForestGreen;
            this.btnToClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToClass.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnToClass.ForeColor = System.Drawing.Color.White;
            this.btnToClass.Location = new System.Drawing.Point(184, 265);
            this.btnToClass.Name = "btnToClass";
            this.btnToClass.Size = new System.Drawing.Size(131, 52);
            this.btnToClass.TabIndex = 7;
            this.btnToClass.Text = "Kelas";
            this.btnToClass.UseVisualStyleBackColor = false;
            this.btnToClass.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnToTask
            // 
            this.btnToTask.BackColor = System.Drawing.Color.ForestGreen;
            this.btnToTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToTask.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnToTask.ForeColor = System.Drawing.Color.White;
            this.btnToTask.Location = new System.Drawing.Point(440, 265);
            this.btnToTask.Name = "btnToTask";
            this.btnToTask.Size = new System.Drawing.Size(132, 52);
            this.btnToTask.TabIndex = 8;
            this.btnToTask.Text = "Tugas";
            this.btnToTask.UseVisualStyleBackColor = false;
            this.btnToTask.Click += new System.EventHandler(this.btnToTask_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(628, 24);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 50);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2.Location = new System.Drawing.Point(440, 24);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(154, 50);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Edit Profil";
            // 
            // StudentChooseMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnToTask);
            this.Controls.Add(this.btnToClass);
            this.Controls.Add(this.label3);
            this.Name = "StudentChooseMode";
            this.Text = "Landing Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Button btnToClass;
        private Button btnToTask;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}