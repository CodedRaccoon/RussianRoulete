using System;
using System.Windows.Forms;

namespace RussianRoulete
{
    public partial class Form1 : Form
    {

        public int CursedBookNum;

        Build myBuild = new Build();

        //private int CursedBookNum, BurnedBook, Counter;
        //public bool Opening, Burning, Restart;

        public Form1()
        {
            InitializeComponent();
        }


        //Book Buttons all link to BtnAllBook

        public void BtnAllBook_Click(object sender, EventArgs e) //create a fake book button
        {
            myBuild.MainGame(sender, this, CursedBookNum);
        }


        // Curse button to start game
        public void btnGo_Click(object sender, EventArgs e)
        {

            CurseMethod();
            myBuild.Curse(sender);
            // to test random generator delete comment below.
            //MessageBox.Show(Convert.ToString(CursedBookNum)); 
        }

        // Curse method for unit testing
        public int CurseMethod()
        {
            var rand = new Random();
            CursedBookNum = rand.Next(1, 6);

            return CursedBookNum;
        }

        // Button to open book
        public void btnOpen_Click(object sender, EventArgs e)
        {
            myBuild.OpenClick(sender);
        }
        // Button to restart program
        public void btnRestart_Click(object sender, EventArgs e)
        {
            myBuild.RestartProgram(sender);
        }

       // Button to burn book
        public void btnBurn_Click(object sender, EventArgs e)
        {
            
            myBuild.BurnClick(sender);
        }

       
    }
}


