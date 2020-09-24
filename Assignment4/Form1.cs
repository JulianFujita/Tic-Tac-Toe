using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// This represents the tic-tac-toe board
        /// </summary>
        Board b = new Board();
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The tic-tac-toe board is clicked.
        /// The row and column are determined.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tictactoe_board_Click(object sender, EventArgs e)
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
        }
    }
}
