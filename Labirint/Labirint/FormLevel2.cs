using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint
{
    public partial class FormLevel2 : Form
    {
        public FormLevel2()
        {
            InitializeComponent();
        }
        private void start_game()
        {
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);
            label_key.Visible = true;
            label_door.Visible = true;
            label_wall1.Visible = true;

        }

        private void finish_game()
        {
            DialogResult dr = MessageBox.Show("Вы проиграли. Повторить игру?", "Сообщение",
              MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                start_game();
            else
                DialogResult = System.Windows.Forms.DialogResult.Abort;

        }

        private void FormLevel2_Shown(object sender, EventArgs e)
        {
            start_game();

        }

        private void label_door_MouseEnter(object sender, EventArgs e)
        {
            if (label_key.Visible)
            {
                DialogResult dr = MessageBox.Show("Вы проиграли. Чтобы открыть дверь, сначала возьмите ключ. Повторить игру?", "Сообщение",
              MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                    start_game();
                else
                    DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
            else
                label_door.Visible = false;


        }

        private void label_key_MouseEnter(object sender, EventArgs e)
        {
            label_key.Visible = false;
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_wall1.Visible = !label_wall1.Visible;

        }

        private void label_wall1_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }
    }
}
