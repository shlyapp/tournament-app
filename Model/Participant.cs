using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows;

namespace TournamentApp.Model
{
    public class Participant
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
