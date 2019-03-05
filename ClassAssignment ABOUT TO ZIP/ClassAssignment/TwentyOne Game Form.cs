using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Low_Level_Objects_Library;
using Games_Logic_Library;

namespace ClassAssignment {

    /// <summary>
    /// 
    /// Author: John Layson
    /// Student no. 09823239
    /// 
    /// </summary>
    public partial class TwentyOne_Game_Form : Form {
        public TwentyOne_Game_Form() {
            InitializeComponent();
            TwentyOneGame.SetUpGame();
            TwentyOneGame.ResetTotals();
        }//end of TwentyOne_Game_Form

        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            foreach (Card card in hand) {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Tell the PictureBox to use all the space inside its square.
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                pictureBox.Image = Images.GetCardImage(card);
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
            }
        }//end of DisplayGuiHand

        private void DealButton_Click(object sender, EventArgs e) {
            //Hides the BUSTED labels.
            BustedLabel1.Visible = false; 
            BustedLabel2.Visible = false;

            //Resets Totals.
            TwentyOneGame.ResetTotals();

            //Updates the Points text.
            PointsLabel2.Text = TwentyOneGame.GetTotalPoints(1).ToString(); 
            PointsLabel1.Text = TwentyOneGame.GetTotalPoints(0).ToString();

            //Updates the Amount of Aces that are considered as one.
            AmountOfAcesAsOne.Text = TwentyOneGame.GetNumOfUserAcesWithValueOne().ToString();

            //Gets the cards from the player's hand.
            Hand players_hand = TwentyOneGame.GetHand(1);

            //Updates GUI panels.
            DisplayGuiHand(TwentyOneGame.GetHand(0), LayoutPanel1);
            DisplayGuiHand(TwentyOneGame.GetHand(1), LayoutPanel2);

            //Find the Aces in the cards.
            foreach (Card card in players_hand) {
                if (card.GetFaceValue() == FaceValue.Ace) {
                    DialogResult choice = MessageBox.Show("Count Ace as 1?", "You got an Ace!", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question);
                    if (choice == DialogResult.Yes) {
                        TwentyOneGame.IncrementNumOfUserAcesWithValueOne();
                        AmountOfAcesAsOne.Text = TwentyOneGame.GetNumOfUserAcesWithValueOne().ToString();

                    }//end of if statement
                }//end of if statement
            }//end of foreach loop

            //Calculates totals.
            TwentyOneGame.CalculateHandTotal(0);
            TwentyOneGame.CalculateHandTotal(1);

            //Updates Totals.
            PointsLabel2.Text = TwentyOneGame.GetTotalPoints(1).ToString();
            PointsLabel1.Text = TwentyOneGame.GetTotalPoints(0).ToString();

            //If dealer goes over 21 points..
            if (TwentyOneGame.GetTotalPoints(0) > 21) {
                //Show BUSTED label.
                BustedLabel1.Visible = true;

                //Updates number of games won.
                Number2.Text = TwentyOneGame.GetNumOfGamesWon(1).ToString();

                //If player goes over 21 points..
            } else if (TwentyOneGame.GetTotalPoints(1) > 21) {
                //Show BUSTED label.
                BustedLabel2.Visible = true;

                //Updates number of games won.
                Number1.Text = TwentyOneGame.GetNumOfGamesWon(0).ToString();
            } else {
                //Disable DealButton when already dealt and enable Hit and Stand buttons.
                DealButton.Enabled = false;
                HitButton.Enabled = true;
                StandButton.Enabled = true;
            }//end of if statement
        }//end of DealButton_Click


