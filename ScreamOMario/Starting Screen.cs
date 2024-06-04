using System;
using System.Windows.Forms;
using System.Media;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ScreamOMario
{
    public partial class Starting_Screen : Form
    {
        //music
        SoundPlayer player = new SoundPlayer("LobbyMusic.wav");

        //Character
        Image Player;
        int positionX = 57;
        int positionY = 311;//369
        public int characterIndex;

        //default settings
        public bool isPushToTalk = false;
        public int inputDevice = 0;
        public Starting_Screen(int deviceNumber = 0, bool isPushToTalk = false, int characterIndex = 0)
        {
            InitializeComponent();
            this.isPushToTalk = isPushToTalk;
            this.inputDevice = deviceNumber;
            this.characterIndex = characterIndex;
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Starting_Screen_Load(object sender, EventArgs e)
        {
            //Player
            ChangeCharacter();

            //Music
            player.Play();

        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScreamOMario screamOMario = new ScreamOMario(inputDevice, isPushToTalk, characterIndex);
            screamOMario.Show();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawImage(Player, positionX, positionY, Player.Width, Player.Height);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings setting = new Settings(this);
            setting.Show();
        }

        private void btnCharacter_Click(object sender, EventArgs e)
        {
            this.Hide();
            CharacterSelection characterSelection = new CharacterSelection(this);
            characterSelection.Show();
        }
        public void ChangeCharacter()
        {
            switch(characterIndex)
            {
                case 0: Player = Image.FromFile(@".\Character\Character (01).png"); break;
                case 1: Player = Image.FromFile(@".\Character\Character (02).png"); break;
                case 2: Player = Image.FromFile(@".\Character\Character (03).png"); break;
                case 3: Player = Image.FromFile(@".\Character\Character (04).png"); break;
            }
            this.Invalidate();

        }

        private void btnHowTo_Click(object sender, EventArgs e)
        {
            Tutorial tutorial = new Tutorial(inputDevice, isPushToTalk, characterIndex);
            tutorial.Show();
        }
    }
}
