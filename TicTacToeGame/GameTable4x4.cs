using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class GameTable4x4 : Form
    {
        Logic logic = new Logic();
        int turn_count = 0;

        public GameTable4x4()
        {
            InitializeComponent();
        }

        private void GameTable4x4_Load(object sender, EventArgs e)
        {
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    c.Click += new System.EventHandler(Btn_click);
                }
            }
        }

        private void InitialBoardArray()
        {
            logic.boardArray[0, 0] = button1.Text;
            logic.boardArray[0, 1] = button2.Text;
            logic.boardArray[0, 2] = button3.Text;
            logic.boardArray[0, 3] = button4.Text;
            logic.boardArray[1, 0] = button5.Text;
            logic.boardArray[1, 1] = button6.Text;
            logic.boardArray[1, 2] = button7.Text;
            logic.boardArray[1, 3] = button8.Text;
            logic.boardArray[2, 0] = button9.Text;
            logic.boardArray[2, 1] = button10.Text;
            logic.boardArray[2, 2] = button11.Text;
            logic.boardArray[2, 3] = button12.Text;
            logic.boardArray[3, 0] = button13.Text;
            logic.boardArray[3, 1] = button14.Text;
            logic.boardArray[3, 2] = button15.Text;
            logic.boardArray[3, 3] = button16.Text;
            logic.boardSize = 4;
        }

        int XorO = 0;

        public void Btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text.Equals(""))
            {
                if (XorO % 2 == 0)
                {
                    btn.Text = "X";

                    btn.ForeColor = Color.Blue;
                    playNowLabel.Text = "O turn now";
                }
                else
                {
                    btn.Text = "O";

                    btn.ForeColor = Color.Red;
                    playNowLabel.Text = "X turn now";
                }
                turn_count++;
                InitialBoardArray();
                string row = logic.CheckRow();
                string column = logic.CheckColumn();
                string cross1 = logic.CheckCross1();
                string cross2 = logic.CheckCross2();
                string cross3 = logic.CheckCross3();
                string cross4 = logic.CheckCross4();
                string cross5 = logic.CheckCross5();
                string cross6 = logic.CheckCross6();

                XorO++;

                if (row != "No winner")
                {
                    playNowLabel.Text = row;
                }
                else if (turn_count == 16 && row == "No winner" && column == "No winner"
                    && cross1 == "No winner" && cross2 == "No winner" && cross3 == "No winner"
                    && cross4 == "No winner" && cross5 == "No winner" && cross6 == "No winner")
                {
                    playNowLabel.Text = logic.win;
                }
                else if (column != "No winner")
                {
                    playNowLabel.Text = column;
                }
                else if (cross1 != "No winner")
                {
                    playNowLabel.Text = cross1;
                }
                else if (cross2 != "No winner")
                {
                    playNowLabel.Text = cross2;
                }
                else if (cross3 != "No winner")
                {
                    playNowLabel.Text = cross3;
                }
                else if (cross4 != "No winner")
                {
                    playNowLabel.Text = cross4;
                }
                else if (cross5 != "No winner")
                {
                    playNowLabel.Text = cross5;
                }
                else if (cross6 != "No winner")
                {
                    playNowLabel.Text = cross6;
                }
            }
        }
                 

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Begin f1 = new Begin();
            f1.ShowDialog();
            this.Close();
        }


        private void newPartieButton_Click(object sender, EventArgs e)
        {
            if (oRadioButton.Checked)
            {
                XorO = 1;
            }
            else
            {
                XorO = 0;
            }
            playNowLabel.Text = "Lets Play!";

            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    c.Text = "";
                    c.BackColor = Color.White;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       // private void GameTable4x4_Load(object sender, EventArgs e)
       // {
 
       //}
    }
}
