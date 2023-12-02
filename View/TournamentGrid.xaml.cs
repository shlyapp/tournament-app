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
using TournamentApp.Control;

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
                
                for (int j = 0; j < lines; j++)
                {
                    RowDefinition rowDefinition = new RowDefinition();
                    subGrid.RowDefinitions.Add(rowDefinition);

                    TournamentCell cell = new TournamentCell();
                    TournamentCellViewModel viewModel = new TournamentCellViewModel()
                    {
                        TextBlockText = "Участник",
                        IsChecked = false,
                    };
                    cell.DataContext = viewModel;
                    Grid.SetColumn(cell, 0);
                    Grid.SetRow(cell, j);
                    subGrid.Children.Add(cell);
                }
                Grid.SetColumn(subGrid, i);
                MainGrid.Children.Add(subGrid);
            }
        }

    }
}
