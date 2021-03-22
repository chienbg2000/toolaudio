using AltoHttp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class CrawleForm : Form
    {
        int stt = 0;
        List<CrawlerFile> crawlerFiles;

        public CrawleForm()
        {
            InitializeComponent();
        
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            num_crawleCount.Enabled = false;
            num_threadCount.Enabled = false;
            btn_start.Enabled = false;
            crawlerFiles = CrawleDAO.geCrawlerStoriesFiles(int.Parse(num_crawleCount.Value.ToString()));
            foreach(CrawlerFile cr in crawlerFiles)
            {
                listview_crawle.Items.Add(new ListViewItem(new string[] {cr.Stt.ToString(), cr.Id.ToString(),cr.Link,
                cr.FileName,cr.Progressbar,cr.Status.ToString()}));
            }

            int totalWorkerThreads = 0;
            int totalCompletePort = 0;
            ThreadPool.GetAvailableThreads(out totalWorkerThreads, out totalCompletePort);

            for (int i = 0; i < num_threadCount.Value; i++)
            {
                ThreadJob tj = new ThreadJob(crawlerFiles[stt]);
                tj.OnStatusChanged += new ThreadJob.ThreadJobEventHandle(tj_OnStatusChanged);
                tj.OnStatusChanged2 += new ThreadJob.ThreadJobEventHandle2(tj_OnStatusChanged2);

                tj.DoJob();
                stt++;
            }
        }
        void tj_OnStatusChanged(ThreadJob sender)
        {
            this.Invoke(new MethodInvoker(delegate
            {

                listview_crawle.Items[sender.crawler.Stt].SubItems[4].Text = sender.crawler.Progressbar;

            }));
        }
        void tj_OnStatusChanged2(ThreadJob sender)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                listview_crawle.Items[sender.crawler.Stt].SubItems[5].Text = "2";
                CrawleDAO.upDateStoriesFile(sender.crawler);

                sender.crawler = crawlerFiles[stt];
                sender.DoJob();
                stt++;
            }));
        }

    }
}
