using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;


namespace walutomat
{
    public partial class Main_Window : Form   //This program is simple currency calculator, based on currency values downloaded from www.bankier.pl
    {
      

        public Double eurValue;
        public Double gbpValue;
        public Double usdValue;

        public Main_Window()
        {

            InitializeComponent();
            if (CheckConnection())
            {
                getValues();
                Timer timer = new Timer();
                timer.Interval = (60 * 1000);   //60 second auto refresh
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
            }
            else {
                MessageBox.Show("Please, check your internet connection! Currency values are set to default in offline mode", "Connection error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                eurValue = 4.3;
                gbpValue = 4.9;
                usdValue = 3.7;
                this.Text += " (Offline mode)";
            }
            setCurrLabels();
            Clear();
        }
        
        public void Clear()  //Method for clearing following currencies 
        {
            ClearSingleCurrency(eurTextBox, eurResult, eurERR);
            ClearSingleCurrency(gbpTextBox, gbpResult, gbpERR);
            ClearSingleCurrency(usdTextBox, usdResult, usdERR);
        }
        

       

        public void getValues()  //Method for downloading currency values from bankier.pl
        {
            CurrencyValue EUR = new CurrencyValue();
            CurrencyValue GBP = new CurrencyValue();
            CurrencyValue USD = new CurrencyValue();
            EUR.downloadValue("https://www.bankier.pl/waluty/kursy-walut/forex/EURPLN", @"profilLast\S{2}(.*)\s\S{2}div");
            GBP.downloadValue("https://www.bankier.pl/waluty/kursy-walut/forex/GBPPLN", @"profilLast\S{2}(.*)\s\S{2}div");
            USD.downloadValue("https://www.bankier.pl/waluty/kursy-walut/forex/USDPLN", @"profilLast\S{2}(.*)\s\S{2}div");
            eurValue = EUR.getValue();                                        
            gbpValue = GBP.getValue();
            usdValue = USD.getValue();      
        }
        public void setCurrLabels() {
            eurCurrency.Text = eurValue + "zł";
            gbpCurrency.Text = gbpValue + "zł";
            usdCurrency.Text = usdValue + "zł";
        }

        public void CountCurrency(Label ERRlabel, TextBox CurrResult, TextBox CurrTextBox, Double CurrValue, bool Reverse) //Method for calculating currency value and setting up labels
        {

            try
            {
                ERRlabel.Text = "";
                double currencyResult;
                if (!Reverse)  
                {
                    currencyResult = Math.Round(CurrValue * double.Parse(CurrTextBox.Text.Replace('.', ',')), 2);
                    CurrResult.Text = currencyResult.ToString();
                }
                else
                {
                    currencyResult = Math.Round(double.Parse(CurrResult.Text.Replace('.', ',')) / CurrValue, 2);
                    CurrTextBox.Text = currencyResult.ToString();
                }
            }
            catch (FormatException fEx)
            {
                ERRlabel.Text = "Type in correct value";
                CurrTextBox.Text = "";
                CurrResult.Text = "";
            }
        }


        public void ClearSingleCurrency(TextBox Text, TextBox ResultText, Label ErrText) //Method for clearing all textboxes and labels for single currency
        {
            Text.Text = "";
            ResultText.Text = "";
            ErrText.Text = "";
        }

        private void buttonEUR_Click(object sender, EventArgs e)
        {
            CountCurrency(eurERR, eurResult, eurTextBox, eurValue, false);
        }
        private void buttonGBP_Click(object sender, EventArgs e)
        {
            CountCurrency(gbpERR, gbpResult, gbpTextBox, gbpValue, false);
        }
        private void buttonUSD_Click(object sender, EventArgs e)
        {
            CountCurrency(usdERR, usdResult, usdTextBox, usdValue, false);
        }
        private void buttonEURrev_Click(object sender, EventArgs e)
        {
            CountCurrency(eurERR, eurResult, eurTextBox, eurValue, true);
        }
        private void buttonGBPrev_Click(object sender, EventArgs e)
        {
            CountCurrency(gbpERR, gbpResult, gbpTextBox, gbpValue, true);
        }
        private void buttonUSDrev_Click(object sender, EventArgs e)
        {
            CountCurrency(usdERR, usdResult, usdTextBox, usdValue, true);
        }
        private void ClearAll_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void timer_Tick(object sender, EventArgs e) //Auto refreshing currency values every 60 seconds
        {
            getValues();
        }
        public static bool CheckConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
