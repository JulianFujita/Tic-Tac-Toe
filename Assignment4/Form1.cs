using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// This represents the tic-tac-toe board
        /// </summary>
        private Board b = new Board();
        /// <summary>
        /// When false, the board will not respond.
        /// </summary>
        private bool handleEvents = true;
        public Form1()
        {
            InitializeComponent();
            PrepareBoard();
        }

        /// <summary>
        /// Overwrites the default text on the labels
        /// </summary>
        public void PrepareBoard() 
        {
            l0_0.Text = "";
            l0_1.Text = "";
            l0_2.Text = "";
            l1_0.Text = "";
            l1_1.Text = "";
            l1_2.Text = "";
            l2_0.Text = "";
            l2_1.Text = "";
            l2_2.Text = "";
            l0_0.ForeColor = Color.Black;
            l0_1.ForeColor = Color.Black;
            l0_2.ForeColor = Color.Black;
            l1_0.ForeColor = Color.Black;
            l1_1.ForeColor = Color.Black;
            l1_2.ForeColor = Color.Black;
            l2_0.ForeColor = Color.Black;
            l2_1.ForeColor = Color.Black;
            l2_2.ForeColor = Color.Black;
        }

        /// <summary>
        /// The tic-tac-toe board is clicked.
        /// The row and column are determined.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tictactoe_board_Click(object sender, EventArgs e)
        {
            if (handleEvents)
            {
                // Gather mouse position and cell widths
                TableLayoutPanel table = (TableLayoutPanel)sender;
                Point origin = table.Location;
                Point mouse = PointToClient(Cursor.Position);

                int cellWidth = table.Width / 3;
                int cellHeight = table.Height / 3;

                mouse.X -= origin.X;
                mouse.Y -= origin.Y;


                // Determine active cell using integer division
                int currentRow = mouse.Y / cellHeight;
                int currentColumn = mouse.X / cellWidth;
                Debug.WriteLine(currentRow + ",  " + currentColumn);

                // Get the panel and attempt a move
                // TODO
                // Get the panel and attempt a move
                Panel selection = b.GetPanel(currentRow, currentColumn);

                selection.TrySelect(b);
                String cell = currentRow + ", " + currentColumn;
                switch (cell)
                {
                    case "0, 0":
                        l0_0.Text = selection.GetSelection().ToString();
                        break;
                    case "0, 1":
                        l0_1.Text = selection.GetSelection().ToString();
                        break;
                    case "0, 2":
                        l0_2.Text = selection.GetSelection().ToString();
                        break;
                    case "1, 0":
                        l1_0.Text = selection.GetSelection().ToString();
                        break;
                    case "1, 1":
                        l1_1.Text = selection.GetSelection().ToString();
                        break;
                    case "1, 2":
                        l1_2.Text = selection.GetSelection().ToString();
                        break;
                    case "2, 0":
                        l2_0.Text = selection.GetSelection().ToString();
                        break;
                    case "2, 1":
                        l2_1.Text = selection.GetSelection().ToString();
                        break;
                    case "2, 2":
                        l2_2.Text = selection.GetSelection().ToString();
                        break;
                }

                // Update textbox
                Board.Turn currentTurn = b.GetTurn();
                if (currentTurn == 0)
                    game_status_text.Text = "Player 1's Turn (X)";
                else
                    game_status_text.Text = "Player 2's Turn (O)";

                // Check for any potential wins or ties
                String winner = "";
                int[] pattern = new int[6];
                bool win = b.IsWinningMove(ref pattern, ref winner);
                bool tie = b.IsTie();

                if (win)
                {
                    GameWon(pattern, winner);
                    handleEvents = false;
                }
                else if (tie)
                {
                    tictactoe_board.Enabled = false;
                    handleEvents = false;
                    game_status_text.Text = "Tie Game";
                    b.Tie();
                    ties.Text = "Ties: " + b.GetTieCount().ToString();
                }
            }
            
        }

        /// <summary>
        /// The start game button has been pressed.
        /// The board is unlocked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_button_Click(object sender, EventArgs e)
        {
            handleEvents = true;
            b = new Board();
            PrepareBoard();
            tictactoe_board.Enabled = true;
            tictactoe_board.BackColor = Color.LightGray;
            game_status_text.Text = "Player 1's Turn (X)";
        }

        /// <summary>
        /// Handles the event that the game is won
        /// </summary>
        /// <param name="pattern">The winning pattern</param>
        /// <param name="winner">The winner</param>
        private void GameWon(int[] pattern, String winner) 
        {
            Point cell1 = new Point(pattern[0], pattern[1]);
            Point cell2 = new Point(pattern[2], pattern[3]);
            Point cell3 = new Point(pattern[4], pattern[5]);

            String cell = cell1.X + ", " + cell1.Y;
            ColorCell(cell);
            cell = cell2.X + ", " + cell2.Y;
            ColorCell(cell);
            cell = cell3.X + ", " + cell3.Y;
            ColorCell(cell);

            if (winner == "X")
            {
                game_status_text.Text = "Player 1 Wins!";
                b.Player1Win();
                player1_wins.Text = "Player 1 Wins: " + b.GetWinCount()[0].ToString();
            }
            else 
            {
                game_status_text.Text = "Player 2 Wins!";
                b.Player2Win();
                player2_wins.Text = "Player 2 Wins: " + b.GetWinCount()[1].ToString();
            }
                
        }

        /// <summary>
        /// Colors the cell when a win is detected
        /// </summary>
        /// <param name="cell">The cell you want to color</param>
        private void ColorCell(String cell) 
        {
            switch (cell)
            {
                case "0, 0":
                    l0_0.ForeColor = Color.Red;
                    break;
                case "0, 1":
                    l0_1.ForeColor = Color.Red;
                    break;
                case "0, 2":
                    l0_2.ForeColor = Color.Red;
                    break;
                case "1, 0":
                    l1_0.ForeColor = Color.Red;
                    break;
                case "1, 1":
                    l1_1.ForeColor = Color.Red;
                    break;
                case "1, 2":
                    l1_2.ForeColor = Color.Red;
                    break;
                case "2, 0":
                    l2_0.ForeColor = Color.Red;
                    break;
                case "2, 1":
                    l2_1.ForeColor = Color.Red;
                    break;
                case "2, 2":
                    l2_2.ForeColor = Color.Red;
                    break;
            }
        }
    }
}
