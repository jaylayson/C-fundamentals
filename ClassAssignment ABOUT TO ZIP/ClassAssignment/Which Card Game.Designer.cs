namespace ClassAssignment {
    partial class Which_Card_Game {
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
            this.ChooseGameComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseAGameToPlay = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseGameComboBox
            // 
            this.ChooseGameComboBox.FormattingEnabled = true;
            this.ChooseGameComboBox.Items.AddRange(new object[] {
            "Solitaire",
            "Twenty-One"});
            this.ChooseGameComboBox.Location = new System.Drawing.Point(66, 57);
            this.ChooseGameComboBox.Name = "ChooseGameComboBox";
            this.ChooseGameComboBox.Size = new System.Drawing.Size(121, 21);
            this.ChooseGameComboBox.TabIndex = 0;
            this.ChooseGameComboBox.SelectedIndexChanged += new System.EventHandler(this.ChooseGameComboBox_SelectedIndexChanged);
            // 
            // ChooseAGameToPlay
            // 
            this.ChooseAGameToPlay.AutoSize = true;
            this.ChooseAGameToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseAGameToPlay.Location = new System.Drawing.Point(21, 34);
            this.ChooseAGameToPlay.Name = "ChooseAGameToPlay";
            this.ChooseAGameToPlay.Size = new System.Drawing.Size(203, 20);
            this.ChooseAGameToPlay.TabIndex = 1;
            this.ChooseAGameToPlay.Text = "Choose A Game To Play";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(98, 135);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 40);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Which_Card_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ChooseAGameToPlay);
            this.Controls.Add(this.ChooseGameComboBox);
            this.Name = "Which_Card_Game";
            this.Text = "Which_Card_Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChooseGameComboBox;
        private System.Windows.Forms.Label ChooseAGameToPlay;
        private System.Windows.Forms.Button ExitButton;
    }
}