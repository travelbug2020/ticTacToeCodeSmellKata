using System.Collections.Generic;
using System.Linq;
using static TicTacToe.Position;

namespace TicTacToe
{
    public class WinningPositions
    {
        public readonly List<Position[]> Positions = new List<Position[]>
        {
            new[] {TopLeft, TopMiddle, TopRight},
            new[] {CenterLeft,CenterMiddle,CenterRight},
            new[] {BottomLeft,BottomMiddle,BottomRight},
            new[] {TopLeft,CenterLeft,BottomLeft},
            new[] {TopMiddle,CenterMiddle,BottomMiddle},
            new[] {TopRight,CenterRight,BottomRight},
            new[] {TopRight,CenterMiddle,BottomLeft},
            new[] {TopLeft,CenterMiddle,BottomRight}


        };
    }
}