using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.forms
{
    public partial class gameInit : Form
    {
        public gameInit()
        {
            InitializeComponent();
            FormClosing += exitGame;
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            mainGame mainGame = new mainGame();
            mainGame.Show();
            this.Hide();
        }

        private void exitGame(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
