namespace LostSongDesktopApp
{
    partial class MainWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.loadFileButton = new System.Windows.Forms.Button();
            this.runMusictagButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // loadFileButton
            // 
            this.loadFileButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.loadFileButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loadFileButton.FlatAppearance.BorderSize = 0;
            this.loadFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.loadFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.loadFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadFileButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadFileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.loadFileButton.Location = new System.Drawing.Point(159, 218);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(197, 55);
            this.loadFileButton.TabIndex = 1;
            this.loadFileButton.Text = "Load File";
            this.loadFileButton.UseVisualStyleBackColor = false;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // runMusictagButton
            // 
            this.runMusictagButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.runMusictagButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.runMusictagButton.Enabled = false;
            this.runMusictagButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.runMusictagButton.FlatAppearance.BorderSize = 0;
            this.runMusictagButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.runMusictagButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.runMusictagButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runMusictagButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.runMusictagButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.runMusictagButton.Location = new System.Drawing.Point(136, 363);
            this.runMusictagButton.Name = "runMusictagButton";
            this.runMusictagButton.Size = new System.Drawing.Size(242, 73);
            this.runMusictagButton.TabIndex = 2;
            this.runMusictagButton.Text = "Run LostSong!";
            this.runMusictagButton.UseVisualStyleBackColor = false;
            this.runMusictagButton.Click += new System.EventHandler(this.runMusictagButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Sitka Text", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.titleLabel.Location = new System.Drawing.Point(37, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(339, 97);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "LostSong";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(382, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 134);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(40, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "LostSong";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(369, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(514, 8);
            this.panel3.TabIndex = 7;
            // 
            // progressStatusLabel
            // 
            this.progressStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.progressStatusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.progressStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.progressStatusLabel.Location = new System.Drawing.Point(19, 298);
            this.progressStatusLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.progressStatusLabel.Name = "progressStatusLabel";
            this.progressStatusLabel.Size = new System.Drawing.Size(476, 40);
            this.progressStatusLabel.TabIndex = 3;
            this.progressStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressStatusLabel.UseMnemonic = false;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(514, 546);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.progressStatusLabel);
            this.Controls.Add(this.runMusictagButton);
            this.Controls.Add(this.loadFileButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(530, 585);
            this.Name = "MainWindowForm";
            this.Text = "Music Tag";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.Button runMusictagButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label progressStatusLabel;
    }
}

