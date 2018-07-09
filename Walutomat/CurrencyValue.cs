using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace walutomat
{
    class CurrencyValue                                          
    {
        private Double value;
        public Double getValue()
        {
            return value;
        }
        public void downloadValue(String link, String pattern)     //Method for filltering html code for currency value using regex function
        {
            String html_code = getWeb(link);                       //Downloading entire html code in simple string using getWeb function
            value = Convert.ToDouble(Regex.Match(html_code, pattern).Groups[1].Value);   //Filtering html code using regex pattern
        }
        private String getWeb(String link)                         //Method for downloading html code from given link
        {
            WebClient web = new WebClient();
            String html = web.DownloadString(link);
            return html;
        }

    }
}
