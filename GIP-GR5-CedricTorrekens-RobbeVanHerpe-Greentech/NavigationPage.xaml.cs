using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech
{
    /// <summary>
    /// Interaction logic for NavigationPage.xaml
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
                                               
    
    public partial class NavigationPage : Window
    {

        public NavigationPage()
        {
            InitializeComponent();


            Home page = new Home();
            Main.Content = page;

        }


        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Home page = new Home();
            Main.Content = page;
        }

        private void btnMap_Click(object sender, RoutedEventArgs e)
        {
            Map page = new Map();
            Main.Content = page;
        }

        private void btnDataGraph_Click(object sender, RoutedEventArgs e)
        {
            DataGraph page = new DataGraph();
            Main.Content = page;
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            Settings page = new Settings();
            Main.Content = page;
        }

        private void btnAccount_Click(object sender, RoutedEventArgs e)
        {
            Account page = new Account();
            Main.Content = page;
        }

        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            AdminPage page = new AdminPage();
            Main.Content = page;
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow signIn = new MainWindow();
            signIn.Show();
            this.Close();
        }
    }

}
