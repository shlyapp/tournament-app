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

        public void ShowHome(object obj) => CurrentView = new HomeViewModel();
        public void ShowTable(object obj)
        {
            CurrentView = new TableViewModel();

            //if (Database.Participants.Elements.Count != 0)
            //{

                
            //    return;
            //}
            //MessageBox.Show("Загрузи таблицу мразь хуле ты смотришь");
        }
        public void ShowTournamentGrid(object obj) => CurrentView = new TournamentGridViewModel();

        private static NavigationViewModel _instance;

        public static NavigationViewModel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NavigationViewModel();
                }

                return _instance;
            }
        }

        private NavigationViewModel()
        {
            HomeViewCommand = new RelayCommand(ShowHome);
            TableViewCommand = new RelayCommand(ShowTable);
            TournamentGridViewCommand = new RelayCommand(ShowTournamentGrid);

            CurrentView = new HomeViewModel();
        }

    }
}
