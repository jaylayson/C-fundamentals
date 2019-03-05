﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter_GUI {

    enum Currencies { AUD = 1, CYN, DKK, EUR, INR, NZD, AED, GBP, USD, VND };

    /// <summary>
    /// 
    /// Author: John Layson
    /// Student no. 09823239
    /// 
    /// </summary>

    static class Currency_Exchange_Class {

        private static double[] xRates = { 0, 1, 4.2681, 5.0844, 0.6849, 43.5921, 0.9705, 2.7094, 0.4963, 0.7382, 19115.5547 };


        /// <summary>
        /// Provides country names and currency code which  can be used to initialise a Combo Box
        /// </summary>
        /// <returns> string array each elemnt of which contains the country name and three letter currency code</returns>
        public static string[] InitialiseComboBox() {

            string[] countries = {   "",
                                    "Australia (AUD)",
                                    "China (CNY)",
                                    "Denmark (DKK)",
                                    "Europe (EUR)",
                                    "India (INR)",
                                    "New Zealand (NZD)",
                                    "United Arab Emirates (AED)",
                                    "United Kingdom (GBP)",
                                    "United States (USD)",
                                    "Vietnam (VND)" };

            return countries;
        } //end InitialiseComboBox()             


        /// <summary>
        /// 
        /// This method grabs the values in whichConversion
        /// and whichConversionIWant to determine which rate
        /// in xRate to use and then it calculates the result
        /// depending on the user input. The input is divided by 
        /// the whichConversion to convert it to AUD which is then multiplied
        /// by the whichConversionIwant rate.
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="whichConversion"></param>
        /// <param name="whichConversionIWant"></param>
        /// <returns></returns>
        public static double Convert_Currencies(double input, int whichConversion, int whichConversionIWant ) {
            return ((input / xRates[whichConversion]) * xRates[whichConversionIWant]);
        }

    }//end class
}
