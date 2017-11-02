namespace Chess_PawnsOnly
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.movesPanel = new System.Windows.Forms.Panel();
            this.movesContent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.board = new System.Windows.Forms.Panel();
            this.computerIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scoreComputer_lbl = new System.Windows.Forms.Label();
            this.scoreUser_lbl = new System.Windows.Forms.Label();
            this.movesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // movesPanel
            // 
            this.movesPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.movesPanel.AutoScroll = true;
            this.movesPanel.BackColor = System.Drawing.Color.NavajoWhite;
            this.movesPanel.Controls.Add(this.movesContent);
            this.movesPanel.Controls.Add(this.label5);
            this.movesPanel.Location = new System.Drawing.Point(433, 12);
            this.movesPanel.Name = "movesPanel";
            this.movesPanel.Size = new System.Drawing.Size(200, 496);
            this.movesPanel.TabIndex = 1;
            // 
            // movesContent
            // 
            this.movesContent.AutoSize = true;
            this.movesContent.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movesContent.Location = new System.Drawing.Point(12, 47);
            this.movesContent.Name = "movesContent";
            this.movesContent.Size = new System.Drawing.Size(0, 20);
            this.movesContent.TabIndex = 1;
            this.movesContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "MOVES";
            // 
            // board
            // 
            this.board.BackgroundImage = global::Chess_PawnsOnly.Properties.Resources.chess_board;
            this.board.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.board.Location = new System.Drawing.Point(12, 12);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(415, 415);
            this.board.TabIndex = 0;
            // 
            // computerIcon
            // 
            this.computerIcon.Image = global::Chess_PawnsOnly.Properties.Resources.black_pawn;
            this.computerIcon.Location = new System.Drawing.Point(26, 438);
            this.computerIcon.Name = "computerIcon";
            this.computerIcon.Size = new System.Drawing.Size(21, 20);
            this.computerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerIcon.TabIndex = 2;
            this.computerIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Computer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "User";
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.DarkGray;
            this.userIcon.Image = global::Chess_PawnsOnly.Properties.Resources.white_pawn;
            this.userIcon.Location = new System.Drawing.Point(319, 436);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(21, 20);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userIcon.TabIndex = 4;
            this.userIcon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Image = global::Chess_PawnsOnly.Properties.Resources.white_pawn;
            this.pictureBox1.Location = new System.Drawing.Point(75, 462);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Chess_PawnsOnly.Properties.Resources.black_pawn;
            this.pictureBox2.Location = new System.Drawing.Point(360, 462);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "x";
            // 
            // scoreComputer_lbl
            // 
            this.scoreComputer_lbl.AutoSize = true;
            this.scoreComputer_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreComputer_lbl.Location = new System.Drawing.Point(19, 467);
            this.scoreComputer_lbl.Name = "scoreComputer_lbl";
            this.scoreComputer_lbl.Size = new System.Drawing.Size(37, 39);
            this.scoreComputer_lbl.TabIndex = 10;
            this.scoreComputer_lbl.Text = "0";
            // 
            // scoreUser_lbl
            // 
            this.scoreUser_lbl.AutoSize = true;
            this.scoreUser_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreUser_lbl.Location = new System.Drawing.Point(303, 469);
            this.scoreUser_lbl.Name = "scoreUser_lbl";
            this.scoreUser_lbl.Size = new System.Drawing.Size(37, 39);
            this.scoreUser_lbl.TabIndex = 11;
            this.scoreUser_lbl.Text = "0";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 520);
            this.Controls.Add(this.scoreUser_lbl);
            this.Controls.Add(this.scoreComputer_lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.computerIcon);
            this.Controls.Add(this.movesPanel);
            this.Controls.Add(this.board);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Text = "Chess game - Pawns only";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.movesPanel.ResumeLayout(false);
            this.movesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.Panel movesPanel;
        private System.Windows.Forms.PictureBox computerIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label scoreComputer_lbl;
        private System.Windows.Forms.Label scoreUser_lbl;
        private System.Windows.Forms.Label movesContent;
        private System.Windows.Forms.Label label5;
    }
}

