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
    public partial class Okno_główne : Form
    {
        Functions functions = new Functions();

        public Double eurValue;
        public Double gbpValue;
        public Double usdValue;

        public Okno_główne()
        {

            InitializeComponent();
            getValues();
            Clear();
            Timer timer = new Timer();
            timer.Interval = (60 * 1000);   //60 second auto refresh
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
       

        }
        
        public void Clear()                       //Method for clearing following currencies 
        {
            functions.ClearSingleCurrency(eurTextBox, eurResult, eurERR);
            functions.ClearSingleCurrency(gbpTextBox, gbpResult, gbpERR);
            functions.ClearSingleCurrency(usdTextBox, usdResult, usdERR);
        }
        

       

        public void getValues()  //Method for downloading currency values from bankier.pl
        {
                               
            eurValue = functions.getValue("https://www.bankier.pl/waluty/kursy-walut/forex/EURPLN", @"profilLast\S{2}(.*)\s\S{2}div");                                           //Function for filtering html code using our regex pattern
            gbpValue = functions.getValue("https://www.bankier.pl/waluty/kursy-walut/forex/GBPPLN", @"profilLast\S{2}(.*)\s\S{2}div");
            usdValue = functions.getValue("https://www.bankier.pl/waluty/kursy-walut/forex/USDPLN", @"profilLast\S{2}(.*)\s\S{2}div");
            eurCurrency.Text = eurValue + "zł";           
            gbpCurrency.Text = gbpValue + "zł";
            usdCurrency.Text = usdValue + "zł";
        }

    

        private void buttonEUR_Click(object sender, EventArgs e)
        {
            functions.CountCurrency(eurERR, eurResult, eurTextBox, eurValue, false);
        }
        private void buttonGBP_Click(object sender, EventArgs e)
        {
            functions.CountCurrency(gbpERR, gbpResult, gbpTextBox, gbpValue, false);
        }
        private void buttonUSD_Click(object sender, EventArgs e)
        {
            functions.CountCurrency(usdERR, usdResult, usdTextBox, usdValue, false);
        }
        private void buttonEURrev_Click(object sender, EventArgs e)
        {
            functions.CountCurrency(eurERR, eurResult, eurTextBox, eurValue, true);
        }
        private void buttonGBPrev_Click(object sender, EventArgs e)
        {
            functions.CountCurrency(gbpERR, gbpResult, gbpTextBox, gbpValue, true);
        }
        private void buttonUSDrev_Click(object sender, EventArgs e)
        {
            functions.CountCurrency(usdERR, usdResult, usdTextBox, usdValue, true);
        }
        private void ClearAll_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            getValues();
        }
    }
}
