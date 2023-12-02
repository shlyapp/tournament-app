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

namespace TournamentApp.Control
{
    /// <summary>
    /// Логика взаимодействия для TournamentCell.xaml
    /// </summary>
    public partial class TournamentCell : UserControl
    {
        public TournamentCell()
        {
            InitializeComponent();
        }
        
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if(button.Background == Brushes.Green )
            {
                button.Background = Brushes.Red;
            }
            else if(button.Background == Brushes.Red )
            {
                button.Background = Brushes.Green;
            }
            else
            {
                button.Background = Brushes.Green;
            }

        }

        

        

    }
}
