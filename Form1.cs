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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2 = new Form2();

        public static string p_cs { get; internal set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e) // Opening new form
        {
            
            f2.Show();
            this.Hide();
        }

        public void button2_Click(object sender, EventArgs e) // Closing the game
        {
            this.Close();
            f2.Close();
        }
    }
}
