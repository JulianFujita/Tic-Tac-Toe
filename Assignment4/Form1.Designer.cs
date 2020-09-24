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
            this.l2_2 = new System.Windows.Forms.Label();
            this.l2_1 = new System.Windows.Forms.Label();
            this.l2_0 = new System.Windows.Forms.Label();
            this.l1_2 = new System.Windows.Forms.Label();
            this.l1_1 = new System.Windows.Forms.Label();
            this.l1_0 = new System.Windows.Forms.Label();
            this.l0_2 = new System.Windows.Forms.Label();
            this.l0_1 = new System.Windows.Forms.Label();
            this.l0_0 = new System.Windows.Forms.Label();
            this.statistics_groupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tictactoe_board.SuspendLayout();
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
            this.tictactoe_board.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tictactoe_board.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tictactoe_board.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tictactoe_board.ColumnCount = 3;
            this.tictactoe_board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tictactoe_board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tictactoe_board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tictactoe_board.Controls.Add(this.l2_2, 2, 2);
            this.tictactoe_board.Controls.Add(this.l2_1, 1, 2);
            this.tictactoe_board.Controls.Add(this.l2_0, 0, 2);
            this.tictactoe_board.Controls.Add(this.l1_2, 2, 1);
            this.tictactoe_board.Controls.Add(this.l1_1, 1, 1);
            this.tictactoe_board.Controls.Add(this.l1_0, 0, 1);
            this.tictactoe_board.Controls.Add(this.l0_2, 2, 0);
            this.tictactoe_board.Controls.Add(this.l0_1, 1, 0);
            this.tictactoe_board.Controls.Add(this.l0_0, 0, 0);
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
            // l2_2
            // 
            this.l2_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l2_2.AutoSize = true;
            this.l2_2.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l2_2.Location = new System.Drawing.Point(274, 242);
            this.l2_2.Name = "l2_2";
            this.l2_2.Size = new System.Drawing.Size(87, 114);
            this.l2_2.TabIndex = 0;
            this.l2_2.Text = "X";
            this.l2_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l2_1
            // 
            this.l2_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l2_1.AutoSize = true;
            this.l2_1.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l2_1.Location = new System.Drawing.Point(147, 242);
            this.l2_1.Name = "l2_1";
            this.l2_1.Size = new System.Drawing.Size(87, 114);
            this.l2_1.TabIndex = 0;
            this.l2_1.Text = "X";
            this.l2_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l2_0
            // 
            this.l2_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l2_0.AutoSize = true;
            this.l2_0.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l2_0.Location = new System.Drawing.Point(21, 242);
            this.l2_0.Name = "l2_0";
            this.l2_0.Size = new System.Drawing.Size(87, 114);
            this.l2_0.TabIndex = 0;
            this.l2_0.Text = "X";
            this.l2_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l1_2
            // 
            this.l1_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l1_2.AutoSize = true;
            this.l1_2.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l1_2.Location = new System.Drawing.Point(274, 123);
            this.l1_2.Name = "l1_2";
            this.l1_2.Size = new System.Drawing.Size(87, 114);
            this.l1_2.TabIndex = 0;
            this.l1_2.Text = "X";
            this.l1_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l1_1
            // 
            this.l1_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l1_1.AutoSize = true;
            this.l1_1.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l1_1.Location = new System.Drawing.Point(147, 123);
            this.l1_1.Name = "l1_1";
            this.l1_1.Size = new System.Drawing.Size(87, 114);
            this.l1_1.TabIndex = 0;
            this.l1_1.Text = "X";
            this.l1_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l1_0
            // 
            this.l1_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l1_0.AutoSize = true;
            this.l1_0.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l1_0.Location = new System.Drawing.Point(21, 123);
            this.l1_0.Name = "l1_0";
            this.l1_0.Size = new System.Drawing.Size(87, 114);
            this.l1_0.TabIndex = 0;
            this.l1_0.Text = "X";
            this.l1_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l0_2
            // 
            this.l0_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l0_2.AutoSize = true;
            this.l0_2.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l0_2.Location = new System.Drawing.Point(274, 4);
            this.l0_2.Name = "l0_2";
            this.l0_2.Size = new System.Drawing.Size(87, 114);
            this.l0_2.TabIndex = 0;
            this.l0_2.Text = "X";
            this.l0_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l0_1
            // 
            this.l0_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l0_1.AutoSize = true;
            this.l0_1.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l0_1.Location = new System.Drawing.Point(147, 4);
            this.l0_1.Name = "l0_1";
            this.l0_1.Size = new System.Drawing.Size(87, 114);
            this.l0_1.TabIndex = 0;
            this.l0_1.Text = "X";
            this.l0_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l0_0
            // 
            this.l0_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l0_0.AutoSize = true;
            this.l0_0.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l0_0.Location = new System.Drawing.Point(21, 4);
            this.l0_0.Name = "l0_0";
            this.l0_0.Size = new System.Drawing.Size(87, 114);
            this.l0_0.TabIndex = 0;
            this.l0_0.Text = "X";
            this.l0_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tictactoe_board.ResumeLayout(false);
            this.tictactoe_board.PerformLayout();
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
        private System.Windows.Forms.Label l0_0;
        private System.Windows.Forms.Label l2_2;
        private System.Windows.Forms.Label l2_1;
        private System.Windows.Forms.Label l2_0;
        private System.Windows.Forms.Label l1_2;
        private System.Windows.Forms.Label l1_1;
        private System.Windows.Forms.Label l1_0;
        private System.Windows.Forms.Label l0_2;
        private System.Windows.Forms.Label l0_1;
    }
}

