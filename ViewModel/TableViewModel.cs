using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TournamentApp.Model;

namespace TournamentApp.ViewModel
{
    public class TableViewModel : PageViewModel
    {
        public TableViewModel()
        {
            Label = "Таблица участников";

            foreach (Participant participant in Database.Participants.Elements)
            {
                Participants.Add(participant);
            }
       
        }

        public ObservableCollection<Participant> Participants { get; set; } = new ObservableCollection<Participant>();
    }
}
