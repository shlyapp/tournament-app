using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Serialization;
using TournamentApp.Model;
using TournamentApp.Utilities;

namespace TournamentApp.ViewModel
{
    public class TableViewModel : PageViewModel
    {
        private string _textForSearch = "";

        public TableViewModel()
        {
            Label = "Таблица участников";

            SearchCommand = new RelayCommand(Search);

            foreach (Participant participant in Database.Participants.Elements)
            {
                Participants.Add(participant);
            }
       
        }

        public ObservableCollection<Participant> Participants { get; set; } = new ObservableCollection<Participant>();

        public ICommand SearchCommand { get; set; }

        public string TextForSearch
        {
            get
            {
                return _textForSearch;
            }
            set
            {
                _textForSearch = value;
            }
        }

        public void Search(object obj)
        {
            ObservableCollection<Participant> result = new ObservableCollection<Participant>();
            foreach(Participant participant in Participants)
            {
                if (participant.Name.Contains(TextForSearch))
                {
                    result.Add(participant);
                }

                Participants = result;
                OnPropertyChanged(nameof(Participants));
            } 
        }
    }


}
