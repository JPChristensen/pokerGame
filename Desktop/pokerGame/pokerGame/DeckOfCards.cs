using System;


namespace pokerGame
{
    class DeckOfCards
    {
        //random generator rng = random number generator
        private static Random rng = new Random();

        private const int NumberOfCards = 52; //deck of cards 
        private Card[] deck = new Card[NumberOfCards]; //array of randomly generated cards
        private int currentCard = 0; //determines the index of the current card in the deck

        //Constructor fills deck of Cards
        public DeckOfCards()
        {
            String[] faces = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            String[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };

            //populate deck with Card Objects
            for (int count = 0; count < deck.Length; count++)
            {
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
            }

        

        } // End Constructor

        //Shuffles the DeckOfCards
        public void Shuffle()
        {
            
            currentCard = 0;

            //for each Card, pick another random card and swap them
            for (int first = 0; first < deck.Length; first++)
            {
                //Selects a Random Number between 0 and 51
                var second = rng.Next(NumberOfCards);

                //swap
                Card temp = deck[second];
                deck[second] = deck[first];
                deck[first] = temp;
            }

           
                
         } // Ends shuffle method

        //deals cards to hands
        public Card DealCard()
        {
            if (currentCard < deck.Length)
            {
                return deck[currentCard++]; //return current card in array
            }
            else
            {
                return null; //indicates that all cards were dealt
            }
        }

        //checks if there is a pair, two pair, three of a kind, four of a kind, or a full house
        public String hasPair(Card[] card)
        {
            int hasP = 0;
            String typeOfPair = null;

            for (int i = 0; i < card.Length - 1; i++)
            {
                String compare = card[i].getFace();

                for (int j = i + 1; j < card.Length; j++)
                {
                    if (compare == card[j].getFace())
                    {
                        hasP++;
                    }
                } // End J for loop
            } // End I for loop


            if (hasP > 0)
            {
                switch(hasP)
                {
                    case 1: typeOfPair = "Pair"; break;
                    case 2: typeOfPair = "Two Pair"; break;
                    case 3: typeOfPair = "Three of a Kind"; break;
                    case 4: typeOfPair = "Full House"; break;
                    default: typeOfPair = "Four of a Kind"; break;

                }
            }

            return typeOfPair;

        } //Ends hasPair()

        //checks if there is a flush
        public String hasFlush(Card[] card)
        {
            String value = card[0].getSuit();
            int isFlush = 0;
            String stringValue = null;

            for (int i = 1; i < card.Length; i++)
            {
                if (value == card[i].getSuit())
                {
                    isFlush++;
                }
            }

            if (isFlush == 4)
            {
                stringValue = "Flush";
            }
            return stringValue;
        }

        //checks if there is a straight
        public String hasStraight(Card[] card)
        {
            String isStraight = null;
            int[] arrayOfFaces = new int[card.Length];
            int value = 0;
            int count = 0;

            //generates an array of integers using the faces of card array
            for(int i = 0; i < card.Length; i++)
            {
                arrayOfFaces[i] = turnFaceToInt(card[i].getFace());
            }

            //checks if the 5 cards are increamental face values
            value = arrayOfFaces[0];
            for (int i = 0; i < arrayOfFaces.Length; i++)
            {   
                if((value + i ) == arrayOfFaces[i])
                {
                    count++;
                }
            }
            //if count is 5, then the hand is a straight
            if (count == 5)
            {
                isStraight = "Straight";
            }

            return isStraight;
        }

        //turns face value to an integer using a switch
        private int turnFaceToInt(String value)
        {
            int amount = 0;

            switch(value)
            {
                case "Ace": amount = 1; break;
                case "Two": amount = 2; break;
                case "Three": amount = 3; break;
                case "Four": amount = 4; break;
                case "Five": amount = 5; break;
                case "Six": amount = 6; break;
                case "Seven": amount = 7; break;
                case "Eight": amount = 8; break;
                case "Nine": amount = 9; break;
                case "Ten": amount = 10; break;
                case "Jack": amount = 11; break;
                case "Queen": amount = 12; break;
                case "King": amount = 13; break;
            }

            return amount;
        }

        //sorts the generated integer array from turnFaceToInt(string)
        private void sortArray(int[] aArray)
        {
            //sorts the array from least to greatest
            for (int i = 0; i < aArray.Length; i++)
            {
                int lowest = aArray[i];

                for (int j = 0; j < aArray.Length; j++)
                {
                    if (lowest > aArray[j])
                    {
                        lowest = aArray[j];
                        ;
                    }

                } //ends j loop
            } //ends i loop
        }

    } // ends class

} // ends namespace
