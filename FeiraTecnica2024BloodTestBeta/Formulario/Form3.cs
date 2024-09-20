using System.Net.Mail;
using System.Net;

namespace FeiraTecnica2024BloodTestBeta.Formulario
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587, 
                    Credentials = new NetworkCredential("feiratecnica2024@gmail.com", "risz buau muwq tgro"),
                    EnableSsl = true, 
                };
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("volks9138@gmail.com"),
                    Subject = "Teste",
                    Body = "testedadoakdoakso",
                    IsBodyHtml = true 
                };
                mail.To.Add("volks9138@gmail.com");
                smtpClient.Send(mail);

                MessageBox.Show("E-mail enviado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar e-mail: {ex.Message}");
            }


            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
