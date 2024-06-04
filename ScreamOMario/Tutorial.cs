using System;
using System.Windows.Forms;
using System.Drawing;
using NAudio.Wave;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using ScreamOMario.Properties;

namespace ScreamOMario
{
    public partial class Tutorial : Form
    {
        //misc
        private delegate void SafeCallDelegate(int max);

        //voice
        WaveInEvent waveIn = new WaveInEvent();//Naudio downloaded via Nugget

        //Character
        Image character;
        List<string> characterMovement = new List<string>();
        int steps = 0;

        //movement
        bool moveLeft, moveRight, jump, pushToTalk;
        int moveX = 5;//10
        int moveY;
        int positionX = 71;
        int positionY = 345; 
        char lastPosition = 'l';//l(default) or r (left or right)

        //platform
        Platform[] platforms = new Platform[3]; //platformCount
        Random rand = new Random();

        //coin
        Platform coin = new Platform();

        //music
        SoundPlayer player = new SoundPlayer("GameMusic.wav");

        //settings
        bool isPushToTalk;
        int deviceNumber;

        //Character
        int characterIndex;
        public Tutorial(int deviceNumber, bool isPushToTalk, int characterIndex)
        {
            InitializeComponent();
            //setings
            this.deviceNumber = deviceNumber;
            this.isPushToTalk = isPushToTalk;
            this.characterIndex = characterIndex;
        }
        private void OnDataAvailable(object sender, WaveInEventArgs args)
        {
            // this example will display the peak audio value of the buffer
            float max = 0;

            // interpret as 16 bit audio
            for (int index = 0; index < args.BytesRecorded; index += 2)
            {
                short sample = (short)((args.Buffer[index + 1] << 8) |
                                        args.Buffer[index + 0]);
                var sample32 = sample / 32768f; // to floating point
                if (sample32 < 0) sample32 = -sample32; // absolute value 
                if (sample32 > max) max = sample32; // is this the max value?
            }
            if (isPushToTalk)
            {
                if (pushToTalk)
                {
                    SetWave((int)(250* max));//100
                    moveY = GetJumpHeight();
                }
                else
                {
                    SetWave((int)(0 * max));
                    moveY = 0;
                }
            }
            else
            {
                SetWave((int)(250* max));//100
                moveY = GetJumpHeight();
            }
            if(moveY != 0)
            {
                jump = true;
            }
            else
            {
                jump = false;
            }
        }
        //Cross-thread safe call
        private void SetWave(int max)
        {
            if (volume.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetWave);
                this.Invoke(d, new object[] { max });
            }
            else
            {
                if(max > 100)
                {
                    max = 100;
                }
                this.volume.Value = max;
            }
        }

        //starts the movement when key is pressed 
        private void ScreamOMario_KeyDown(object sender, KeyEventArgs e)
        {
            //position x
            if(e.KeyCode == Keys.Left)
            {
                moveLeft = true;
                lastPosition = 'l';
            }else if(e.KeyCode == Keys.Right)
            {
                moveRight = true;
                lastPosition = 'r';
            }
            else if (isPushToTalk)
            {
                if(e.KeyCode == Keys.Space)
                {
                    pushToTalk = true;
                }
            }
        }

        private void ScreamOMario_KeyUp(object sender, KeyEventArgs e)
        {
            //position x
            if(e.KeyCode == Keys.Left)
            {
                moveLeft = false;
                lastPosition = 'l';
                //jump left
                if (jump)
                {
                    character = Image.FromFile(characterMovement[3]);
                }
                //left
                else
                {
                    character = Image.FromFile(characterMovement[1]);
                }
            }else if(e.KeyCode == Keys.Right)
            {
                moveRight= false;
                lastPosition = 'r';
                //jump right
                if (jump)
                {
                    character = Image.FromFile(characterMovement[2]);
                }
                //right
                else
                {
                    character = Image.FromFile(characterMovement[0]);
                }
            }
            else if (isPushToTalk)
            {
                if(e.KeyCode == Keys.Space)
                {
                    pushToTalk = false;
                    
                }
            }
        }
        private void MoveEvent(object sender, EventArgs e)
        {
            //stop if both move left and right
            if (moveLeft && moveRight)
            {
                if (!jump)
                {
                    positionX += 0;
                    //left
                    if(lastPosition == 'l')
                    {
                        character = Image.FromFile(characterMovement[0]);
                    }
                    //right
                    else if(lastPosition == 'r')
                    {
                        character = Image.FromFile(characterMovement[1]);
                    }
                }
            }
            else if (moveLeft)
            {
                if (positionX <= 0 - character.Width) positionX = this.Width - character.Width;
                else
                {
                    positionX -= moveX;
                    //run left Image
                    if (!jump)
                    {
                        AnimateMario(8, 11);
                    }
                    //left jump
                    else if (jump)
                    {
                        character = Image.FromFile(characterMovement[3]);
                    }
                   
                }
            }
            else if (moveRight)
            {
                if (positionX >= this.Width - character.Width) positionX = 0;
                else
                {
                    positionX += moveX;
                    //run right Image
                    if (!jump)
                    {
                        AnimateMario(4, 7);
                    }
                    //right jump
                    else if (jump)
                    {
                        character = Image.FromFile(characterMovement[2]);
                    }
                }
            }

            this.Invalidate();
        }

