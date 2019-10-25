using System;
using Skat;

namespace Skat
{
    public class Afgift
    {

        public static int BilAfgift(int pris) //Jeg bruger if-statement til at udregne min priser og afgifter for BilAfgift
        {
            double BilAfgift = 0;

            if (pris < 0) //her fortæller jeg, hvis prisen er 0 eller under, så retunere argumentException
            {
                throw new ArgumentException("Prisen må ikke være under 0"); //hvis prisen er under 0, så throw argumentexception
            }

           
            if(pris <= 200000)//her fortæller hvis prisen er under eller <= så regn det med 85%
            {
                BilAfgift = pris * 0.85;  //hvis prisen er = eller under, så skal den regne med 85%
            }
            else
            {
                BilAfgift = pris * 1.5; // hvis prisen er større end 200k så ganger vi med 150% og trækker 130k fra.
                BilAfgift -= 130000;
                
            }
            return (int)BilAfgift;


        }
        
        public static int ElbilAfgift(int pris)
        {
            double ElbilAfgift = BilAfgift(pris) * 0.20; //for at lave ElBilAgiften, så henter jeg bare prisen fra BilAfgiften istedet for lave det forfra
            return (int)ElbilAfgift;
        }

        
    }
}
