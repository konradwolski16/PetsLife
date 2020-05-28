namespace PetsLife
{
    partial class Form2
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
            this.b_parrot = new System.Windows.Forms.Button();
            this.b_dog = new System.Windows.Forms.Button();
            this.b_cat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.p_ch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_parrot
            // 
            this.b_parrot.Location = new System.Drawing.Point(57, 92);
            this.b_parrot.Name = "b_parrot";
            this.b_parrot.Size = new System.Drawing.Size(125, 52);
            this.b_parrot.TabIndex = 0;
            this.b_parrot.Text = "Snake";
            this.b_parrot.UseVisualStyleBackColor = true;
            this.b_parrot.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_dog
            // 
            this.b_dog.Location = new System.Drawing.Point(57, 180);
            this.b_dog.Name = "b_dog";
            this.b_dog.Size = new System.Drawing.Size(125, 52);
            this.b_dog.TabIndex = 1;
            this.b_dog.Text = "Dog";
            this.b_dog.UseVisualStyleBackColor = true;
            this.b_dog.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_cat
            // 
            this.b_cat.Location = new System.Drawing.Point(57, 276);
            this.b_cat.Name = "b_cat";
            this.b_cat.Size = new System.Drawing.Size(125, 52);
            this.b_cat.TabIndex = 2;
            this.b_cat.Text = "Cat";
            this.b_cat.UseVisualStyleBackColor = true;
            this.b_cat.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(335, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 289);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(29, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "pictureBox1";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Choose";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // p_ch
            // 
            this.p_ch.AutoSize = true;
            this.p_ch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_ch.Location = new System.Drawing.Point(335, 27);
            this.p_ch.Name = "p_ch";
            this.p_ch.Size = new System.Drawing.Size(31, 19);
            this.p_ch.TabIndex = 6;
            this.p_ch.Text = "Pet";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.p_ch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b_cat);
            this.Controls.Add(this.b_dog);
            this.Controls.Add(this.b_parrot);
            this.Name = "Form2";
            this.Text = "Pet\'s Life";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_parrot;
        private System.Windows.Forms.Button b_dog;
        private System.Windows.Forms.Button b_cat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label p_ch;
    }
}