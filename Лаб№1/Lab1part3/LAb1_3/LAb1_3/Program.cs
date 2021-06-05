using System;
using System.Net;
using System.Net.Mail;

namespace lab_1_part_4
{
    class Program
    {
        static int Main(string[] args)
        {
            try
            {
                if (args.Length != 2)
                {
                    Console.WriteLine("Incorrect usage!");
                    Console.WriteLine("Two arguments required: <E-mail address> <Subject>");
                    return 1;
                }
                string receiver = args[0];
                string subject = args[1];
                string host = "DenysS";
                using (SmtpClient mail = new SmtpClient("mail.univ.net.ua"))
                {
                    mail.Port = 25;
                    mail.EnableSsl = true;
                    mail.Credentials = new NetworkCredential(host, "3231616Denis");
                    string text = "Name: Denys\nSurname:Sytnychenko\nDate:" + DateTime.Now;
                    mail.Send(new MailMessage(host + "@univ.net.ua", receiver, subject, text));
                }
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }
        }
    }
}
