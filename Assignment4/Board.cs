using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Assignment4
{
    /// <summary>
    /// Holds the game statistics, and houses the panels.
    /// Methods include start, and checking for a winning move.
    /// </summary>
    class Board
    {
        private static int moves = 0;
        /// <summary>
        /// Holds 3x3 grid of panels
        /// Row X Columns
        /// </summary>
        private Panel[,] p = { { new Panel(), new Panel(), new Panel() }, 
            { new Panel(), new Panel(), new Panel() } , 
            { new Panel(), new Panel(), new Panel() } };
        /// <summary>
        /// Signifies who's turn it is
        /// </summary>
        public enum Turn { P1 = 0, P2 = 1 }
        private Turn turn = Turn.P1;
        /// <summary>
        /// Number of wins in the current game
        /// Index 0 means Player 1
        /// </summary>
        private static int[] winCount = { 0, 0 };
        /// <summary>
        /// Number of ties in the current game
        /// </summary>
        private static int tieCount = 0;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Board() { moves = 0; }

        /// <summary>
        /// Gets the current win count
        /// </summary>
        /// <returns>winCount</returns>
        public int[] GetWinCount() { return winCount; }
        /// <summary>
        /// Increment win count for player1
        /// </summary>
        public void Player1Win() { winCount[0]++; }
        /// <summary>
        /// Increment win cound for player2
        /// </summary>
        public void Player2Win() { winCount[1]++; }
        public void Tie() { tieCount++; }
        /// <summary>
        /// Gets the current tie count
        /// </summary>
        /// <returns>tieCount</returns>
        public int GetTieCount() { return tieCount; }
        /// <summary>
        /// Gets who's turn it is
        /// </summary>
        /// <returns>turn</returns>
        public Turn GetTurn() { return this.turn; }
        /// <summary>
        /// Switches to the next turn
        /// </summary>
        public void NextTurn() 
        {
            if (this.turn == Turn.P1)
                this.turn = Turn.P2;
            else
                this.turn = Turn.P1;

            moves++;
        }
        /// <summary>
        /// Get the panel for the provided indicies.
        /// </summary>
        /// <param name="row">Row index</param>
        /// <param name="column">Column index</param>
        /// <returns>The specific panel is returned</returns>
        public Panel GetPanel(int row, int column) { return this.p[row, column]; }

        /// <summary>
        /// Check if the current status of the board to see if the move was a winning move
        /// Row X Column
        /// </summary>
        /// <param name="winner">Passed by reference and is set on the way out</param>
        /// <param name="pattern">Passed by reference. Used to show winning pattern</param>
        /// <returns>True if it is a winning move</returns>
        public bool IsWinningMove(ref int[] pattern, ref String winner) 
        {
            //Horizontal
            if (p[0, 0].Equals(p[0, 1]) && p[0, 1].Equals(p[0, 2]))
            {
                pattern[0] = 0;
                pattern[1] = 0;
                pattern[2] = 0;
                pattern[3] = 1;
                pattern[4] = 0;
                pattern[5] = 2;
                winner = p[0, 0].GetSelection().ToString();
            }
            else if (p[1, 0].Equals(p[1, 1]) && p[1, 1].Equals(p[1, 2]))
            {
                pattern[0] = 1;
                pattern[1] = 0;
                pattern[2] = 1;
                pattern[3] = 1;
                pattern[4] = 1;
                pattern[5] = 2;
                winner = p[1, 0].GetSelection().ToString();
            }
            else if (p[2, 0].Equals(p[2, 1]) && p[2, 1].Equals(p[2, 2]))
            {
                pattern[0] = 2;
                pattern[1] = 0;
                pattern[2] = 2;
                pattern[3] = 1;
                pattern[4] = 2;
                pattern[5] = 2;
                winner = p[2, 0].GetSelection().ToString();
            }
            //Vertical
            else if (p[0, 0].Equals(p[1, 0]) && p[1, 0].Equals(p[2, 0]))
            {
                pattern[0] = 0;
                pattern[1] = 0;
                pattern[2] = 1;
                pattern[3] = 0;
                pattern[4] = 2;
                pattern[5] = 0;
                winner = p[0, 0].GetSelection().ToString();
            }
            else if (p[0, 1].Equals(p[1, 1]) && p[1, 1].Equals(p[2, 1]))
            {
                pattern[0] = 0;
                pattern[1] = 1;
                pattern[2] = 1;
                pattern[3] = 1;
                pattern[4] = 2;
                pattern[5] = 1;
                winner = p[0, 1].GetSelection().ToString();
            }
            else if (p[0, 2].Equals(p[1, 2]) && p[1, 2].Equals(p[2, 2]))
            {
                pattern[0] = 0;
                pattern[1] = 2;
                pattern[2] = 1;
                pattern[3] = 2;
                pattern[4] = 2;
                pattern[5] = 2;
                winner = p[0, 2].GetSelection().ToString();
            }
            //Diagonal
            else if (p[0, 0].Equals(p[1, 1]) && p[1, 1].Equals(p[2, 2]))
            {
                pattern[0] = 0;
                pattern[1] = 0;
                pattern[2] = 1;
                pattern[3] = 1;
                pattern[4] = 2;
                pattern[5] = 2;
                winner = p[0, 0].GetSelection().ToString();
            }
            else if (p[0, 2].Equals(p[1, 1]) && p[1, 1].Equals(p[2, 0]))
            {
                pattern[0] = 0;
                pattern[1] = 2;
                pattern[2] = 1;
                pattern[3] = 1;
                pattern[4] = 2;
                pattern[5] = 0;
                winner = p[0, 2].GetSelection().ToString();
            }
            else
            {
                return false;
            }

            return true;
        }
        /// <summary>
        /// Check if the current status of the board to see if the move is a tie
        /// Row X Column
        /// </summary>
        /// <returns>True if it is a tie</returns>
        public bool IsTie()
        {
            if(moves >= 9)
                return true;
            return false;
        }
    }
}
