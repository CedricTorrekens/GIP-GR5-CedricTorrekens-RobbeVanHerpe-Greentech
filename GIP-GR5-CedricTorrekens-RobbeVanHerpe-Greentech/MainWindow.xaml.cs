using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
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


    public partial class MainWindow : Window
    {
        connect con = new connect();
        

        public MainWindow()
        {
            InitializeComponent();


        }

        private void btnSignUpClick(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Close();
        }

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



        private void btnSignInClick(object sender, RoutedEventArgs e)
        {
            BusinessLayer businessLayer = new BusinessLayer();

            con.connection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(SQLScripts.sqlLogIn, con.con);
            DataTable dt = new DataTable();

            adapter.SelectCommand.Parameters.AddWithValue("@Email", txtEmail.Text);

            dt.Clear();
            adapter.Fill(dt);
            con.con.Close();

            
            if (Encrypt(txtPassword.Password) == dt.Rows[0].ItemArray[2].ToString())
            {
                BusinessLayer.propUserId = Convert.ToInt16(dt.Rows[0].ItemArray[0]);


                loadingData loadPage = new loadingData();
                loadPage.Show();
                this.Close();

                
            }
            else
            {
                MessageBox.Show("Failed to log in.", "Message", MessageBoxButton.OK);
            }
            

        }
    }
}
