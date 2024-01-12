namespace MailSentFormTest
{
    partial class frmMail
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnResendCode = new System.Windows.Forms.LinkLabel();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(76, 58);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(76, 93);
            this.txtCode.MaxLength = 6;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(151, 20);
            this.txtCode.TabIndex = 2;
            // 
            // btnResendCode
            // 
            this.btnResendCode.AutoSize = true;
            this.btnResendCode.Location = new System.Drawing.Point(103, 174);
            this.btnResendCode.Name = "btnResendCode";
            this.btnResendCode.Size = new System.Drawing.Size(72, 13);
            this.btnResendCode.TabIndex = 4;
            this.btnResendCode.TabStop = true;
            this.btnResendCode.Text = "Resend Code";
            this.btnResendCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnResendCode_LinkClicked);
            // 
            // btnSendCode
            // 
            this.btnSendCode.Location = new System.Drawing.Point(45, 132);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(75, 23);
            this.btnSendCode.TabIndex = 5;
            this.btnSendCode.Text = "Send Code";
            this.btnSendCode.UseVisualStyleBackColor = true;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(152, 132);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(45, 132);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // frmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 207);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.btnResendCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Name = "frmMail";
            this.Text = "Mail Sent";
            this.Load += new System.EventHandler(this.frmMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.LinkLabel btnResendCode;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnApply;
    }
}

