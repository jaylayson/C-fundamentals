using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter_GUI {

    /// <summary>
    /// 
    /// Author: John Layson
    /// Student no. 09823239
    /// 
    /// </summary>

    public partial class Currency : Form {

        private int whichConversion;
        private int whichConversionIWant;
        private Currencies chosenCurrency;
        private string countryAbbreviation;

        public Currency() {
            
            InitializeComponent();

            HaveComboBox.DataSource = Currency_Exchange_Class.InitialiseComboBox();
            WantComboBox.DataSource = Currency_Exchange_Class.InitialiseComboBox();


        }//end Form1


        /// <summary>
        /// 
        /// This is the method linked to the Currency I have combo box.
        /// It detects if the user has selected an option and then it
        /// enables the Currency I want combo box, disables HaveComboBox and 
        /// changes the FromCurrency label text.
        /// 
        /// whichConversion variable stores the position of the countries array
        /// which is determined by the user's choice.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HaveComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            int blank = 0;
            whichConversion = HaveComboBox.SelectedIndex;
            chosenCurrency = (Currencies)whichConversion;


            if ( whichConversion > blank) {
                EnableWantBox();
            }


            switch (chosenCurrency) {
                case Currencies.AUD:
                    countryAbbreviation = "AUD";
                    break;

                case Currencies.CYN:
                    countryAbbreviation = "CYN";
                    break;

                case Currencies.DKK:
                    countryAbbreviation = "DKK";
                    break;
                case Currencies.EUR:
                    countryAbbreviation = "EUR";
                    break;
                case Currencies.INR:
                    countryAbbreviation = "INR";
                    break;
                case Currencies.NZD:
                    countryAbbreviation = "NZD";
                    break;
                case Currencies.AED:
                    countryAbbreviation = "AED";
                    break;
                case Currencies.GBP:
                    countryAbbreviation = "GBP";
                    break;
                case Currencies.USD:
                    countryAbbreviation = "USD";
                    break;
                case Currencies.VND:
                    countryAbbreviation = "VND";
                    break;
            }

            FromCurrency.Text = countryAbbreviation;
            FromCurrency.Visible = false;

        }//end of HaveComboBox


        /// <summary>
        /// 
        /// This is the method linked to the Currency I Want combo box.
        /// It detects if the user has selected an option and then it
        /// enables the HaveInput text box, changes the ToCurrency
        /// label text, and makes the FromCurrency label visible.
        /// 
        /// whichConversionIWant stores the position of the countries array
        /// which is determined by the user's choice.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WantComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            int blank = 0;
            whichConversionIWant = WantComboBox.SelectedIndex;
            chosenCurrency = (Currencies)whichConversionIWant;


            if (whichConversionIWant > blank) {
                EnableAmountIHave();
            }

            switch (chosenCurrency) {
                case Currencies.AUD:
                    countryAbbreviation = "AUD";
                    break;

                case Currencies.CYN:
                    countryAbbreviation = "CYN";
                    break;

                case Currencies.DKK:
                    countryAbbreviation = "DKK";
                    break;
                case Currencies.EUR:
                    countryAbbreviation = "EUR";
                    break;
                case Currencies.INR:
                    countryAbbreviation = "INR";
                    break;
                case Currencies.NZD:
                    countryAbbreviation = "NZD";
                    break;
                case Currencies.AED:
                    countryAbbreviation = "AED";
                    break;
                case Currencies.GBP:
                    countryAbbreviation = "GBP";
                    break;
                case Currencies.USD:
                    countryAbbreviation = "USD";
                    break;
                case Currencies.VND:
                    countryAbbreviation = "VND";
                    break;
            }

            ToCurrency.Text = countryAbbreviation;
            FromCurrency.Visible = true;

        }//end of WantComboBox


        /// <summary>
        /// 
        /// This is the method linked to the Amount I Have text box.
        /// It detects if the user has typed some characters which
        /// then enables the EqualsButton by calling EnableEqualsButton();
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HaveInput_TextChanged(object sender, EventArgs e) {

            EnableEqualsButton();

        }//end of HaveInput
        

        /// <summary>
        /// 
        /// This method is called in HaveComboBox.
        /// Its purpose is to disable the HaveComboBox
        /// and enable WantComboBox.
        /// 
        /// </summary>
        private void EnableWantBox() {
            WantComboBox.Enabled = true;
            HaveComboBox.Enabled = false;
        } //end EnableTempInput


        /// <summary>
        /// 
        /// This method is called in WantComboBox.
        /// Its purpose is to disable the WantComboBox
        /// and enable HaveInput text box.
        /// 
        /// </summary>
        private void EnableAmountIHave() {
            WantComboBox.Enabled = false;
            HaveComboBox.Enabled = false;
            HaveInput.Enabled = true;
        }//end EnableAmountIHave


        /// <summary>
        /// 
        /// This method is called in EqualsButton_Click.
        /// Its purpose is to enable AnotherConversion
        /// groupbox and also make it visible.
        /// 
        /// </summary>
        private void EnableGroupBox() {
            AnotherConversion.Visible = true;
            AnotherConversion.Enabled = true;
        }//end EnableGroupBox


        /// <summary>
        /// 
        /// This method is called in HaveInput.
        /// Its purpose is to enable the EqualsButton
        /// so it's clickable.
        /// 
        /// </summary>
        private void EnableEqualsButton() {
            EqualsButton.Enabled = true;
        }//end EnableEqualsButton


        /// <summary>
        /// 
        /// This method has 2 double variables.
        /// 
        /// 1. input: this stores the value that the user
        /// types in the HaveInput box.
        /// 2. result: result is the variable that stores
        /// the calculated number in Currency Exchange Class.cs
        /// which has a method returning value.
        /// 
        /// This method also has if functions which checks if
        /// the user input is a number or a negative number,
        /// in which case an error message appears and prompts
        /// the user to enter a valid input.
        /// 
        /// The method also makes the ToCurrency label visible,
        /// AmountIWant label enabled, formats the result to 4 decimals,
        /// and enables the AnotherConversion group box.
        /// 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualsButton_Click(object sender, EventArgs e) {
            double input, result;

            if (!double.TryParse(HaveInput.Text, out input)) {
                MessageBox.Show("Value entered must be numeric");
                HaveInput.Text = "";
                HaveInput.Focus();
                return;
            } else if (input < 0) {
                MessageBox.Show("Value entered must be a valid number");
                HaveInput.Text = "";
                return;
            }



            result = Currency_Exchange_Class.Convert_Currencies(input, whichConversion, whichConversionIWant);

            ToCurrency.Visible = true;
            AmountIWant.Enabled = true;
            WantInput.Text = result.ToString("0.####");
            EnableGroupBox();
          }//end of EqualsButton_Click

        private void WantInput_TextChanged(object sender, EventArgs e) {
        }


        /// <summary>
        /// 
        /// This is the method linked to Yes option Radiobutton.
        /// When selected, it resets the GUI such as clearing the
        /// Texts in the comboboxes, textboxes, and labels.
        /// It disables all boxes except HaveComboBox so that 
        /// the user can start again from top.
        /// It hides the labels and groupbox.
        /// It also clears the radiobutton to be used again later.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YesOption_CheckedChanged(object sender, EventArgs e) {
            HaveComboBox.Text = "";
            WantComboBox.Text = "";
            HaveInput.Text = "";
            WantInput.Text = "";
            FromCurrency.Text = "";
            ToCurrency.Text = "";
            HaveComboBox.Enabled = true;
            HaveInput.Enabled = false;
            EqualsButton.Enabled = false;
            AmountIWant.Enabled = false;
            FromCurrency.Visible = false;
            ToCurrency.Visible = false;
            AnotherConversion.Visible = false;
            YesOption.Checked = false;
        }//end YesOption_CheckedChanged


        /// <summary>
        /// 
        /// This method closes the program.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoOption_CheckedChanged(object sender, EventArgs e) {
            MessageBox.Show("Thank you for using CC!");
            this.Close();
        }//end of NoOption_CheckedChanged
    }//end class
}
