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
    /// Interaction logic for Round_Results.xaml
    /// </summary>
    public partial class Round_Results : Page
    {
        Random Rand = new Random();
        List<Game> Games = new List<Game>()
        {
            new Game(1, "Wanterna", "Scoresby", 3, 1),
            new Game(2, "Mitcham", "Ringwood", 1, 2),
            new Game(3, "Belgrave", "Oakleigh", 1, 0)
        };


        public Round_Results()
        {
            InitializeComponent();
        }

        private void SeasonButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateSeason());
        }

        private void RoundSelectBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RoundDate.Text = Rand.Next(1, 31) + "/" + Rand.Next(1, 13) + "/18";
            ShowRoundGames();
        }

        private void ViewLadderButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("chrome.exe", @"C:\Users\Aidan\Desktop\ExampleLadder.pdf");
        }

        void ShowRoundGames()
        {
            if(RoundSelectBox.SelectedItem != null && DivisionSelectBox.SelectedItem != null)
            {
                ListView_Games.ItemsSource = Games;
            }
        }

        class Game
        {
            public Game(int gameNo, string homeTeam, string awayTeam, int homeScore, int awayScore)
            {
                GameNo = gameNo;
                HomeTeam = homeTeam;
                AwayTeam = awayTeam;
                HomeScore = homeScore;
                AwayScore = awayScore;
            }

            public int GameNo { get; set; }
            public string HomeTeam { get; set; }
            public string AwayTeam { get; set; }
            public int HomeScore { get; set; }
            public int AwayScore { get; set; }
        }

        private void DivisionSelectBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowRoundGames();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ladder Updated");
        }
    }
}
