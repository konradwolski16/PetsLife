namespace PetsLife
{
    partial class Form3
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
            this.Health = new System.Windows.Forms.ProgressBar();
            this.Boredness = new System.Windows.Forms.ProgressBar();
            this.Sleep = new System.Windows.Forms.ProgressBar();
            this.Hunger = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Picture1 = new System.Windows.Forms.PictureBox();
            this.p_ch2 = new System.Windows.Forms.Label();
            this.Feed = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Sl = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.ft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // Health
            // 
            this.Health.Location = new System.Drawing.Point(490, 107);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(100, 23);
            this.Health.TabIndex = 4;
            this.Health.Tag = "";
            // 
            // Boredness
            // 
            this.Boredness.Location = new System.Drawing.Point(490, 242);
            this.Boredness.Name = "Boredness";
            this.Boredness.Size = new System.Drawing.Size(100, 23);
            this.Boredness.TabIndex = 5;
            this.Boredness.Tag = "";
            // 
            // Sleep
            // 
            this.Sleep.Location = new System.Drawing.Point(490, 179);
            this.Sleep.Name = "Sleep";
            this.Sleep.Size = new System.Drawing.Size(100, 23);
            this.Sleep.TabIndex = 6;
            this.Sleep.Tag = "";
            // 
            // Hunger
            // 
            this.Hunger.Location = new System.Drawing.Point(490, 50);
            this.Hunger.Name = "Hunger";
            this.Hunger.Size = new System.Drawing.Size(100, 23);
            this.Hunger.TabIndex = 7;
            this.Hunger.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hunger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sleep";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Boredness";
            // 
            // Picture1
            // 
            this.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Picture1.Location = new System.Drawing.Point(12, 27);
            this.Picture1.Name = "Picture1";
            this.Picture1.Size = new System.Drawing.Size(472, 330);
            this.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture1.TabIndex = 12;
            this.Picture1.TabStop = false;
            this.Picture1.Click += new System.EventHandler(this.Picture_Click);
            // 
            // p_ch2
            // 
            this.p_ch2.AutoSize = true;
            this.p_ch2.Location = new System.Drawing.Point(637, 50);
            this.p_ch2.Name = "p_ch2";
            this.p_ch2.Size = new System.Drawing.Size(0, 17);
            this.p_ch2.TabIndex = 13;
            // 
            // Feed
            // 
            this.Feed.Location = new System.Drawing.Point(506, 307);
            this.Feed.Name = "Feed";
            this.Feed.Size = new System.Drawing.Size(110, 50);
            this.Feed.TabIndex = 14;
            this.Feed.Text = "Feed";
            this.Feed.UseVisualStyleBackColor = true;
            this.Feed.Click += new System.EventHandler(this.Feed_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(649, 307);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(110, 50);
            this.Play.TabIndex = 15;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Sl
            // 
            this.Sl.Location = new System.Drawing.Point(506, 376);
            this.Sl.Name = "Sl";
            this.Sl.Size = new System.Drawing.Size(110, 50);
            this.Sl.TabIndex = 16;
            this.Sl.Text = "Sleep";
            this.Sl.UseVisualStyleBackColor = true;
            this.Sl.Click += new System.EventHandler(this.Sl_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(649, 380);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(119, 43);
            this.Back.TabIndex = 17;
            this.Back.Text = "Exit";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ft
            // 
            this.ft.AutoSize = true;
            this.ft.Location = new System.Drawing.Point(640, 86);
            this.ft.Name = "ft";
            this.ft.Size = new System.Drawing.Size(0, 17);
            this.ft.TabIndex = 18;
            this.ft.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ft);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Sl);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Feed);
            this.Controls.Add(this.p_ch2);
            this.Controls.Add(this.Picture1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hunger);
            this.Controls.Add(this.Sleep);
            this.Controls.Add(this.Boredness);
            this.Controls.Add(this.Health);
            this.Name = "Form3";
            this.Text = "Pet\'s Life";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Health;
        private System.Windows.Forms.ProgressBar Boredness;
        private System.Windows.Forms.ProgressBar Sleep;
        private System.Windows.Forms.ProgressBar Hunger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Picture1;
        private System.Windows.Forms.Label p_ch2;
        private System.Windows.Forms.Button Feed;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Sl;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label ft;
    }
}