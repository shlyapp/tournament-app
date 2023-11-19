using Aspose.Cells;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TournamentApp.Utilities;
using TournamentApp.Model;
using System.Windows;

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
