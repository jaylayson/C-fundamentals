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

namespace ClassAssignment {

    /// <summary>
    /// 
    /// Author: John Layson
    /// Student no. 09823239
    /// 
    /// </summary>
    public partial class Pig_Game_Form : Form {
        public Pig_Game_Form() {
            InitializeComponent();
            Pig_Single_Die_Game.SetUpGame();
            PictureBox.Image = Images.GetDieImage(Pig_Single_Die_Game.GetFaceValue());
        }

        /// <summary>
        /// Rolls die through .PlayGame(), updates image, changes player, checks for wins
        /// Updates WhosTurnToLabel, updates textbox, enables groupbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RollButton_Click(object sender, EventArgs e) {
            if (Pig_Single_Die_Game.current_player == 1) {
                Pig_Single_Die_Game.PlayGame();
                PictureBox.Image = Images.GetDieImage(Pig_Single_Die_Game.GetFaceValue());
                PlayerOneTotalTextBox.Text = Pig_Single_Die_Game.overall_points.ToString();
                if (Pig_Single_Die_Game.did_roll_one == 1) {
                    MessageBox.Show("You have thrown a 1.\n Your turn is over!\n Your overall_points reverts to "  + Pig_Single_Die_Game.GetPointsTotal() + "!");
                    Pig_Single_Die_Game.current_player = 2;
                    WhoseTurnToLabel.Text = "Player 2";
                }
                if (Pig_Single_Die_Game.HasWon()) {
                    MessageBox.Show("Player 1 has won!\n Well done!");
                    AnotherGameGroupBox.Enabled = true;
                }                
            } else if (Pig_Single_Die_Game.current_player == 2) {
                Pig_Single_Die_Game.PlayGame();
                PictureBox.Image = Images.GetDieImage(Pig_Single_Die_Game.GetFaceValue());
                PlayerTwoTotalTextBox.Text = Pig_Single_Die_Game.overall_points.ToString();
                if (Pig_Single_Die_Game.did_roll_one == 1) {
                    MessageBox.Show("You have thrown a 1.\n Your turn is over!\n Your overall_points reverts to " + Pig_Single_Die_Game.GetPointsTotal() + "!");
                    Pig_Single_Die_Game.current_player = 1;
                    WhoseTurnToLabel.Text = "Player 1";
                    Pig_Single_Die_Game.did_roll_one = 0;
                }
                if (Pig_Single_Die_Game.HasWon()) {
                    MessageBox.Show("Player 2 has won!\n Well done!");
                    AnotherGameGroupBox.Enabled = true;
                }               
            }
        }//end of RollButton_Click


        /// <summary>
        /// Updates textbox, changes player, updates WhoseTurnToLabel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldButton_Click(object sender, EventArgs e) {
            if (Pig_Single_Die_Game.current_player == 1) {
                PlayerOneTotalTextBox.Text = Pig_Single_Die_Game.GetPointsTotal().ToString();
                Pig_Single_Die_Game.current_player = 2;
                WhoseTurnToLabel.Text = "Player 2";

            } else if (Pig_Single_Die_Game.current_player == 2) {
                PlayerTwoTotalTextBox.Text = Pig_Single_Die_Game.GetPointsTotal().ToString();
                Pig_Single_Die_Game.current_player = 1;
                WhoseTurnToLabel.Text = "Player 1";

            }
        }//end of HoldButton_Click


        /// <summary>
        /// Setup game, updates WhoseTurnToLabel, updates textbox, unchecks YesOption button
        /// Disables groupbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YesOption_CheckedChanged(object sender, EventArgs e) {
            Pig_Single_Die_Game.SetUpGame();
            WhoseTurnToLabel.Text = "Player 1";
            PlayerOneTotalTextBox.Text = "";
            PlayerTwoTotalTextBox.Text = "";
            YesOption.Checked = false;
            AnotherGameGroupBox.Enabled = false;
        }//end of YesOption_Checked


        /// <summary>
        /// Closes the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoOption_CheckedChanged(object sender, EventArgs e) {
            this.Close();
        }//end of NoOption_CheckedChanged
    }
}
