using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tamagochi_IlyaProject
{
    public partial class Form1 : Form
    {
        public Object myPerson;
        public Form1()
        {
            InitializeComponent();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            
            progressBar1.Visible = false;
            progressBar2.Visible = false;
            progressBar3.Visible = false;
            pictureBox.Visible = false;
            add_Eat.Visible = false;
            add_Water.Visible = false;
            add_Health.Visible = false;
            label.Visible = false;
            label_name.Visible = false;
         
      

            Person.Items.Add("Птица");
            Person.Items.Add("Котенок");
            Person.Items.Add("Собака");



        }
        public void Form1_myLoad_Restart()
        {
            textBox_name.Visible = true;
            progressBar1.Value = 100;
            progressBar2.Value = 100;
            progressBar3.Value = 100;
            Exit.Visible = true;
            Person.Visible = true;
            button_Start.Visible = true;
            progressBar1.Visible = false;
            progressBar2.Visible = false;
            progressBar3.Visible = false;
            pictureBox.Visible = false;
            add_Eat.Visible = false;
            add_Water.Visible = false;
            add_Health.Visible = false;
            label.Visible = false;
            label_name.Visible = false;
        }

        public void button_Start_Click(object sender, EventArgs e)
        {

            if (textBox_name.Text == "")
            {
                MessageBox.Show("Введите имя персонажа");

            }
            else {

                switch (Person.SelectedIndex)
                {
                    case 0:
                        myPerson = new Bird();
                        pictureBox.Load("bird.jpg");
                        break;
                    case 1:
                        myPerson = new Kitten();
                        pictureBox.Load("cat.jpg");
                        break;
                    case 2:
                        myPerson = new Dog();
                        pictureBox.Load("dog.jpg");
                        break;

                }
                label_name.Text = Convert.ToString(textBox_name.Text);

                textBox_name.Visible = false;
                timer1.Start();
                Person.Visible = false;
                button_Start.Visible = false;
                progressBar1.Visible = true;
                progressBar2.Visible = true;
                progressBar3.Visible = true;
                pictureBox.Visible = true;
                add_Eat.Visible = true;
                add_Water.Visible = true;
                add_Health.Visible = true;
                label.Visible = true;
                label_name.Visible = true;
                Exit.Visible = false;

            }
           


        }




        private void timer1_Tick(object sender, EventArgs e)
        {


            try
            {
                progressBar1.Step = ((Person)myPerson).getStep_eat();
                if (progressBar1.Value != 1 || progressBar1.Value != 2 || progressBar1.Value != 3)
                    progressBar1.Value -= progressBar1.Step;

                progressBar2.Step = ((Person)myPerson).getStep_health();
                if (progressBar2.Value != 1 || progressBar2.Value != 2 || progressBar2.Value != 3)
                    progressBar2.Value -= progressBar2.Step;

                progressBar3.Step = ((Person)myPerson).getStep_water();
                if (progressBar3.Value != 1 || progressBar3.Value != 2 || progressBar3.Value != 3 )
                    progressBar3.Value -= progressBar3.Step;
            }
            catch {
               
                timer1.Stop();
                MessageBox.Show("Вы проиграли, одна из покозателей дошла до нуля.");
                Form1_myLoad_Restart();
               
              
            }
            Thread.Sleep(((Person)myPerson).getInterval());
        }

        private void add_Eat_Click(object sender, EventArgs e)
        {

           
                try
                {
                    progressBar1.Value += ((Person)myPerson).getAdd();

                }
                catch
                {



                }
            
        }

        private void add_Health_Click(object sender, EventArgs e)
        {
           
                try
                {
                    progressBar3.Value += ((Person)myPerson).getAdd();

                }
                catch
                {



                }
            
        }

        private void add_Water_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar2.Value += ((Person)myPerson).getAdd();

            }
            catch
            {



            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
