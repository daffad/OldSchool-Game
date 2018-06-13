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
    public partial class Form_mainmenu : Form
    {
        public Form_mainmenu()
        {
            InitializeComponent();
        }

        private void Form_mainmenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            start_level1();

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void start_level1()
        {
            FormLevel1 level1 = new FormLevel1();
            DialogResult dr = level1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                start_level2();
        }
        private void start_level2()
        {
            FormLevel2 level2 = new FormLevel2();
            DialogResult dr = level2.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                start_level3();

            }
        }

        private void start_level3()
        {
            FormLevel3 level3 = new FormLevel3();
            DialogResult dr = level3.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                start_win();

            }
        }
        
        private void start_win()

        {
            MessageBox.Show("Вы прошли игру! Ура!");
        }

        private void button_tutorial_Click(object sender, EventArgs e)
        {
            start_tutorial();
        }

        private void start_tutorial()
        {
            Tutorial tutorial = new Tutorial();
            DialogResult dr = tutorial.ShowDialog();
        }
    }
}    
