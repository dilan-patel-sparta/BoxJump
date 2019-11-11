namespace BoxJump
{
    partial class gameScreen
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
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.chest = new System.Windows.Forms.PictureBox();
            this.coin = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.leftWall = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::BoxJump.Properties.Resources.Character;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(79, 767);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(34, 39);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Beige;
            this.pictureBox2.BackgroundImage = global::BoxJump.Properties.Resources.Grass1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(512, 423);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(432, 25);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "floor";
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Beige;
            this.floor.BackgroundImage = global::BoxJump.Properties.Resources.Grass;
            this.floor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.floor.Location = new System.Drawing.Point(-68, 812);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(2033, 44);
            this.floor.TabIndex = 7;
            this.floor.TabStop = false;
            this.floor.Tag = "floor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Beige;
            this.pictureBox1.BackgroundImage = global::BoxJump.Properties.Resources.Grass1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(929, 744);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 25);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "floor";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Beige;
            this.pictureBox3.BackgroundImage = global::BoxJump.Properties.Resources.Grass1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(277, 595);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(181, 25);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "floor";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Beige;
            this.pictureBox4.BackgroundImage = global::BoxJump.Properties.Resources.Grass1;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(984, 528);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(186, 25);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "floor";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Beige;
            this.pictureBox5.BackgroundImage = global::BoxJump.Properties.Resources.Grass1;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(79, 497);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(179, 25);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "floor";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Beige;
            this.pictureBox6.BackgroundImage = global::BoxJump.Properties.Resources.Grass1;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(1182, 639);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(181, 25);
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "floor";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Beige;
            this.pictureBox7.BackgroundImage = global::BoxJump.Properties.Resources.Grass1;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(12, 379);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(122, 25);
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "floor";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Beige;
            this.pictureBox8.BackgroundImage = global::BoxJump.Properties.Resources.Grass1;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(184, 278);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(164, 25);
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "floor";
            // 
            // chest
            // 
            this.chest.BackgroundImage = global::BoxJump.Properties.Resources.Chest;
            this.chest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chest.Location = new System.Drawing.Point(290, 241);
            this.chest.Name = "chest";
            this.chest.Size = new System.Drawing.Size(39, 41);
            this.chest.TabIndex = 15;
            this.chest.TabStop = false;
            this.chest.Tag = "chest";
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.Transparent;
            this.coin.BackgroundImage = global::BoxJump.Properties.Resources.Coin;
            this.coin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin.Location = new System.Drawing.Point(360, 559);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(20, 20);
            this.coin.TabIndex = 16;
            this.coin.TabStop = false;
            this.coin.Tag = "coin";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = global::BoxJump.Properties.Resources.Coin;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(596, 379);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(20, 20);
            this.pictureBox9.TabIndex = 17;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "coin";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = global::BoxJump.Properties.Resources.Coin;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(719, 305);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(20, 20);
            this.pictureBox10.TabIndex = 18;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "coin";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.BackgroundImage = global::BoxJump.Properties.Resources.Coin;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(854, 384);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(20, 20);
            this.pictureBox11.TabIndex = 19;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "coin";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.BackgroundImage = global::BoxJump.Properties.Resources.Coin;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Location = new System.Drawing.Point(845, 622);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(20, 20);
            this.pictureBox12.TabIndex = 20;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "coin";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.BackgroundImage = global::BoxJump.Properties.Resources.Coin;
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox13.Location = new System.Drawing.Point(160, 455);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(20, 20);
            this.pictureBox13.TabIndex = 21;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "coin";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.BackgroundImage = global::BoxJump.Properties.Resources.Coin;
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox14.Location = new System.Drawing.Point(62, 334);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(20, 20);
            this.pictureBox14.TabIndex = 22;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "coin";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.BackgroundImage = global::BoxJump.Properties.Resources.Coin;
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox15.Location = new System.Drawing.Point(12, 600);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(20, 20);
            this.pictureBox15.TabIndex = 23;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "coin";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox16.BackgroundImage = global::BoxJump.Properties.Resources.Coin;
            this.pictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox16.Location = new System.Drawing.Point(1252, 407);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(20, 20);
            this.pictureBox16.TabIndex = 24;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "coin";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.BackgroundImage = global::BoxJump.Properties.Resources.Coin;
            this.pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox17.Location = new System.Drawing.Point(1061, 486);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(20, 20);
            this.pictureBox17.TabIndex = 25;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "coin";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.BackgroundImage = global::BoxJump.Properties.Resources.Coin;
            this.pictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox18.Location = new System.Drawing.Point(1031, 706);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(20, 20);
            this.pictureBox18.TabIndex = 26;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "coin";
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox19.BackgroundImage = global::BoxJump.Properties.Resources.Coin;
            this.pictureBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox19.Location = new System.Drawing.Point(1311, 600);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(20, 20);
            this.pictureBox19.TabIndex = 27;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "coin";
            // 
            // leftWall
            // 
            this.leftWall.BackColor = System.Drawing.Color.SlateBlue;
            this.leftWall.Location = new System.Drawing.Point(1483, -11);
            this.leftWall.Name = "leftWall";
            this.leftWall.Size = new System.Drawing.Size(1, 900);
            this.leftWall.TabIndex = 28;
            this.leftWall.TabStop = false;
            this.leftWall.Tag = "leftWall";
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBox20.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(1, 900);
            this.pictureBox20.TabIndex = 29;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Tag = "rightWall";
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::BoxJump.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1415, 844);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.leftWall);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.chest);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "gameScreen";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox chest;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox leftWall;
        private System.Windows.Forms.PictureBox pictureBox20;
    }
}

