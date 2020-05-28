using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsLife
{
    public partial class Form2 : Form
    {
        public int pet_c = 0;
        
        public Form2()
        {
            InitializeComponent();

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

           

        }
        
        
        
        public void button1_Click(object sender, EventArgs e) // Functions to change the picture in selection form.
        {
            pet_c = 1;
            
            
            

            if (pet_c == 1)
            {
                pictureBox1.Image = Properties.Resources.snake_normal;
                p_ch.Text = "Snake";
                p_ch.Refresh();
            }
            else if (pet_c == 2)
            {
                pictureBox1.Image = Properties.Resources.dog_normal;
            }
            else if (pet_c == 3)
            {
                pictureBox1.Image = Properties.Resources.cat_normal;
            }
            else
            {
                
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
           pet_c = 2;
          

            if (pet_c == 1)
            {
                pictureBox1.Image = Properties.Resources.snake_normal;
            }
            else if (pet_c == 2)
            {
                pictureBox1.Image = Properties.Resources.dog_normal;
                p_ch.Text = "Dog";
                p_ch.Refresh();
            }
            else if (pet_c == 3)
            {
                pictureBox1.Image = Properties.Resources.cat_normal;
            }
            else
            {

            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            pet_c = 3;

           

            if (pet_c == 1)
            {
                pictureBox1.Image = Properties.Resources.snake_normal;
            }
            else if (pet_c == 2)
            {
                pictureBox1.Image = Properties.Resources.dog_normal;
            }
            else if (pet_c == 3)
            {
                pictureBox1.Image = Properties.Resources.cat_normal;
                p_ch.Text = "Cat";
                p_ch.Visible = true;
                p_ch.Refresh();
            }
            else
            {

            }
        }
        
        
        public void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
            
        }

        public void button2_Click_1(object sender, EventArgs e) // Function to pass the data of which pet was selected
        {
            if (pet_c == 1)
            {
                
                
                Form3 f3 = new Form3();
                f3.passingvalue = p_ch.Text;
                f3.Show();
                this.Close();

                
            }
            else if (pet_c == 2)
            {
               
                
                Form3 f3 = new Form3();
                f3.passingvalue = p_ch.Text;
                f3.Show();
                this.Close();
            }
            else if (pet_c == 3)
            {
                
                
                Form3 f3 = new Form3();
                f3.passingvalue = p_ch.Text;
                f3.Show();
                this.Close();
            }
        }
    }
}
