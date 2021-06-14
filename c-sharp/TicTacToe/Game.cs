using System;
using System.Collections.Generic;
using System.Linq;
using static TicTacToe.Player;

namespace TicTacToe
{
    //SHOTGUN SURERY
    //DATA CLASS

    public class Axis
    {
        public int xAxis;
        public int yAxis;
    }

    // SHOT GUN SURGERY
    // LARGE CLASS - CODE SMELL
  
    // DIVERGANT CHANGE
    // COMMENTS
    public class Game
    {
        //PRIMITIVE OBBSESSION
        private Player _lastSymbol = NONE;
        private Board _board = new Board();
        //LONG METHOD - CODE SMELL
        //LONG PARAMETER LIST
        //PRIMITIVE OBBSESSION
        //DATA CLUMP
        public void Play(Player player, Axis xAxis, Axis yAxis) //O o o
        {
          string xAxisString =  xAxis.ToString();
          string yAxisString =  yAxis.ToString();
          string coordcombo = xAxisString + yAxisString;
             
             
            var positionToPlay = PositionExtensions.coordsToPosition[coordcombo.ToString()];
            //var position = _board.checkPosition(positionToPlay);
            //SWITCH - CODE SMELL
            //if first move
            if (_lastSymbol == NONE)
            {
                //if player is X
                if(player == O)
                {
                    throw new Exception("Invalid first player");
                }
            } 
            //if not first move but player repeated
            else if (player == _lastSymbol)
            {
                throw new Exception("Invalid next player");
            }
            //if not first move but play on an already played tile
            //Message Chain
            //else if (position != NONE)
            //{
            //    throw new Exception("Invalid position");
            //}

            // update game state
            _lastSymbol = player;
            _board.AddTileAt(player, positionToPlay);
        }
        //Primitive OBBSESSION - CODE SMELL
        //LONG METHOD - CODE SMELL
        //SWITCH
        //DUPLICATE CODE
        // FEATURE ENVY
        //Innappropiate intimicy
        //Message Chains
        private readonly WinningPositions _listOfWinningMoves = new WinningPositions();
        private bool IsAWinningLine(Position winningPosition1, Position winningPosition2, Position winningPosition3)
        {
            return _board._board.ContainsKey(winningPosition1) && _board._board.ContainsKey(winningPosition2) &&
            _board._board.ContainsKey(winningPosition3) && _board._board[winningPosition1] == _board._board[winningPosition2] &&
                   _board._board[winningPosition2] == _board._board[winningPosition3];
        }
        public Player Winner()
        {
            var winningLine = _listOfWinningMoves.Positions.FirstOrDefault(winningMoves =>
                IsAWinningLine(winningMoves[0], winningMoves[1], winningMoves[2]));
            if (winningLine == null)
            {
                return NONE;
            }
            return _board._board[winningLine[0]];
            
        }
       
    }
}