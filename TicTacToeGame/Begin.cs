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
    public partial class Begin : Form
    {
        public Begin()
        {
            InitializeComponent();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {        
                this.Hide();
                GameTable3x3 f1 = new GameTable3x3();
                f1.ShowDialog();
                this.Close();
        }

        private void startGame4x4Button_Click(object sender, EventArgs e)
        {
                this.Hide();
                GameTable4x4 f1 = new GameTable4x4();
                f1.ShowDialog();
                this.Close();
        }

        private void startGame5x5Button_Click(object sender, EventArgs e)
        {
                this.Hide();
                GameTable5x5 f1 = new GameTable5x5();
                f1.ShowDialog();
                this.Close();
        }
    }
}
