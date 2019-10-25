using Microsoft.VisualStudio.TestTools.UnitTesting;
using Skat;
using System;

namespace SkatTestUni
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BilafgiftUnder200000() // tester det i unitest for at se om opgaverne virker eller om der fejl.
        {
            //arrange
            int pris = 150000; //giver prisen for bilens afgift for biler under 200k
            int expected = 127500; //her har jeg regnet prisen ud som er under 200k. 150k * 0,85 = 127500.

            //Act

            int actual = Skat.Afgift.BilAfgift(pris);

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void BilAfgiftOver200000()
        {
            //arrange
            int pris = 250000; // giver prisen for bilens afgift for biler over 200k.
            int expected = 245000; //eller int expected = (pris * 1.50)-130000; || 250k * 1,5% - 130k = 245000;
            //act
            int actual = Skat.Afgift.BilAfgift(pris);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BilAfgiftUnder0()
        {
            //arrange
            int pris = -1000; //giver pris -1k

            //act
           try
            {
                Afgift.BilAfgift(pris); //her vil jeg prøve at regne noget negativ tal ud, hvis prisen er under 0 eller minus tal.
                                        // så vil den fortælle mig "prisen må ikke være under 0";
            }
           catch(ArgumentException e)
            {
                //Assert
                Assert.AreEqual("Prisen må ikke være under 0", e.Message);
            }
            
        }


        [TestMethod]
        public void ElBilAfgiftUnder200000() //regner afgifterne af elbiler ud her.
        {
            //arrange
            int pris = 150000; // giver min el bil pris 150k
            int expected = 25500;  //150k*0,85*0,20 = 25500;

            //Act

            int actual = Skat.Afgift.ElbilAfgift(pris);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ElBilAfgiftOver200000()
        {
            //arrange
            int pris = 250000;
            int expected = 49000; //25.000*1,5=375000-130000=245000*0.20;
            //act
            int actual = Skat.Afgift.ElbilAfgift(pris);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ElBilAfgiftUnder0() // her prøver jeg at give bilafgiften en negativ tal og så skal den fortælle "prisen må ikke være under 0";
        {
            //arrange
            int pris = -1000; //giver prisen en negativ tal og ser om det virker med det message jeg har givet.

            //act
            try
            {
                Afgift.ElbilAfgift(pris);
            }
            catch (ArgumentException e)
            {
                //Assert
                Assert.AreEqual("Prisen må ikke være under 0", e.Message); //skal uskrive det message, hvis prisen er negativ.
            }

        }
    }
}
