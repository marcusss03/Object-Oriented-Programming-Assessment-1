using CMP1903M_A01_2223;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        // This class is used to test that pack population, shuffles, and the deal are all somewhat working

        // Removed the need to press enter all the time to deal a new card, instead it now deals the specified amount all at once (as suggested in a review).
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to initialize pack of cards...");
            Console.ReadLine();

            Console.WriteLine("Would you like to shuffle? 'y' for yes, 'n' for no.");
            String userShuffle = Console.ReadLine();

            if(userShuffle == "y")
            {
                Console.WriteLine("Input 1 - Fisher Yates Shuffle, 2 - Riffle Shuffle");
                int shuffleType = Convert.ToInt32(Console.ReadLine());

                if(shuffleType >= 1 && shuffleType <= 2)
                {
                    Console.WriteLine("Pack Shuffled Successfully... Dealing a Card");

                    Pack.shuffleCardPack(shuffleType);
                    Card dealedCard = Pack.deal();

                    Console.WriteLine(dealedCard.Value + " of " + dealedCard.Suit); // Returns the card in a format the user can understand
                    
                }
                else
                {
                    Console.WriteLine("No Shuffle.. Dealing a Card");
                    Console.ReadLine();

                    Pack.shuffleCardPack(3);
                    Card dealedCard = Pack.deal();

                    Console.WriteLine(dealedCard.Value + " of " + dealedCard.Suit); // Returns the card in a format the user can understand
                    
                }
            }
            else
            {
                Main(args);
            }

            Console.WriteLine("How many more cards would you like to deal?"); // Allows users to deal a specified amount of cards
            int amountOfDeals = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i < amountOfDeals; i++) // For loop that deals cards until the 'i' int reaches the value inputted by user
            {
                //Console.WriteLine("Press Enter For Next Card...");
                
                Card dealCard = Pack.deal();
                Console.WriteLine(dealCard.Value + " of " + dealCard.Suit); // Returns the card in a format the user can understand
                
            }
            Console.ReadLine();
        }
    }
}
