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
    public partial class GameTable5x5 : Form
    {
        Logic logic = new Logic();
        int turn_count = 0;

        public GameTable5x5()
        {
            InitializeComponent();
        }

        private void GameTable5x5_Load(object sender, EventArgs e)
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
            logic.boardArray[0, 4] = button5.Text;
            logic.boardArray[1, 0] = button6.Text;
            logic.boardArray[1, 1] = button7.Text;
            logic.boardArray[1, 2] = button8.Text;
            logic.boardArray[1, 3] = button9.Text;
            logic.boardArray[1, 4] = button10.Text;
            logic.boardArray[2, 0] = button11.Text;
            logic.boardArray[2, 1] = button12.Text;
            logic.boardArray[2, 2] = button13.Text;
            logic.boardArray[2, 3] = button14.Text;
            logic.boardArray[2, 4] = button15.Text;
            logic.boardArray[3, 0] = button16.Text;
            logic.boardArray[3, 1] = button17.Text;
            logic.boardArray[3, 2] = button18.Text;
            logic.boardArray[3, 3] = button19.Text;
            logic.boardArray[3, 4] = button20.Text;
            logic.boardArray[4, 0] = button21.Text;
            logic.boardArray[4, 1] = button22.Text;
            logic.boardArray[4, 2] = button23.Text;
            logic.boardArray[4, 3] = button24.Text;
            logic.boardArray[4, 4] = button25.Text;
            logic.boardSize = 5;
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
                string cross6 = logic.CheckCross6();
                string cross7 = logic.CheckCross7();
                string cross8 = logic.CheckCross8();
                string cross9 = logic.CheckCross9();
                string cross10 = logic.CheckCross10();
                string cross11 = logic.CheckCross11();            

                XorO++;

                if (row != "No winner")
                {
                    playNowLabel.Text = row;
                }
                else if (turn_count == 25 && row == "No winner" && column == "No winner"
                    && cross1 == "" && cross2 == "No winner" && cross3 == "No winner"
                    && cross4 == "No winner" && cross6 == "No winner" && cross7 == "No winner"
                    && cross8 == "No winner" && cross9 == "No winner" && cross10 == "No winner"
                    && cross11 == "No winner")

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
                else if (cross6 != "No winner")
                {
                    playNowLabel.Text = cross6;
                }
                else if (cross7 != "No winner")
                {
                    playNowLabel.Text = cross7;
                }
                else if (cross8 != "No winner")
                {
                    playNowLabel.Text = cross8;
                }
                else if (cross9 != "No winner")
                {
                    playNowLabel.Text = cross9;
                }
                else if (cross10 != "No winner")
                {
                    playNowLabel.Text = cross10;
                }
                else if (cross11 != "No winner")
                {
                    playNowLabel.Text = cross11;
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

     
    }
}
