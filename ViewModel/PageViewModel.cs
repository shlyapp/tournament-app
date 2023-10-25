using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentApp.ViewModel
{
    public class PageViewModel : ViewModelBase
    {
        private string _label;

        public string Label
        {
            get
            {
                return _label;
            }
            set
            {
                _label = value;
                OnPropertyChanged();
            }
        }
    }
}
