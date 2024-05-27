using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ScreamOMario
{
    public partial class CharacterSelection : Form
    {
        //Characters
        Image Character;
        List<string> Characters = new List<string>();
        int characterIndex;
        Starting_Screen character = null;
        public CharacterSelection(Starting_Screen character)
        {
            InitializeComponent();
            this.character = character;   
        }

        private void CharacterSelection_Load(object sender, EventArgs e)
        {
            //Characters
            Characters = Directory.GetFiles("Characters", "*.png").ToList(); 

            //Default Character
            characterIndex = this.character.characterIndex;
            Character = Image.FromFile(Characters[characterIndex]);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(characterIndex+1 > Characters.Count-1)
            {
                characterIndex = 0;
            }
            else
            {
                characterIndex+=1;
            }
            Character = Image.FromFile(Characters[characterIndex]);
            CharacterName();
            this.Invalidate();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(characterIndex-1 < 0)
            {
                characterIndex = Characters.Count-1;
            }
            else
            {
                characterIndex-=1;
            }
            Character = Image.FromFile(Characters[characterIndex]);
            CharacterName();
            this.Invalidate();

        }

        private void CharacterSelection_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Character, 80, 1, 600, 372);
        }
        private void CharacterName()
        {
            switch(characterIndex)
            {
                case 0: characterName.Text = "Mario"; break;
                case 1: characterName.Text = "Luigi"; break;
                case 2: characterName.Text = "Yoshi"; break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.character.characterIndex = characterIndex;
            this.character.ChangeCharacter();
            this.Close();
            character.Show();
        }
    }
}
