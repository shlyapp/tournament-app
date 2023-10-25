using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TournamentApp.Utitlities;

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
                OnPropertyChanged();
            }
        }

        public ICommand HomeViewCommand { get; set; }
        public ICommand TableViewCommand { get; set; }
        public ICommand TournamentGridViewCommand { get; set; }

        private void ShowHome(object obj) => CurrentView = new HomeViewModel();
        private void ShowTable(object obj) =>  CurrentView = new TableViewModel();
        private void ShowTournamentGrid(object obj) => CurrentView = new TournamentGridViewModel();

        public NavigationViewModel()
        {
            HomeViewCommand = new RelayCommand(ShowHome);
            TableViewCommand = new RelayCommand(ShowTable);
            TournamentGridViewCommand = new RelayCommand(ShowTournamentGrid);

            CurrentView = new HomeViewModel();
        }

    }
}
