using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using System.Net;
using System.Net.Mail;


namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.EMAIL_SERVICES
{
    public class Email_Services01
    {
   
        public bool send_email(string input,string input01,string input02, string input03,out string output01)
        {
            try
            {
                string fromEmail = File_Manger01.Admin_text01.Trim();
                string appPassword = File_Manger01.Admin_text04.Trim();

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(fromEmail);
                mail.Subject = "Test";
                mail.Body = $"Email: {input}\n" +
                            $"Name: {input01}\n" +
                            $"Phonenumber: {input02}\n" +
                            $"Message:{input03}\n";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(fromEmail, appPassword);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                output01 = "message sent";
                return true;            
            }
            catch(Exception ex)
            {
                output01 = ex.Message;   
                return false;       

            }
     
        }
    }
}
