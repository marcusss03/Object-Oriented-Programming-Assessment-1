using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    static class Pack
    {
        private static Card[] pack;

        const int packSize = 52;

        static int amountOfDeals = 0;

        public static Card[] PopulatePack()
        {
            // A function for creating a pack of 52 cards
            // Creates 13 cards for 4 different suits

            pack = new Card[packSize]; 
            int currentCardValue = 0;
            int currentSuit = 0;

            while (currentSuit <= 3 )
            {
                for (int i = 1; i <= 13; i++)
                {
                    
                    pack[currentCardValue] = new Card(i, currentSuit);
                    
                  
                    if (currentCardValue == 52)
                    {
                        return pack;
                    }
                    currentCardValue++;
                }
                currentSuit++;
            }

            return pack;
        }
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle the user has inputted

            if(typeOfShuffle == 1) // Fisher-Yates Shuffle
            {
                Random random = new Random();

                pack = PopulatePack();

                // A for loop that shuffles 52 times to ensure every card has been moved in the pack
                for (int shuffleAmount = 0; shuffleAmount < 52; shuffleAmount++)
                {

                    for (int i = 0; i < packSize; i++)
                    {
                        int newPos = i + random.Next(52 - i); // Finds a random position in the card array and stores this as the new position
                        Card newPosCard = pack[newPos];
                        pack[newPos] = pack[i];
                        pack[i] = newPosCard;
                    }
                }

                return true;
            }
            else if (typeOfShuffle == 2) // Riffle Shuffle
            {
                pack = PopulatePack(); // Initializes the pack

                Card[] firstHalf = pack.Take(pack.Length / 2).ToArray(); // This takes the first half of the pack of cards and stores it into an array
                Card[] secondHalf = pack.Skip(pack.Length / 2).ToArray(); // This stores the second half into an array

                for (int i = 0; i < (pack.Length / 2); i+= 2)
                {
                    // Merges the two split decks back into each other

                    pack[i] = firstHalf[i];
                    pack[i+1] = secondHalf[i];

                }

                return true;
            }
            else // No Shuffle
            {
                // Returns the base pack in order

                pack = PopulatePack();
                return false;
            }
            
        }
       public static Card deal()
       {
            // Deals one card to begin, then asks user for input to deal a certain amount of cards

            int deals = amountOfDeals;
            amountOfDeals++;
            return pack[deals];
        }
    }
}
