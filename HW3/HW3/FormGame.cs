using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3
{
    public partial class FormGame : Form
    {
        private Game game;
        private int player;

        public FormGame(Game game, string playerFirst)
        {
            InitializeComponent();
            this.game = game;
            labelTurn.Text = playerFirst;
            textBox.Text = game.getGameFild();
            if (playerFirst == "Нолики") player = 0;
            else player = 1;
        }

        private void buttonTurn_Click(object sender, EventArgs e)
        {
            if (!game.check(player))
            {
                FormStep fs = new FormStep(game.size);
                fs.ShowDialog();
                if (fs.DialogResult == DialogResult.OK)
                {
                    game.add(fs.column, fs.row, player);
                    player = game.changePlayer(player);
                    labelTurn.Text = game.players[player];
                }
                textBox.Text = game.getGameFild();
            }
            else
            {
                labelTurn.Text = "Игра окончена!";
            }
        }
    }
}
