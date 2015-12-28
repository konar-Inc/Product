using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    public class Constants
    {
        public const int Rows = 15;
        public const int Cols = 9;

        public const int SuperScore = 1000000;

        public const int PathClosedScore = 0;

        public const int FiveConnectedScore = 10000;

        public const int FourConnectedOneOpenScore = 500;
        public const int FourConnectedBothOpenScore = 1000;

        public const int ThreeConnectedOneOpenScore = 200;
        public const int ThreeConnectedBothOpenScore = 500;

        public const int TwoConnectedOneOpenScore = 100;
        public const int TwoConnectedBothOpenScore = 250;

        public const int OneConnectedOneOpenScore = 1;
        public const int OneConnectedBothOpenScore = 100;

        public static readonly Dictionary<ExtendLevel, double> ExtendScore = new Dictionary<ExtendLevel, double>()
        {
            { ExtendLevel.None, 0.0 },
            { ExtendLevel.Good, 1.0 },
            { ExtendLevel.Better, 1.5 }
        };

    }
}
