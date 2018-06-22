namespace walutomat
{
    partial class Okno_główne
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEUR = new System.Windows.Forms.Button();
            this.eurTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eurERR = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gbpCurrency = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbpTextBox = new System.Windows.Forms.TextBox();
            this.buttonGBP = new System.Windows.Forms.Button();
            this.gbpERR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usdERR = new System.Windows.Forms.Label();
            this.buttonUSD = new System.Windows.Forms.Button();
            this.usdTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.usdCurrency = new System.Windows.Forms.Label();
            this.ClearAll = new System.Windows.Forms.Button();
            this.eurCurrency = new System.Windows.Forms.Label();
            this.eurResult = new System.Windows.Forms.TextBox();
            this.usdResult = new System.Windows.Forms.TextBox();
            this.gbpResult = new System.Windows.Forms.TextBox();
            this.buttonEURrev = new System.Windows.Forms.Button();
            this.buttonGBPrev = new System.Windows.Forms.Button();
            this.buttonUSDrev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEUR
            // 
            this.buttonEUR.Location = new System.Drawing.Point(162, 39);
            this.buttonEUR.Name = "buttonEUR";
            this.buttonEUR.Size = new System.Drawing.Size(75, 23);
            this.buttonEUR.TabIndex = 0;
            this.buttonEUR.Text = "Calculate ->";
            this.buttonEUR.UseVisualStyleBackColor = true;
            this.buttonEUR.Click += new System.EventHandler(this.buttonEUR_Click);
            // 
            // eurTextBox
            // 
            this.eurTextBox.Location = new System.Drawing.Point(62, 41);
            this.eurTextBox.Name = "eurTextBox";
            this.eurTextBox.Size = new System.Drawing.Size(72, 20);
            this.eurTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PLN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "EUR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "EUR/PLN";
            // 
            // eurERR
            // 
            this.eurERR.AutoSize = true;
            this.eurERR.ForeColor = System.Drawing.Color.Red;
            this.eurERR.Location = new System.Drawing.Point(592, 44);
            this.eurERR.Name = "eurERR";
            this.eurERR.Size = new System.Drawing.Size(45, 13);
            this.eurERR.TabIndex = 7;
            this.eurERR.Text = "eurERR";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(607, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // gbpCurrency
            // 
            this.gbpCurrency.AutoSize = true;
            this.gbpCurrency.Location = new System.Drawing.Point(469, 77);
            this.gbpCurrency.Name = "gbpCurrency";
            this.gbpCurrency.Size = new System.Drawing.Size(67, 13);
            this.gbpCurrency.TabIndex = 9;
            this.gbpCurrency.Text = "gbpCurrency";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "GBP/PLN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "GBP";
            // 
            // gbpTextBox
            // 
            this.gbpTextBox.Location = new System.Drawing.Point(62, 74);
            this.gbpTextBox.Name = "gbpTextBox";
            this.gbpTextBox.Size = new System.Drawing.Size(72, 20);
            this.gbpTextBox.TabIndex = 12;
            // 
            // buttonGBP
            // 
            this.buttonGBP.Location = new System.Drawing.Point(162, 72);
            this.buttonGBP.Name = "buttonGBP";
            this.buttonGBP.Size = new System.Drawing.Size(75, 23);
            this.buttonGBP.TabIndex = 13;
            this.buttonGBP.Text = "Calculate ->";
            this.buttonGBP.UseVisualStyleBackColor = true;
            this.buttonGBP.Click += new System.EventHandler(this.buttonGBP_Click);
            // 
            // gbpERR
            // 
            this.gbpERR.AutoSize = true;
            this.gbpERR.ForeColor = System.Drawing.Color.Red;
            this.gbpERR.Location = new System.Drawing.Point(592, 77);
            this.gbpERR.Name = "gbpERR";
            this.gbpERR.Size = new System.Drawing.Size(48, 13);
            this.gbpERR.TabIndex = 15;
            this.gbpERR.Text = "gbpERR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Actual currency";
            // 
            // usdERR
            // 
            this.usdERR.AutoSize = true;
            this.usdERR.ForeColor = System.Drawing.Color.Red;
            this.usdERR.Location = new System.Drawing.Point(592, 106);
            this.usdERR.Name = "usdERR";
            this.usdERR.Size = new System.Drawing.Size(47, 13);
            this.usdERR.TabIndex = 30;
            this.usdERR.Text = "usdERR";
            // 
            // buttonUSD
            // 
            this.buttonUSD.Location = new System.Drawing.Point(162, 101);
            this.buttonUSD.Name = "buttonUSD";
            this.buttonUSD.Size = new System.Drawing.Size(75, 23);
            this.buttonUSD.TabIndex = 28;
            this.buttonUSD.Text = "Calculate ->";
            this.buttonUSD.UseVisualStyleBackColor = true;
            this.buttonUSD.Click += new System.EventHandler(this.buttonUSD_Click);
            // 
            // usdTextBox
            // 
            this.usdTextBox.Location = new System.Drawing.Point(62, 103);
            this.usdTextBox.Name = "usdTextBox";
            this.usdTextBox.Size = new System.Drawing.Size(72, 20);
            this.usdTextBox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "USD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(530, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "USD/PLN";
            // 
            // usdCurrency
            // 
            this.usdCurrency.AutoSize = true;
            this.usdCurrency.Location = new System.Drawing.Point(469, 106);
            this.usdCurrency.Name = "usdCurrency";
            this.usdCurrency.Size = new System.Drawing.Size(66, 13);
            this.usdCurrency.TabIndex = 24;
            this.usdCurrency.Text = "usdCurrency";
            // 
            // ClearAll
            // 
            this.ClearAll.Location = new System.Drawing.Point(62, 173);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(72, 23);
            this.ClearAll.TabIndex = 31;
            this.ClearAll.Text = "Clear";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // eurCurrency
            // 
            this.eurCurrency.AutoSize = true;
            this.eurCurrency.Location = new System.Drawing.Point(469, 44);
            this.eurCurrency.Name = "eurCurrency";
            this.eurCurrency.Size = new System.Drawing.Size(64, 13);
            this.eurCurrency.TabIndex = 1;
            this.eurCurrency.Text = "eurCurrency";
            // 
            // eurResult
            // 
            this.eurResult.Location = new System.Drawing.Point(371, 41);
            this.eurResult.Name = "eurResult";
            this.eurResult.Size = new System.Drawing.Size(72, 20);
            this.eurResult.TabIndex = 32;
            // 
            // usdResult
            // 
            this.usdResult.Location = new System.Drawing.Point(371, 103);
            this.usdResult.Name = "usdResult";
            this.usdResult.Size = new System.Drawing.Size(72, 20);
            this.usdResult.TabIndex = 34;
            // 
            // gbpResult
            // 
            this.gbpResult.Location = new System.Drawing.Point(371, 72);
            this.gbpResult.Name = "gbpResult";
            this.gbpResult.Size = new System.Drawing.Size(72, 20);
            this.gbpResult.TabIndex = 35;
            // 
            // buttonEURrev
            // 
            this.buttonEURrev.Location = new System.Drawing.Point(267, 39);
            this.buttonEURrev.Name = "buttonEURrev";
            this.buttonEURrev.Size = new System.Drawing.Size(75, 23);
            this.buttonEURrev.TabIndex = 36;
            this.buttonEURrev.Text = "<- Calculate";
            this.buttonEURrev.UseVisualStyleBackColor = true;
            this.buttonEURrev.Click += new System.EventHandler(this.buttonEURrev_Click);
            // 
            // buttonGBPrev
            // 
            this.buttonGBPrev.Location = new System.Drawing.Point(267, 72);
            this.buttonGBPrev.Name = "buttonGBPrev";
            this.buttonGBPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonGBPrev.TabIndex = 37;
            this.buttonGBPrev.Text = "<- Calculate";
            this.buttonGBPrev.UseVisualStyleBackColor = true;
            this.buttonGBPrev.Click += new System.EventHandler(this.buttonGBPrev_Click);
            // 
            // buttonUSDrev
            // 
            this.buttonUSDrev.Location = new System.Drawing.Point(267, 101);
            this.buttonUSDrev.Name = "buttonUSDrev";
            this.buttonUSDrev.Size = new System.Drawing.Size(75, 23);
            this.buttonUSDrev.TabIndex = 39;
            this.buttonUSDrev.Text = "<- Calculate";
            this.buttonUSDrev.UseVisualStyleBackColor = true;
            this.buttonUSDrev.Click += new System.EventHandler(this.buttonUSDrev_Click);
            // 
            // Okno_główne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 208);
            this.Controls.Add(this.buttonUSDrev);
            this.Controls.Add(this.buttonGBPrev);
            this.Controls.Add(this.buttonEURrev);
            this.Controls.Add(this.gbpResult);
            this.Controls.Add(this.usdResult);
            this.Controls.Add(this.eurResult);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.usdERR);
            this.Controls.Add(this.buttonUSD);
            this.Controls.Add(this.usdTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.usdCurrency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbpERR);
            this.Controls.Add(this.buttonGBP);
            this.Controls.Add(this.gbpTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbpCurrency);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.eurERR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eurTextBox);
            this.Controls.Add(this.eurCurrency);
            this.Controls.Add(this.buttonEUR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Okno_główne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEUR;
        private System.Windows.Forms.TextBox eurTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label eurERR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label gbpCurrency;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox gbpTextBox;
        private System.Windows.Forms.Button buttonGBP;
        private System.Windows.Forms.Label gbpERR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usdERR;
        private System.Windows.Forms.Button buttonUSD;
        private System.Windows.Forms.TextBox usdTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label usdCurrency;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Label eurCurrency;
        private System.Windows.Forms.TextBox eurResult;
        private System.Windows.Forms.TextBox usdResult;
        private System.Windows.Forms.TextBox gbpResult;
        private System.Windows.Forms.Button buttonEURrev;
        private System.Windows.Forms.Button buttonGBPrev;
        private System.Windows.Forms.Button buttonUSDrev;
    }
}

