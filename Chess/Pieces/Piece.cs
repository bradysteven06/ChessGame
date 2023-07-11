using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Game;

namespace Chess.Pieces
{
    abstract class Piece
    {
        // Properties
        public Position Position { get; set; }
        public string Color { get; set; }
        public bool HasMoved { get; set; }

        // Method
        // returns a list of Position for possible moves
        public abstract List<Position> PossibleMoves();
    }
}
