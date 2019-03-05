using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {


    /// <summary>
    /// 
    /// Author: John Layson
    /// Student no. 09823239
    /// 
    /// </summary>
    public static class TwentyOneGame {
        private static CardPile cardPile;
        private static Hand[] hands = new Hand[2];
        private static int[] totalPoints = new int[2];
        private static int[] numOfGamesWon = new int[2];
        private static int numOfUserAcesWithValueOne;


        /// <summary>
        /// Sets up class variables.
        /// </summary>
        public static void SetUpGame() {
            cardPile = new CardPile(true);
            numOfGamesWon[0] = 0;
            numOfGamesWon[1] = 0;
            cardPile.Shuffle();
        }//end of SetUpGame


        /// <summary>
        /// Deals a card to a specific hand(dealer/player)
        /// </summary>
        /// <param name="who"></param>
        /// <returns>Added card</returns>
        public static Card DealOneCardTo(int who) {
            ReplacementCards(1);
            Card deal = cardPile.DealOneCard();
            hands[who].Add(deal);
            return deal;
        }//end of DealOneCardTo


        /// <summary>
        /// Calculates each hand total.
        /// </summary>
        /// <param name="who"></param>
        /// <returns>Calculated int value of dealer/player.</returns>
        public static int CalculateHandTotal(int who) {
            totalPoints[who] = 0;
            foreach (Card card in hands[who]) {
                int cardValue = (int)card.GetFaceValue();
                if (cardValue == 12) {
                    totalPoints[who] += 11;
                } else if (cardValue > 7 && cardValue < 12) {
                    totalPoints[who] += 10;
                } else {
                    totalPoints[who] += (cardValue + 2);
                }//end of if statement
            }//end of for each loop
            if (who == 1) {
                totalPoints[who] -= (GetNumOfUserAcesWithValueOne()*10);
            }//end of if statement
            if (totalPoints[0] > 21) {
                numOfGamesWon[1] += 1;
            } else if (totalPoints[1] > 21) {
                numOfGamesWon[0] += 1;
            }//end of if statement

            return totalPoints[who];
        }//end of CalculateHandTotal


        /// <summary>
        /// Dealer plays.
        /// </summary>
        public static void PlayForDealer() {
            if ((GetTotalPoints(0) < GetTotalPoints(1) && GetTotalPoints(0) < 21) || GetTotalPoints(0) < 17) {
                DealOneCardTo(0);
                CalculateHandTotal(0);
            } else if (GetTotalPoints(0) < 22) {
                if (GetTotalPoints(0) > GetTotalPoints(1)) {
                    numOfGamesWon[0]++;
                } else if (GetTotalPoints(0) < GetTotalPoints(1)) {
                    numOfGamesWon[1]++;
                }
            }
        }//end of PlayForDealer


        /// <summary>
        /// Gets all the cards from a [who]'s hand(dealer/player).
        /// </summary>
        /// <param name="who"></param>
        /// <returns>cards list of dealer/player </returns>
        public static Hand GetHand(int who) {
            return hands[who];
        }//end of GetHand


        /// <summary>
        /// Gets totalPoints of [who](dealer/player).
        /// </summary>
        /// <param name="who"></param>
        /// <returns> totalPoints of dealer/player </returns>
        public static int GetTotalPoints(int who) {
            return totalPoints[who];
        }//end of GetTotalPoints


        /// <summary>
        /// Get the amount of games won of [who](dealer/player).
        /// </summary>
        /// <param name="who"></param>
        /// <returns> numOfGameswon of dealer/player</returns>
        public static int GetNumOfGamesWon(int who) {
            return numOfGamesWon[who];
        }//end of GetNumOfGamesWon


        /// <summary>
        /// Gets the amount of Aces that counts as One.
        /// </summary>
        /// <returns> numOfUserAcesWithValueOne </returns>
        public static int GetNumOfUserAcesWithValueOne() {
            return numOfUserAcesWithValueOne;
        }//end of GetNumOfUserAcesWithValueOne


        /// <summary>
        /// Adds one to the value of numOfUserAcesWIthValueOne.
        /// </summary>
        public static void IncrementNumOfUserAcesWithValueOne() {
            numOfUserAcesWithValueOne += 1;
        }//end of IncrementNumOfUserAces

        /// <summary>
        /// Resets variables.
        /// </summary>
        public static void ResetTotals() {
            ReplacementCards(4);
            hands[0] = new Hand(cardPile.DealCards(2));
            hands[1] = new Hand(cardPile.DealCards(2));
            totalPoints[0] = 0;
            totalPoints[1] = 0;
            numOfUserAcesWithValueOne = 0;

        }//end of ResetTotals


        /// <summary>
        /// Creates a new pile if there is not enough of needed cards. 
        /// Shuffles the newly created pile.
        /// </summary>
        /// <param name="needed">amount of cards needed in deck. </param>
        private static void ReplacementCards(int needed) {
            if(cardPile.GetCount() < needed) {
                cardPile = new CardPile(true);
                cardPile.Shuffle();
            }//end of if statement.
        }//end of Replacement Cards.
    }//end of class
}//end of namespace
