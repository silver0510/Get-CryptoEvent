using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fizzler;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using System.Net;
using System.Globalization;

namespace CrytocoinTodayEvent
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            dtpCheckDay.Value = DateTime.Now.Date;
            txtPageNumber.Text = "8";
        }

        private void getCryptoTodayEvent()
        {
            //Khởi tạo biến chứa trang web
            HtmlWeb htmlWeb = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8 //Set UTF8 để hiển thị tiếng Việt
            };

            var items = new List<CryptocoinEvent>();
            txtEvent.Text = "";
            int i = 0;
            int TOTALPAGECHECK;
            bool isNumber = Int32.TryParse(txtPageNumber.Text,out TOTALPAGECHECK);
            if (!isNumber || (TOTALPAGECHECK <= 0)) TOTALPAGECHECK = 8;
            CryptocoinEvent coinEvent = new CryptocoinEvent();
            bool blnChecked = false;
            bool blnBreak = false;
            for (int n = 1;n<= TOTALPAGECHECK; n++)
            {
                if (blnBreak) break;
                //Load trang web, nạp html vào document
                HtmlAgilityPack.HtmlDocument document = htmlWeb.Load("https://coinmarketcal.com/?page=" + n);

                //Load các element cần tìm vào mảng
                var threadItems = document.DocumentNode.SelectNodes("//*[@id='explore']/div[2]/div[3]/article").ToList();
                foreach (var item in threadItems)
                {                  
                    string strEventDay = item.SelectSingleNode(".//div/h5[1]").InnerText.Trim();
                    string strToday = dtpCheckDay.Value.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("en-US"));
                    if (!strEventDay.Contains(strToday))
                    {
                        if (!blnChecked)
                            continue;
                        else
                            blnBreak = true;
                            break;
                    }
                    if (!blnChecked) blnChecked = true;
               
                    i++;
                    txtEvent.Text += i.ToString() + "/ ";
                    coinEvent.coinName = decoderFromHtmlUtinitiesToString(item.SelectSingleNode(".//div/h5[2]").InnerText.Trim());
                    coinEvent.eventName = decoderFromHtmlUtinitiesToString(item.SelectSingleNode(".//div/h5[3]").InnerText.Trim());
                    coinEvent.eventDescription = decoderFromHtmlUtinitiesToString(item.SelectSingleNode(".//div/div/p[2]").InnerText.Trim());

                    txtEvent.Text += coinEvent.coinName;
                    txtEvent.Text += Environment.NewLine;
                    txtEvent.Text += "Event: " + coinEvent.eventName;
                    txtEvent.Text += Environment.NewLine;
                    txtEvent.Text += "Description: " + coinEvent.eventDescription;
                    txtEvent.Text += Environment.NewLine;
                }
            }
            
        }

        static string decoderFromHtmlUtinitiesToString(string unicodeString)
        {
            return WebUtility.HtmlDecode(unicodeString);
        }

        private void btnGetEvent_Click(object sender, EventArgs e)
        {
            getCryptoTodayEvent();
        }
    }
}
