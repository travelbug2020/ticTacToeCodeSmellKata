using System;
using System.Linq;
using System.Collections.Generic;

namespace TicTacToe
{
    //SHOTGUN SURERY
    //DATA CLASS
    public class Tile
    {
        // PRIMITIVE OBSESSION
        public int X {get; set;}
        public int Y {get; set;}
        public char Symbol {get; set;}
    }
    // SHOT GUN SURGERY
    // LARGE CLASS - CODE SMELL
    public class Board
    {
       private List<Tile> _plays = new List<Tile>();
       
        public Board()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _plays.Add(new Tile{ X = i, Y = j, Symbol = ' '});
                }  
            }       
        }
        //PRIMITIVE OBBSESSION
        //DATA CLUMP
       public Tile TileAt(int x, int y)
       {
           return _plays.Single(tile => tile.X == x && tile.Y == y);
       }
        //LONG PARAMETER LIST
        //PRIMITIVE OBBSESSION
        //DATA CLUMPS
       public void AddTileAt(char symbol, int x, int y)
       {
           //DEAD CODE
           var newTile = new Tile
           {
               X = x,
               Y = y,
               Symbol = symbol
           };
            //Message Chain
           _plays.Single(tile => tile.X == x && tile.Y == y).Symbol = symbol;
       }
    }
    // DIVERGANT CHANGE
    // COMMENTS
    public class Game
    {
        //PRIMITIVE OBBSESSION
        private char _lastSymbol = ' ';
        private Board _board = new Board();
        //LONG METHOD - CODE SMELL
        //LONG PARAMETER LIST
        //PRIMITIVE OBBSESSION
        //DATA CLUMP
        public void Play(char symbol, int x, int y)
        {
            
            //SWITCH - CODE SMELL
            //if first move
            if(_lastSymbol == ' ')
            {
                //if player is X
                if(symbol == 'O')
                {
                    throw new Exception("Invalid first player");
                }
            } 
            //if not first move but player repeated
            else if (symbol == _lastSymbol)
            {
                throw new Exception("Invalid next player");
            }
            //if not first move but play on an already played tile
            //Message Chain
            else if (_board.TileAt(x, y).Symbol != ' ')
            {
                throw new Exception("Invalid position");
            }

            // update game state
            _lastSymbol = symbol;
            _board.AddTileAt(symbol, x, y);
        }
        //Primitive OBBSESSION - CODE SMELL
        //LONG METHOD - CODE SMELL
        //SWITCH
        //DUPLICATE CODE
        // FEATURE ENVY
        //Innappropiate intimicy
        //Message Chains
        public char Winner()
        {   //if the positions in first row are taken
            if(_board.TileAt(0, 0).Symbol != ' ' &&
               _board.TileAt(0, 1).Symbol != ' ' &&
               _board.TileAt(0, 2).Symbol != ' ')
               {
                    //if first row is full with same symbol
                    if (_board.TileAt(0, 0).Symbol == 
                        _board.TileAt(0, 1).Symbol &&
                        _board.TileAt(0, 2).Symbol == 
                        _board.TileAt(0, 1).Symbol )
                        {
                            return _board.TileAt(0, 0).Symbol;
                        }
               }
                
             //if the positions in first row are taken
             if(_board.TileAt(1, 0).Symbol != ' ' &&
                _board.TileAt(1, 1).Symbol != ' ' &&
                _board.TileAt(1, 2).Symbol != ' ')
                {
                    //if middle row is full with same symbol
                    if (_board.TileAt(1, 0).Symbol == 
                        _board.TileAt(1, 1).Symbol &&
                        _board.TileAt(1, 2).Symbol == 
                        _board.TileAt(1, 1).Symbol)
                        {
                            return _board.TileAt(1, 0).Symbol;
                        }
                }

            //if the positions in first row are taken
             if(_board.TileAt(2, 0).Symbol != ' ' &&
                _board.TileAt(2, 1).Symbol != ' ' &&
                _board.TileAt(2, 2).Symbol != ' ')
                {
                    //if middle row is full with same symbol
                    if (_board.TileAt(2, 0).Symbol == 
                        _board.TileAt(2, 1).Symbol &&
                        _board.TileAt(2, 2).Symbol == 
                        _board.TileAt(2, 1).Symbol)
                        {
                            return _board.TileAt(2, 0).Symbol;
                        }
                }

            return ' ';
        }
    }
}