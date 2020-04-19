using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulete
{
    public partial class Form1 : Form
    {
       

        //
        //
        //
        private int CursedBookNum, BurnedBook, Counter;
        public bool Opening, Burning, Restart;

        //TODO 








        public Form1()
        {
            InitializeComponent();
       

            
            
        }


        public void BtnAllBook_Click(object sender, EventArgs e) //create a fake book button
        {
            Button FakeButton = (Button)sender;
            int BookButtonNum = Convert.ToInt32(FakeButton.Text);
           
            if (Opening == true)
            {

                if (BookButtonNum == CursedBookNum)
                {
                    MessageBox.Show("You're CURSED, Game Over.. Game Restarting");

                    Application.Restart();
                    Environment.Exit(0);


                }
                else
                {

                    MessageBox.Show("You're Safe... For now...");

                }
            }
            else if(Burning == true)
            {


                if (BookButtonNum == CursedBookNum)
                {
                    MessageBox.Show("You Have defeated the curse, Congrats! Restarting Game");

                    Application.Restart();
                    Environment.Exit(0);

                }
                else
                {

                    MessageBox.Show("This book isn't cursed and is now burned!");
                    FakeButton.Enabled = false;
                    Counter -= 1;
                    lblCounter.Text = Convert.ToString(Counter);
                    if (Counter == 0) 
                    {

                        MessageBox.Show("OH NO, Your lighter has ran out of gas! I guess there is only 1 option");
                        btnRestart.Visible = false;
                        btnBurn.Visible = false;
                        btnOpen.PerformClick();
                        
                    
                    }
                        
                }
            }
        }

        

        public void btnGo_Click(object sender, EventArgs e)
        {
            Counter = 2;
            //  
            var rand = new Random();
            btnGo.Enabled = false;
            btnGo.BackColor = Color.DimGray;
            //
            CursedBookNum = rand.Next(1, 6);
            
            // to test random generator delete comment below.
            //MessageBox.Show(Convert.ToString(CursedBookNum)); 
        }

        public void btnOpen_Click(object sender, EventArgs e)
        {
            Opening = true;
            Burning = false;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            
            Application.Restart();
            Environment.Exit(0);
        }

       
        public void btnBurn_Click(object sender, EventArgs e)
        {
            Opening = false;
            Burning = true;
        }
    }
}


//blah blah