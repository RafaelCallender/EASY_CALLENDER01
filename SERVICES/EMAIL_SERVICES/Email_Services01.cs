using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EASY_CALLENDER01.SERVICES.EMAIL_SERVICES
{
    public class Email_Services01
    {
        private static Read_Textfiles Read_T01 = new Read_Textfiles();
        public bool send_email(string input,string input01,string input02, string input03,out string output01)
        {
            try
            {
                string fromEmail = Read_T01.admin_path01.Split("\n")[0].Trim();
                string appPassword = Read_T01.admin_path01.Split("\n")[3].Trim();

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(Read_T01.admin_path01.Split("\n")[0].Trim());
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
