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
    /// Interaction logic for EnterTicketNumber.xaml
    /// </summary>
    public partial class EnterTicketNumber : Page
    {
        Control Control;
        public EnterTicketNumber(Control control)
        {
            Control = control;
            InitializeComponent();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
