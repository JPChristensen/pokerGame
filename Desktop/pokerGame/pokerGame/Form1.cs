using System;
using System.Drawing;
using System.Windows.Forms;


namespace pokerGame
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private Card[] handOne = new Card[5]; // hand for player 1 randomly generated
        private Card[] handTwo = new Card[5]; // hand for player 2 randomly generated
        private DeckOfCards deck = new DeckOfCards(); //deck of cards
        private Bitmap[] handOneImage = new Bitmap[5]; //stores the address for images in handOne
        private Bitmap[] handTwoImage = new Bitmap[5]; //stores the address for images in handTwo

        //loads the page
        private void Main_Load(object sender, EventArgs e)
        {

        }

        //calls the necessary methods to generate the game
        private void generateButton_Click(object sender, EventArgs e)
        {
            deck.Shuffle();
            generateCardsOne();
            generateCardsTwo();
            setImagesOne();
            setImagesTwo();
            results();
        }

        //determines a winner by using rankHand(string) and displays it in resultLabel
        private void results()
        {
            resultLabel.Text = "";

            String rankOne = p1Result.Text;
            int rankOneValue = 0;
            String rankTwo = p2Result.Text;
            int rankTwoValue = 0;
            String winner = null;

            rankOneValue = rankHand(rankOne);

            rankTwoValue = rankHand(rankTwo);

            //Compares the ranks of handOne and handTwo to determine a victor
            if (rankOneValue == rankTwoValue)
            {
                winner = "No one";
            }
            else 
            {
                if (rankOneValue > rankTwoValue)
                    winner = "Player One";
                else
                    winner = "Player Two";
            }

            resultLabel.Text = winner;
        }

        //Ranks the hand
        private int rankHand(String value)
        {
            int rank = 0;
            switch (value)
            {
                case "Pair": rank = 1; break;
                case "Two Pair": rank = 2; break;
                case "Three of a Kind": rank = 3; break;
                case "Four of a Kind": rank = 4; break;
                case "Full House": rank = 5; break;
                case "Flush": rank = 6; break;
                case "Straight": rank = 7; break;
            }

            return rank;
        }

        //sets images for handOne using switch statements
        private void setImagesOne()
        {
            //holds the address for the image 
            Bitmap address = null;

            //sets the image depending on the suit 
            ImageSetter IS = new ImageSetter();

            //determines the suit and calls the corresponding methods from ImageSetter
            for (int i = 0; i < handOne.Length; i++)
            {
                switch (handOne[i].getSuit())
                {
                    case "Diamonds": address = IS.getDiamonds(handOne[i].getFace()); break;
                    case "Hearts": address = IS.getHearts(handOne[i].getFace()); break;
                    case "Spades": address = IS.getSpades(handOne[i].getFace()); break;
                    case "Clubs": address = IS.getClubs(handOne[i].getFace()); break;
                }

                handOneImage[i] = address;    
            }

            //sets images for picture box handOne(1-5).Image
            handOne1.Image = handOneImage[0];
            handOne2.Image = handOneImage[1];
            handOne3.Image = handOneImage[2];
            handOne4.Image = handOneImage[3];
            handOne5.Image = handOneImage[4]; 
        }

        //sets images for handTwo using switch statements
        private void setImagesTwo()
        {
            //holds address for images
            Bitmap address = null;
            //determines face value for suit called
            ImageSetter IS = new ImageSetter();

            //determines the suit and alls the corresponding method from ImageSetter
            for (int i = 0; i < handTwo.Length; i++)
            {
                switch (handTwo[i].getSuit())
                {
                    case "Diamonds": address = IS.getDiamonds(handTwo[i].getFace()); break;
                    case "Hearts": address = IS.getHearts(handTwo[i].getFace()); break;
                    case "Spades": address = IS.getSpades(handTwo[i].getFace()); break;
                    case "Clubs": address = IS.getClubs(handTwo[i].getFace()); break;
                }

                handTwoImage[i] = address;
            }

            //sets the image for picture box handTwo(1-5).Image
            handTwo1.Image = handTwoImage[0];
            handTwo2.Image = handTwoImage[1];
            handTwo3.Image = handTwoImage[2];
            handTwo4.Image = handTwoImage[3];
            handTwo5.Image = handTwoImage[4];
        }

        //generates the cards for handOne
        private void generateCardsOne()
        {
            //clears the text box for player one
            p1Result.Text = "";

            //deals cards
            for (int i = 0; i < handOne.Length; i++)
            {
                //deals card to hand one
                if (deck.DealCard() != null)
                {
                    handOne[i] = deck.DealCard();
                }
                else
                {
                    deck.Shuffle();
                }
            }

            String value = null;

            //Checks if handOne has a pair, two pair, three of a kind, four of a kind, or a full house
            value = deck.hasPair(handOne);
            if (value == null)
            {
                //if no pair found checks if there is a flush
                value = deck.hasFlush(handOne);

                if(value == null)
                {
                    //if no flush found, checks if there is a straight
                    value = deck.hasStraight(handOne);
                }
            }

            p1Result.Text = value;
        }

        //generates the cards for handTwo
        private void generateCardsTwo()
        {
            //clears text for p2Results
            p2Result.Text = "";

            //deals cards for handTwo
            for (int i = 0; i < handTwo.Length; i++)
            {
                //deals card to hand one
                if (deck.DealCard() != null)
                {
                    handTwo[i] = deck.DealCard();
                }
                else
                {
                    deck.Shuffle();
                }
            }

            String value = null;

            //Checks if handTwo has a pair, two pair, three of a kind, four of a kind, or a full house
            value = deck.hasPair(handTwo);

            if (value == null)
            {
                //if no pair found, checks for a flush
                value = deck.hasFlush(handTwo);

                if (value == null)
                {
                    //if no flush found checks if there is a straight
                    value = deck.hasStraight(handTwo);
                }
            }
            p2Result.Text = value;
        }

        //generates a new hand for handOne when new hand on TAB player one is pressed
        private void newHandOne_Click(object sender, EventArgs e)
        {
            //calls methods to generate new handOne
            generateCardsOne();
            setImagesOne();
        }

        //generates a new hand for handTwo when new hand on TAB player Two is pressed
        private void newHandTwo_Click(object sender, EventArgs e)
        {
            //calls methods to generate cards for handTwo
            generateCardsTwo();
            setImagesTwo();
        }
    }
}
