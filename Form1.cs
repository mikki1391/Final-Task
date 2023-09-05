using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Gamer gamer;
        private void BLogin_Click(object sender, EventArgs e)
        {
            gamer = new Gamer(TBLogin.Text);
        }

        private void BGame1_Click(object sender, EventArgs e)
        {
            gamer.AddGame(new Game());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gamer.Play();
        }
    }
}