        private void GravityEvent(object sender, EventArgs e)
        {
            //gravity
            if (!jump && positionY < 345)
            {
                positionY += 7;
            }

            this.Invalidate();
        }

        private void JumpEvent(object sender, EventArgs e)
        {
            if (jump && positionY >= this.ClientSize.Height / 2 - character.Height * 2)
            {
                //positionY -= 10;
                positionY -= moveY;
                //last position
                if(lastPosition == 'r')
                {
                    character = Image.FromFile(characterMovement[2]);
                }
                else if(lastPosition == 'l')
                {
                    character = Image.FromFile(characterMovement[3]);
                }
            }
            else if(!jump)
            {
                if(lastPosition == 'r')
                {
                    character = Image.FromFile(characterMovement[0]);
                }
                else if(lastPosition == 'l')
                {
                    character = Image.FromFile(characterMovement[1]);
                }

            }
            this.Invalidate();
            
        }
        private void ScreamOMario_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            //paltform
            foreach (Platform platform in platforms)
            {
                graphics.DrawImage(platform.platformImage, platform.positionX, platform.positionY, platform.platformImage.Width, platform.platformImage.Height);
            }
            //Mario
            graphics.DrawImage(character, positionX, positionY, character.Width, character.Height);
            
            //Coins
            graphics.DrawImage(coin.platformImage,coin.positionX,coin.positionY, coin.platformImage.Width, coin.platformImage.Height );

        }

        private void CollisionEvent(object sender, EventArgs e)
        {
            foreach(Platform platform in platforms)
            {
                if (!jump)
                {
                    if (positionY + character.Height > platform.positionY && positionY + character.Height < platform.positionY + platform.platformImage.Height)
                    {
                        if (positionX > platform.positionX - character.Width && positionX < platform.positionX + platform.platformImage.Width )
                        {
                            positionY = platform.positionY -character.Height;
                        }
                    }
                }
            }
            if (positionY + character.Height > coin.positionY && positionY + character.Height < coin.positionY + coin.platformImage.Height)
            {
                if (positionX > coin.positionX - character.Width && positionX < coin.positionX + coin.platformImage.Width )
                {
                    this.Close();
                    MessageBox.Show("You are ready to play!", "Tutorial");
                }
            }
        }

        private int GetJumpHeight()
        {
            if(volume.Value > 75 && volume.Value <= 100) { return 6; }//7
            else if(volume.Value > 50 && volume.Value <= 75 ) { return 4; }//5
            return 0;
        }

        private void MakePlatform()
        {

            for (int i = 0; i < platforms.Length; i++)
            {
                platforms[i] = new Platform();
            }
            platforms[0].positionX = 400;
            platforms[0].positionY = 300;

            platforms[1].positionX = 500;
            platforms[1].positionY = 250;
            
            platforms[2].positionX = 600;
            platforms[2].positionY = 200;


        }
        //setup
        private void ScreamOMario_Load(object sender, EventArgs e)
        {
            //character
            Character();
            character = Image.FromFile(characterMovement[0]);

            //platform
            MakePlatform();

            //coin
            MakeCoin();

            //music
            player.Play();


            //naudio
            waveIn.DeviceNumber = deviceNumber;
            waveIn.DataAvailable += OnDataAvailable;
            waveIn.StartRecording();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AnimateMario(int start, int end)
        {
            steps++;
            if(steps > end || steps < start)
            {
                steps = start;
            }
            character = Image.FromFile(characterMovement[steps]);
        }
        private void Character()
        {
            switch (characterIndex)
            {
                //Mario
                case 0: characterMovement = Directory.GetFiles("Mario", "*.png").ToList(); break;
                case 1: characterMovement = Directory.GetFiles("Luigi", "*.png").ToList(); break;
                case 2: characterMovement = Directory.GetFiles("Yoshi", "*.png").ToList(); break;
                case 3: characterMovement = Directory.GetFiles("Papa B", "*.png").ToList(); break;
            }
        }
        private void MakeCoin()
        {
            coin.platformImage = Image.FromFile("coin.png");
            coin.positionX = 600+coin.platformImage.Width;
            coin.positionY = 200-coin.platformImage.Height;
        }
    }
}
