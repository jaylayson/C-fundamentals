namespace ClassAssignment {
    partial class GamesForm {
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
            this.InteractiveGamesLabel = new System.Windows.Forms.Label();
            this.SelectGameGroupBox = new System.Windows.Forms.GroupBox();
            this.CardGameRadioButton = new System.Windows.Forms.RadioButton();
            this.DiceGameRadioButton = new System.Windows.Forms.RadioButton();
            this.StartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SelectGameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InteractiveGamesLabel
            // 
            this.InteractiveGamesLabel.AutoSize = true;
            this.InteractiveGamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InteractiveGamesLabel.Location = new System.Drawing.Point(58, 26);
            this.InteractiveGamesLabel.Name = "InteractiveGamesLabel";
            this.InteractiveGamesLabel.Size = new System.Drawing.Size(176, 24);
            this.InteractiveGamesLabel.TabIndex = 0;
            this.InteractiveGamesLabel.Text = "Interactive Games";
            // 
            // SelectGameGroupBox
            // 
            this.SelectGameGroupBox.Controls.Add(this.CardGameRadioButton);
            this.SelectGameGroupBox.Controls.Add(this.DiceGameRadioButton);
            this.SelectGameGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectGameGroupBox.Location = new System.Drawing.Point(62, 68);
            this.SelectGameGroupBox.Name = "SelectGameGroupBox";
            this.SelectGameGroupBox.Size = new System.Drawing.Size(172, 110);
            this.SelectGameGroupBox.TabIndex = 1;
            this.SelectGameGroupBox.TabStop = false;
            this.SelectGameGroupBox.Text = "Select Game Type";
            // 
            // CardGameRadioButton
            // 
            this.CardGameRadioButton.AutoSize = true;
            this.CardGameRadioButton.Location = new System.Drawing.Point(6, 73);
            this.CardGameRadioButton.Name = "CardGameRadioButton";
            this.CardGameRadioButton.Size = new System.Drawing.Size(98, 21);
            this.CardGameRadioButton.TabIndex = 1;
            this.CardGameRadioButton.Text = "Card Game";
            this.CardGameRadioButton.UseVisualStyleBackColor = true;
            this.CardGameRadioButton.CheckedChanged += new System.EventHandler(this.CardGameRadioButton_CheckedChanged);
            // 
            // DiceGameRadioButton
            // 
            this.DiceGameRadioButton.AutoSize = true;
            this.DiceGameRadioButton.Location = new System.Drawing.Point(6, 33);
            this.DiceGameRadioButton.Name = "DiceGameRadioButton";
            this.DiceGameRadioButton.Size = new System.Drawing.Size(96, 21);
            this.DiceGameRadioButton.TabIndex = 0;
            this.DiceGameRadioButton.Text = "Dice Game";
            this.DiceGameRadioButton.UseVisualStyleBackColor = true;
            this.DiceGameRadioButton.CheckedChanged += new System.EventHandler(this.DiceGameRadioButton_CheckedChanged);
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(68, 249);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(125, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(68, 294);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(125, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // GamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 382);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.SelectGameGroupBox);
            this.Controls.Add(this.InteractiveGamesLabel);
            this.Name = "GamesForm";
            this.Text = "Games";
            this.SelectGameGroupBox.ResumeLayout(false);
            this.SelectGameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InteractiveGamesLabel;
        private System.Windows.Forms.GroupBox SelectGameGroupBox;
        private System.Windows.Forms.RadioButton CardGameRadioButton;
        private System.Windows.Forms.RadioButton DiceGameRadioButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

