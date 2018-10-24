using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace EDSLApp
{
    /// <summary>
    /// Interaction logic for CreateSeason.xaml
    /// </summary>
    public partial class CreateSeason : Page
    {
        Random rand = new Random();
        List<int> years = new List<int>()
        {
            2015,2016,2017
        };
        public CreateSeason()
        {
            InitializeComponent();
        }

        private void onload(object sender, RoutedEventArgs e)
        {
            SeasonSelectBox.ItemsSource = years;
        }

        private void ResultsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Round_Results());
        }

        private void ViewDraw_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("chrome.exe", @"C:\Users\Aidan\Desktop\ExampleDraw.pdf");
        }

        private void CreateDraw_Click(object sender, RoutedEventArgs e)
        {
            ViewDraw.IsEnabled = true;
        }

        private void SesaonSelectBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DivisionSelectBox.IsEnabled = true;
        }

        private void DivisionSelectBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CreateDraw.IsEnabled = true;
        }

        private void StartDate_DateChanged(object sender, SelectionChangedEventArgs e)
        {
            NoRounds.Text = rand.Next(6, 9).ToString();
        }

        private void CreateSeason_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SeasonYear.Background = Brushes.White;
                SeasonSelectBox.ItemsSource = years;
                years.Add(Convert.ToInt32(SeasonYear.Text));
            }
            catch (Exception)
            {
                SeasonYear.Background = Brushes.IndianRed;
                MessageBox.Show("Enter a valid year");
            }
        }

    }
}
