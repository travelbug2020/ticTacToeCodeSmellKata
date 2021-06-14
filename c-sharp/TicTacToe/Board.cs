using System.Collections.Generic;
using static TicTacToe.Player;
using static TicTacToe.PositionExtensions;

namespace TicTacToe
{
    public class Board
    {
        //private List<Tile> _plays = new List<Tile>();
        public readonly Dictionary<Position, Player> _board = new Dictionary<Position, Player>();
        public Board()
        {
            for (int xAxis = 0; xAxis < 3; xAxis++)
            {
                for (int yAxis = 0; yAxis < 3; yAxis++)
                {
                    var coordcombo = xAxis + yAxis;
                    var player = NONE;
                    var positionToPlay = coordsToPosition[coordcombo.ToString()];
                    _board.Add(positionToPlay,player);
                }  
            }       
        }
        //PRIMITIVE OBBSESSION
        //DATA CLUMP
        public Player checkPosition(Position position)
        {
            return _board[position];
        }
        //LONG PARAMETER LIST
        //PRIMITIVE OBBSESSION
        //DATA CLUMPS
        public void AddTileAt(Player player, Position position)
        {
           _board.Add(position,player);
           
        }
    }
}