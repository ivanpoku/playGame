using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace playGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playCountdown_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Refresh();
            Thread.Sleep(1000);
            playCountdown.Text = "2";
            SoundPlayer player = new SoundPlayer(Properties.Resources.beepSound);

            player.Play();


            Refresh();
            Thread.Sleep(1000);
            playCountdown.Text = "1";
            player.Play();

            Refresh();
            Thread.Sleep(1000);
            playCountdown.Text = "GO";
            background.Visible = true;
            playCountdown.BackColor = Color.LimeGreen;
            playGameLabel.BackColor = Color.LimeGreen;
            SoundPlayer player1 = new SoundPlayer(Properties.Resources.explosionSound);
            player1.Play();



        }
    }
}
