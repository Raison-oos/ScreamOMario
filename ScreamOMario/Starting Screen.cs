using System;
using System.Windows.Forms;
using System.Media;
using System.Drawing;
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

        //default settings
        public bool isPushToTalk = false;
        public int inputDevice = 0;
        public Starting_Screen(int deviceNumber = 0, bool isPushToTalk = false)
        {
            InitializeComponent();
            this.isPushToTalk = isPushToTalk;
            this.inputDevice = deviceNumber;
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Starting_Screen_Load(object sender, EventArgs e)
        {
            //Music
            player.Play();

            //Player
            Player = Image.FromFile(@".\Mario\Mario_01.png");
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScreamOMario screamOMario = new ScreamOMario(inputDevice, isPushToTalk);
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
    }
}
