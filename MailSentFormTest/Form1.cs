using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSentFormTest
{
    public partial class frmMail : Form
    {
        public frmMail()
        {
            InitializeComponent();
            txtCode.KeyPress += txtCode_KeyPress;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        string code = String.Empty;

        private void frmMail_Load(object sender, EventArgs e)
        {
            btnResendCode.Visible = false;
            txtCode.Enabled = false;
            btnBack.Enabled = false;
            btnApply.Visible = false;
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            if (!ValidData())
            {
                return;
            }

            btnSendCode.Enabled = false;
            btnResendCode.Visible = true;
            btnBack.Enabled = true;
            txtEmail.Enabled = false;
            txtCode.Enabled = true;
            txtCode.Focus();

            SendEmail snd = new SendEmail();

            code = snd.SendCode(txtEmail.Text.Trim());

            btnSendCode.Visible = false;
            btnApply.Visible = true;
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешить ввод только цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Отклонить ввод, если символ не является цифрой или управляющим символом
            }
        }


        private bool ValidData()
        {

            if (string.IsNullOrWhiteSpace(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Enter your email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            if (!txtEmail.Text.Trim().Contains("@") && !txtEmail.Text.Trim().Contains("."))
            {
                MessageBox.Show("Enter correct email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }


            return true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnResendCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnSendCode_Click(sender, e);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (code == txtCode.Text)
            {
                MessageBox.Show("Code is correct.", "Access.Ok", MessageBoxButtons.OK);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Code is not correct.", "Access.Ok", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCode.Focus();
                txtCode.Text = String.Empty;
            }
        }
    }
}
