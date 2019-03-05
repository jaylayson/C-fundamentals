namespace ClassAssignment {
    partial class Pig_With_Two_Dice_Form {
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
            this.components = new System.ComponentModel.Container();
            this.WhoseTurnToLabel = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PlayerOneTotalLabel = new System.Windows.Forms.Label();
            this.PlayerTwoTotalLabel = new System.Windows.Forms.Label();
            this.PlayerOneTotalTextBox = new System.Windows.Forms.TextBox();
            this.PlayerTwoTotalTextBox = new System.Windows.Forms.TextBox();
            this.RollButton = new System.Windows.Forms.Button();
            this.HoldButton = new System.Windows.Forms.Button();
            this.AnotherGameGroupBox = new System.Windows.Forms.GroupBox();
            this.NoOption = new System.Windows.Forms.RadioButton();
            this.YesOption = new System.Windows.Forms.RadioButton();
            this.DiceTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.AnotherGameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WhoseTurnToLabel
            // 
            this.WhoseTurnToLabel.AutoSize = true;
            this.WhoseTurnToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhoseTurnToLabel.Location = new System.Drawing.Point(68, 9);
            this.WhoseTurnToLabel.Name = "WhoseTurnToLabel";
            this.WhoseTurnToLabel.Size = new System.Drawing.Size(53, 13);
            this.WhoseTurnToLabel.TabIndex = 1;
            this.WhoseTurnToLabel.Text = "Player 1";
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(66, 40);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(55, 55);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox2.Location = new System.Drawing.Point(66, 101);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(55, 55);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 4;
            this.PictureBox2.TabStop = false;
            // 
            // PlayerOneTotalLabel
            // 
            this.PlayerOneTotalLabel.AutoSize = true;
            this.PlayerOneTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerOneTotalLabel.Location = new System.Drawing.Point(215, 40);
            this.PlayerOneTotalLabel.Name = "PlayerOneTotalLabel";
            this.PlayerOneTotalLabel.Size = new System.Drawing.Size(86, 13);
            this.PlayerOneTotalLabel.TabIndex = 5;
            this.PlayerOneTotalLabel.Text = "Player 1 Total";
            // 
            // PlayerTwoTotalLabel
            // 
            this.PlayerTwoTotalLabel.AutoSize = true;
            this.PlayerTwoTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerTwoTotalLabel.Location = new System.Drawing.Point(215, 82);
            this.PlayerTwoTotalLabel.Name = "PlayerTwoTotalLabel";
            this.PlayerTwoTotalLabel.Size = new System.Drawing.Size(86, 13);
            this.PlayerTwoTotalLabel.TabIndex = 6;
            this.PlayerTwoTotalLabel.Text = "Player 2 Total";
            // 
            // PlayerOneTotalTextBox
            // 
            this.PlayerOneTotalTextBox.Location = new System.Drawing.Point(307, 33);
            this.PlayerOneTotalTextBox.Name = "PlayerOneTotalTextBox";
            this.PlayerOneTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlayerOneTotalTextBox.TabIndex = 7;
            // 
            // PlayerTwoTotalTextBox
            // 
            this.PlayerTwoTotalTextBox.Location = new System.Drawing.Point(307, 75);
            this.PlayerTwoTotalTextBox.Name = "PlayerTwoTotalTextBox";
            this.PlayerTwoTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlayerTwoTotalTextBox.TabIndex = 8;
            // 
            // RollButton
            // 
            this.RollButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollButton.Location = new System.Drawing.Point(46, 200);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(75, 32);
            this.RollButton.TabIndex = 9;
            this.RollButton.Text = "Roll";
            this.RollButton.UseVisualStyleBackColor = false;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // HoldButton
            // 
            this.HoldButton.BackColor = System.Drawing.Color.Red;
            this.HoldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoldButton.Location = new System.Drawing.Point(137, 199);
            this.HoldButton.Name = "HoldButton";
            this.HoldButton.Size = new System.Drawing.Size(75, 33);
            this.HoldButton.TabIndex = 10;
            this.HoldButton.Text = "Hold";
            this.HoldButton.UseVisualStyleBackColor = false;
            this.HoldButton.Click += new System.EventHandler(this.HoldButton_Click);
            // 
            // AnotherGameGroupBox
            // 
            this.AnotherGameGroupBox.Controls.Add(this.NoOption);
            this.AnotherGameGroupBox.Controls.Add(this.YesOption);
            this.AnotherGameGroupBox.Enabled = false;
            this.AnotherGameGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnotherGameGroupBox.Location = new System.Drawing.Point(278, 121);
            this.AnotherGameGroupBox.Name = "AnotherGameGroupBox";
            this.AnotherGameGroupBox.Size = new System.Drawing.Size(129, 111);
            this.AnotherGameGroupBox.TabIndex = 11;
            this.AnotherGameGroupBox.TabStop = false;
            this.AnotherGameGroupBox.Text = "Another Game?";
            // 
            // NoOption
            // 
            this.NoOption.AutoSize = true;
            this.NoOption.Location = new System.Drawing.Point(7, 75);
            this.NoOption.Name = "NoOption";
            this.NoOption.Size = new System.Drawing.Size(41, 17);
            this.NoOption.TabIndex = 1;
            this.NoOption.TabStop = true;
            this.NoOption.Text = "No";
            this.NoOption.UseVisualStyleBackColor = true;
            this.NoOption.CheckedChanged += new System.EventHandler(this.NoOption_CheckedChanged);
            // 
            // YesOption
            // 
            this.YesOption.AutoSize = true;
            this.YesOption.Location = new System.Drawing.Point(6, 37);
            this.YesOption.Name = "YesOption";
            this.YesOption.Size = new System.Drawing.Size(46, 17);
            this.YesOption.TabIndex = 0;
            this.YesOption.TabStop = true;
            this.YesOption.Text = "Yes";
            this.YesOption.UseVisualStyleBackColor = true;
            this.YesOption.CheckedChanged += new System.EventHandler(this.YesOption_CheckedChanged);
            // 
            // DiceTimer
            // 
            this.DiceTimer.Tick += new System.EventHandler(this.DiceTimer_Tick);
            // 
            // Pig_With_Two_Dice_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 261);
            this.Controls.Add(this.AnotherGameGroupBox);
            this.Controls.Add(this.HoldButton);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.PlayerTwoTotalTextBox);
            this.Controls.Add(this.PlayerOneTotalTextBox);
            this.Controls.Add(this.PlayerTwoTotalLabel);
            this.Controls.Add(this.PlayerOneTotalLabel);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.WhoseTurnToLabel);
            this.Name = "Pig_With_Two_Dice_Form";
            this.Text = "Pig with Two Dice Form";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.AnotherGameGroupBox.ResumeLayout(false);
            this.AnotherGameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WhoseTurnToLabel;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.Label PlayerOneTotalLabel;
        private System.Windows.Forms.Label PlayerTwoTotalLabel;
        private System.Windows.Forms.TextBox PlayerOneTotalTextBox;
        private System.Windows.Forms.TextBox PlayerTwoTotalTextBox;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Button HoldButton;
        private System.Windows.Forms.GroupBox AnotherGameGroupBox;
        private System.Windows.Forms.RadioButton NoOption;
        private System.Windows.Forms.RadioButton YesOption;
        private System.Windows.Forms.Timer DiceTimer;
    }
}