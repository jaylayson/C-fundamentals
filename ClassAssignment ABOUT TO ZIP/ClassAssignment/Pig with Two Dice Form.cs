using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Games_Logic_Library;
using Low_Level_Objects_Library;

namespace ClassAssignment {

    /// <summary>
    /// 
    /// Author: John Layson
    /// Student no. 09823239
    /// 
    /// </summary>
    public partial class Pig_With_Two_Dice_Form : Form {
        static Random randomValue = new Random();
        private static int min = 1;
        private static int max = 6;
        private static int counter = 0;
        public Pig_With_Two_Dice_Form() {
            InitializeComponent();
            PictureBox[] pictureBoxes;
            pictureBoxes = new PictureBox[Pig_Double_Dice_Game.NUM_OF_PLAYERS]
            {PictureBox, PictureBox2};
            Pig_Double_Dice_Game.SetUpGame();

        }


        /// <summary>
        /// Disables RollButton, initializes counter as 0, starts DiceTimer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RollButton_Click(object sender, EventArgs e) {
            RollButton.Enabled = false;
            counter = 0;
            DiceTimer.Start();
        }//end of RollButton

        /// <summary>
        /// Updates textbox, changes player, updates WhoseTurnToLabel.
        /// </summary>
        private void HoldButton_Click(object sender, EventArgs e) {
            if (Pig_Double_Dice_Game.current_player == 1) {
                PlayerOneTotalTextBox.Text = Pig_Double_Dice_Game.GetPointsTotal().ToString();
                Pig_Double_Dice_Game.current_player = 2;
                WhoseTurnToLabel.Text = "Player 2";
            } else if (Pig_Double_Dice_Game.current_player == 2) {
                PlayerTwoTotalTextBox.Text = Pig_Double_Dice_Game.GetPointsTotal().ToString();
                Pig_Double_Dice_Game.current_player = 1;
                WhoseTurnToLabel.Text = "Player 1";
            }
        }//end of HoldButton


        /// <summary>
        /// Setup game, updates WhoseTurnToLabel, updates textbox, unchecks YesOption button
        /// Disables groupbox.
        /// </summary>
        private void YesOption_CheckedChanged(object sender, EventArgs e) {
            Pig_Double_Dice_Game.SetUpGame();
            PlayerOneTotalTextBox.Text = "";
            PlayerTwoTotalTextBox.Text = "";
            WhoseTurnToLabel.Text = "Player 1";
            YesOption.Checked = false;
            AnotherGameGroupBox.Enabled = false;
        }//end of YesOption


        /// <summary>
        /// Closes the window.
        /// </summary>
        private void NoOption_CheckedChanged(object sender, EventArgs e) {
            this.Close();
        }//end of NoOption


        /// <summary>
        /// Rolls die through .PlayGame(), updates image, changes player, checks for wins
        /// Updates WhosTurnToLabel, updates textbox, enables groupbox.
        /// </summary>
        private void RollDice() {
            if (Pig_Double_Dice_Game.current_player == 1) {
                Pig_Double_Dice_Game.PlayGame();
                 PictureBox.Image = Images.GetDieImage(Pig_Double_Dice_Game.GetFaceValue(0));
                PictureBox2.Image = Images.GetDieImage(Pig_Double_Dice_Game.GetFaceValue(1));
                PlayerOneTotalTextBox.Text = Pig_Double_Dice_Game.overall_points.ToString();
                if (Pig_Double_Dice_Game.did_roll_one == 1) {
                    MessageBox.Show("You have thrown a 1.\n Your turn is over!\n Your overall_points reverts to " + Pig_Double_Dice_Game.GetPointsTotal() + "!");
                    Pig_Double_Dice_Game.current_player = 2;
                    WhoseTurnToLabel.Text = "Player 2";
                    RollButton.Enabled = true;
                }
                if (Pig_Double_Dice_Game.HasWon()) {
                    MessageBox.Show("Player 1 has won!\n Well done!");
                    AnotherGameGroupBox.Enabled = true;
                }
            } else if (Pig_Double_Dice_Game.current_player == 2) {
                Pig_Double_Dice_Game.PlayGame();
                   PictureBox.Image = Images.GetDieImage(Pig_Double_Dice_Game.GetFaceValue(0));
                 PictureBox2.Image = Images.GetDieImage(Pig_Double_Dice_Game.GetFaceValue(1));
                PlayerTwoTotalTextBox.Text = Pig_Double_Dice_Game.overall_points.ToString();
                if (Pig_Double_Dice_Game.did_roll_one == 1) {
                    MessageBox.Show("You have thrown a 1.\n Your turn is over!\n Your overall_points reverts to " + Pig_Double_Dice_Game.GetPointsTotal() + "!");
                    Pig_Double_Dice_Game.current_player = 1;
                    WhoseTurnToLabel.Text = "Player 1";
                    Pig_Double_Dice_Game.did_roll_one = 0;
                    RollButton.Enabled = true;
                }
                if (Pig_Double_Dice_Game.HasWon()) {
                    MessageBox.Show("Player 2 has won!\n Well done!");
                    AnotherGameGroupBox.Enabled = true;
                }
            }
        }//end RollDice


        /// <summary>
        /// Shows the random dice rolling animation.
        /// </summary>
        private void UpdatePictureBoxes() {
                int randomNumber = randomValue.Next(min, max);
                int randomNumber1 = randomValue.Next(min, max);
                PictureBox.Image = Images.GetDieImage(randomNumber);
                PictureBox2.Image = Images.GetDieImage(randomNumber1);
        }//end UpdatePictureBoxes


        /// <summary>
        /// increments counter, show rolling animation while counter is less than 11
        /// Stops timer, rolls dice and gets values, enables RollButton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiceTimer_Tick(object sender, EventArgs e) {
            counter++;

            if(counter < 11) {
                UpdatePictureBoxes();
            }else {
                DiceTimer.Stop();
                RollDice();
                RollButton.Enabled = true;
            }
        }//end DiceTimer
    }//end of Class
}
