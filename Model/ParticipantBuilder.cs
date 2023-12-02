using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    (string)values[3],
                    (string)values[4],
                    (string)values[5],
                    (DateTime)values[6],
                    double.Parse(values[7].ToString()),
                    (int)values[8],
                    (string)values[9],
                    (string)values[10],
                    (string)values[11]));
            }



            return participants;
        }
    }
}
