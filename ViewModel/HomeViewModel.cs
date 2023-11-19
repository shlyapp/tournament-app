using Microsoft.Win32;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TournamentApp.Model;
using TournamentApp.Utitlities;

namespace TournamentApp.ViewModel
{
    public class HomeViewModel : PageViewModel
    {
        public HomeViewModel() 
        {
            Label = "Главная";

            DownloadDataCommand = new RelayCommand(DownloadDataFromExcel);
        }

        public ICommand DownloadDataCommand { get; set; } 

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
    }
}
