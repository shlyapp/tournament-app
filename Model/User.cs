using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentApp.Model
{
    public class User
    {
        private int _id;
        private string _name;
        private string _sex;
        private DateTime _birthday;
        private float _weight;
        private float _age;
        private string _qualification;
        private string _discipline;
        private string _coachName;

        public User(int id, string name, string sex, DateTime birthday, float weight, float age, string qualification, string discipline, string coachName)
        {
            _id = id;
            _name = name;
            _sex = sex;
            _birthday = birthday;
            _weight = weight;
            _age = age;
            _qualification = qualification;
            _discipline = discipline;
            _coachName = coachName;
        }
    }
}
