using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAssignment {

    /// <summary>
    /// 
    /// Author: John Layson
    /// Student no. 09823239
    /// 
    /// </summary>
    public partial class GamesForm : Form {
        Which_Dice_Game GameForm = new Which_Dice_Game();
        Which_Card_Game GameForm1 = new Which_Card_Game();
        public GamesForm() {
            InitializeComponent();
        }

        private void DiceGameRadioButton_CheckedChanged(object sender, EventArgs e) {
            StartButton.Enabled = true;
        }

        private void CardGameRadioButton_CheckedChanged(object sender, EventArgs e) {
            StartButton.Enabled = true;
        }

        private void StartButton_Click(object sender, EventArgs e) {
            if (DiceGameRadioButton.Checked) {
                GameForm.Show();
                DiceGameRadioButton.Checked = false;

            }
            else if (CardGameRadioButton.Checked) {
                GameForm1.Show();
                CardGameRadioButton.Checked = false;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Do you really want to quit?","Quit?",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                this.Close();
                } else {
                return;
            }
        }
    }
}