        private void HitButton_Click(object sender, EventArgs e) {
            //Ask player if they want to use Ace as 1.
            if (TwentyOneGame.DealOneCardTo(1).GetFaceValue() == FaceValue.Ace) {
                DialogResult choice = MessageBox.Show("Count Ace as 1?", "You got an Ace!", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //If choice is Yes, Ace card is given a 1 value.
                if (choice == DialogResult.Yes) {
                    TwentyOneGame.IncrementNumOfUserAcesWithValueOne();
                    AmountOfAcesAsOne.Text = TwentyOneGame.GetNumOfUserAcesWithValueOne().ToString();
                }//end of if statement
            }//end of if statement

            //Calculates totals.
            TwentyOneGame.CalculateHandTotal(1);

            //Updates the points text.
            PointsLabel2.Text = TwentyOneGame.GetTotalPoints(1).ToString();

            //Updates GUI panels.
            DisplayGuiHand(TwentyOneGame.GetHand(1), LayoutPanel2);

            //If players points go over 21..
            if (TwentyOneGame.GetTotalPoints(1) > 21) {
                //Show BUSTED label.
                BustedLabel2.Visible = true;

                //Updates games won.
                Number1.Text = TwentyOneGame.GetNumOfGamesWon(0).ToString();

                //Enables DealButton again for another Game, and disables Hit and stand buttons.
                DealButton.Enabled = true;
                HitButton.Enabled = false;
                StandButton.Enabled = false;
            }//end of if statement
        }//end of HitButton_Click

        private void StandButton_Click(object sender, EventArgs e) {
            //While Dealer's points are under 17..
            while (TwentyOneGame.GetTotalPoints(0) < 17) {
                //Dealer plays.
                TwentyOneGame.PlayForDealer();

                //Updates points.
                PointsLabel1.Text = TwentyOneGame.GetTotalPoints(0).ToString();

                //Updates GUI.
                DisplayGuiHand(TwentyOneGame.GetHand(0), LayoutPanel1);
            }
            //Disables Stand and Hit button and enables DealButton.
            StandButton.Enabled = false;
            HitButton.Enabled = false;
            DealButton.Enabled = true;

            //If Dealer's points are over 21..
            if (TwentyOneGame.GetTotalPoints(0) > 21) {
                //Show BUSTED Label
                BustedLabel1.Visible = true;

                //Updates Games won of player.
                Number2.Text = TwentyOneGame.GetNumOfGamesWon(1).ToString();
            } else {
            //Otherwise dealer plays
                TwentyOneGame.PlayForDealer();
                //Updates Games won.
                Number1.Text = TwentyOneGame.GetNumOfGamesWon(0).ToString();
                Number2.Text = TwentyOneGame.GetNumOfGamesWon(1).ToString();
            }//end of if statement
        }//end of StandButton_Click

        private void CancelButton_Click(object sender, EventArgs e) {
            //Reset totals.
            TwentyOneGame.ResetTotals();

            //If player and dealer has the same amount of games won.
            if (TwentyOneGame.GetNumOfGamesWon(0) == TwentyOneGame.GetNumOfGamesWon(1)) {
                MessageBox.Show("It was a draw!");
            }
            //If dealer has less games won than players show player won message. 
            else if (TwentyOneGame.GetNumOfGamesWon(0) > TwentyOneGame.GetNumOfGamesWon(1)) {
                MessageBox.Show("House won! Better luck next time!");
            } 
            //Otherwise show house won message.
            else {
                MessageBox.Show("You won! Well done.");
            }//end if
            //Close window.
            this.Close();
        }//end of CancelButton_Click

        private void TestButton_Click(object sender, EventArgs e) {

            const int testNumOfCardsForDealer = 2;
            const int testNumOfCardsForPlayer = 8;

            CardPile testCardPile = new CardPile(true);
            testCardPile.Shuffle();

            Hand testHandForDealer = new Hand(testCardPile.DealCards(testNumOfCardsForDealer));
            Hand testHandForPlayer = new Hand(testCardPile.DealCards(testNumOfCardsForPlayer));

            DisplayGuiHand(testHandForDealer, LayoutPanel1);
            DisplayGuiHand(testHandForPlayer, LayoutPanel2);
        }//end of TestButton_Click
    }
}
