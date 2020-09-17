using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    /// <summary>
    /// Holds the game statistics, and houses the panels.
    /// Methods include start, and checking for a winning move.
    /// </summary>
    class Board
    {
        /// <summary>
        /// Holds 3x3 grid of panels
        /// </summary>
        private Panel[,] p = new Panel[3, 3];
        /// <summary>
        /// Signifies who's turn it is
        /// </summary>
        public enum Turn { P1 = 0, P2 = 1 }
        private Turn turn = Turn.P1;
        /// <summary>
        /// Number of wins in the current game
        /// Index 0 means Player 1
        /// </summary>
        private int[] winCount = { 0, 0 };
        /// <summary>
        /// Number of ties in the current game
        /// </summary>
        private int tieCount = 0;

        /// <summary>
        /// Gets the current win count
        /// </summary>
        /// <returns>winCount</returns>
        public int[] GetWinCount() { return this.winCount; }
        /// <summary>
        /// Gets the current tie count
        /// </summary>
        /// <returns>tieCount</returns>
        public int GetTieCount() { return this.tieCount; }
        /// <summary>
        /// Gets who's turn it is
        /// </summary>
        /// <returns>turn</returns>
        public Turn GetTurn() { return this.turn; }

        /// <summary>
        /// Check if the current status of the board to see if the move was a winning move
        /// </summary>
        /// <returns>True if it is a winning move</returns>
        public bool isWinningMove() 
        {
            //Horizontal
            if (p[0, 0].Equals(p[0, 1]) && p[0, 1].Equals(p[0, 2]))
            {

            }
            else if (p[1, 0].Equals(p[1, 1]) && p[1, 1].Equals(p[1, 2]))
            {

            }
            else if (p[2, 0].Equals(p[2, 1]) && p[2, 1].Equals(p[2, 2]))
            {

            }
            //Vertical
            else if (p[0, 0].Equals(p[1, 0]) && p[1, 0].Equals(p[2, 0]))
            {

            }
            else if (p[0, 1].Equals(p[1, 1]) && p[1, 1].Equals(p[2, 1]))
            {

            }
            else if (p[0, 2].Equals(p[1, 2]) && p[1, 2].Equals(p[2, 2]))
            {

            }
            //Diagonal
            else if (p[0, 0].Equals(p[1, 1]) && p[1, 1].Equals(p[2, 2]))
            { 
            
            }
            else if (p[0, 2] == p[1, 1] && p[1, 1] == p[2, 0])
            {

            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
