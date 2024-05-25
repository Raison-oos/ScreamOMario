using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ScreamOMario
{
    public partial class GameOver : Form
    {
        int deviceNumber;
        bool isPushToTalk;
        public GameOver(int score, bool isPushToTalk,int deviceNumber)
        {
            InitializeComponent();
            lblScore.Text = score.ToString();
            this.deviceNumber = deviceNumber;
            this.isPushToTalk = isPushToTalk;
        }
        SoundPlayer player = new SoundPlayer("GameOver.wav");

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            this.Close();
            player.Stop();
            //ScreamOMario Form1 = new ScreamOMario(deviceNumber, isPushToTalk);
            //Form1.Show();
            Starting_Screen starting_Screen = new Starting_Screen(deviceNumber,isPushToTalk);
            starting_Screen.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            player.Play();
        }

    }
}
