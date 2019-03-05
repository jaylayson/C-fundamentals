using System;



namespace Gold_Lotto_Checker {
    /// <summary>
    /// 
    /// This is a program that simulates multiple games
    /// of lotto draws. This program checks the values
    /// of the user's chosen numbers in each game(lottoNumbers)
    /// and compares it with the draw which will output 
    /// the amount of winning numbers and supplementary
    /// numbers are won.
    /// 
    /// Author John Layson
    /// Student Number: 09823239 APRIL 2017
    /// 
    /// </summary>
    class Program {

        static void Main() {

            int[,] lottoNumbers ={
                                  { 4, 7, 19, 23, 28, 36},
                                  {14, 18, 26, 34, 38, 45},
                                  { 8, 10,11, 19, 28, 30},
                                  {15, 17, 19, 24, 43, 44},
                                  {10, 27, 29, 30, 32, 41},
                                  { 9, 13, 26, 32, 37,  43},
                                  { 1, 3, 25, 27, 35, 41},
                                  { 7, 9, 17, 26, 28, 44},
                                  {17, 18, 20, 28, 33, 38}
                              };

            int[] drawNumbers = new int[] { 44, 9, 17, 43, 26, 7, 28, 19 };

            ShowGameNumbers(lottoNumbers);
            ShowDraw(drawNumbers);

            CheckGameScores(lottoNumbers, drawNumbers);

            ThankYou();
            ExitProgram();
        }//end Main


        /// <summary>
        /// 
        /// Shows the exit message and prompts the user
        /// to press any key to exit.
        /// 
        /// </summary>
        static void ExitProgram() {
            Console.Write("\n\nPress any key to exit program: ");
            Console.ReadKey();
        }//end ExitProgram


        /// <summary>
        /// 
        /// This method has the parameter lottoNumbers to be 
        /// able to access the values specified in it from Main().
        /// It also goes through each row and column and prints
        /// out the values of each Game with Console.Write().
        /// 
        /// </summary>
        /// <param name="lottoNumbers"></param>
        static void ShowGameNumbers(int[,] lottoNumbers) {
            Console.WriteLine("Your Lotto numbers are: ");
            for (int game = 0; game < lottoNumbers.GetLength(0); game++) {
                Console.Write("\n Game {0}: ", game + 1);
                for (int column = 0; column < lottoNumbers.GetLength(1); column++) {
                    Console.Write("\t{0} ", lottoNumbers[game, column]);
                }
                Console.WriteLine();
            }
        }//end ShowGameNumbers


        /// <summary>
        /// 
        /// This method has the parameter drawNumbers to be
        /// able to access the values specified in it from Main().
        /// It also goes through each value and prints them out
        /// using Console.Write().
        /// 
        /// </summary>
        /// <param name="drawNumbers"></param>
        static void ShowDraw(int[] drawNumbers) {
            Console.Write("\n Lotto Draw Numbers are: \n");
            for (int draw = 0; draw < drawNumbers.GetLength(0); draw++) {
                Console.Write("\t {0} ", drawNumbers[draw]);
            }
        }//end ShowDraw


        /// <summary>
        /// 
        /// This method searches and compares the values in
        /// lottoNumbers and drawNumbers accordingly based on
        /// the rows and columns of lottoNumbers.
        /// The parameter row was made to be able to specify
        /// which row to search in from Main().
        ///
        /// The while loop continues to run until the position
        /// is equal to the length of lottoNumbers and has not
        /// seen a match. The -1 is stated to make sure the index
        /// is not out of reach. It checks one value from drawNumbers
        /// for a match with each lottoNumber' column in the row specified.
        /// 
        /// The for loop returns the value in matchesWon
        /// with incrementation when the if statement condition is met.
        /// It also excludes the search of the last 2 values in the if
        /// statement by stating that the winning numbers are the values
        /// in position 0-5.
        /// 
        /// </summary>
        /// <param name="lottoNumbers"></param>
        /// <param name="drawNumbers"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        static int LinearSearch(int[,] lottoNumbers, int[] drawNumbers, int row) {
            int winningNumbers = 5;
            int matchesWon = 0;
            int columns = 1;
            for (int i = 0; i < drawNumbers.GetLength(0); i++) {
                int position = 0;
                while ((position < lottoNumbers.GetLength(columns) - 1) && (lottoNumbers[row, position] != drawNumbers[i])) {
                    position++;
                }
                if ((lottoNumbers[row, position]) == drawNumbers[i] && (i <= winningNumbers)) {
                    matchesWon++;
                }
            }
            return matchesWon;
        }//end LinearSearch


