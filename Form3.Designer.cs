namespace Exam0612
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_emailcheck = new System.Windows.Forms.Button();
            this.btn_email = new System.Windows.Forms.Button();
            this.txt_emailchecknum = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_emailcheck);
            this.groupBox1.Controls.Add(this.btn_email);
            this.groupBox1.Controls.Add(this.txt_emailchecknum);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "이메일 인증";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "인증번호";
            // 
            // btn_emailcheck
            // 
            this.btn_emailcheck.Location = new System.Drawing.Point(252, 68);
            this.btn_emailcheck.Name = "btn_emailcheck";
            this.btn_emailcheck.Size = new System.Drawing.Size(104, 34);
            this.btn_emailcheck.TabIndex = 5;
            this.btn_emailcheck.Text = "인증 확인";
            this.btn_emailcheck.UseVisualStyleBackColor = true;
            this.btn_emailcheck.Click += new System.EventHandler(this.btn_emailcheck_Click);
            // 
            // btn_email
            // 
            this.btn_email.Location = new System.Drawing.Point(252, 19);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(104, 34);
            this.btn_email.TabIndex = 4;
            this.btn_email.Text = "이메일 인증";
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // txt_emailchecknum
            // 
            this.txt_emailchecknum.Location = new System.Drawing.Point(130, 68);
            this.txt_emailchecknum.Name = "txt_emailchecknum";
            this.txt_emailchecknum.Size = new System.Drawing.Size(100, 25);
            this.txt_emailchecknum.TabIndex = 3;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(130, 26);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 25);
            this.txt_email.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "이메일";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 177);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.TextBox txt_emailchecknum;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_emailcheck;
        private System.Windows.Forms.Label label3;
    }
}