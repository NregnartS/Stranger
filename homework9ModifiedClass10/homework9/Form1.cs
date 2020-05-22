using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crawler;
using System.Text.RegularExpressions;
using System.Threading;

namespace homework9
{
    public partial class Form1 : Form
    {
        SimpleCrawler simpleCrawler = new SimpleCrawler();
        Thread thread = null;
        
        public Form1()
        {
            InitializeComponent();
            simpleCrawler.PageDownloaded += Crawler_PageDownloaded;
            simpleCrawler.CrawlerStopped += Crawler_CrawlerStopped;
        }
        private void Crawler_PageDownloaded(SimpleCrawler crawler, string url, string info)
        {
            var pageInfo = new {URL = url, Status = info };
            Action action = () => { ClimbResult.Text+=pageInfo+"\r\n";};
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }
        private void Crawler_CrawlerStopped(SimpleCrawler obj)
        {
            Action action = () => ClimbResult.Text += "爬虫已停止"+"\r\n";
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }
        private void StartClimb_Click(object sender, EventArgs e)
        {
            simpleCrawler.StartURL = StartUrlTextBox.Text;
            Match match = Regex.Match(simpleCrawler.StartURL, SimpleCrawler.urlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            simpleCrawler.HostFilter = "^" + host + "$";
            simpleCrawler.FileFilter = ".html?$";

            if (thread != null)
            {
                thread.Abort();
            }
            thread = new Thread(simpleCrawler.Start);
            thread.Start();
            ClimbResult.Text = "爬虫已启动...."+"\r\n";
        }
    }
}
