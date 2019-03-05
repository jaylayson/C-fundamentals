namespace Currency_Converter_GUI {
    partial class Currency {
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
            this.CurrencyIHave = new System.Windows.Forms.Label();
            this.CurrencyIWant = new System.Windows.Forms.Label();
            this.HaveComboBox = new System.Windows.Forms.ComboBox();
            this.WantComboBox = new System.Windows.Forms.ComboBox();
            this.AmountIHave = new System.Windows.Forms.Label();
            this.AmountIWant = new System.Windows.Forms.Label();
            this.HaveInput = new System.Windows.Forms.TextBox();
            this.WantInput = new System.Windows.Forms.TextBox();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.AnotherConversion = new System.Windows.Forms.GroupBox();
            this.NoOption = new System.Windows.Forms.RadioButton();
            this.YesOption = new System.Windows.Forms.RadioButton();
            this.FromCurrency = new System.Windows.Forms.Label();
            this.ToCurrency = new System.Windows.Forms.Label();
            this.AnotherConversion.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrencyIHave
            // 
            this.CurrencyIHave.AutoSize = true;
            this.CurrencyIHave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyIHave.Location = new System.Drawing.Point(40, 29);
            this.CurrencyIHave.Name = "CurrencyIHave";
            this.CurrencyIHave.Size = new System.Drawing.Size(122, 17);
            this.CurrencyIHave.TabIndex = 0;
            this.CurrencyIHave.Text = "Currency I have";
            // 
            // CurrencyIWant
            // 
            this.CurrencyIWant.AutoSize = true;
            this.CurrencyIWant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyIWant.Location = new System.Drawing.Point(288, 29);
            this.CurrencyIWant.Name = "CurrencyIWant";
            this.CurrencyIWant.Size = new System.Drawing.Size(120, 17);
            this.CurrencyIWant.TabIndex = 1;
            this.CurrencyIWant.Text = "Currency I want";
            // 
            // HaveComboBox
            // 
            this.HaveComboBox.FormattingEnabled = true;
            this.HaveComboBox.Location = new System.Drawing.Point(43, 49);
            this.HaveComboBox.Name = "HaveComboBox";
            this.HaveComboBox.Size = new System.Drawing.Size(121, 21);
            this.HaveComboBox.TabIndex = 2;
            this.HaveComboBox.SelectedIndexChanged += new System.EventHandler(this.HaveComboBox_SelectedIndexChanged);
            // 
            // WantComboBox
            // 
            this.WantComboBox.Enabled = false;
            this.WantComboBox.FormattingEnabled = true;
            this.WantComboBox.Location = new System.Drawing.Point(287, 49);
            this.WantComboBox.Name = "WantComboBox";
            this.WantComboBox.Size = new System.Drawing.Size(121, 21);
            this.WantComboBox.TabIndex = 3;
            this.WantComboBox.SelectedIndexChanged += new System.EventHandler(this.WantComboBox_SelectedIndexChanged);
            // 
            // AmountIHave
            // 
            this.AmountIHave.AutoSize = true;
            this.AmountIHave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountIHave.Location = new System.Drawing.Point(40, 145);
            this.AmountIHave.Name = "AmountIHave";
            this.AmountIHave.Size = new System.Drawing.Size(111, 17);
            this.AmountIHave.TabIndex = 4;
            this.AmountIHave.Text = "Amount I have";
            // 
            // AmountIWant
            // 
            this.AmountIWant.AutoSize = true;
            this.AmountIWant.Enabled = false;
            this.AmountIWant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountIWant.Location = new System.Drawing.Point(299, 142);
            this.AmountIWant.Name = "AmountIWant";
            this.AmountIWant.Size = new System.Drawing.Size(109, 17);
            this.AmountIWant.TabIndex = 5;
            this.AmountIWant.Text = "Amount I want";
            // 
            // HaveInput
            // 
            this.HaveInput.Enabled = false;
            this.HaveInput.Location = new System.Drawing.Point(43, 165);
            this.HaveInput.Name = "HaveInput";
            this.HaveInput.Size = new System.Drawing.Size(100, 20);
            this.HaveInput.TabIndex = 6;
            this.HaveInput.TextChanged += new System.EventHandler(this.HaveInput_TextChanged);
            // 
            // WantInput
            // 
            this.WantInput.Enabled = false;
            this.WantInput.Location = new System.Drawing.Point(302, 166);
            this.WantInput.Name = "WantInput";
            this.WantInput.Size = new System.Drawing.Size(100, 20);
            this.WantInput.TabIndex = 7;
            this.WantInput.TextChanged += new System.EventHandler(this.WantInput_TextChanged);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Enabled = false;
            this.EqualsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsButton.Location = new System.Drawing.Point(174, 142);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(75, 66);
            this.EqualsButton.TabIndex = 8;
            this.EqualsButton.Text = "Equals";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // AnotherConversion
            // 
            this.AnotherConversion.Controls.Add(this.NoOption);
            this.AnotherConversion.Controls.Add(this.YesOption);
            this.AnotherConversion.Enabled = false;
            this.AnotherConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnotherConversion.Location = new System.Drawing.Point(115, 220);
            this.AnotherConversion.Name = "AnotherConversion";
            this.AnotherConversion.Size = new System.Drawing.Size(185, 100);
            this.AnotherConversion.TabIndex = 9;
            this.AnotherConversion.TabStop = false;
            this.AnotherConversion.Text = "Another Conversion";
            this.AnotherConversion.Visible = false;
            // 
            // NoOption
            // 
            this.NoOption.AutoSize = true;
            this.NoOption.Location = new System.Drawing.Point(6, 50);
            this.NoOption.Name = "NoOption";
            this.NoOption.Size = new System.Drawing.Size(46, 21);
            this.NoOption.TabIndex = 1;
            this.NoOption.TabStop = true;
            this.NoOption.Text = "No";
            this.NoOption.UseVisualStyleBackColor = true;
            this.NoOption.CheckedChanged += new System.EventHandler(this.NoOption_CheckedChanged);
            // 
            // YesOption
            // 
            this.YesOption.AutoSize = true;
            this.YesOption.Location = new System.Drawing.Point(6, 22);
            this.YesOption.Name = "YesOption";
            this.YesOption.Size = new System.Drawing.Size(53, 21);
            this.YesOption.TabIndex = 0;
            this.YesOption.TabStop = true;
            this.YesOption.Text = "Yes";
            this.YesOption.UseVisualStyleBackColor = true;
            this.YesOption.CheckedChanged += new System.EventHandler(this.YesOption_CheckedChanged);
            // 
            // FromCurrency
            // 
            this.FromCurrency.AutoSize = true;
            this.FromCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromCurrency.Location = new System.Drawing.Point(2, 166);
            this.FromCurrency.Name = "FromCurrency";
            this.FromCurrency.Size = new System.Drawing.Size(35, 17);
            this.FromCurrency.TabIndex = 10;
            this.FromCurrency.Text = "000";
            this.FromCurrency.Visible = false;
            // 
            // ToCurrency
            // 
            this.ToCurrency.AutoSize = true;
            this.ToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToCurrency.Location = new System.Drawing.Point(265, 167);
            this.ToCurrency.Name = "ToCurrency";
            this.ToCurrency.Size = new System.Drawing.Size(35, 17);
            this.ToCurrency.TabIndex = 11;
            this.ToCurrency.Text = "000";
            this.ToCurrency.Visible = false;
            // 
            // Currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 332);
            this.Controls.Add(this.ToCurrency);
            this.Controls.Add(this.FromCurrency);
            this.Controls.Add(this.AnotherConversion);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.WantInput);
            this.Controls.Add(this.HaveInput);
            this.Controls.Add(this.AmountIWant);
            this.Controls.Add(this.AmountIHave);
            this.Controls.Add(this.WantComboBox);
            this.Controls.Add(this.HaveComboBox);
            this.Controls.Add(this.CurrencyIWant);
            this.Controls.Add(this.CurrencyIHave);
            this.Name = "Currency";
            this.Text = "Currency Converter";
            this.AnotherConversion.ResumeLayout(false);
            this.AnotherConversion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrencyIHave;
        private System.Windows.Forms.Label CurrencyIWant;
        private System.Windows.Forms.ComboBox HaveComboBox;
        private System.Windows.Forms.ComboBox WantComboBox;
        private System.Windows.Forms.Label AmountIHave;
        private System.Windows.Forms.Label AmountIWant;
        private System.Windows.Forms.TextBox HaveInput;
        private System.Windows.Forms.TextBox WantInput;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.GroupBox AnotherConversion;
        private System.Windows.Forms.RadioButton NoOption;
        private System.Windows.Forms.RadioButton YesOption;
        private System.Windows.Forms.Label FromCurrency;
        private System.Windows.Forms.Label ToCurrency;
    }
}

