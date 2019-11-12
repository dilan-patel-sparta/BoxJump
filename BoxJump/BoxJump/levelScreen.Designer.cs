namespace BoxJump
{
    partial class LevelScreen
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
            this.Title = new System.Windows.Forms.PictureBox();
            this.easyButton = new System.Windows.Forms.Button();
            this.intermediateButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BackgroundImage = global::BoxJump.Properties.Resources.selectLevel;
            this.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Title.Location = new System.Drawing.Point(319, 84);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(792, 164);
            this.Title.TabIndex = 4;
            this.Title.TabStop = false;
            this.Title.Tag = "Title";
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.Color.Transparent;
            this.easyButton.BackgroundImage = global::BoxJump.Properties.Resources.easy;
            this.easyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.easyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.easyButton.FlatAppearance.BorderSize = 0;
            this.easyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.Location = new System.Drawing.Point(608, 341);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(218, 106);
            this.easyButton.TabIndex = 5;
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.easyLevelClick);
            // 
            // intermediateButton
            // 
            this.intermediateButton.BackColor = System.Drawing.Color.Transparent;
            this.intermediateButton.BackgroundImage = global::BoxJump.Properties.Resources.intermediate;
            this.intermediateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.intermediateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.intermediateButton.FlatAppearance.BorderSize = 0;
            this.intermediateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.intermediateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.intermediateButton.Location = new System.Drawing.Point(444, 464);
            this.intermediateButton.Name = "intermediateButton";
            this.intermediateButton.Size = new System.Drawing.Size(542, 106);
            this.intermediateButton.TabIndex = 6;
            this.intermediateButton.UseVisualStyleBackColor = false;
            this.intermediateButton.Click += new System.EventHandler(this.intermediateLevelClick);
            // 
            // hardButton
            // 
            this.hardButton.BackColor = System.Drawing.Color.Transparent;
            this.hardButton.BackgroundImage = global::BoxJump.Properties.Resources.hard;
            this.hardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hardButton.FlatAppearance.BorderSize = 0;
            this.hardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardButton.Location = new System.Drawing.Point(608, 581);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(218, 106);
            this.hardButton.TabIndex = 7;
            this.hardButton.UseVisualStyleBackColor = false;
            // 
            // LevelScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BoxJump.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1482, 844);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.intermediateButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.Title);
            this.Name = "LevelScreen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Title;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button intermediateButton;
        private System.Windows.Forms.Button hardButton;
    }
}