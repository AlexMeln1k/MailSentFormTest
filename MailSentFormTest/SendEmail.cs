using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSentFormTest
{
    internal class SendEmail
    {
        public SendEmail()
        {
                
        }

        private const string SenderEmail = "mail@example.com";
        private const string SenderPassword = "password";

        public string SendCode(string recipientEmail)
        {
            Random rnd = new Random();
            string code = "";
            while (code.Length < 6)
            {
                code += rnd.Next(0, 9);
            }

            try
            {
                using (SmtpClient client = new SmtpClient("smtp.office365.com"))
                {
                    client.Port = 587; // Порт
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential(SenderEmail, SenderPassword);

                    MailMessage message = new MailMessage(SenderEmail, recipientEmail, "Access Code", $"Your Code is {code}");

                    client.Send(message);

                    MessageBox.Show("Письмо успешно отправлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка отправки письма: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
            return code;
        }

    }
}
