using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
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
using MySql.Data.MySqlClient;

namespace GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech
{
    /// <summary>
    /// Interaction logic for Home.xaml
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


    public partial class Home : Page
    {
        connect con = new connect();
        

        private double _lastLecture;
        private double _trend;


        public Home()
        {
            InitializeComponent();

            

            //AutoUpdateStationData();

            ///
            /// Welcome Label
            /// 

            con.connection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(SQLScripts.sqlUserInfo, con.con);
            DataTable dt = new DataTable();

            adapter.SelectCommand.Parameters.AddWithValue("@userId", BusinessLayer.propUserId);

            dt.Clear();
            adapter.Fill(dt);
            con.con.Close();

            lblWelcome.Content = "Hey, " + dt.Rows[0].ItemArray[1].ToString();



            /// 
            /// Combobox stations
            /// 

            con.connection();
            adapter = new MySqlDataAdapter(SQLScripts.sqlUserStations, con.con);
            adapter.SelectCommand.Parameters.AddWithValue("@userId", BusinessLayer.propUserId);

            DataSet ds = new DataSet();
            ds.Clear();
            adapter.Fill(ds, "MijnTabel");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                cmbStations.Items.Add(row.ItemArray[0].ToString());
            }




            ///
            /// CHARTS
            /// 


            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "PM 2.5",
                    Values = GetPM25Data(),
                    PointGeometry = null
                },
                new LineSeries
                {
                    Title = "PM 10",
                    Values = GetPM10Data(),
                    PointGeometry = null
                },
                new LineSeries
                {
                    Title = "Temperature",
                    Values = GetTemperatureData(),
                    PointGeometry = null
                }
            };

            //Labels = new[] { "", "Feb", "Mar", "Apr", "May" };
            XFormatter = val => new DateTime((long)val).ToString("HH:mm");
            YFormatter = value => value.ToString();

            DataContext = this;


        }



        public SeriesCollection SeriesCollection { get; set; }
        public Func<double, string> XFormatter { get; set; }
        public Func<double, string> YFormatter { get; set; }

        private ChartValues<DateTimePoint> GetPM25Data()
        {
            var values = new ChartValues<DateTimePoint>();

            con.connection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(SQLScripts.sqlData, con.con);

            DataSet ds = new DataSet();
            ds.Clear();
            adapter.Fill(ds, "MijnTabel");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine(DateTime.Parse(Convert.ToString(row.ItemArray[1])));
                values.Add(new DateTimePoint(DateTime.Parse(Convert.ToString(row.ItemArray[1])), Convert.ToDouble(row.ItemArray[2])));
            }

            return values;
        }

        private ChartValues<DateTimePoint> GetPM10Data()
        {
            var values = new ChartValues<DateTimePoint>();

            con.connection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(SQLScripts.sqlData, con.con);

            DataSet ds = new DataSet();
            ds.Clear();
            adapter.Fill(ds, "MijnTabel");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                values.Add(new DateTimePoint(DateTime.Parse(Convert.ToString(row.ItemArray[1])), Convert.ToDouble(row.ItemArray[3])));
            }

            return values;
        }

        private ChartValues<DateTimePoint> GetHumidityData()
        {
            var values = new ChartValues<DateTimePoint>();

            con.connection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(SQLScripts.sqlData, con.con);

            DataSet ds = new DataSet();
            ds.Clear();
            adapter.Fill(ds, "MijnTabel");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                values.Add(new DateTimePoint(DateTime.Parse(Convert.ToString(row.ItemArray[1])), Convert.ToDouble(row.ItemArray[4])));
            }

            return values;
        }

        private ChartValues<DateTimePoint> GetTemperatureData()
        {
            var values = new ChartValues<DateTimePoint>();

            con.connection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(SQLScripts.sqlData, con.con);

            DataSet ds = new DataSet();
            ds.Clear();
            adapter.Fill(ds, "MijnTabel");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                values.Add(new DateTimePoint(DateTime.Parse(Convert.ToString(row.ItemArray[1])), Convert.ToDouble(row.ItemArray[5])));
            }

            return values;
        }


    }

        
    
}
