using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TournamentApp.Model
{
    public class Participant
    {
        private int _id;
        private string _name;
        private string _sex;
        private DateTime _birthday;
        private double _weight;
        private int _age;
        private string _qualification;
        private string _discipline;
        private string _coachName;

        public Participant(int id, string name, string sex, DateTime birthday, double weight, int age, string qualification, string discipline, string coachName)
        {
            Id = id;
            Name = name;
            Sex = sex;
            Birthday = birthday;
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
            private set
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
            private set
            {
                string[] parts = value.Split();
                if (parts.Length != 3)
                {
                    throw new ArgumentException("");
                }

                _name = value;
            }
        }

        public string Sex
        {
            get
            {
                return _sex;
            }
            private set
            {
                value = value.ToLower();
                if (value != "ж" && value != "м")
                {
                    throw new ArgumentException("");
                }

                _sex = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }
            private set
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
            private set
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
            private set
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
            private set
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
            private set
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
            private set
            {
                _coachName = value;
            }
        }
    }
}
