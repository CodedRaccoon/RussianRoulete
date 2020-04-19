using RussianRoulete.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RussianRoulete
{
    class Build
    {  
        public int Counter;
        public bool Opening, Burning;

        
        public void MainGame(object sender, Form1 Form1, int CursedBookNum)
        {
            Form1 mainForm = new Form1();
            Button FakeButton = (Button)sender;
            int BookButtonNum = Convert.ToInt32(FakeButton.Text);
            
            
            if (Opening == true)
            {
                //if Book button = the cursed book it, you become cursed and lose.
                //else statement below for when you open the book and its safe.
                if (BookButtonNum == CursedBookNum)
                {
                    MessageBox.Show("You're CURSED! Game Over.. Game Restarting");

                    SoundPlayer LoseSound = new SoundPlayer(Resources.Laugh);
                    LoseSound.Play();

                    Application.Restart();
                    Environment.Exit(0);
                }
                else
                {

                    MessageBox.Show("You're Safe... For now...");
                    FakeButton.Enabled = false;
                }
            }
            else if (Burning == true)
            {

                // if statement for when you burn the cursed book you win and the game restarts.
                if (BookButtonNum == CursedBookNum)
                {
                    MessageBox.Show("You have defeated the curse, congratulations! Game restarting...");

                    Application.Restart();
                    Environment.Exit(0);

                } 
                else
                {
                    
                    MessageBox.Show("This book isn't cursed and is now burned!");
                    FakeButton.Enabled = false;
                    //Burn Counter
                    Counter -= 1;
                    if (Counter == 0)
                    {
                        /* If statement to restart game when you run out of burn attempts and also brings the message
                        up for when you lose the game. */
                        MessageBox.Show("OH NO! Your lighter has run out of gas! You can only be cursed now, you lose. Game restarting...");
                        Application.Restart();
                        Environment.Exit(0);
                    }

                }

            }


        }
        // Class for Curse that adds counter for how many burn book attempts and most importantly starts the game.
        public void Curse(object sender)
        {
            Form1 mainForm = new Form1();
            Counter = 2;
            //var rand = new Random();
            //CursedBookNum = rand.Next(1, 6);
        }
        
        // Class for Open button
        public void OpenClick(object sender)
        {
            Opening = true;
            Burning = false;
        }

        // Class for restart button
        public void RestartProgram(object sender)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        // Class for Burn Button
        public void BurnClick(object sender)
        {
            Opening = false;
            Burning = true;
        }
    }
}
