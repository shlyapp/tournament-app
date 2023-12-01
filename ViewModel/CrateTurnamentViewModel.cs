using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentApp.ViewModel
{
    public class CrateTurnamentViewModel : PageViewModel
    {
        private string _selectedValue;

        public CrateTurnamentViewModel()
        {
            SelectedValue = "Бокс";
        }

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
