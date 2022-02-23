using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech
{
    /// <summary>
    /// Interaction logic for Settings.xaml
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

    
    public partial class Settings : Page
    {
        string imageLocation;
        connect con = new connect();
        MySqlCommand cmd;
        MySqlDataReader reader;

        public Settings()
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

        private void btnMyAccount_Click(object sender, RoutedEventArgs e)
        {
            MyAccount.Visibility = Visibility.Visible;
            AddStation.Visibility = Visibility.Hidden;
            Manual.Visibility = Visibility.Hidden;
        }

        private void btnAddStation_Click(object sender, RoutedEventArgs e)
        {
            AddStation.Visibility = Visibility.Visible;
            MyAccount.Visibility = Visibility.Hidden;
            Manual.Visibility = Visibility.Hidden;
        }

        private void btnManual_Click(object sender, RoutedEventArgs e)
        {
            Manual.Visibility = Visibility.Visible;
            MyAccount.Visibility = Visibility.Hidden;
            AddStation.Visibility = Visibility.Hidden;
        }

        private void btnChangePicture_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.jpg;*.png;*.gif) |*.jpg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DialogResult dialog = System.Windows.Forms.MessageBox.Show("Are you sure you want to update your profile picture?", "GreenTech", MessageBoxButtons.YesNo);
                if (dialog != DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    imageLocation = ofd.FileName.ToString();
                    picProfile.ImageSource = new BitmapImage(new Uri(ofd.FileName));

                    byte[] img = null;
                    FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    img = brs.ReadBytes((int)stream.Length);

                    con.connection();
                    cmd = new MySqlCommand("UPDATE picture SET picture = @pic WHERE empid = '4'", con.con);
                    cmd.Parameters.AddWithValue("@pic", img);
                    cmd.ExecuteNonQuery();
                    con.con.Close();
                }
            }
        }
    }
}
