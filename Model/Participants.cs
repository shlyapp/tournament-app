using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace TournamentApp.Model
{
    public class Participants
    {
        private List<Participant> _participants;

        private bool HaveElement(Participant participant)
        {
            foreach(Participant element in _participants)
            {
                if (participant.Id == element.Id || participant.Name == element.Name)
                {
                    return true;
                }
            }

            return false;
        }

        public Participants()
        {
            _participants = new List<Participant>();
        }

        public Participants(List<Participant> participants)
        {
            _participants = participants;
        }

        public Participant this[int index]
        {
            get
            {
                if (index >= 0 && index < _participants.Count)
                {
                    return _participants[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("");
                }
            }
            set
            {
                if (index >= 0 && index < _participants.Count)
                {
                    _participants[index] = value;
                }
            }
        }

        public List<Participant> Elements
        {
            get
            {
                return _participants;
            }
        }

        public void Add(Participant participant)
        {
            if (!HaveElement(participant))
            {
                _participants.Add(participant);
                return;
            }

            throw new ArgumentException("");
        }

        public void Remove(Participant participant)
        {
            if (!HaveElement(participant))
            {
                _participants.Remove(participant);
                return;
            }

            throw new ArgumentException("");
        }
    }
}
