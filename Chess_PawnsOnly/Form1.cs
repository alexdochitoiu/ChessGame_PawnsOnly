using System;
using System.Drawing;
using System.Windows.Forms;
using Chess_PawnsOnly.Properties;
using System.Linq;

namespace Chess_PawnsOnly
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            Pictures = new PictureBox[8, 8];
        }

        public bool FirstMove = true;
        public bool SecondMove;
        public bool AllowMove;

        public bool BoundsError { get; private set; }

        public PictureBox[,] Pictures;
        public bool ReadyToCapture;
        public new int Move = 1;
        public PictureBox PictureToBeMoved;
        public string PlayerTurn;
        public bool ComputerFirstMove = true;

        public PictureBox BoundsErrorPicture { get; private set; }

        private void GameForm_Load(object sender, EventArgs e)
        {
            PlayerTurn = "User";
            for (var i = 0; i < 8; i++)
            {
                for (var j = 0; j < 8; j++)
                {
                    Pictures[i, j] = new PictureBox
                    {
                        Size = new Size(48, 49),
                        Location = new Point(17 + 47 * j, 14 + 48 * i),
                        Visible = true,
                        Name = "Picture_" + (8 - i) + (char) (65 + j),
                        BackgroundImage =
                            i == 1
                                ? new Bitmap(Resources.black_pawn)
                                : i == 6
                                    ? new Bitmap(Resources.white_pawn)
                                    : null,
                        BackColor = Color.Transparent,
                        BackgroundImageLayout = ImageLayout.Zoom
                    };
                    board?.Controls.Add(Pictures[i, j]);
                    Pictures[i, j].Click += Picture_Click;
                    Pictures[i, j].Tag = "E";
                    if (i == 1) Pictures[i, j].Tag = "B";
                    if (i == 6) Pictures[i, j].Tag = "W";
                }
            }
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            //User staff..
            if (PlayerTurn.Equals("User"))
            {
                if (((PictureBox)sender).Tag.Equals("W"))
                {
                    //Just when starting
                    if (((PictureBox)sender).Name.StartsWith("Picture_2"))
                    {
                        if (FirstMove && !SecondMove)
                        {
                            var cell = (PictureBox)sender;
                            PictureToBeMoved = cell;
                            FirstMove = false;
                            SecondMove = true;
                            Pictures[8 - 3, cell.Name[9] - 65].BackColor = Color.LightGreen;
                            Pictures[8 - 4, cell.Name[9] - 65].BackColor = Color.LightGreen;
                            cell.BorderStyle
                                = Pictures[8 - 3, cell.Name[9] - 65].BorderStyle
                                    = Pictures[8 - 4, cell.Name[9] - 65].BorderStyle
                                        = BorderStyle.Fixed3D;
                        }
                        else if (SecondMove)
                        {
                            var cell = (PictureBox)sender;
                            PictureToBeMoved = cell;
                            Pictures[8 - 3, cell.Name[9] - 65].BackColor = Color.LightGreen;
                            cell.BorderStyle
                                = Pictures[8 - 3, cell.Name[9] - 65].BorderStyle
                                    = BorderStyle.Fixed3D;

                            SecondMove = false;
                        }
                    }

                    if (AllowMove)
                    {
                        AllowMove = false;

                        var cell = (PictureBox)sender;
                        PictureToBeMoved = cell;

                        if (!cell.Name.EndsWith("A") &&
                            Pictures[8 - (cell.Name[8] - 48) - 1, -1 + (cell.Name[9] - 65)].Tag.Equals("B"))
                        {
                            //Make diagonal cell light green if there are a opponent present
                            ReadyToCapture = true;
                            Pictures[8 - (cell.Name[8] - 48) - 1, -1 + (cell.Name[9] - 65)].BackColor = Color.LightGreen;
                            cell.BorderStyle
                                = Pictures[8 - (cell.Name[8] - 48) - 1, -1 + (cell.Name[9] - 65)].BorderStyle
                                    = BorderStyle.Fixed3D;
                        }
                        if (!cell.Name.EndsWith("H") &&
                            Pictures[8 - (cell.Name[8] - 48) - 1, 1 + (cell.Name[9] - 65)].Tag.Equals("B"))
                        {
                            //Make diagonal cell light green if there are a opponent present
                            ReadyToCapture = true;
                            Pictures[8 - (cell.Name[8] - 48) - 1, 1 + (cell.Name[9] - 65)].BackColor = Color.LightGreen;
                            cell.BorderStyle
                                = Pictures[8 - (cell.Name[8] - 48) - 1, 1 + (cell.Name[9] - 65)].BorderStyle
                                    = BorderStyle.Fixed3D;
                        }
                        if (Pictures[8 - (cell.Name[8] - 48) - 1, cell.Name[9] - 65].Tag.Equals("E"))
                        {
                            // The rest of cases - move one pawn, one cell forward and 
                            //  if the opponent is placed diagonally then capture himv
                            Pictures[8 - (cell.Name[8] - 48) - 1, cell.Name[9] - 65].BackColor = Color.LightGreen;
                            cell.BorderStyle
                                = Pictures[8 - (cell.Name[8] - 48) - 1, cell.Name[9] - 65].BorderStyle
                                    = BorderStyle.Fixed3D;
                        }

                        if ("BW".Contains(Pictures[8 - (cell.Name[8] - 48) - 1, cell.Name[9] - 65].Tag.ToString()[0]))
                        {
                            bool x = false;
                            if (cell.Name[9] > 'A' && Pictures[8 - (cell.Name[8] - 48) - 1, -1 + cell.Name[9] - 65].Tag.Equals("B")) x = true;
                            if (cell.Name[9] < 'H' && Pictures[8 - (cell.Name[8] - 48) - 1, 1 + cell.Name[9] - 65].Tag.Equals("B")) x = true;

                            if (!x)
                            {
                                if (cell.Name[9] > 'A' && "EW".Contains(Pictures[8 - (cell.Name[8] - 48) - 1, -1 + cell.Name[9] - 65].Tag.ToString()[0]) ||
                                   cell.Name[9] < 'H' && "EW".Contains(Pictures[8 - (cell.Name[8] - 48) - 1, 1 + cell.Name[9] - 65].Tag.ToString()[0]))
                                {
                                    AllowMove = true;
                                    return;
                                }
                            }                          
                        }
                    }
                }
                //Move the pawn to clicked light green cell
                if (((PictureBox)sender).BackColor == Color.LightGreen && !AllowMove)
                {
                    CleanBoard();

                    var cell = (PictureBox)sender;
                    if (cell.Name[9].Equals(PictureToBeMoved.Name[9])) ReadyToCapture = false;
                    Pictures[8 - (cell.Name[8] - 48), cell.Name[9] - 65].BackgroundImage = PictureToBeMoved.BackgroundImage;
                    PictureToBeMoved.BackgroundImage = null;
                    Pictures[8 - (cell.Name[8] - 48), cell.Name[9] - 65].Tag = "W";
                    PictureToBeMoved.Tag = "E";

                    movesContent.Text += $"{Move++}. {PlayerTurn}: {PictureToBeMoved.Name.Substring(8, 2)} -> {cell.Name.Substring(8, 2)}\n";

                    if (!FirstMove && !SecondMove) AllowMove = true;
                    if (ReadyToCapture)
                    {
                        ReadyToCapture = false;
                        scoreUser_lbl.Text = (Convert.ToInt32(scoreUser_lbl.Text) + 1).ToString();
                    }

                    //Check if game is over
                    if (cell.Name[8] == '8' || scoreUser_lbl.Text.Equals("8"))
                    {
                        MessageBox.Show("You won!");
                    }

                    if (AllowMove)
                    {
                        PlayerTurn = "Computer";
                        ComputerMove_EasyLevel();
                        PlayerTurn = "User";
                    }
                }
            }
        }

        public void CleanBoard()
        {
            for (var i = 0; i < 8; i++)
            {
                for (var j = 0; j < 8; j++)
                {
                    Pictures[i, j].BackColor = Color.Transparent;
                    Pictures[i, j].BorderStyle = BorderStyle.None;
                }
            }
        }

        public void ComputerMove_EasyLevel()
        {
            Random rand = new Random();
            if (ComputerFirstMove)
            {
                ComputerFirstMove = false;

                int firstPawn = rand.Next(8);
                int secondPawn = rand.Next(8);
                while (secondPawn == firstPawn) secondPawn = rand.Next(8);

                Pictures[3, firstPawn].BackgroundImage = Pictures[1, firstPawn].BackgroundImage;
                Pictures[3, firstPawn].Tag = Pictures[1, firstPawn].Tag;
                Pictures[1, firstPawn].BackgroundImage = null;
                Pictures[1, firstPawn].Tag = "E";

                Pictures[2, secondPawn].BackgroundImage = Pictures[1, secondPawn].BackgroundImage;
                Pictures[2, secondPawn].Tag = Pictures[1, secondPawn].Tag;
                Pictures[1, secondPawn].BackgroundImage = null;
                Pictures[1, secondPawn].Tag = "E";

                movesContent.Text += $"{Move++}. {PlayerTurn}: {Pictures[1, firstPawn].Name.Substring(8, 2)} -> {Pictures[3, firstPawn].Name.Substring(8, 2)}\n";
                movesContent.Text += $"{Move++}. {PlayerTurn}: {Pictures[1, secondPawn].Name.Substring(8, 2)} -> {Pictures[2, secondPawn].Name.Substring(8, 2)}\n";
            }
            else
            {
                ChooseAgain:
                bool found = false;
                int j = -1, pawn = -1;
                while (!found)
                {
                    pawn = rand.Next(8);
                    for (j = 0; j < 8; j++)
                        if (Pictures[pawn, j].Tag.Equals("B"))
                        {
                            found = true;
                            break;
                        }
                }
                //Check if game is over
                if (pawn == 7)
                {
                    MessageBox.Show("Computer won!");
                }
                //Capture user pawns
                if(j>0 && Pictures[pawn + 1, j-1].Tag.Equals("W"))
                {
                    //Move pawn
                    Pictures[pawn + 1, j - 1].BackgroundImage = Pictures[pawn, j].BackgroundImage;
                    Pictures[pawn + 1, j - 1].Tag = Pictures[pawn, j].Tag;
                    Pictures[pawn, j].BackgroundImage = null;
                    Pictures[pawn, j].Tag = "E";

                    scoreComputer_lbl.Text = (Convert.ToInt32(scoreComputer_lbl.Text) + 1).ToString();
                    goto End;
                }

                if (j < 7 && Pictures[pawn + 1, j + 1].Tag.Equals("W"))
                {
                    //Move pawn
                    Pictures[pawn + 1, j + 1].BackgroundImage = Pictures[pawn, j].BackgroundImage;
                    Pictures[pawn + 1, j + 1].Tag = Pictures[pawn, j].Tag;
                    Pictures[pawn, j].BackgroundImage = null;
                    Pictures[pawn, j].Tag = "E";

                    scoreComputer_lbl.Text = (Convert.ToInt32(scoreComputer_lbl.Text) + 1).ToString();
                    goto End;
                }

                if (Pictures[pawn + 1, j].Tag.Equals("W")) goto ChooseAgain;
                //Move pawn
                Pictures[pawn + 1, j].BackgroundImage = Pictures[pawn, j].BackgroundImage;
                Pictures[pawn + 1, j].Tag = Pictures[pawn, j].Tag;
                Pictures[pawn, j].BackgroundImage = null;
                Pictures[pawn, j].Tag = "E";

                End:
                movesContent.Text += $"{Move++}. {PlayerTurn}: {Pictures[pawn, j].Name.Substring(8, 2)} -> {Pictures[pawn + 1, j].Name.Substring(8, 2)}\n";
                if(scoreComputer_lbl.Text == "8")
                {
                    MessageBox.Show("Computer won!");
                }
            }
        }

        public void ComputerMove_HardLevel()
        {

        }
    }
}
