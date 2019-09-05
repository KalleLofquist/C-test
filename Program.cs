using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            *   Variabler som sparar värdena för hur mycket priset är och hur mycket som betalts.
            */
            int price;
            int pay;

            /*
            *   Kod för att ta reda på hur mycket priset är och vad som betalas.
            *   Värdena sparas i variablerna.
            */
            Console.WriteLine("How much is the cost?");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine("How much do you pay?");
            pay = int.Parse(Console.ReadLine());

            /*
            *   If-sats som kontrollerar ifall betalningen inte räcker till.
            *   Skriver i så fall ut ett felmeddelande i konsolen.
            */
            if (pay < price)
            {
                Console.WriteLine("You didn't pay enough!");
            }

            /*
            *   Else if-sats som kontrollerar ifall priset och betalningen är lika.
            *   Skriver i så fall ut ett meddelande i konsolen.
            */
            else if (pay == price)
            {
                Console.WriteLine("Even money! I like that. ;)");
            }

            /*
            *   Else-sats som skriver ut ett meddelande om hur mycket kunden ska få tillbaka i växel i konsolen.
            */
            else
            {
                decimal change = pay - price;
                Console.WriteLine("You'll get " + (change) + "kr back.");
                Console.WriteLine("That is ");

                /*
                *   If-sats som kontrollerar om växeln är delbar med 500 och i så fall hur många sedlar av denna valör
                *   kunden ska få tillbaka.
                */
                if ((change / 500) >= 1)
                {
                    decimal nrOf500 = change / 500;
                    nrOf500 = Math.Floor(nrOf500);
                    Console.WriteLine(nrOf500 + " bill(s) worth 500kr");
                    change = change - (nrOf500 * 500);
                }

                /*
                *   If-sats som kontrollerar om växeln är delbar med 100 och i så fall hur många sedlar av denna valör
                *   kunden ska få tillbaka.
                */
                if ((change / 100) >= 1)
                {
                    decimal nrOf100 = change / 100;
                    nrOf100 = Math.Floor(nrOf100);
                    Console.WriteLine(nrOf100 + " bill(s) worth 100kr");
                    change = change - (nrOf100 * 100);
                }

                /*
                *   If-sats som kontrollerar om växeln är delbar med 50 och i så fall hur många sedlar av denna valör
                *   kunden ska få tillbaka.
                */
                if ((change / 50) >= 1)
                {
                    decimal nrOf50 = change / 50;
                    nrOf50 = Math.Floor(nrOf50);
                    Console.WriteLine(nrOf50 + " bill(s) worth 50kr");
                    change = change - (nrOf50 * 50);
                }

                /*
                *   If-sats som kontrollerar om växeln är delbar med 20 och i så fall hur många sedlar av denna valör
                *   kunden ska få tillbaka.
                */
                if ((change / 20) >= 1)
                {
                    decimal nrOf20 = change / 20;
                    nrOf20 = Math.Floor(nrOf20);
                    Console.WriteLine(nrOf20 + " bill(s) worth 20kr");
                    change = change - (nrOf20 * 20);
                }

                /*
                *   If-sats som kontrollerar om växeln är delbar med 10 och i så fall hur många mynt av denna valör
                *   kunden ska få tillbaka.
                */
                if ((change / 10) >= 1)
                {
                    decimal nrOf10 = change / 10;
                    nrOf10 = Math.Floor(nrOf10);
                    Console.WriteLine(nrOf10 + " coin(s) worth 10kr");
                    change = change - (nrOf10 * 10);
                }

                /*
                *   If-sats som kontrollerar om växeln är delbar med 5 och i så fall hur många mynt av denna valör
                *   kunden ska få tillbaka.
                */
                if ((change / 5) >= 1)
                {
                    decimal nrOf5 = change / 5;
                    nrOf5 = Math.Floor(nrOf5);
                    Console.WriteLine(nrOf5 + " coin(s) worth 5kr");
                    change = change - (nrOf5 * 5);
                }

                /*
                *   If-sats som kontrollerar om växeln är delbar med 1 och i så fall hur många mynt av denna valör
                *   kunden ska få tillbaka.
                */
                if ((change / 1) >= 1)
                {
                    decimal nrOf1 = change / 1;
                    nrOf1 = Math.Floor(nrOf1);
                    Console.WriteLine(nrOf1 + " coin(s) worth 1kr");
                    change = change - (nrOf1 * 1);
                }
            }

            /*
            *   Kod för att indikera att programmet har nått sitt slut.
            */
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);

        }
    }
}
