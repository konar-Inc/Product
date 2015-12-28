using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    public class CandidatePosition
    {
        public int Score { get; set; }
        public Position Position { get; set; }

        public string Key
        { get { return Position.Key; } }

        public Dictionary<string, CandidateVoteFactor> VoteFactors { get; set; }

    }
}
