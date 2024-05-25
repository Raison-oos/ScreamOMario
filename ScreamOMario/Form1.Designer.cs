using NAudio.Wave;

namespace ScreamOMario
{
    partial class ScreamOMario
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
            this.PlatformTimer = new System.Windows.Forms.Timer(this.components);
            this.CollisionTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // PlatformTimer
            // 
            this.PlatformTimer.Enabled = true;
            this.PlatformTimer.Interval = 20;
            this.PlatformTimer.Tick += new System.EventHandler(this.PlatformEvent);
            // 
            // CollisionTimer
            // 
            this.CollisionTimer.Enabled = true;
            this.CollisionTimer.Interval = 5;
            this.CollisionTimer.Tick += new System.EventHandler(this.CollisionEvent);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(90, 401);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(23, 24);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.GameOverEvenet);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::ScreamOMario.Properties.Resources.score__2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ScreamOMario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::ScreamOMario.Properties.Resources.Background__3_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreamOMario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ScreamOMario_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ScreamOMario_Paint_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreamOMario_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ScreamOMario_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveTimer;
        private System.Windows.Forms.ProgressBar volume;
        private System.Windows.Forms.Timer JumpTimer;
        private System.Windows.Forms.Timer GravityTimer;
        private System.Windows.Forms.Timer PlatformTimer;
        private System.Windows.Forms.Timer CollisionTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

