using System;

namespace MagicElements
{	
	public class Card
	{
			private int rank;
			private int suit;
			private bool face_up;
			
			public static readonly int DIAMONDS = 4;
			public static readonly int HEARTS = 3;
			public static readonly int SPADES = 6;
			public static readonly int CLUBS = 5;
			
			public static readonly int TWO = 2;
			public static readonly int THREE = 3;
			public static readonly int FOUR = 4;
			public static readonly int FIVE = 5;
			public static readonly int SIX = 6;
			public static readonly int SEVEN = 7;
			public static readonly int EIGHT = 8;
			public static readonly int NINE = 9;
			public static readonly int TEN = 10;
			public static readonly int JACK = 74;
			public static readonly int QUEEN = 81;
			public static readonly int KING = 75;
			public static readonly int ACE = 65;
			
			public Card(int suit, int rank)
			{
				
				this.suit = suit;
				this.rank = rank;
			}
			public int getSuit()
			{
				return suit;
			}
			public int getRank()
			{
				return rank;
			}
			public void faceUp()
			{
				face_up = true;
			}
			public void faceDown()
			{
			face_up = false;
		    }

		public bool isFaceUp()
		{
			return face_up;
		}

		public string display()
		{
			string display;
			if(rank > 10)
			{
				display = string.valueOf((char) rank);
			}
			else
			{
				display = string.valueOf(rank);
			}
			switch(suit)
			{
				case DIAMONDS:
					return display + String.valueOf((char) DIAMONDS);
				case HEARTS:
					return display + String.valueOf((char) HEARTS);
				case SPADES:
					return display + String.valueOf((char) SPADES);
				default:
					return display + String.valueOf((char) CLUBS);
			}
		}
	}


}
}
