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
    public partial class Which_Card_Game : Form {
        public Which_Card_Game() {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Do you really want to quit?", "Quit?",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                this.Hide();
            } else {
                return;
            }
        }

        private void ChooseGameComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            string option = "";
            option = ChooseGameComboBox.SelectedItem.ToString();
            if(option == "Solitaire") {
                Solitaire_Form GameForm = new Solitaire_Form();
                GameForm.Show();
            }else if(option == "Twenty-One") {
                TwentyOne_Game_Form GameForm1 = new TwentyOne_Game_Form();
                GameForm1.Show();
            }
        }
    }
}
