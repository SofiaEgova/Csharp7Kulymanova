using HW1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2
{
    public partial class FormMain : Form
    {
        private Game game;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxFirstStep.Items.AddRange(new object[] { "Нолики", "Единички" });
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBoxSize.Text != null)
            {
                try
                {
                    int size = Convert.ToInt32(textBoxSize.Text);
                    if (comboBoxFirstStep.SelectedItem != null)
                    {
                        game = new Game(size);
                        new FormGame(game, comboBoxFirstStep.SelectedItem.ToString()).ShowDialog();
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
