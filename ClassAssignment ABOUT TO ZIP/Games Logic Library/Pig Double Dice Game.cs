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
    public static class Pig_Double_Dice_Game {
        private static Die[] dice = new Die[2];
        private static int[] faceValue = { 0, 0 };
        private static string[] playersName = { "Player 1", "Player 2" };
        public static int current_player = 1;
        public static int[] pointsTotal = { 0, 0 };
        private static int player1_turn_points = 0;
        public static int overall_points = 0;
        private static int player2_turn_points = 0;
        private static int points1;
        private static int points2;
        public static int did_roll_one = 0;
        public const int NUM_OF_PLAYERS = 2;
        private static int double_ones = 25;
        private static int double_dice = 2;
        private static int goal = 100;


        /// <summary>
        /// Set everything to 0(except current_player), also used to Reset.
        /// </summary>
        public static void SetUpGame() {
            dice[0] = new Die();
            dice[1] = new Die();
            pointsTotal[0] = 0;
            pointsTotal[1] = 0;
            current_player = 1;
            player1_turn_points = 0;
            player2_turn_points = 0;
            overall_points = 0;
            did_roll_one = 0;
        }//end of SetUpGame


        /// <summary>
        /// Roll dice, gets faceValues, gets overall_points, gets turn points.
        /// </summary>
        /// <returns>true or false</returns>
        public static bool PlayGame() {
            //Player 1's turn.
            if (current_player == 1) {
                dice[0].RollDie();
                dice[1].RollDie();
                faceValue[0] = dice[0].GetFaceValue();
                faceValue[1] = dice[1].GetFaceValue();
                player1_turn_points += faceValue[0] + faceValue[1];
                overall_points = pointsTotal[0] + player1_turn_points;
                //If one of the dice is a 1..
                if ((faceValue[0] == 1 && faceValue[1] != 1) || (faceValue[1] == 1 && faceValue[0] != 1)) {
                    overall_points = pointsTotal[0];
                    player1_turn_points = 0;
                    did_roll_one = 1;
                    return true;
                    //If both dice are 1..
                }else if(faceValue[0] == 1 && faceValue[1] == 1){

                    //Take away 2 to only add 25 to points, not 27.
                    player1_turn_points += double_ones - 2;
                    overall_points = pointsTotal[0] + player1_turn_points;
                    return true;

                    //If both dice have equal faceValues..
                }else if (faceValue[0] == faceValue[1]) {
                    //After doubling the added faceValues, take away each faceValue.
                    player1_turn_points = player1_turn_points + ((faceValue[0] + faceValue[1]) * double_dice) - (faceValue[0] + faceValue[1]);
                    overall_points = pointsTotal[0] + player1_turn_points;
                    return true;
                }else {
                    did_roll_one = 0;
                    return false;
                }
            }
            //Player 2's turn
            if (current_player == 2) {
                dice[0].RollDie();
                dice[1].RollDie();
                faceValue[0] = dice[0].GetFaceValue();
                faceValue[1] = dice[1].GetFaceValue();
                player2_turn_points += faceValue[0] + faceValue[1];
                overall_points = pointsTotal[1] + player2_turn_points;

                //If one of the dice is a 1..
                if ((faceValue[0] == 1 && faceValue[1] != 1) || (faceValue[1] == 1 && faceValue[0] != 1)) {
                    overall_points = pointsTotal[1];
                    player2_turn_points = 0;
                    did_roll_one = 1;
                    return true;

                    //If both dice are 1..
                } else if (faceValue[0] == 1 && faceValue[1] == 1) {
                    //Take away 2 to only add 25 to points, not 27.
                    player2_turn_points += double_ones - 2;
                    overall_points = pointsTotal[1] + player2_turn_points;
                    return true;

                    //If both dice have equal faceValues..
                } else if (faceValue[0] == faceValue[1]) {
                    //After doubling the added faceValues, take away each faceValue.
                    player2_turn_points = player2_turn_points + ((faceValue[0] + faceValue[1]) * double_dice) - (faceValue[0] + faceValue[1]);
                    overall_points = pointsTotal[1] + player2_turn_points;
                    return true;
                }else{
                    did_roll_one = 0;
                    return false;
                }
            } else {
                did_roll_one = 0;
                return false;
            }
           }//end of PlayGame


        /// <summary>
        /// Returns true if a player has won.
        /// </summary>
        /// <returns>true or false</returns>
        public static bool HasWon() {

            if (player1_turn_points >= goal || overall_points >= goal) {
                return true;
            }
            if (player2_turn_points >= goal || overall_points >= goal) {
                return true;
            } else {
                return false;
            }
        }//end of HasWon


        /// <summary>
        /// Gets "Player 1" string.
        /// </summary>
        /// <returns>string of playersName</returns>
        public static string GetFirstPlayersName() {
            return playersName[0];
        }//end of GetFirstPlayersName

        /// <summary>
        /// Gets "Player 2" string.
        /// </summary>
        /// <returns>string of playersName</returns>
        public static string GetNextPlayersName() {
            return playersName[1];
        }//end of GetNextPlayersName


        /// <summary>
        /// Gets the pointsTotal for a specific player.
        /// </summary>
        /// <returns>int points1/points2</returns>
        public static int GetPointsTotal() {
            if (current_player == 1) {
                pointsTotal[0] += player1_turn_points;
                points1 = pointsTotal[0];
                player1_turn_points = 0;
                return points1;
            }

            if (current_player == 2) {
                pointsTotal[1] += player2_turn_points;
                points2 = pointsTotal[1];
                player2_turn_points = 0;
                return points2;
            }
            return 0;

        }//end of GetPointsTotal


        /// <summary>
        /// Gets facevalues.
        /// </summary>
        /// <returns>faceValue</returns>
        public static int GetFaceValue(int whichDie) {
            return dice[whichDie].GetFaceValue();

        }
    }
}
