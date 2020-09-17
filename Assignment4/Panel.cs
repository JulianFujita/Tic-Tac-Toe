using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    /// <summary>
    /// This is a single panel of the game board
    /// </summary>
    class Panel
    {
        /// <summary>
        /// The current selection for this panel
        /// </summary>
        public enum Selection { X = 'X', O = 'O', None};
        private Selection selection = Selection.None;
        /// <summary>
        /// Blocks the move if the panel is already used
        /// </summary>
        private bool isUsed = false;


        /// <summary>
        /// Tries to select the panel for the current player.
        /// </summary>
        /// <param name="selection">X or O</param>
        /// <returns>True if successful</returns>
        public bool TrySelect(Selection selection)
        {
            if (isUsed)
                return false;
            else 
            {
                isUsed = true;
                this.selection = selection;
                return true;
            }
        }
        /// <summary>
        /// Gets the current selection of the panel
        /// </summary>
        /// <returns>selection</returns>
        public Selection GetSelection() { return this.selection; }

        /// <summary>
        /// Override the equals method to make determining the winning move easier
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            // Cast object to Panel object
            Panel panel = (Panel)obj;

            // If either panel is empty, return false
            if (this.selection == Selection.None || panel.selection == Selection.None)
                return false;
            // If panels are not empty, check if they are equal
            if (this.selection == panel.selection)
                return true;
        }

    }
}
