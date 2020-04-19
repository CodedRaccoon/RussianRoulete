using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianRoulete;

namespace UnitTestRR
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //RNG is my Random Number Generator.
        public void RNGtest()
        {
            // instantiate a new form and pass the form properties across

            Form1 myForm = new Form1();
            //run the method on the form and then pass the number to a variable for testing
            int CursedBookNum = myForm.CurseMethod();
            //is the number greater than 0 and less than 7?
            Assert.IsTrue((CursedBookNum > 0) && (CursedBookNum < 7));
        }
       
    }
}
