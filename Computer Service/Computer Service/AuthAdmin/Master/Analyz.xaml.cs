using LiveCharts;
using LiveCharts.Wpf;
using MahApps.Metro.Controls;
using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Media;

namespace Computer_Service
{
    /// <summary>
    /// Логика взаимодействия для MasterMain.xaml
    /// </summary>
    public partial class Analyz : MetroWindow
    {
        string connectionString = @"data source=MAX-PC\SQLEXPRESS;initial catalog=ComputerService;integrated security=True;";
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

        int summa1;
        int summa2;
        int summa3;
        public Analyz()
        {
            InitializeComponent();





















            string master1 = "SELECT SUM(cost) FROM dbo.Orders WHERE [master] = 1 AND [order_status]=5";
            string master2 = "SELECT SUM(cost) FROM dbo.Orders WHERE [master] = 2 AND [order_status]=5";
            string master3 = "SELECT SUM(cost) FROM dbo.Orders WHERE [master] = 3 AND [order_status]=5";






            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(master1, connection);
                var m1 = command.ExecuteScalar();

                if (m1 != null)
                {
                    int sum1 = Convert.ToInt32(m1);
                    summa1 = sum1;
                    myPieChart.Series.Add(new PieSeries
                    {
                        Title = "Семенов Александр",
                        Fill = Brushes.Blue,
                        StrokeThickness = 0,
                        Values = new ChartValues<double> { sum1
}

                    });
                    connection.Close();
                }
                else
                {
                    connection.Close();
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(master2, connection);
                var m1 = command.ExecuteScalar();

                if (m1 != null)
                {
                    int sum2 = Convert.ToInt32(m1);
                    summa2 = sum2;
                    myPieChart.Series.Add(new PieSeries
                    {
                        Title = "Артюшихин Максим",
                        Fill = Brushes.Red,
                        StrokeThickness = 0,
                        Values = new ChartValues<double> { sum2
}
                    });
                    connection.Close();
                }
                else
                {
                    connection.Close();
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(master3, connection);
                var m1 = command.ExecuteScalar();

                if (m1 != null)
                {
                    int sum3 = Convert.ToInt32(m1);
                    summa3 = sum3;
                    myPieChart.Series.Add(new PieSeries
                    {
                        Title = "Смирнов Влад",
                        Fill = Brushes.Green,
                        StrokeThickness = 0,
                        Values = new ChartValues<double> { sum3
                        }
                    });
                    connection.Close();
                }
                else
                {
                    connection.Close();
                }


            }




            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Заработок",
                    Values = new ChartValues<double> { summa1, summa2, summa3 }
                }
            };

            //adding series will update and animate the chart automatically


            //also adding values updates and animates the chart automatically

            Labels = new[] { "Александр", "Максим", "Владислав", };
            Formatter = value => value.ToString("N");

            DataContext = this;
        }

















        public Func<ChartPoint, string> PointLabel { get; set; }

        private void Chart_OnDataClick(object sender, ChartPoint chartpoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartpoint.ChartView;

            //clear selected slice.
            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;

            var selectedSeries = (PieSeries)chartpoint.SeriesView;
            selectedSeries.PushOut = 30;
        }



        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}