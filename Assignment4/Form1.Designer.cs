namespace Assignment4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statistics_groupbox = new System.Windows.Forms.GroupBox();
            this.ties = new System.Windows.Forms.Label();
            this.player2_wins = new System.Windows.Forms.Label();
            this.player1_wins = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.game_status_text = new System.Windows.Forms.RichTextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.tictactoe_board = new System.Windows.Forms.TableLayoutPanel();
            this.statistics_groupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statistics_groupbox
            // 
            this.statistics_groupbox.Controls.Add(this.ties);
            this.statistics_groupbox.Controls.Add(this.player2_wins);
            this.statistics_groupbox.Controls.Add(this.player1_wins);
            this.statistics_groupbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statistics_groupbox.Location = new System.Drawing.Point(412, 224);
            this.statistics_groupbox.Name = "statistics_groupbox";
            this.statistics_groupbox.Size = new System.Drawing.Size(255, 149);
            this.statistics_groupbox.TabIndex = 0;
            this.statistics_groupbox.TabStop = false;
            this.statistics_groupbox.Text = "Statistics";
            // 
            // ties
            // 
            this.ties.AutoSize = true;
            this.ties.Location = new System.Drawing.Point(86, 104);
            this.ties.Name = "ties";
            this.ties.Size = new System.Drawing.Size(54, 20);
            this.ties.TabIndex = 0;
            this.ties.Text = "Ties: 0";
            // 
            // player2_wins
            // 
            this.player2_wins.AutoSize = true;
            this.player2_wins.Location = new System.Drawing.Point(19, 68);
            this.player2_wins.Name = "player2_wins";
            this.player2_wins.Size = new System.Drawing.Size(121, 20);
            this.player2_wins.TabIndex = 0;
            this.player2_wins.Text = "Player 2 Wins: 0";
            // 
            // player1_wins
            // 
            this.player1_wins.AutoSize = true;
            this.player1_wins.Location = new System.Drawing.Point(19, 33);
            this.player1_wins.Name = "player1_wins";
            this.player1_wins.Size = new System.Drawing.Size(121, 20);
            this.player1_wins.TabIndex = 0;
            this.player1_wins.Text = "Player 1 Wins: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.game_status_text);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Status";
            // 
            // game_status_text
            // 
            this.game_status_text.Location = new System.Drawing.Point(7, 26);
            this.game_status_text.Name = "game_status_text";
            this.game_status_text.ReadOnly = true;
            this.game_status_text.Size = new System.Drawing.Size(317, 68);
            this.game_status_text.TabIndex = 0;
            this.game_status_text.Text = "";
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.start_button.Location = new System.Drawing.Point(412, 12);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(186, 89);
            this.start_button.TabIndex = 3;
            this.start_button.Text = "Start Game";
            this.start_button.UseVisualStyleBackColor = true;
            // 
            // tictactoe_board
            // 
            this.tictactoe_board.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tictactoe_board.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tictactoe_board.ColumnCount = 3;
            this.tictactoe_board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tictactoe_board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tictactoe_board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tictactoe_board.Location = new System.Drawing.Point(12, 12);
            this.tictactoe_board.Name = "tictactoe_board";
            this.tictactoe_board.RowCount = 3;
            this.tictactoe_board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tictactoe_board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tictactoe_board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tictactoe_board.Size = new System.Drawing.Size(383, 361);
            this.tictactoe_board.TabIndex = 2;
            this.tictactoe_board.Click += new System.EventHandler(this.tictactoe_board_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 508);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.tictactoe_board);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statistics_groupbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statistics_groupbox.ResumeLayout(false);
            this.statistics_groupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox statistics_groupbox;
        private System.Windows.Forms.Label player2_wins;
        private System.Windows.Forms.Label player1_wins;
        private System.Windows.Forms.Label ties;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox game_status_text;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.TableLayoutPanel tictactoe_board;
    }
}

