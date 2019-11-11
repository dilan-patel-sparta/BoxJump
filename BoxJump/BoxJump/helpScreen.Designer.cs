namespace BoxJump
{
    partial class helpScreen
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Title = new System.Windows.Forms.PictureBox();
            this.HelpBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BackgroundImage = global::BoxJump.Properties.Resources.help;
            this.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Title.Location = new System.Drawing.Point(593, 92);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(314, 164);
            this.Title.TabIndex = 5;
            this.Title.TabStop = false;
            this.Title.Tag = "Title";
            // 
            // HelpBox
            // 
            this.HelpBox.BackColor = System.Drawing.Color.Transparent;
            this.HelpBox.BackgroundImage = global::BoxJump.Properties.Resources.helpBackground1;
            this.HelpBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HelpBox.Location = new System.Drawing.Point(537, 262);
            this.HelpBox.Name = "HelpBox";
            this.HelpBox.Size = new System.Drawing.Size(418, 585);
            this.HelpBox.TabIndex = 6;
            this.HelpBox.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::BoxJump.Properties.Resources.back;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(1233, 746);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(237, 101);
            this.backButton.TabIndex = 7;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton);
            // 
            // helpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BoxJump.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1482, 844);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.HelpBox);
            this.Controls.Add(this.Title);
            this.Name = "helpScreen";
            this.Text = "helpScreen";
            ((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox Title;
        private System.Windows.Forms.PictureBox HelpBox;
        private System.Windows.Forms.Button backButton;
    }
}