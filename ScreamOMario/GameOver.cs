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
        //save details
        int deviceNumber;
        bool isPushToTalk;
        int characterIndex;
        
        //Music
        SoundPlayer player = new SoundPlayer("GameOver.wav");

        public GameOver(int score, bool isPushToTalk,int deviceNumber, int characterIndex)
        {
            InitializeComponent();
            lblScore.Text = score.ToString();
            this.deviceNumber = deviceNumber;
            this.isPushToTalk = isPushToTalk;
            this.characterIndex = characterIndex;
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            this.Close();
            player.Stop();
            Starting_Screen starting_Screen = new Starting_Screen(deviceNumber,isPushToTalk,characterIndex);
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
