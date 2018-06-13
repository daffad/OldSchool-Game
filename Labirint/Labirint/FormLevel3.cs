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
    public partial class FormLevel3 : Form
    {
        public FormLevel3()
        {
            InitializeComponent();
        }
        private void start_game()
        {
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);
            label79.Visible = true;
            label_door3.Visible = true;
            wall31.Visible = true;
            wall32.Visible = false;
            wall33.Visible = true;
            wall34.Visible = false;
            wall35.Visible = false;

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

        private void FormLevel3_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void label_door3_MouseEnter(object sender, EventArgs e)
        {
            if (label_key3.Visible)
            {
                DialogResult dr = MessageBox.Show("Вы проиграли. Чтобы открыть дверь, сначала возьмите ключ. Повторить игру?", "Сообщение",
              MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                    start_game();
                else
                    DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
            else
                label_door3.Visible = false;
        }
        private void label_key3_MouseEnter(object sender, EventArgs e)
        {
            label_key3.Visible = false;
        }







        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void wall32_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }
        private void wall33_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }
        private void wall31_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }
        private void wall34_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }
        private void wall35_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            wall31.Visible = !wall31.Visible;

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            wall32.Visible = !wall32.Visible;

        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            wall33.Visible = !wall33.Visible;

        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            wall34.Visible = !wall34.Visible;

        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            wall35.Visible = !wall35.Visible;

        }
        private void label_door3_Enter(object sender, EventArgs e)
        {

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }
    }
}
