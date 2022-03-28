using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

namespace GIP_GR5_CedricTorrekens_RobbeVanHerpe_Greentech
{
    /// <summary>
    /// Interaction logic for loadingData.xaml
    /// </summary>
    public partial class loadingData : Window
    {
        connect con = new connect();
        public loadingData()
        {
            InitializeComponent();




            con.connection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(SQLScripts.sqlLastData, con.con);


            DataTable dt = new DataTable();
            adapter.Fill(dt);

            con.con.Close();

            TimeSpan timeSpan = DateTime.Now - DateTime.Parse(Convert.ToString(dt.Rows[0].ItemArray[1]));

            if (timeSpan.TotalDays <= 1)
            {
                

            }
            else if (timeSpan.TotalDays <= 7)
            {

            }
            else if (timeSpan.TotalDays <= 28)
            {

            }
            else
            {

            }


            Task.Run(() =>
            {
                for (int i = 0; i < 14; i++)
                {
                    var tempFilePath = System.IO.Path.GetTempFileName();
                    using (var client = new WebClient())
                    {
                        String date = DateTime.Today.AddDays(-i).ToString("yyyy-MM-dd");
                        client.DownloadFile("https://api-rrd.madavi.de/data_csv/csv-files/" + date + "/data-esp8266-3130811-" + date + ".csv", tempFilePath);
                    }

                    con.connection();

                    var lineNumber = 0;
                    using (StreamReader reader = new StreamReader(tempFilePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            try
                            {
                                var line = reader.ReadLine();
                                if (lineNumber != 0)
                                {
                                    var values = line.Split(';');
                                    var sql = "INSERT INTO tblGegevens VALUES ('esp8266-3130811','" + values[0] + "','" + values[7] + "','" + values[8] + "','" + values[12] + "','" + values[11] + "')";

                                    var cmd = new MySqlCommand();
                                    cmd.CommandText = sql;
                                    cmd.CommandType = System.Data.CommandType.Text;
                                    cmd.Connection = con.con;
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            catch (Exception e)
                            {
                                return;
                            }

                            lineNumber++;

                        }
                        con.con.Close();


                    }

                    Console.WriteLine("-------------------");
                    Console.WriteLine("  " + i + "/14   COMPLETE");
                    Console.WriteLine("-------------------");

                }
            })
            .ContinueWith(t =>
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("CSV IMPORT COMPLETE");
                Console.WriteLine("-------------------");

                Application.Current.Dispatcher.Invoke(delegate
                {
                    NavigationPage view = new NavigationPage();
                    view.Show();
                    this.Close();
                });


            });



        }

    }
}
