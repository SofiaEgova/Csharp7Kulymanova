using HW1;
using System;
using System.Windows.Forms;

namespace HW2
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
            if (!game.check())
            {
                FormStep fs = new FormStep(game.size);
                fs.ShowDialog();
                if (fs.DialogResult == DialogResult.OK)
                {
                    game.add(fs.column, fs.row, player);
                    player = game.changePlayer(player);
                    labelTurn.Text = game.players[player].ToString();
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
