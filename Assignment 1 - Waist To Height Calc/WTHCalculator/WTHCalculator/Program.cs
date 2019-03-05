using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTHCalculator
{
    /// <summary>
    /// 
    /// Menu driven program which provides
    /// the choice of waist and height
    /// in centimeters to provide information about
    /// the user's risk of developing cardiovascular diseases
    /// 
    /// Entering any other key besides Y when prompted
    /// will exit the program
    /// 
    /// Author John Layson March 2017
    /// Student number: 9823239
    /// 
    /// </summary>
    class Program {
        const double RISKMALE = 0.536;
        const double RISKFEMALE = 0.492;

        static void Main() {
            WelcomeMessage();
            ResetProgram();
        }//End main


// Displays a welcome message.
        static void WelcomeMessage() {
            Console.WriteLine("\n\t\t\tWelcome to Waist to Height Ratio Calculator!\n");
        }//End welcomeMessage


// Displays the exit message.
        static void ExitProgram() {
            Console.Write("\n\t\t\tPress any key to exit");
            Console.ReadKey();
        }//End exitProgram


// Prompts the user to input their waist measurement in cm.
// The parameter minimum is set to 60 when called in Main.
// It also checks the input to determine if it is a number. 
// ..Continued in CheckInputValue
        static double InputWaist(double min) {
            string userInput;
            bool doubleInput, okay;
            double waistValue;
            do {
                do {
                    Console.Write("\nPlease input your waist measurement in cm: ");
                    userInput = Console.ReadLine();
                    doubleInput = double.TryParse(userInput, out waistValue);
                    if (!doubleInput) {
                        Console.WriteLine("Invalid character. Please input a number");
                    }

                } while (!doubleInput);
                okay = CheckInputValue(waistValue, min);
            } while (!okay);
            return waistValue;
        }//End InputWaist


// CheckInputValue method is connected to the method above.
// It has 2 parameters. 1. The value returned 2. Minimum
// It returns the value successfully if the number input
// is greater than or equals to 60.
        static bool CheckInputValue(double waistValue, double min) {
            bool okay;
            okay = waistValue >= min;
            if (!okay) {
                okay = false;
                Console.WriteLine("Please input a valid waist value.");
            }
            return okay;
        }//End CheckInputValue


// Prompts the user to input their height measurement in cm.
// The parameter minimum is set to 120 when called in Main.
// It also checks the input to determine if it is a number. 
// ..Continued in CheckInputValue1
        static double inputHeight(double min) {
            string userInput;
            bool doubleInput, okay;
            double heightValue;
            do {
                do {
                    Console.Write("\nPlease input your height measurement in cm: ");
                    userInput = Console.ReadLine();
                    doubleInput = double.TryParse(userInput, out heightValue);
                    if (!doubleInput) {
                        Console.WriteLine("Invalid character. Please input a number");
                    }

                } while (!doubleInput);
                okay = CheckInputValue1(heightValue, min);
            } while (!okay);
            return heightValue;
        }//End inputHeight


// CheckInputValue1 method is connected to the method above.
// It has 2 parameters. 1. The value returned 2. Minimum
// It returns the value successfully if the number input
// is greater than or equals to 120.
        static bool CheckInputValue1(double heightValue, double min) {
            bool okay;
            okay = heightValue >= min;
            if (!okay) {
                okay = false;
                Console.WriteLine("Please input a valid height value.");
            }
            return okay;
        }//End CheckInputValue1


// DisplayMenu method prompts the user to select which option applies to them.
        static void DisplayMenu() {
            string menu = "\nAre you"
                        + "\n\t(1)Male"
                        + "\n\t(2)Female"
                        + "\n\nEnter your option <1 or 2>: ";
            Console.Write(menu);
        }//End displayMenu
 

// ReadMenu method returns the user input as their option.
// It also checks the input to determine if it is a number. 
// ..Continued in CheckInputOption.
        static int ReadMenu(int min, int max) {
            string choice;
            int option;
            bool okaychoice, okay;
            do {
                do {
                    choice = Console.ReadLine();
                    okaychoice = int.TryParse(choice, out option);
                    if (!okaychoice) {
                        Console.WriteLine("You entered an incorrect option.");
                        DisplayMenu();
                    }
                } while (!okaychoice);
                okay = CheckInputOption(option, min, max);

            } while (!okay);
            return option;
        }//End readMenu


// CheckInputOption method is connected to the method above.
// It has 3 parameters: 1. The option returned  2. Minimum value being 1 
// 2. Maximum value being 2 which are set when called in Main.
// It returns the option successfully if the number input
// is either equals to 1 or 2.
        static bool CheckInputOption(int option, int min, int max) {
            bool okay;
            okay = option == min | option == max;
            if (!okay) {
                okay = false;
                Console.WriteLine("Please input a valid option.");
                DisplayMenu();
            }
            return okay;
        }//End CheckInputOption





// CalculateRatio takes the waist and height user input and 
// divide's waist by height to return the ratio.
        static double CalculateRatio(double waist, double height) {
            double ratio;
            ratio = waist / height;
            return ratio;
            }//End CalculateRatio


// CalculateRisk method takes the ratio and option from the above methods to determine
// and display the user's low/high risk of developing diseases with
// the results in 3 decimal places. The parameters are the option they've 
// picked and ratio calculated above.
        static double DetermineRisk(int option, double ratio) {
            if (option == 1 & ratio >= RISKMALE) {
                Console.WriteLine("\nYour ratio is " + Math.Round(ratio, 3) + " therefore, you are at a High risk of"
                                                                          + " obesity and developing cardiovascular diseases");
            }
                if (option == 1 & ratio < RISKMALE) {
                    Console.WriteLine("\nYour ratio is " + Math.Round(ratio, 3) + " therefore, you are at a Low risk of" 
                                                                              + " obesity and developing cardiovascular diseases");
            }
            else if (option == 2 & ratio >= RISKFEMALE) {
                Console.WriteLine("\nYour ratio is " + Math.Round(ratio, 3) + " therefore, you are at a High risk of" 
                                                                          + "  obesity and developing cardiovascular diseases");
            }
                if (option == 2 & ratio < RISKFEMALE) {
                Console.WriteLine("\nYour ratio is " + Math.Round(ratio, 3) + " therefore, you are at a Low risk of" 
                                                                          + " obesity and developing cardiovascular diseases");
            }
            return option;
        }//End CalculateRisk


 // AnotherCalculationOption method asks the user if they want to do another calculation
 // by pressing the Y button, they are also given the choice to press N to say no and
 // proceed to exit. However, the method is coded so that ANY button besides Y will lead to exit.
         static string AnotherCalculationOption() {
            string choice;
                Console.Write("\n\nDo you want to do another calculation <Enter Y or N>: ");
                choice = Console.ReadLine();
            if (choice == "y" | choice == "Y") {
                ResetProgram();
            } else {
                ExitProgram();
            } return choice;
        }//End AnotherCalculationOption


// This method is restarts the program by leaving out the welcome message.
// When choice variable in the method above becomes equals to Y or y, it calls this method.
       static void ResetProgram() {
            double waist;
            double height;
            double ratio;
            int option;
            waist = InputWaist(60);
            height = inputHeight(120);
            DisplayMenu();
            option = ReadMenu(1, 2);
            ratio = CalculateRatio(waist, height);
            DetermineRisk(option, ratio);
            AnotherCalculationOption();
        }
    }//End class
}
