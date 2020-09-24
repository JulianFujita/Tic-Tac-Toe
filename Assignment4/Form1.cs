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
        }
    }
}
