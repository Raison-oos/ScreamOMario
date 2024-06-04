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
    public partial class ScreamOMario : Form
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
        int positionX = 408;
        int positionY = 300; 
        char lastPosition = 'l';//l(default) or r (left or right)

        //platform
        Platform[] platforms = new Platform[11]; //platformCount
        Random rand = new Random();
        int platformCount = 10;
        int platformGap;

        //coin
        Platform coin = new Platform();
       

        //score
        int score = 0;

        //music
        SoundPlayer player = new SoundPlayer("GameMusic.wav");

        //settings
        bool isPushToTalk;
        int deviceNumber;

        //Character
        int characterIndex;
        public ScreamOMario(int deviceNumber, bool isPushToTalk, int characterIndex)
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
            if (!jump)
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

        private void PlatformEvent(object sender, EventArgs e)
        {
            //coin
            coin.positionY += 5;

            foreach(Platform platform in platforms)
            {
                if (positionY<= this.ClientSize.Height / 2 - character.Height)
                {
                    //platform.positionY += moveY;
                    platform.positionY += 7;
                }
                if (platform.positionY > 389 + platform.platformImage.Height)
                {
                    //x.Location = new Point(rand.Next(0, this.ClientSize.Width - x.Width), character.Height - 3 * platformGap);
                    platform.positionX = rand.Next(0, this.ClientSize.Width - platform.platformImage.Width);
                    platform.positionY = character.Height - 1 * platformGap;

                    //score
                    score += 10;
                    lblScore.Text = "";
                    lblScore.Text = score.ToString();
                }

            }
        }
        private void ScreamOMario_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            //paltform
            foreach(Platform platform in platforms)
            {
                graphics.DrawImage(platform.platformImage,platform.positionX,platform.positionY, platform.platformImage.Width, platform.platformImage.Height );
            }
            //Mario
            graphics.DrawImage(character, positionX, positionY, character.Width, character.Height);
            
            //Coins
            graphics.DrawImage(coin.platformImage,coin.positionX,coin.positionY, coin.platformImage.Width, coin.platformImage.Height );

            graphics.DrawImage(platforms[10].platformImage, platforms[10].positionX, platforms[10].positionY, platforms[10].platformImage.Width, platforms[10].platformImage.Height);
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
                    coin.positionY = this.Height + coin.platformImage.Height;
                    score += 500;
                    lblScore.Text = "";
                    lblScore.Text = score.ToString();
                }
            }
        }

        private int GetJumpHeight()
        {
            if(volume.Value > 75 && volume.Value <= 100) { return 6; }//7
            else if(volume.Value > 50 && volume.Value <= 75 ) { return 4; }//5
            return 0;
        }

        private void GameOverEvenet(object sender, EventArgs e)
        {
            GameOver();
        }

        private void MakePlatform()
        {
            for(int i = 0; i < platformCount; i++)
            {
                platforms[i] = new Platform();
                platforms[i].positionX = rand.Next(0, this.ClientSize.Width - platforms[i].platformImage.Width);
                platforms[i].positionY = rand.Next(0, positionY - character.Height);
            }
            platforms[10] = new Platform();
            platforms[10].positionX = 408;
            platforms[10].positionY = 300 + character.Height;
            
        }
        private void GameOver()
        {
            if(positionY > 369 + character.Height)
            {
                this.Close();
                player.Stop();
                GameOver gameOver = new GameOver(score, isPushToTalk, deviceNumber, characterIndex);
                gameOver.Show();
            }
        }
        //setup
        private void ScreamOMario_Load(object sender, EventArgs e)
        {
            //character
            Character();
            character = Image.FromFile(characterMovement[0]);

            //platform
            MakePlatform();
            platformGap = this.ClientSize.Height/platformCount;

            //coin
            MakeCoin();

            //score
            score = 0;
            lblScore.Text = score.ToString();

            //music
            player.Play();


            //naudio
            waveIn.DeviceNumber = deviceNumber;
            waveIn.DataAvailable += OnDataAvailable;
            waveIn.StartRecording();
        }

        private void CoinEvent(object sender, EventArgs e)
        {
            if (coin.positionY > 389 + coin.platformImage.Height)
            {
                coin.positionX = rand.Next(0, this.ClientSize.Width - coin.platformImage.Width);
                coin.positionY = 0;
            }

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
            coin.positionX = rand.Next(0, this.ClientSize.Width - coin.platformImage.Width);
            coin.positionY = 0;
        }
    }
}
