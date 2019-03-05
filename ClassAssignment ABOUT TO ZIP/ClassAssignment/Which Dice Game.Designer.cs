namespace ClassAssignment {
    partial class Which_Dice_Game {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SelectPigGroupBox = new System.Windows.Forms.GroupBox();
            this.TwoDicePigRadioButton = new System.Windows.Forms.RadioButton();
            this.SingleDiePigRadioButton = new System.Windows.Forms.RadioButton();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SelectPigGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectPigGroupBox
            // 
            this.SelectPigGroupBox.Controls.Add(this.TwoDicePigRadioButton);
            this.SelectPigGroupBox.Controls.Add(this.SingleDiePigRadioButton);
            this.SelectPigGroupBox.Location = new System.Drawing.Point(12, 38);
            this.SelectPigGroupBox.Name = "SelectPigGroupBox";
            this.SelectPigGroupBox.Size = new System.Drawing.Size(200, 115);
            this.SelectPigGroupBox.TabIndex = 0;
            this.SelectPigGroupBox.TabStop = false;
            this.SelectPigGroupBox.Text = "Select which Pig to play";
            // 
            // TwoDicePigRadioButton
            // 
            this.TwoDicePigRadioButton.AutoSize = true;
            this.TwoDicePigRadioButton.Location = new System.Drawing.Point(7, 72);
            this.TwoDicePigRadioButton.Name = "TwoDicePigRadioButton";
            this.TwoDicePigRadioButton.Size = new System.Drawing.Size(89, 17);
            this.TwoDicePigRadioButton.TabIndex = 1;
            this.TwoDicePigRadioButton.Text = "Two Dice Pig";
            this.TwoDicePigRadioButton.UseVisualStyleBackColor = true;
            this.TwoDicePigRadioButton.CheckedChanged += new System.EventHandler(this.TwoDicePigRadioButton_CheckedChanged);
            // 
            // SingleDiePigRadioButton
            // 
            this.SingleDiePigRadioButton.AutoSize = true;
            this.SingleDiePigRadioButton.Location = new System.Drawing.Point(7, 35);
            this.SingleDiePigRadioButton.Name = "SingleDiePigRadioButton";
            this.SingleDiePigRadioButton.Size = new System.Drawing.Size(94, 17);
            this.SingleDiePigRadioButton.TabIndex = 0;
            this.SingleDiePigRadioButton.Text = "Single Die Pig ";
            this.SingleDiePigRadioButton.UseVisualStyleBackColor = true;
            this.SingleDiePigRadioButton.CheckedChanged += new System.EventHandler(this.SingleDiePigRadioButton_CheckedChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(38, 186);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 32);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Which_Dice_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SelectPigGroupBox);
            this.Name = "Which_Dice_Game";
            this.Text = "Dice Games";
            this.SelectPigGroupBox.ResumeLayout(false);
            this.SelectPigGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SelectPigGroupBox;
        private System.Windows.Forms.RadioButton TwoDicePigRadioButton;
        private System.Windows.Forms.RadioButton SingleDiePigRadioButton;
        private System.Windows.Forms.Button ExitButton;
    }
}