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

namespace SomePageForTicketSystem
{
    /// <summary>
    /// Interaction logic for Control.xaml
    /// </summary>
    public partial class Control : Page
    {
        public MainMenu MainMenu;
        public EnterTicketNumber EnterTicketNumber;

        public Control()
        {
            Loaded += OnLoad;
            InitializeComponent();
        }

        public void OnLoad(object sender, RoutedEventArgs e)
        {
            CreateNewMenu();
            NavigationService.Navigate(MainMenu);
        }

        public void CreateNewMenu()
        {
            MainMenu = new MainMenu(this);
        }

        public void CreateNewEnterTicketNum()
        {
            EnterTicketNumber = new EnterTicketNumber(this);
        }
    }
}
