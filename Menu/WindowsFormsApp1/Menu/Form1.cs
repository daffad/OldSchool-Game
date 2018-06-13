using System;
using System.Windows.Forms;
using Snake;
using Labirint;


namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shake New = new Shake();
            New.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.Tags N = new WindowsFormsApp1.Tags();
            N.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_mainmenu N = new Form_mainmenu();
            N.Show();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
