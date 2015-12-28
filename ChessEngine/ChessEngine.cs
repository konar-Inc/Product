using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class ChessEngine
    {
        public const int Rows = 15;
        public const int Cols = 9;
        private int _curX = -1;
        private int _curY = -1;



        private PointState[][] globalState = new PointState[Rows][];

        private CheckerBoard _checkBoard = new CheckerBoard();

        private Stack<Position> humanHistory = new Stack<Position>() { };
        private Stack<Position> computerHistory = new Stack<Position>() { };
        private int currentCursor = -1;

        private PlayerRole _currentPlayer = PlayerRole.White;

        public List<CandidatePosition> GetAllCandidadteWithScores(List<Position> historyPositions, CheckerBoard checkerBoard)
        {
            List<CandidatePosition> candidates = Utilities.GetAllCandidatePositions(historyPositions.ToList(), checkerBoard);

            foreach (var candidate in candidates)
            {
                candidate.Score = Evaluation.EvaluatePositionScore(candidate, checkerBoard, checkerBoard[historyPositions.First()]);
            }

            return candidates;
        }

        public Position GetBestNextPosition()
        {
            Position bestNextPosition = null;

            if (computerHistory.Count > 0)
            {
                List<CandidatePosition> computerCandidates = GetAllCandidadteWithScores(computerHistory.ToList(), _checkBoard);

                var superCandidate = computerCandidates.Where(candidate => candidate.Score >= Constants.SuperScore).FirstOrDefault();
                if (superCandidate != null)
                {
                    return superCandidate.Position;
                }
                else
                {
                    List<CandidatePosition> humanCandidates = GetAllCandidadteWithScores(humanHistory.ToList(), _checkBoard);

                }

            }

            return bestNextPosition;
        }
    }
}
