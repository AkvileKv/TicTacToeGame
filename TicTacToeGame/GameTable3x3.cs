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
    public partial class GameTable3x3 : Form
    {
        Logic logic = new Logic();
        int turn_count = 0;

        public GameTable3x3()
        {
            InitializeComponent();
        }

        private void GameTable_Load(object sender, EventArgs e)
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
            logic.boardArray[1, 0] = button4.Text;
            logic.boardArray[1, 1] = button5.Text;
            logic.boardArray[1, 2] = button6.Text;
            logic.boardArray[2, 0] = button7.Text;
            logic.boardArray[2, 1] = button8.Text;
            logic.boardArray[2, 2] = button9.Text;
            logic.boardSize = 3;
        }

        int XorO = 0;

        //create  button action
        public void Btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text.Equals("")) //jei tuscias laukas
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

                XorO++;

                if (row != "No winner")
                {         
                    playNowLabel.Text = row;
                }
                else if (turn_count == 9 && row == "No winner" && column == "No winner"
                    && cross1 == "No winner" && cross2 == "No winner")
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
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void newPartieButton_Click(object sender, EventArgs e) // OK
        {
            if (oRadioButton.Checked)
            {
                XorO = 1;
            } else
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

        private void backButton_Click(object sender, EventArgs e) //OK
        {
            this.Hide();
            Begin f1 = new Begin();
            f1.ShowDialog();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
