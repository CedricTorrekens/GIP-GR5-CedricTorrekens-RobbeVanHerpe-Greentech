using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
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
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;

namespace GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech
{
    /// <summary>
    /// Interaction logic for DataGraph.xaml
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


    public partial class DataGraph : Page
    {

        connect con = new connect();

        public DataGraph()
        {
            InitializeComponent();
            /*
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
            */

            DataContext = this;


            Model1 = new PlotModel();
            Model1.Title = "PM 2.5";
            Model1.Legends.Add(new Legend()
            {
                LegendPosition = LegendPosition.TopCenter,
                LegendOrientation = LegendOrientation.Horizontal,
                LegendPlacement = LegendPlacement.Outside,
            });

            Model1.Axes.Add(new DateTimeAxis { Position = AxisPosition.Bottom, StringFormat = "dd/MM/yyyy HH:mm" });


            FunctionSeries data1 = new FunctionSeries();
            data1.Title = "PM 2.5";
            FunctionSeries data2 = new FunctionSeries();
            data2.Title = "PM 10";
            FunctionSeries data3 = new FunctionSeries();
            data3.Title = "Humidity";
            FunctionSeries data4 = new FunctionSeries();
            data4.Title = "Temperature";

            con.connection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(SQLScripts.sqlData, con.con);

            DataSet ds = new DataSet();
            ds.Clear();
            adapter.Fill(ds, "MijnTabel");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine(DateTime.Parse(Convert.ToString(row.ItemArray[1])));
                data1.Points.Add(new DataPoint(DateTimeAxis.ToDouble(DateTime.Parse(Convert.ToString(row.ItemArray[1]))), Convert.ToDouble(row.ItemArray[2])));
                data2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(DateTime.Parse(Convert.ToString(row.ItemArray[1]))), Convert.ToDouble(row.ItemArray[3])));
                data3.Points.Add(new DataPoint(DateTimeAxis.ToDouble(DateTime.Parse(Convert.ToString(row.ItemArray[1]))), Convert.ToDouble(row.ItemArray[4])));
                data4.Points.Add(new DataPoint(DateTimeAxis.ToDouble(DateTime.Parse(Convert.ToString(row.ItemArray[1]))), Convert.ToDouble(row.ItemArray[5])));
            }

            Model1.Series.Add(data1);
            Model1.Series.Add(data2);
            Model1.Series.Add(data3);
            Model1.Series.Add(data4);


            //Model1 = CreateModel("Model 1");
            Model2 = CreateModel("Model 2");
            Model3 = CreateModel("Model 3");

        }

        /// <summary>
        /// Gets the left model.
        /// </summary>
        public PlotModel Model1 { get; private set; }

        /// <summary>
        /// Gets the right-top model.
        /// </summary>
        public PlotModel Model2 { get; private set; }

        /// <summary>
        /// Gets the right-bottom model.
        /// </summary>
        public PlotModel Model3 { get; private set; }

        /// <summary>
        /// Creates a sample model.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <returns>A <see cref="PlotModel" />.</returns>
        private static PlotModel CreateModel(string title)
        {
            var model = new PlotModel { Title = title };
            model.Axes.Add(new LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left });
            model.Axes.Add(new LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom });
            model.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 1000));
            model.Series.Add(new FunctionSeries(x => Math.Sin(x) / x, 0, 10, 1000));
            return model;
        }


        /*
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
                //values.Add(new DateTimePoint(DateTime.Parse(Convert.ToString(row.ItemArray[1])), Convert.ToDouble(row.ItemArray[2])));
                
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
        */

        private void ViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmdViewSelect.Text == "Table")
            {
                plotter.Visibility = Visibility.Visible;
                dgvData.Visibility = Visibility.Hidden;
            }
            else if (cmdViewSelect.Text == "Graph")
            {
                plotter.Visibility = Visibility.Hidden;
                dgvData.Visibility = Visibility.Visible;
            }
        }
        
        private void btnSearchData_Click(object sender, RoutedEventArgs e)
        {
            SearchPopup popup = new SearchPopup();
            popup.Show();
        }
        
    }

    
}
