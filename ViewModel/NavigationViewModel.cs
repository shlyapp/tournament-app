using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TournamentApp.Model;
using TournamentApp.Utilities;

namespace TournamentApp.ViewModel
{
    public class NavigationViewModel : ViewModelBase
    {
        private PageViewModel _currentView;

        public PageViewModel CurrentView
        {
            get
            {
                return _currentView;
            }
            set
            {
                _currentView = value;
                OnPropertyChanged("CurrentView");
            }
        }

        public ICommand HomeViewCommand { get; set; }
        public ICommand TableViewCommand { get; set; }
        public ICommand TournamentGridViewCommand { get; set; }
        public ICommand CalculatorViewModelCommand { get; set; }

        public ICommand CrateTurnament { get; set; }

        public void ShowHome(object obj) => CurrentView = new HomeViewModel();
        public void ShowTable(object obj)
        {
            CurrentView = new TableViewModel();
        }
        public void ShowTournamentGrid(object obj) => CurrentView = new TournamentGridViewModel();

        public void ShowCalculator(object obj) => CurrentView = new CalculatorViewModel();

        public void ShowCrateTurnament(object obj) => CurrentView = new CrateTurnamentViewModel();

        public NavigationViewModel()
        {
            HomeViewCommand = new RelayCommand(ShowHome);
            TableViewCommand = new RelayCommand(ShowTable);
            TournamentGridViewCommand = new RelayCommand(ShowTournamentGrid);
            CalculatorViewModelCommand = new RelayCommand(ShowCalculator);
            CurrentView = new CrateTurnamentViewModel();
        }

    }
}
