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
    public partial class Form1 : Form
    {
        GameDbContext context;
        private Game game;

        public Form1(GameDbContext _context)
        {
            context = _context;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxPlayer.Items.AddRange(new object[] { "Нолики", "Единички" });
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBoxSize.Text != null)
            {
                try
                {
                    int size = Convert.ToInt32(textBoxSize.Text);
                    if (comboBoxPlayer.SelectedItem != null)
                    {
                        game = new Game(size, context);
                        new FormGame(game, comboBoxPlayer.SelectedItem.ToString()).ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Выберите первого игрока", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
