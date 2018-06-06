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
    public partial class FormStep : Form
    {
        public int column { get; set; }

        public int row { get; set; }

        private int size;

        public FormStep(int size)
        {
            this.size = size;
            InitializeComponent();
        }

        private void buttonStep_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxColumn.Text != null && textBoxRow.Text != null)
                {
                    int c = Convert.ToInt32(textBoxColumn.Text);
                    int r = Convert.ToInt32(textBoxRow.Text);
                    if (c < 0 || c > size - 1 || r < 0 || r > size - 1)
                    {
                        MessageBox.Show("Введенные вами данные не верны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        column = c;
                        row = r;
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
