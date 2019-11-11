﻿namespace BoxJump
{
    partial class menuScreen
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
            this.Start = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.BackgroundImage = global::BoxJump.Properties.Resources.startButton;
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.ForeColor = System.Drawing.Color.Transparent;
            this.Start.Location = new System.Drawing.Point(634, 485);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(236, 91);
            this.Start.TabIndex = 1;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.startGame);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.BackgroundImage = global::BoxJump.Properties.Resources.helpButton;
            this.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help.FlatAppearance.BorderSize = 0;
            this.help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.ForeColor = System.Drawing.Color.Transparent;
            this.help.Location = new System.Drawing.Point(656, 584);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(190, 83);
            this.help.TabIndex = 2;
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.showHelp);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BackgroundImage = global::BoxJump.Properties.Resources.Title;
            this.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Title.Location = new System.Drawing.Point(363, 174);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(792, 164);
            this.Title.TabIndex = 3;
            this.Title.TabStop = false;
            this.Title.Tag = "Title";
            // 
            // menuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BoxJump.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1482, 844);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.help);
            this.Controls.Add(this.Start);
            this.Name = "menuScreen";
            this.Text = "menuScreen";
            ((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.PictureBox Title;
    }
}