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
    public partial class Which_Dice_Game : Form {      
        public Which_Dice_Game() {
            InitializeComponent();
        }

        private void SingleDiePigRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (SingleDiePigRadioButton.Checked) {
                Pig_Game_Form GameForm = new Pig_Game_Form();
                GameForm.Show();
                SingleDiePigRadioButton.Checked = false;
            }
            
        }

        private void TwoDicePigRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (TwoDicePigRadioButton.Checked) {
                Pig_With_Two_Dice_Form GameForm1 = new Pig_With_Two_Dice_Form();
                GameForm1.Show();
                TwoDicePigRadioButton.Checked = false;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Do you really want to quit?", "Quit?",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                this.Hide();
                //this.Close();
            } else {
                return;
            }
        }
    }
}
