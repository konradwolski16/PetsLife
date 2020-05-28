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
    public partial class Form3 : Form
    {
        Pet attributes;

        public Form3()
        {
            InitializeComponent();


            attributes = new Pet();



            Timer Realtime = new Timer();      //Timer to update the screen 
            Realtime.Interval = 500;
            Realtime.Tick += new EventHandler(screenUpdate);       //Event Handler
            Realtime.Start();






        }

        public void Pchanges() // Method for updating the pictures depending on the value of the attributes
        {
            if (p_ch2.Text == "Snake")  // if we choose Snake in form 2 it will be updated to form3
            {

                if (Hunger.Value < 50 && Sleep.Value < 50)
                {
                    Picture1.Image = Properties.Resources.snake_angry;
                }
                else if (Hunger.Value < 50)
                {
                    Picture1.Image = Properties.Resources.snake_angry;
                }
                else if (Sleep.Value < 50)
                {
                    Picture1.Image = Properties.Resources.snake_sleepy;
                }
                else if (Health.Value < 50)
                {
                    Picture1.Image = Properties.Resources.snake_confused;
                }
                else if (Boredness.Value > 50)
                {
                    Picture1.Image = Properties.Resources.snake_bored;
                }
                else if (Boredness.Value < 60 && Hunger.Value > 80 && Sleep.Value > 80)
                {
                    Picture1.Image = Properties.Resources.snake_love;
                }
                else if (Boredness.Value < 60 && Hunger.Value > 40 && Sleep.Value > 40)
                {
                    Picture1.Image = Properties.Resources.snake_normal;
                }


            }
            else if (p_ch2.Text == "Dog")
            {

                if (Hunger.Value < 50 && Sleep.Value < 50)
                {
                    Picture1.Image = Properties.Resources.dog_angry;
                }
                else if (Hunger.Value < 50)
                {
                    Picture1.Image = Properties.Resources.dog_angry;
                }
                else if (Sleep.Value < 50)
                {
                    Picture1.Image = Properties.Resources.dog_sleepy;
                }
                else if (Health.Value < 50)
                {
                    Picture1.Image = Properties.Resources.dog_confused;
                }
                else if (Boredness.Value > 50)
                {
                    Picture1.Image = Properties.Resources.dog_bored;
                }
                else if (Boredness.Value < 60 && Hunger.Value > 80 && Sleep.Value > 80)
                {
                    Picture1.Image = Properties.Resources.dog_love;
                }
                else if (Boredness.Value < 60 && Hunger.Value > 40 && Sleep.Value > 40)
                {
                    Picture1.Image = Properties.Resources.dog_normal;
                }



            }
            else if (p_ch2.Text == "Cat")
            {

                if (Hunger.Value < 50 && Sleep.Value < 50)
                {
                    Picture1.Image = Properties.Resources.cat_angry;
                }
                else if (Hunger.Value < 50)
                {
                    Picture1.Image = Properties.Resources.cat_angry;
                }
                else if (Sleep.Value < 50)
                {
                    Picture1.Image = Properties.Resources.cat_sleepy;
                }
                else if (Health.Value < 50)
                {
                    Picture1.Image = Properties.Resources.cat_confused;
                }
                else if (Boredness.Value > 50)
                {
                    Picture1.Image = Properties.Resources.cat_bored;
                }
                else if (Boredness.Value < 60 && Hunger.Value > 80 && Sleep.Value > 80)
                {
                    Picture1.Image = Properties.Resources.cat_love;
                }
                else if (Boredness.Value < 60 && Hunger.Value > 40 && Sleep.Value > 40)
                {
                    Picture1.Image = Properties.Resources.cat_normal;
                }



            }
        }

        public string passingvalue // Getting the value from Form2 to Form3
        {
            get { return p_ch2.Text; }
            set { p_ch2.Text = value; }
        }



        public class Pet // Main class Pet which has starting attributes and different methods
        {

            public int Hunger = 100;
            public int Boredness = 0;
            public int Sleep = 100;
            public int Health = 100;

            public virtual void H() // Calculating Hunger
            {

            }
            public virtual void S() // Calculating Sleep
            {

            }
            public virtual void Ha() // Calculating Health
            {

            }
            public virtual void B() // Calculating Boredness
            {

            }
            public virtual void Feed() // Button to Feed
            {

            }
            
            public virtual void Play() // Button to Play
            {

            }
            public virtual void Sl() // Button to Sleep
            {

            }

            public int getHunger() // Getting attrubutes
            {

                return Hunger;


            }
            public int getSleep()
            {

                return Sleep;
            }
            public int getHealth()
            {

                return Health;
            }
            public int getBoredness()
            {
                return Boredness;
            }


        }

        public class Snake : Pet // Sub-class Snake which is overriding the methods from nain class
        {



            public override void H()
            {

                Hunger = Hunger - 1;
                if (Hunger < 0) { Hunger = 0; }
            }
            public override void S()
            {

                Sleep = Sleep - 1;
                if (Sleep < 0) { Sleep = 0; }
            }
            public override void Ha()
            {

                if (Sleep == 0 && Hunger == 0)
                {
                    Health = Health - 10;
                }
                if (Health < 0) { }
            }
            public override void B()
            {
                Boredness = Boredness + 1;
                if (Boredness > 100) { Boredness = 100; }
            }
            public override void Feed()
            {

                if (Hunger <= 90)
                {
                    Hunger = Hunger + 10;
                }
                else if (Hunger > 90)
                {
                    Hunger = 100;
                }

            }
            
            public override void Play()
            {
                if (Boredness >= 10)
                {
                    Boredness = Boredness - 10;
                }
                else if (Boredness < 10)
                {
                    Boredness = 0;
                }
            }
            public override void Sl()
            {
                if (Sleep <= 90)
                {
                    Sleep = Sleep + 10;
                    if (Boredness <= 90)
                    {
                        Boredness = Boredness + 10;
                        if (Hunger >= 5)
                        {
                            Hunger = Hunger - 5;
                        }
                        else if (Hunger < 5)
                        {
                            Hunger = 0;
                        }
                    }
                    else if (Boredness > 90)
                    {
                        Boredness = 100;
                        if (Hunger >= 5)
                        {
                            Hunger = Hunger - 5;
                        }
                        else if (Hunger < 5)
                        {
                            Hunger = 0;
                        }

                    }


                }
                else if (Sleep > 90)
                {
                    Sleep = 100;
                    if (Boredness <= 90)
                    {
                        Boredness = Boredness + 10;
                        if (Hunger >= 5)
                        {
                            Hunger = Hunger - 5;
                        }
                        else if (Hunger < 5)
                        {
                            Hunger = 0;
                        }
                    }
                    else if (Boredness > 90)
                    {
                        Boredness = 100;
                        if (Hunger >= 5)
                        {
                            Hunger = Hunger - 5;
                        }
                        else if (Hunger < 5)
                        {
                            Hunger = 0;
                        }

                    }
                }
            }

        }
        public class Dog : Pet   // Sub-class Dog which is overriding the methods from nain class
        {
            public override void H()
            {

                Hunger = Hunger - 1;
                if (Hunger < 0) { Hunger = 0; }
            }
            public override void S()
            {

                Sleep = Sleep - 1;
                if (Sleep < 0) { Sleep = 0; }
            }
            public override void Ha()
            {

                if (Sleep == 0 && Hunger == 0)
                {
                    Health = Health - 10;
                }
                if (Health < 0) { }
            }
            public override void B()
            {
                Boredness = Boredness + 1;
                if (Boredness > 100) { Boredness = 100; }
            }
            public override void Feed()
            {
                if (Hunger <= 90)
                {
                    Hunger = Hunger + 10;
                }
                else if (Hunger > 90)
                {
                    Hunger = 100;
                }
            }
            public override void Play()
            {
                if (Boredness >= 10)
                {
                    Boredness = Boredness - 10;
                }
                else if (Boredness < 10)
                {
                    Boredness = 0;
                }
            }
            public override void Sl()
            {
                if (Sleep <= 90)
                {
                    Sleep = Sleep + 10;
                    if (Boredness <= 90)
                    {
                        Boredness = Boredness + 10;
                        if (Hunger >= 5)
                        {
                            Hunger = Hunger - 5;
                        }
                        else if (Hunger < 5)
                        {
                            Hunger = 0;
                        }
                    }
                    else if (Boredness > 90)
                    {
                        Boredness = 100;
                        if (Hunger >= 5)
                        {
                            Hunger = Hunger - 5;
                        }
                        else if (Hunger < 5)
                        {
                            Hunger = 0;
                        }

                    }


                }
                else if (Sleep > 90)
                {
                    Sleep = 100;
                    if (Boredness <= 90)
                    {
                        Boredness = Boredness + 10;
                        if (Hunger >= 5)
                        {
                            Hunger = Hunger - 5;
                        }
                        else if (Hunger < 5)
                        {
                            Hunger = 0;
                        }
                    }
                    else if (Boredness > 90)
                    {
                        Boredness = 100;
                        if (Hunger >= 5)
                        {
                            Hunger = Hunger - 5;
                        }
                        else if (Hunger < 5)
                        {
                            Hunger = 0;
                        }

                    }
                }
            }
        }
        public class Cat : Pet   // Sub-class Cat which is overriding the methods from nain class
        {
            public override void H()
            {

                Hunger = Hunger - 1;
                if (Hunger < 0) { Hunger = 0; }
            }
            public override void S()
            {

                Sleep = Sleep - 1;
                if (Sleep < 0) { Sleep = 0; }
            }
            public override void Ha()
            {

                if (Sleep == 0 && Hunger == 0)
                {
                    Health = Health - 10;
                }
                if (Health < 0) { }
            }
            public override void B()
            {
                Boredness = Boredness + 1;
                if (Boredness > 100) { Boredness = 100; }
            }
            public override void Feed()
            {


                if (Hunger <= 90)
                {
                    Hunger = Hunger + 10;
                }
                else if (Hunger > 90)
                {
                    Hunger = 100;
                }
            }
            public override void Play()
            {
                if (Boredness >= 10)
                {
                    Boredness = Boredness - 10;
                }
                else if (Boredness < 10)
                {
                    Boredness = 0;
                }
            }
            public override void Sl()
            {
                if (Sleep <= 90)
                {
                    Sleep = Sleep + 10;
                    if (Boredness <= 90)
                    {
                        Boredness = Boredness + 10;
                        if (Hunger >= 5)
                        {
                            Hunger = Hunger - 5;
                        }
                        else if (Hunger < 5)
                        {
                            Hunger = 0;
                        }
                    }
                    else if (Boredness > 90)
                    {
                        Boredness = 100;
                        if (Hunger >= 5)
                        {
                            Hunger = Hunger - 5;
                        }
                        else if (Hunger < 5)
                        {
                            Hunger = 0;
                        }

                    }


                }
                else if (Sleep > 90)
                {
                    Sleep = 100;
                    if (Boredness <= 90)
                    {
                        Boredness = Boredness + 10;
                        if (Hunger >= 5)
                        {
                            Hunger = Hunger - 5;
                        }
                        else if (Hunger < 5)
                        {
                            Hunger = 0;
                        }
                    }
                    else if (Boredness > 90)
                    {
                        Boredness = 100;
                        if (Hunger >= 5)
                        {
                            Hunger = Hunger - 5;
                        }
                        else if (Hunger < 5)
                        {
                            Hunger = 0;
                        }

                    }
                }
            }
        }
        public void screenUpdate(object sender, EventArgs e) // Event Handler where you enter which methods from which object and class will be used each 2sec
        {
            Health.Value = attributes.getHealth();
            Hunger.Value = attributes.getHunger();
            Boredness.Value = attributes.getBoredness();
            Sleep.Value = attributes.getSleep();
            attributes.H();
            attributes.S();
            attributes.Ha();
            attributes.B();
            Pchanges();

        }
        public int fo = 0;
        public void Form3_Load(object sender, EventArgs e) // Depending what we choose in Form2 it will create new pet
        {



            if (p_ch2.Text == "Snake")
            {

                attributes = new Snake();
                Feed.Text = "Feed with Mouse";
                if (ft.Text == "Med")
                {
                    fo = 1;

                }
                else if (ft.Text == "Es")
                {
                    fo = 2;
                }
                else if (ft.Text == "Bn")
                {
                    fo = 3;
                }


            }
            else if (p_ch2.Text == "Dog")
            {

                attributes = new Dog();
                Feed.Text = "Feed with Dog Food";


            }
            else if (p_ch2.Text == "Cat")
            {

                attributes = new Cat();
                Feed.Text = "Feed with Cat Food";


            }





        }

        public void Feed_Click(object sender, EventArgs e) // Feed button which is taking the method from Pet
        {
            attributes.Feed();



        }

        private void Play_Click(object sender, EventArgs e)// Play button which is taking the method from Pet
        {
            attributes.Play();
        }

        private void Sl_Click(object sender, EventArgs e)// Sleep button which is taking the method from Pet
        {
            attributes.Sl();
        }

        private void Picture_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        


    }
}

