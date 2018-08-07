/*Author: Jaime Maldonado
 *C# game that asks use to choose between
 * rock, paper, and scissor for a chance 
 * to play and beat the computer
 */

using System;

using System.Windows.Forms;

namespace RPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setVisibility();
        }

        private void setVisibility()
        {
            rockImg.Visible = false;
            paperImg.Visible = false;
            scissorsImg.Visible = false;
        }


        private void selection(int random, int button)
        {
            if(random == 1)
            {
                rockImg.Visible = true;
                paperImg.Visible = false;
                scissorsImg.Visible = false;
            }
            else if(random == 2)
            {
                paperImg.Visible = true;
                rockImg.Visible = false;
                scissorsImg.Visible = false;
            }
            else if(random == 3)
            {
                scissorsImg.Visible = true;
                paperImg.Visible = false;
                rockImg.Visible = false;
            }

            if (random == 1 && button == 1)
            {
                label3.Text = "DRAW!";
            }
            else if(random == 1 && button == 2)
            {
                label3.Text = "PAPER WRAPS ROCK: YOU WIN!";
            }
            else if (random == 1 && button == 3)
            {
                label3.Text = "ROCK BEATS SCISSORS: YOU LOSE!";
            }
            else if (random == 2 && button == 1)
            {
                label3.Text = "PAPER WRAPS ROCK: YOU LOSE!";
            }
            else if (random == 2 && button == 2)
            {
                label3.Text = "DRAW!";
            }
            else if (random == 2 && button == 3)
            {
                label3.Text = "SCISSORS CUTS PAPER: YOU WIN!";
            }
            else if (random == 3 && button == 1)
            {
                label3.Text = "ROCK BEATS SCISSORS: YOU WIN!";
            }
            else if (random == 3 && button == 2)
            {
                label3.Text = "SCISSORS CUTS PAPER: YOU LOSE!";
            }
            else if (random == 3 && button == 3)
            {
                label3.Text = "DRAW!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //rock
            int button1 = 1;
            Random rand = new Random();
            int randomNumber = rand.Next(1,4);
            selection(randomNumber, button1);
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            //paper
            int button2 = 2;
            Random rand = new Random();
            int randomNumber = rand.Next(1,4);
            selection(randomNumber, button2);
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            //scissors
            int button3 = 3;
            Random rand = new Random();
            int randomNumber = rand.Next(1,4);
            selection(randomNumber, button3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
