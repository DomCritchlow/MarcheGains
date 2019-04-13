using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using RestSharp;
using DotNet.Highcharts;
using System.Net;
using System.Threading;

namespace MarcheGains
{
   public  class API_CALL
    {
        const string clientwebadrress = "http://dev.markitondemand.com";
        const string clientsingle = "/api/v2/Quote/json?count=15&symbol=";
        const string clienthist = "/Api/v2/InteractiveChart/json?callback=jQuery&parameters=";
        //Tester Ticker
        const string ticker1 = "AAPL";
        
        //{%22Normalized%22:false,%22NumberOfDays%22:3650,%22DataPeriod%22:%22Day%22,%22Elements%22:[{%22Symbol%22:%22AAPL%22,%22Type%22:%22price%22,%22Params%22:[%22ohlc%22]},{%22Symbol%22:%22AAPL%22,%22Type%22:%22volume%22}]}


        private Stock updatedStock
        {
            get;
            set;
        }

        public virtual Stock Stock
        {
            get;
            set;
        }

        public Stock Stock1
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Stockhist Stockhist
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public virtual Stock getspecificStock(string stockticker)
        {
            var client = new RestClient(clientwebadrress);
            var request = new RestRequest(clientsingle + stockticker, Method.GET);

            IRestResponse response = client.Execute(request);
            var content = response.Content;
            //Console.WriteLine(content);
            char r = 'R';
            Stock stock = new Stock();
            do {
                if (content[0] != r)
                {
                    stock = JsonConvert.DeserializeObject<Stock>(content);
                }
                Console.WriteLine("TestHere");
                Thread.Sleep(5000);
            } while (content[0] == r);
            return stock;
        }

        public virtual Stock stocklist(List<string> tickerlist)
        {
            string stocktext = "listofstocksticker.txt";
            int numstocks = 0;

            int bytesRead = 0;
            byte[] buffer = new byte[2048];
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://ftp.nasdaqtrader.com/SymbolDirectory/nasdaqlisted.txt");
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();

            Stream reader = request.GetResponse().GetResponseStream();
            FileStream fileStream = new FileStream(stocktext, FileMode.Create);

            while (true)
            {
                bytesRead = reader.Read(buffer, 0, buffer.Length);
                if (bytesRead == 0)
                    break;

                fileStream.Write(buffer, 0, bytesRead);
            }
            fileStream.Close();


            string text = System.IO.File.ReadAllText(stocktext);

            string[] lines = text.Split('\n');
            numstocks = lines.Length;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] cells = lines[i].Split('|');

                tickerlist.Add(cells[0]);
            }
            tickerlist.RemoveAt(numstocks - 1);
            tickerlist.RemoveAt(numstocks - 2);
            tickerlist.RemoveAt(0);
            numstocks = tickerlist.Count;

            int rand = new Random().Next(0, numstocks);

            string ticker = tickerlist[rand];
            Console.Write(rand);
          


            Stock currentStock = new Stock();
           
            currentStock = this.getspecificStock(ticker);
            do
            {
                rand = new Random().Next(0, numstocks);

                ticker = tickerlist[rand];
                Console.Write(rand);

                
                currentStock = this.getspecificStock(ticker);
            } while (currentStock.Symbol == null);

            return currentStock;

        }



        public virtual Stockhist getstockhist(string ticker, int numdays, string period, string type)
        {

            string test = "{%22Normalized%22:false,%22NumberOfDays%22:" + numdays + ",%22DataPeriod%22:%22" + period + "%22,%22Elements%22:[{%22Symbol%22:%22"
                + ticker + "%22,%22Type%22:%22"
                + type + "%22,%22Params%22:[%22ohlc%22]},{%22Symbol%22:%22"
                + ticker + "%22,%22Type%22:%22volume%22}]}";

            var client = new RestClient(clientwebadrress);
            var request = new RestRequest(clienthist + test, Method.GET);

            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content[0]);
            Stockhist stockhist1 = new Stockhist();

            char test1 = content[0];
            char r = 'R';
            char g = '<';
            do
            {
                
                if (content[0] != r && content[0] != g)
                {
                    stockhist1 = JsonConvert.DeserializeObject<Stockhist>(content);
                }
                Console.WriteLine("Test");
                Thread.Sleep(2000);
            } while (content[0] == r && content[0] == g);
            return stockhist1;

        }

    }
}
