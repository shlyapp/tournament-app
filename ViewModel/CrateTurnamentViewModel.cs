using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using TournamentApp.Model;
using TournamentApp.Utilities;

namespace TournamentApp.ViewModel
{
    public class CrateTurnamentViewModel : PageViewModel
    {
        private string _selectedValue;

        public CrateTurnamentViewModel()
        {
            SelectedValue = "Бокс";
            DownloadDataCommand = new RelayCommand(DownloadDataFromExcel);
        }

        private void DownloadDataFromExcel(object obj)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";

            if (openFileDialog.ShowDialog() == true)
            {
                var rawData = ExcelReader.ReadDataFromExcel(openFileDialog.FileName);
                Database.Participants = ParticipantBuilder.BuildParicipants(rawData);
            }


        }

        public ICommand DownloadDataCommand { get; set; }

        public String RandomValue = "HELLO!!!";

        public string SelectedValue
        {
            get
            {

                return _selectedValue;
            }
            set
            {
                _selectedValue = value;
                OnPropertyChanged(nameof(SelectedValue));
            }

        }

        public ObservableCollection<String> Values = new ObservableCollection<String>()
        {
            "Бокс",
            "Карате"
        };

    }   
}