        /// <summary>
        /// 
        /// This method searches and compares the values in
        /// lottoNumbers and drawNumbers accordingly based on
        /// the rows and columns of lottoNumbers.
        /// The parameter row was made to be able to specify
        /// which row to search in from Main().
        ///
        /// The while loop continues to run until the position
        /// is equal to the length of lotto numbers and has not
        /// seen a match.  The -1 is stated to make sure the index
        /// is not out of reach. It checks one value from drawNumbers
        /// for a match with each lottoNumber' column in the row specified.
        /// 
        /// The for loop returns the value in supplementaryWon 
        /// with incrementation when the if statement condition is met.
        /// It also excludes the search of the first 6 values in the if
        /// statement by stating that the supplementary numbers are the
        /// values in position 6-7.
        /// 
        /// </summary>
        /// <param name="lottoNumbers"></param>
        /// <param name="drawNumbers"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        static int LinearSearch1(int[,] lottoNumbers, int[] drawNumbers, int row) {
            int supplementaryNumbers = 6;
            int supplementaryWon = 0;
            int columns = 1;
            for (int i = 0; i < drawNumbers.GetLength(0); i++) {
                int position = 0;
                while ((position < lottoNumbers.GetLength(columns) - 1) && (lottoNumbers[row, position] != drawNumbers[i])) {
                    position++;
                }
                if ((lottoNumbers[row, position]) == drawNumbers[i] && (i >= supplementaryNumbers)) {
                    supplementaryWon++;
                }
            }
            return supplementaryWon;
        }//end LinearSearch1


        /// <summary>
        /// 
        /// This method outputs the values in the parameters
        /// given such as, totalWins, totalSupplementaries
        /// and gameCount.
        /// 
        /// </summary>
        /// <param name="totalWins"></param>
        /// <param name="totalSupplementaries"></param>
        /// <param name="gameCount"></param>
        static void PrintOutcome(int totalWins, int totalSupplementaries, int gameCount) {
            Console.Write("\n \t Found {0} winning numbers and {1} supplementary numbers in Game {2} \n",
                totalWins, totalSupplementaries,
                gameCount);
        }//End PrintOutcome


        /// <summary>
        /// 
        /// This method takes the returned values in LinearSearch 
        /// and LinearSearch1 into new variables called totalWins 
        /// and totalSupplementaries. Which are then used to print
        /// the outcome. 
        /// gameNumber variable increment each time 
        /// the for loop as the gameNumber specifies which rows to
        /// check.
        /// gameCount variable also increment for the purpose of
        /// printing which game is checked.
        /// 
        /// </summary>
        /// <param name="lottoNumbers"></param>
        /// <param name="drawNumbers"></param>
        static void CheckGameScores(int[,] lottoNumbers, int[] drawNumbers) {
            int gameNumber = 0;
            int gameCount = 1;
            int results = 9;
            for (int i = 0; i < results; i++) {
                int totalWins;
                int totalSupplementaries;
                totalWins = LinearSearch(lottoNumbers, drawNumbers, gameNumber);
                totalSupplementaries = LinearSearch1(lottoNumbers, drawNumbers, gameNumber);
                PrintOutcome(totalWins, totalSupplementaries, gameCount);
                gameCount++;
                gameNumber++;
            }
        }



        static void ThankYou() {
            Console.WriteLine("\n Thank you for using Lotto Checker");
        }//end ThankYou

    }//end class
}
