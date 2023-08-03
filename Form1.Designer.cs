
namespace Bird_Shooter
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.Player = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bullets = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Missed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Hits = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GO_screen = new System.Windows.Forms.Panel();
            this.MVP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.GO_screen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::Bird_Hunt.Properties.Resources.bird;
            this.Player.Location = new System.Drawing.Point(499, 34);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(115, 132);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 877);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.LightCoral;
            this.Score.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(166, 877);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(147, 57);
            this.Score.TabIndex = 2;
            this.Score.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 57);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bullets left:";
            // 
            // Bullets
            // 
            this.Bullets.AutoSize = true;
            this.Bullets.BackColor = System.Drawing.Color.LightCoral;
            this.Bullets.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bullets.Location = new System.Drawing.Point(258, 115);
            this.Bullets.Name = "Bullets";
            this.Bullets.Size = new System.Drawing.Size(47, 57);
            this.Bullets.TabIndex = 4;
            this.Bullets.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1030, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 57);
            this.label3.TabIndex = 5;
            this.label3.Text = "EXIT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(933, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 57);
            this.label4.TabIndex = 6;
            this.label4.Text = "RESTART";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Missed
            // 
            this.Missed.AutoSize = true;
            this.Missed.BackColor = System.Drawing.Color.LightCoral;
            this.Missed.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Missed.Location = new System.Drawing.Point(307, 194);
            this.Missed.Name = "Missed";
            this.Missed.Size = new System.Drawing.Size(47, 57);
            this.Missed.TabIndex = 8;
            this.Missed.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightCoral;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 57);
            this.label6.TabIndex = 7;
            this.label6.Text = "Missed shots:";
            // 
            // Hits
            // 
            this.Hits.AutoSize = true;
            this.Hits.BackColor = System.Drawing.Color.LightCoral;
            this.Hits.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hits.Location = new System.Drawing.Point(131, 34);
            this.Hits.Name = "Hits";
            this.Hits.Size = new System.Drawing.Size(47, 57);
            this.Hits.TabIndex = 10;
            this.Hits.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightCoral;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 57);
            this.label8.TabIndex = 9;
            this.label8.Text = "Hits:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GO_screen
            // 
            this.GO_screen.BackColor = System.Drawing.Color.Yellow;
            this.GO_screen.Controls.Add(this.MVP);
            this.GO_screen.Controls.Add(this.label7);
            this.GO_screen.Controls.Add(this.label5);
            this.GO_screen.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GO_screen.Location = new System.Drawing.Point(182, 198);
            this.GO_screen.Name = "GO_screen";
            this.GO_screen.Size = new System.Drawing.Size(858, 277);
            this.GO_screen.TabIndex = 11;
            // 
            // MVP
            // 
            this.MVP.AutoSize = true;
            this.MVP.BackColor = System.Drawing.Color.LightCoral;
            this.MVP.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MVP.Location = new System.Drawing.Point(476, 182);
            this.MVP.Name = "MVP";
            this.MVP.Size = new System.Drawing.Size(147, 57);
            this.MVP.TabIndex = 12;
            this.MVP.Text = "Score:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightCoral;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 57);
            this.label7.TabIndex = 12;
            this.label7.Text = "High Score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(-11, -4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(869, 162);
            this.label5.TabIndex = 1;
            this.label5.Text = "GAME OVER!";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 741);
            this.ControlBox = false;
            this.Controls.Add(this.GO_screen);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Hits);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Missed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bullets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "MainFrame";
            this.Text = "Bird Hunt";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainFrame_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.GO_screen.ResumeLayout(false);
            this.GO_screen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Bullets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Missed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Hits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel GO_screen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MVP;
        private System.Windows.Forms.Label label7;
    }
}

