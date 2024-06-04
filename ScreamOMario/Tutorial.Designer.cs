using NAudio.Wave;

namespace ScreamOMario
{
    partial class Tutorial
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
            this.components = new System.ComponentModel.Container();
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.volume = new System.Windows.Forms.ProgressBar();
            this.JumpTimer = new System.Windows.Forms.Timer(this.components);
            this.GravityTimer = new System.Windows.Forms.Timer(this.components);
            this.CollisionTimer = new System.Windows.Forms.Timer(this.components);
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.XMove = new System.Windows.Forms.Label();
            this.YMove = new System.Windows.Forms.Label();
            this.coins = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MoveTimer
            // 
            this.MoveTimer.Enabled = true;
            this.MoveTimer.Interval = 5;
            this.MoveTimer.Tick += new System.EventHandler(this.MoveEvent);
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(141, 428);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(490, 10);
            this.volume.TabIndex = 0;
            // 
            // JumpTimer
            // 
            this.JumpTimer.Enabled = true;
            this.JumpTimer.Interval = 10;
            this.JumpTimer.Tick += new System.EventHandler(this.JumpEvent);
            // 
            // GravityTimer
            // 
            this.GravityTimer.Enabled = true;
            this.GravityTimer.Interval = 5;
            this.GravityTimer.Tick += new System.EventHandler(this.GravityEvent);
            // 
            // CollisionTimer
            // 
            this.CollisionTimer.Enabled = true;
            this.CollisionTimer.Interval = 5;
            this.CollisionTimer.Tick += new System.EventHandler(this.CollisionEvent);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            // 
            // XMove
            // 
            this.XMove.AutoSize = true;
            this.XMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.XMove.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XMove.Location = new System.Drawing.Point(173, 40);
            this.XMove.Name = "XMove";
            this.XMove.Size = new System.Drawing.Size(419, 21);
            this.XMove.TabIndex = 1;
            this.XMove.Text = "Use Left Arrow and Right Arrow to move.";
            // 
            // YMove
            // 
            this.YMove.AutoSize = true;
            this.YMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.YMove.Font = new System.Drawing.Font("Cooper Black", 14.25F);
            this.YMove.Location = new System.Drawing.Point(186, 61);
            this.YMove.Name = "YMove";
            this.YMove.Size = new System.Drawing.Size(394, 21);
            this.YMove.TabIndex = 2;
            this.YMove.Text = "Shout to Jump. Jump on the Platforms.\r\n";
            // 
            // coins
            // 
            this.coins.AutoSize = true;
            this.coins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.coins.Font = new System.Drawing.Font("Cooper Black", 14.25F);
            this.coins.Location = new System.Drawing.Point(204, 82);
            this.coins.Name = "coins";
            this.coins.Size = new System.Drawing.Size(365, 21);
            this.coins.TabIndex = 3;
            this.coins.Text = "Get Coins. Coins give you 200 points.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F);
            this.label1.Location = new System.Drawing.Point(65, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "How to Play:";
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::ScreamOMario.Properties.Resources.Background21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coins);
            this.Controls.Add(this.YMove);
            this.Controls.Add(this.XMove);
            this.Controls.Add(this.volume);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ScreamOMario_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ScreamOMario_Paint_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreamOMario_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ScreamOMario_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveTimer;
        private System.Windows.Forms.ProgressBar volume;
        private System.Windows.Forms.Timer JumpTimer;
        private System.Windows.Forms.Timer GravityTimer;
        private System.Windows.Forms.Timer CollisionTimer;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label XMove;
        private System.Windows.Forms.Label YMove;
        private System.Windows.Forms.Label coins;
        private System.Windows.Forms.Label label1;
    }
}

