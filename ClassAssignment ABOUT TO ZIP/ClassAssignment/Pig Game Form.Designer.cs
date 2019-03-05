namespace ClassAssignment {
    partial class Pig_Game_Form {
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
            this.WhoseTurnToLabel = new System.Windows.Forms.Label();
            this.RollOrHold = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.PlayerOneTotalLabel = new System.Windows.Forms.Label();
            this.PlayerTwoTotalLabel = new System.Windows.Forms.Label();
            this.PlayerOneTotalTextBox = new System.Windows.Forms.TextBox();
            this.PlayerTwoTotalTextBox = new System.Windows.Forms.TextBox();
            this.RollButton = new System.Windows.Forms.Button();
            this.HoldButton = new System.Windows.Forms.Button();
            this.AnotherGameGroupBox = new System.Windows.Forms.GroupBox();
            this.NoOption = new System.Windows.Forms.RadioButton();
            this.YesOption = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.AnotherGameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WhoseTurnToLabel
            // 
            this.WhoseTurnToLabel.AutoSize = true;
            this.WhoseTurnToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhoseTurnToLabel.Location = new System.Drawing.Point(15, 65);
            this.WhoseTurnToLabel.Name = "WhoseTurnToLabel";
            this.WhoseTurnToLabel.Size = new System.Drawing.Size(53, 13);
            this.WhoseTurnToLabel.TabIndex = 0;
            this.WhoseTurnToLabel.Text = "Player 1";
            // 
            // RollOrHold
            // 
            this.RollOrHold.AutoSize = true;
            this.RollOrHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollOrHold.Location = new System.Drawing.Point(15, 78);
            this.RollOrHold.Name = "RollOrHold";
            this.RollOrHold.Size = new System.Drawing.Size(74, 13);
            this.RollOrHold.TabIndex = 1;
            this.RollOrHold.Text = "Roll or Hold";
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(105, 45);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(55, 55);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            // 
            // PlayerOneTotalLabel
            // 
            this.PlayerOneTotalLabel.AutoSize = true;
            this.PlayerOneTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerOneTotalLabel.Location = new System.Drawing.Point(213, 45);
            this.PlayerOneTotalLabel.Name = "PlayerOneTotalLabel";
            this.PlayerOneTotalLabel.Size = new System.Drawing.Size(86, 13);
            this.PlayerOneTotalLabel.TabIndex = 3;
            this.PlayerOneTotalLabel.Text = "Player 1 Total";
            // 
            // PlayerTwoTotalLabel
            // 
            this.PlayerTwoTotalLabel.AutoSize = true;
            this.PlayerTwoTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerTwoTotalLabel.Location = new System.Drawing.Point(213, 78);
            this.PlayerTwoTotalLabel.Name = "PlayerTwoTotalLabel";
            this.PlayerTwoTotalLabel.Size = new System.Drawing.Size(86, 13);
            this.PlayerTwoTotalLabel.TabIndex = 4;
            this.PlayerTwoTotalLabel.Text = "Player 2 Total";
            // 
            // PlayerOneTotalTextBox
            // 
            this.PlayerOneTotalTextBox.Location = new System.Drawing.Point(317, 45);
            this.PlayerOneTotalTextBox.Name = "PlayerOneTotalTextBox";
            this.PlayerOneTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlayerOneTotalTextBox.TabIndex = 5;
            // 
            // PlayerTwoTotalTextBox
            // 
            this.PlayerTwoTotalTextBox.Location = new System.Drawing.Point(317, 78);
            this.PlayerTwoTotalTextBox.Name = "PlayerTwoTotalTextBox";
            this.PlayerTwoTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlayerTwoTotalTextBox.TabIndex = 6;
            // 
            // RollButton
            // 
            this.RollButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollButton.Location = new System.Drawing.Point(36, 160);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(75, 32);
            this.RollButton.TabIndex = 7;
            this.RollButton.Text = "Roll";
            this.RollButton.UseVisualStyleBackColor = false;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // HoldButton
            // 
            this.HoldButton.BackColor = System.Drawing.Color.Red;
            this.HoldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoldButton.Location = new System.Drawing.Point(127, 159);
            this.HoldButton.Name = "HoldButton";
            this.HoldButton.Size = new System.Drawing.Size(75, 33);
            this.HoldButton.TabIndex = 8;
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
            this.AnotherGameGroupBox.Location = new System.Drawing.Point(288, 138);
            this.AnotherGameGroupBox.Name = "AnotherGameGroupBox";
            this.AnotherGameGroupBox.Size = new System.Drawing.Size(129, 111);
            this.AnotherGameGroupBox.TabIndex = 9;
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
            // Pig_Game_Form
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
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.RollOrHold);
            this.Controls.Add(this.WhoseTurnToLabel);
            this.Name = "Pig_Game_Form";
            this.Text = "Pig Game ";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.AnotherGameGroupBox.ResumeLayout(false);
            this.AnotherGameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WhoseTurnToLabel;
        private System.Windows.Forms.Label RollOrHold;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label PlayerOneTotalLabel;
        private System.Windows.Forms.Label PlayerTwoTotalLabel;
        private System.Windows.Forms.TextBox PlayerOneTotalTextBox;
        private System.Windows.Forms.TextBox PlayerTwoTotalTextBox;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Button HoldButton;
        private System.Windows.Forms.GroupBox AnotherGameGroupBox;
        private System.Windows.Forms.RadioButton NoOption;
        private System.Windows.Forms.RadioButton YesOption;
    }
}