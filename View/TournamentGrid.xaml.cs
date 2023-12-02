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

namespace TournamentApp.View
{
    /// <summary>
    /// Логика взаимодействия для TournamentGrid.xaml
    /// </summary>
    public partial class TournamentGrid : UserControl
    {
        private int _participantCouner = 8;

        public TournamentGrid()
        {
            InitializeComponent();   

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int columns = (int)Math.Log2(_participantCouner) + 1;
            for (int i = 0; i < columns; i++)
            {
                ColumnDefinition columnDefinition = new ColumnDefinition();
                MainGrid.ColumnDefinitions.Add(columnDefinition);

                int lines = (int)(_participantCouner / (Math.Pow(2, i)));
                Grid subGrid = new Grid();
                subGrid.ShowGridLines = true;
                for (int j = 0; j < lines; j++)
                {
                    RowDefinition rowDefinition = new RowDefinition();
                    subGrid.RowDefinitions.Add(rowDefinition);

                    TextBlock textBlock = new TextBlock();
                    //textBlock.Style = (Style)FindResource("ParticipantTextBlock");
                    textBlock.Text = $"{i} - {j}";
                    Grid.SetColumn(textBlock, 0);
                    Grid.SetRow(textBlock, j);
                    subGrid.Children.Add(textBlock);
                }
                Grid.SetColumn(subGrid, i);
                MainGrid.Children.Add(subGrid);
            }
        }

    }
}
