using System.Collections.Generic;

namespace TicTacToe
{
    public static class PositionExtensions
    {

        public static readonly Dictionary<string, Position> coordsToPosition = new Dictionary<string, Position>
        {
            {"0,0",Position.BottomLeft},
            {"1,0",Position.BottomMiddle},
            {"2,0",Position.BottomRight},
            {"0,1",Position.CenterLeft},
            {"1,1",Position.CenterMiddle},
            {"2,1",Position.CenterRight},
            {"0,2",Position.TopLeft},
            {"1,2",Position.TopMiddle},
            {"2,2",Position.TopRight},
        };


    }
}