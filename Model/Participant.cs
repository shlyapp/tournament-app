using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using TournamentApp.ViewModel;

namespace TournamentApp.Model
{
    public class Participant : ViewModelBase
    {
        private int _id;
        private string _name;
        private string _region;
        private string _city;
        private string _club;
        private string _sex;
        private string _birthday;
        private double _weight;
        private int _age;
        private string _qualification;
        private string _discipline;
        private string _coachName;
        private double _number1;
        private double _number2;
        private double _number3;
        private double _number4;
        private double _number5;
        private double _number6;
        private double _number7;
        private double _number8;
        private double _sum;
        

        public Participant(int id, string name, string region, string city, string club, string sex, DateTime birthday, double weight, int age, string qualification, string discipline, string coachName)
        {
            Id = id;
            Name = name;
            Region = region;
            City = city;
            Club = club;
            Sex = sex;
            Birthday = birthday.ToString("dd.MM.yyyy");
            Weight = weight;
            Age = age;
            Qualification = qualification;
            Discipline = discipline;
            CoachName = coachName;
            
             
            
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("");
                }

                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
             set
            {
                string[] parts = value.Split();
                if (parts.Length != 3)
                {
                    MessageBox.Show("ФИО не содержит трех слов");
                    return;
                }

                _name = value;
            }
        }

        public string Region
        {
            get
            {
                return _region;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception();
                }

                _region = value;
            } 
        }

        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception();
                }

                _city = value;
            }
        }

        public string Club
        {
            get
            {
                return _club;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception();
                }

                _club = value;
            }
        }

        public string Sex
        {
            get
            {
                return _sex;
            }
             set
            {
                value = value.ToLower();
                if (value != "ж" && value != "м")
                {
                    throw new ArgumentException("");
                }

                _sex = value;
            }
        }

        public string Birthday
        {
            get
            {
                return _birthday;
            }
             set
            {
                _birthday = value;
            }
        }

        public double Weight
        {
            get
            {
                return _weight;
            }
             set
            {
                if (value < 0)
                {
                    throw new ArgumentException("");
                }

                _weight = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
             set
            {
                if (value < 0)
                {
                    throw new ArgumentException("");
                }

                _age = value;
            }
        }

        public string Qualification
        {
            get
            {
                return _qualification;
            }
             set
            {
                _qualification = value;
            }
        }

        public string Discipline
        {
            get
            {
                return _discipline;
            }
             set
            {
                _discipline = value;
            }
        }

        public string CoachName
        {
            get
            {
                return _coachName;
            }
             set
            {
                _coachName = value;
            }
        }

        public void ChangeSum()
        {
            List<double> scores = new List<double>() { _number1, _number2,  _number3, _number4, _number5, _number6, _number7, _number8 };
            double min = scores.Min();
            double max = scores.Max();

            Sum = scores.Sum() - min - max;
        }

        public double Number1
        {
            get
            {
                return _number1;
            }
            set
            {
                if(value < 0)
                {
                    throw  new ArgumentException("");
                }
                _number1 = value;

                ChangeSum();
            }
        }

        public double Number2
        {
            get
            {
                return _number2;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("");
                }
                _number2 = value;

                ChangeSum();
            }
        }

        public double Number3
        {
            get
            {
                return _number3;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("");
                }
                _number3 = value;

                ChangeSum();
            }
        }
        public double Number4
        {
            get
            {
                return _number4;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("");
                }
                _number4 = value;

                ChangeSum();
            }
        }

        public double Number5
        {
            get
            {
                return _number5;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("");
                }
                _number5 = value;

                ChangeSum();
            }
        }

        public double Number6
        {
            get
            {
                return _number6;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("");
                }
                _number6 = value;

                ChangeSum();
            }
        }

        public double Number7
        {
            get
            {
                return _number7;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("");
                }
                _number7 = value;

                ChangeSum();
            }
        }

        public double Number8
        {
            get
            {
                return _number8;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("");
                }
                _number8 = value;

                ChangeSum();
            }
        }

        public double Sum
        {
            get
            {
                return _sum;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("");
                }
                _sum = value;

                OnPropertyChanged(nameof(Sum));
            }
        }

        public override string ToString()
        {
            return $"Id: {_id}\n" +
                $"Name: {_name}\n" +
                $"Sex: {_sex}\n" +
                $"Birthday: {_birthday}\n" +
                $"Weight: {_weight}\n" +
                $"Age: {_age}\n" +
                $"Qualification: {_qualification}\n" +
                $"Discipline: {_discipline}\n" +
                $"Coach Name: {_coachName}";
        }
    }
}
