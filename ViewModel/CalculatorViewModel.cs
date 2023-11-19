using Aspose.Cells.Drawing;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TournamentApp.Model;

namespace TournamentApp.ViewModel
{
    public class CalculatorViewModel : PageViewModel
    {
        public CalculatorViewModel()
        {
            Label = "Калькулятор Ката";

            foreach(Participant participant in Database.Participants.Elements)
            {
                Participants.Add(participant);
            }

        }

        public ObservableCollection<Participant> Participants { get; set; } = new ObservableCollection<Participant>();
    }
}
