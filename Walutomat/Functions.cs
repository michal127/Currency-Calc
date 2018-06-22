using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace walutomat
{
    class Functions
    {
        public Double getValue(String link, String pattern)  //Method for filltering html code for currency value using regex function
        {

            String html_code = getWeb(link);  //Downloading entire html codes in simple strings using getWeb function
            Double value = Convert.ToDouble(Regex.Match(html_code, pattern).Groups[1].Value);   //Filtering html code using regex pattern
            return value;
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

        public String getWeb(String link)   //Method for downloading html code from given link
        {
            WebClient web = new WebClient();
            String html = web.DownloadString(link);
            return html;
        }
        public void ClearSingleCurrency(TextBox Text, TextBox ResultText, Label ErrText) //Method for clearing all textboxes and labels for single currency
        {
            Text.Text = "";
            ResultText.Text = "";
            ErrText.Text = "";
        }  
       


    }
}
