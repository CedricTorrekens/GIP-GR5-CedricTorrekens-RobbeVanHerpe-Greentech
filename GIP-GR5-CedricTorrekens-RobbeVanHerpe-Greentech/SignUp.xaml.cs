using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Security.Cryptography;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.IO;
using System.Data;

namespace GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    /// 


    //       _____                  _______        _     
    //      / ____|                |__   __|      | |    
    //     | |  __ _ __ ___  ___ _ __ | | ___  ___| |__  
    //     | | |_ | '__/ _ \/ _ \ '_ \| |/ _ \/ __| '_ \ 
    //     | |__| | | |  __/  __/ | | | |  __/ (__| | | |
    //      \_____|_|  \___|\___|_| |_|_|\___|\___|_| |_|
    //
    //


    public partial class SignUp : Window
    {
        connect con = new connect();
        MySqlCommand cmd;

        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignInClick(object sender, RoutedEventArgs e)
        {
            MainWindow signIn = new MainWindow();
            signIn.Show();
            this.Close();
        }

        // Encrypting of the password
        static string Encrypt(string value)
        {
            //Using MD5 to encrypt a string
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                //Hash data
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        // On button press creating account
        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password == txtRepPassword.Password)
            {
                if (string.IsNullOrEmpty(txtPassword.Password))
                {
                    System.Windows.Forms.MessageBox.Show("Please enter your password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    con.connection();
                    cmd = new MySqlCommand(SQLScripts.sqlInsertUser, con.con);
                    cmd.Parameters.AddWithValue("@NameUser", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastNameUser", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Password", Encrypt(txtPassword.Password));
                    cmd.ExecuteNonQuery();
                    con.con.Close();


                    ///
                    /// Send verification email
                    /// 

                    // create a new mime message object which we are going to use to fill the message data
                    MimeMessage message = new MimeMessage();
                    // add the sender info that will appear in the email message
                    message.From.Add(new MailboxAddress("GreenTech", "greentech.smi22@gmail.com"));

                    // add the receiver email address
                    message.To.Add(MailboxAddress.Parse(txtEmail.Text));

                    // add the message subject
                    message.Subject = "Welcome " + txtFirstName.Text + "!";

                    // add the message body

                    var bodyBuilder = new BodyBuilder();

                    var content = File.ReadAllText("mail.html");

                    bodyBuilder.HtmlBody = content;

                    message.Body = bodyBuilder.ToMessageBody();
                    
                    SmtpClient client = new SmtpClient();

                    try
                    {
                        // connect to gmail smtp server
                        client.Connect("smtp.gmail.com", 465, true);
                        // Note: only needed if the SMTP server
                        client.Authenticate("greentech.smi22@gmail.com", "6ETu%3f8");
                        client.Send(message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        client.Disconnect(true);
                        client.Dispose();
                    }




                    
                    con.connection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(SQLScripts.sqlLogIn, con.con);
                    DataTable dt = new DataTable();

                    adapter.SelectCommand.Parameters.AddWithValue("@Email", txtEmail.Text);

                    dt.Clear();
                    adapter.Fill(dt);
                    con.con.Close();

                    BusinessLayer.propUserId = Convert.ToInt16(dt.Rows[0].ItemArray[0]);

                    NavigationPage navPage = new NavigationPage();
                    navPage.Show();
                    this.Close();


                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The passwords are not the same.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

            


        }
    }
}
