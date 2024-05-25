namespace ScreamOMario
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputDevices = new System.Windows.Forms.ComboBox();
            this.voiceActivity = new System.Windows.Forms.RadioButton();
            this.pushToTalk = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pushToTalkKey = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputDevices
            // 
            this.inputDevices.BackColor = System.Drawing.Color.White;
            this.inputDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputDevices.Font = new System.Drawing.Font("Cooper Black", 11.25F);
            this.inputDevices.ForeColor = System.Drawing.Color.Black;
            this.inputDevices.FormattingEnabled = true;
            this.inputDevices.Location = new System.Drawing.Point(75, 30);
            this.inputDevices.Name = "inputDevices";
            this.inputDevices.Size = new System.Drawing.Size(272, 25);
            this.inputDevices.TabIndex = 0;
            this.inputDevices.SelectedIndexChanged += new System.EventHandler(this.inputDevices_SelectedIndexChanged);
            // 
            // voiceActivity
            // 
            this.voiceActivity.AutoSize = true;
            this.voiceActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(76)))), ((int)(((byte)(12)))));
            this.voiceActivity.Location = new System.Drawing.Point(23, 24);
            this.voiceActivity.Name = "voiceActivity";
            this.voiceActivity.Size = new System.Drawing.Size(134, 21);
            this.voiceActivity.TabIndex = 2;
            this.voiceActivity.TabStop = true;
            this.voiceActivity.Text = "Voice Activity";
            this.voiceActivity.UseVisualStyleBackColor = false;
            this.voiceActivity.CheckedChanged += new System.EventHandler(this.voiceActivity_CheckedChanged);
            // 
            // pushToTalk
            // 
            this.pushToTalk.AutoSize = true;
            this.pushToTalk.Location = new System.Drawing.Point(23, 61);
            this.pushToTalk.Name = "pushToTalk";
            this.pushToTalk.Size = new System.Drawing.Size(123, 21);
            this.pushToTalk.TabIndex = 3;
            this.pushToTalk.TabStop = true;
            this.pushToTalk.Text = "Push to Talk";
            this.pushToTalk.UseVisualStyleBackColor = true;
            this.pushToTalk.CheckedChanged += new System.EventHandler(this.pushToTalk_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(76)))), ((int)(((byte)(12)))));
            this.label2.Font = new System.Drawing.Font("Cooper Black", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(72, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input Device";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(76)))), ((int)(((byte)(12)))));
            this.label3.Font = new System.Drawing.Font("Cooper Black", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(72, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Shortcut:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(76)))), ((int)(((byte)(12)))));
            this.label4.Font = new System.Drawing.Font("Cooper Black", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(181, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Keybind";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(76)))), ((int)(((byte)(12)))));
            this.groupBox1.Controls.Add(this.voiceActivity);
            this.groupBox1.Controls.Add(this.pushToTalk);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(75, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Mode";
            // 
            // pushToTalkKey
            // 
            this.pushToTalkKey.BackColor = System.Drawing.Color.White;
            this.pushToTalkKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pushToTalkKey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pushToTalkKey.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pushToTalkKey.ForeColor = System.Drawing.Color.Black;
            this.pushToTalkKey.Location = new System.Drawing.Point(75, 185);
            this.pushToTalkKey.Name = "pushToTalkKey";
            this.pushToTalkKey.Size = new System.Drawing.Size(100, 23);
            this.pushToTalkKey.TabIndex = 15;
            this.pushToTalkKey.Text = "Space";
            this.pushToTalkKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnApply
            // 
            this.btnApply.AutoSize = true;
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(76)))), ((int)(((byte)(12)))));
            this.btnApply.FlatAppearance.BorderSize = 2;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Cooper Black", 11.25F);
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(191, 249);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 31);
            this.btnApply.TabIndex = 16;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(76)))), ((int)(((byte)(12)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Cooper Black", 11.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(272, 249);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(76)))), ((int)(((byte)(12)))));
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(128, 251);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(57, 29);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(76)))), ((int)(((byte)(12)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.pushToTalkKey);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.inputDevices);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(194, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 303);
            this.panel1.TabIndex = 19;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(76)))), ((int)(((byte)(12)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Cooper Black", 11.25F);
            this.btnExit.Location = new System.Drawing.Point(737, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 29);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::ScreamOMario.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox inputDevices;
        private System.Windows.Forms.RadioButton voiceActivity;
        private System.Windows.Forms.RadioButton pushToTalk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label pushToTalkKey;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
    }
}