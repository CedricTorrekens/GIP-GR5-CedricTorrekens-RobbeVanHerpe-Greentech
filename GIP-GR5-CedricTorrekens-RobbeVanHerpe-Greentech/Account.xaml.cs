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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech
{
    /// <summary>
    /// Interaction logic for Account.xaml
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


    public partial class Account : Page
    {
        connect con = new connect();
        MySqlCommand cmd;
        MySqlDataReader reader;

        public Account()
        {
            InitializeComponent();

            con.connection();
            cmd = new MySqlCommand("SELECT * FROM picture WHERE empid = '4'", con.con);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                byte[] img = (byte[])(reader["picture"]);
                MemoryStream ms = new MemoryStream(img);

                picProfile.ImageSource = BitmapFrame.Create(ms);

            }
            else
            {
                picProfile.ImageSource = null;
            }

        }
    }
}
