using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomewWork9
{
    
    public partial class Form1 : Form
    {
        public static List<UrlData> urlDatas = new List<UrlData>();
        public static string startUrl;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_crawl_Click(object sender, EventArgs e)
        {
            startUrl = tb_startuml.Text;
            SimpleCrawler.WillCrawl(startUrl);
            bds_urldata.DataSource = urlDatas;
        }
    }
    public class SimpleCrawler
    {
        public List<string> lists = new List<string>();
        private Hashtable urls = new Hashtable();
        private int count = 0;
        public static void WillCrawl(string startUrl)
        {
            UrlData urlData = new UrlData();
            urlData.Url = startUrl;
            urlData.IsSuccess = true;
            Form1.urlDatas.Add(urlData);
            SimpleCrawler myCrawler = new SimpleCrawler();         
            myCrawler.urls.Add(startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
        }

        private void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                    lists.Add(current);
                }

                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html);//解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html)
        {

            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            UrlData urlData = new UrlData();
            foreach (Match match in matches)
            {
                urlData.Url = strRef;
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;               
                urlData.IsSuccess =true;
                if (urls[strRef] == null) urls[strRef] = false;
                if (!Regex.IsMatch(strRef, "html") || !Regex.IsMatch(strRef, "aspe") ||! Regex.IsMatch(strRef, "jsp")) {
                    urlData.IsSuccess = false;
                    Form1.urlDatas.Add(urlData);
                    continue;
                }
                if (!Regex.IsMatch(strRef,Form1.startUrl))
                {
                    urls[strRef] = true;
                    urlData.IsSuccess = false;

                }
                Form1.urlDatas.Add(urlData);
            }
        }
    }

    public class UrlData
    {
        string url;
        bool isSucccess;
        public string Url
        {
            get => url;
            set => url = value;
        }
        public bool IsSuccess
        {
            get => isSucccess;
            set => isSucccess = value;
        }
    }
}
