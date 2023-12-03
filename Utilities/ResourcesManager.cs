using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TournamentApp.Style.Theme;

namespace TournamentApp.Utilities
{
    public static class ResourcesManager
    {
        private static ResourceDictionary _darkTheme;
        private static ResourceDictionary _lightTheme;
        static ResourcesManager()
        {
            _darkTheme = new DarkTheme();
            _lightTheme = new LightTheme();


            Application.Current?.Resources.MergedDictionaries.Add(_darkTheme);
            Application.Current?.Resources.MergedDictionaries.Add(_lightTheme);
        }


        public static ResourceDictionary DarkTheme
        {
            get => _darkTheme;
            set
            {
                try
                {
                    Application.Current?.Resources.MergedDictionaries.Remove(_darkTheme);
                    _darkTheme = value;
                    Application.Current?.Resources.MergedDictionaries.Add(_darkTheme);
                }
                catch { }
            }
        }
        
        public static ResourceDictionary LightTheme
        {
            get => _lightTheme;
            set
            {
                try
                {
                    Application.Current?.Resources.MergedDictionaries.Remove(_lightTheme);
                    _lightTheme = value;
                    Application.Current?.Resources.MergedDictionaries.Add(_lightTheme);
                }
                catch { }
            }
        }
    }

}
