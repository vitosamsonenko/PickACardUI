using System;
using System.Collections.Generic;
using System.Text;

namespace PickACardUI
{
    class CardPicker
    {
        static Random random = new Random();
     
        /// <summary>
        /// Chooses random cards
        /// </summary>
        /// <param name="numberOfCards">The number of cards to pick randomly</param>
        /// <returns>An array of strings that contains the card names</returns>
        public static string[] PickSomeCards(int numberOfCards) 
        {
            string[] pickedCards = new string[numberOfCards];

            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }

            return pickedCards;
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);           
            switch (value)
            {
                case 1:
                    return "Spades";
                    
                case 2:
                    return "Hearts";
                
                case 3:
                    return "Clubs";
                

                default:
                    return "Diamonds";
                
            }
        }

        private static string RandomValue()
        {
            int value = random.Next(1,14);
            switch (value) 
            {
                case 1:
                    return "Ace";
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                default:
                    return value.ToString();
                
            }

        }
    }
}
