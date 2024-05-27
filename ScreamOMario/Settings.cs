using System;
using System.Windows.Forms;
using NAudio.Wave;

namespace ScreamOMario
{
    public partial class Settings : Form
    {
        //input devices
        int waveInDevices;
        int inputDevice = 0;
        bool isPushToTalk = false;

        Starting_Screen setting = null;
        public Settings(Starting_Screen setting)
        {
            InitializeComponent();
            this.setting = setting;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            //Input Device
            waveInDevices = WaveIn.DeviceCount;
            inputDevices.Items.Add("Default");
            for(int waveInDevice = 0; waveInDevice < waveInDevices; waveInDevice++)
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(waveInDevice);
                inputDevices.Items.Add(deviceInfo.ProductName);
            }
            OldSettings();
        }

        private void inputDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            //default
            if(inputDevices.SelectedIndex == 1)
            {
                inputDevice = 0;
            }
            for(int i = 2;i < inputDevices.Items.Count;i++) { 
                if(inputDevices.SelectedIndex == i)
                {
                    inputDevice = i;
                }
            }
        }
        private void Default()
        {
            //Input Device
            inputDevices.SelectedIndex = 0;
            this.setting.inputDevice = inputDevice;

            //Input Mode
            voiceActivity.Select(); //default
            this.setting.isPushToTalk = isPushToTalk;
        }
        private void OldSettings()
        {
            //input device
            inputDevice = this.setting.inputDevice;
            inputDevices.SelectedIndex = inputDevice;

            //input mode
            isPushToTalk = this.setting.isPushToTalk;
            if (isPushToTalk)
            {
                pushToTalk.Select();
            }
            else
            {
                voiceActivity.Select();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OldSettings();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you wish to Apply changes?","Settings!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.setting.inputDevice = inputDevice;
                this.setting.isPushToTalk = isPushToTalk;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you wish to Reset Settings to Default?","Settings!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Default();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            setting.Show();
        }

        private void voiceActivity_CheckedChanged(object sender, EventArgs e)
        {
            pushToTalkKey.Enabled = false;
            isPushToTalk = false;
        }

        private void pushToTalk_CheckedChanged(object sender, EventArgs e)
        {
            pushToTalkKey.Enabled = true;
            isPushToTalk = true;
        }
    }
}
