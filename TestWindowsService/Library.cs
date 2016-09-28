using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Mail;

namespace TestWindowsService
{
    public static class Library
    {
        //public static void WriteErrorLog(Exception ex)
        //{
        //    StreamWriter sw = null;

        //    try
        //    {
        //        sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
        //        sw.WriteLine(DateTime.Now.ToString() + ": " + ex.Source.ToString().Trim() + "; " + ex.Message.ToString().Trim());
        //        sw.Flush();
        //        sw.Close();
        //    }
        //    catch
        //    { }
        //}

        public static void WriteErrorLog(string Message)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                var MyDateNow = DateTime.Now;

                sw.WriteLine(MyDateNow.AddDays(7).ToString() + ":" + Message);
                sw.Flush();
                sw.Close();
            }
            catch
            { }
        }

        public static void read()
        {
            StreamWriter sw = null;

            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"c:\\users\\optimus\\documents\\visual studio 2015\\Projects\\TestWindowsService\\TestWindowsService\\TestDb.mdf\";Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM pegawai", conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                                sw.WriteLine(DateTime.Now.ToString() + ":" + "Id =" + reader["id"] + "Nama = " + reader["nama"] + "email = " + reader["email"]);
                                sw.Flush();
                                sw.Close();

                                //Console.WriteLine("Id = ", reader["Id"]);
                                //Console.WriteLine("Nama = ", reader["nama"]);
                                //Console.WriteLine("Email = ", reader["email"]);
                            }
                        }

                        reader.Close();
                    }
                }
            }
            catch 
            {
                //Log exception
                //Display Error message
                Console.WriteLine("Error");
            }
        }

        public static void send()
        {
            StreamWriter sw = null;

            try
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"c:\\users\\optimus\\documents\\visual studio 2015\\Projects\\TestWindowsService\\TestWindowsService\\TestDb.mdf\";Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM pegawai", conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);

                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.mail.yahoo.com");

                        mail.From = new MailAddress("wak_keydhonabm@ymail.com");
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                mail.To.Add(reader["email"].ToString());
                            }
                        }
                        reader.Close();
                        mail.Subject = "Test Mail, multiple receiver from DB";
                        mail.Body = "This is for testing SMTP mail from ymail, Jangkrik Boss....MAAF SPAM Test Kirim email per jam :)";

                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("wak_keydhonabm@ymail.com", "gr3zm41lp4ss");
                        SmtpServer.EnableSsl = true;

                        SmtpServer.Send(mail);

                        sw.WriteLine(DateTime.Now.ToString() + ":" + "Jangkrik bos");
                        sw.Flush();
                        sw.Close();
                    }
                }
            }
            catch
            { }
        }
    }
}
