using System;
using System.Drawing;

namespace pokerGame
{
    class ImageSetter
    {
        //determines face value for Diamond suit
        public Bitmap getDiamonds(String face)
        {
            Bitmap address = null;

            switch (face)
            {
                case "Ace": address = HW4ChristensenJakob.Properties.Resources.AD; break;
                case "Two": address = HW4ChristensenJakob.Properties.Resources._2D; break;
                case "Three": address = HW4ChristensenJakob.Properties.Resources._3D; break;
                case "Four": address = HW4ChristensenJakob.Properties.Resources._4D; break;
                case "Five": address = HW4ChristensenJakob.Properties.Resources._5D; break;
                case "Six": address = HW4ChristensenJakob.Properties.Resources._6D; break;
                case "Seven": address = HW4ChristensenJakob.Properties.Resources._7D; break;
                case "Eight": address = HW4ChristensenJakob.Properties.Resources._8D; break;
                case "Nine": address = HW4ChristensenJakob.Properties.Resources._9D; break;
                case "Ten": address = HW4ChristensenJakob.Properties.Resources._10D; break;
                case "Jack": address = HW4ChristensenJakob.Properties.Resources.JD; break;
                case "Queen": address = HW4ChristensenJakob.Properties.Resources.QD; break;
                case "King": address = HW4ChristensenJakob.Properties.Resources.KD; break;
            }

            return address;
        }

        //determines face value for heart suit
        public Bitmap getHearts(String face)
        {
            Bitmap address = null;

            switch (face)
            {
                case "Ace": address = HW4ChristensenJakob.Properties.Resources.AH; break;
                case "Two": address = HW4ChristensenJakob.Properties.Resources._2H; break;
                case "Three": address = HW4ChristensenJakob.Properties.Resources._3H; break;
                case "Four": address = HW4ChristensenJakob.Properties.Resources._4H; break;
                case "Five": address = HW4ChristensenJakob.Properties.Resources._5H; break;
                case "Six": address = HW4ChristensenJakob.Properties.Resources._6H; break;
                case "Seven": address = HW4ChristensenJakob.Properties.Resources._7H; break;
                case "Eight": address = HW4ChristensenJakob.Properties.Resources._8H; break;
                case "Nine": address = HW4ChristensenJakob.Properties.Resources._9H; break;
                case "Ten": address = HW4ChristensenJakob.Properties.Resources._10H; break;
                case "Jack": address = HW4ChristensenJakob.Properties.Resources.JH; break;
                case "Queen": address = HW4ChristensenJakob.Properties.Resources.QH; break;
                case "King":
                    address = HW4ChristensenJakob.Properties.Resources.KH
; break;
            }

            return address;
        }

        //determines face value for spades suit
        public Bitmap getSpades(String face)
        {
            Bitmap address = null;

            switch (face)
            {
                case "Ace": address = HW4ChristensenJakob.Properties.Resources.AS; break;
                case "Two": address = HW4ChristensenJakob.Properties.Resources._2S; break;
                case "Three": address = HW4ChristensenJakob.Properties.Resources._3S; break;
                case "Four": address = HW4ChristensenJakob.Properties.Resources._4S; break;
                case "Five": address = HW4ChristensenJakob.Properties.Resources._5S; break;
                case "Six": address = HW4ChristensenJakob.Properties.Resources._6S; break;
                case "Seven": address = HW4ChristensenJakob.Properties.Resources._7S; break;
                case "Eight": address = HW4ChristensenJakob.Properties.Resources._8S; break;
                case "Nine": address = HW4ChristensenJakob.Properties.Resources._9S; break;
                case "Ten": address = HW4ChristensenJakob.Properties.Resources._10S; break;
                case "Jack": address = HW4ChristensenJakob.Properties.Resources.JS; break;
                case "Queen": address = HW4ChristensenJakob.Properties.Resources.QS; break;
                case "King": address = HW4ChristensenJakob.Properties.Resources.KS; break;
            }

            return address;
        }

        //determines face value for clubs suit
        public Bitmap getClubs(String face)
        {
            Bitmap address = null;

            switch (face)
            {
                case "Ace": address = HW4ChristensenJakob.Properties.Resources.AC; break;
                case "Two": address = HW4ChristensenJakob.Properties.Resources._2C; break;
                case "Three": address = HW4ChristensenJakob.Properties.Resources._3C; break;
                case "Four": address = HW4ChristensenJakob.Properties.Resources._4C; break;
                case "Five": address = HW4ChristensenJakob.Properties.Resources._5C; break;
                case "Six": address = HW4ChristensenJakob.Properties.Resources._6C; break;
                case "Seven": address = HW4ChristensenJakob.Properties.Resources._7C; break;
                case "Eight": address = HW4ChristensenJakob.Properties.Resources._8C; break;
                case "Nine": address = HW4ChristensenJakob.Properties.Resources._9C; break;
                case "Ten": address = HW4ChristensenJakob.Properties.Resources._10C; break;
                case "Jack": address = HW4ChristensenJakob.Properties.Resources.JC; break;
                case "Queen": address = HW4ChristensenJakob.Properties.Resources.QC; break;
                case "King": address = HW4ChristensenJakob.Properties.Resources.KC; break;
            }

            return address;
        }
    }
}
