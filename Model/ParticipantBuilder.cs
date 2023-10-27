using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace TournamentApp.Model
{
    public static class ParticipantBuilder
    {
        public static Participants BuildParicipants(List<List<object>> rawData)
        {
            Participants participants = new Participants();

            foreach (List<object> values in rawData)
            {
                participants.Add(new Participant((int)values[0],
                    (string)values[1],
                    (string)values[2],
                    (DateTime)values[3],
                    double.Parse(values[4].ToString()),
                    (int)values[5],
                    (string)values[6],
                    (string)values[7],
                    (string)values[8]));
            }

            return participants;
        }
    }
}
