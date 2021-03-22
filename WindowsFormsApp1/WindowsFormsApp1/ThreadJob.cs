using AltoHttp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using xNet;

namespace WindowsFormsApp1
{
    class ThreadJob
    {
        public CrawlerFile crawler;
        
        HttpDownloader httpDownloader;
        String folderName = "D:\\crawle";
        public delegate void ThreadJobEventHandle(ThreadJob sender);
        public event ThreadJobEventHandle OnStatusChanged;
        public delegate void ThreadJobEventHandle2(ThreadJob sender);
        public event ThreadJobEventHandle2 OnStatusChanged2;

        public ThreadJob(CrawlerFile crawler)
        {
            this.crawler = crawler;
            
        }
        public void DoJob()
        {
            httpDownloader = new HttpDownloader(crawler.Link, $"{folderName}\\{crawler.FileName}");
            httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
            httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
            httpDownloader.Start();
            
        }

        public void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            httpDownloader.ProgressChanged -= HttpDownloader_ProgressChanged;
            httpDownloader.DownloadCompleted -= HttpDownloader_DownloadCompleted;
            OnStatusChanged2(this);
        }

        public void HttpDownloader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
              crawler.Progressbar =  e.Progress.ToString() + "%";
              OnStatusChanged(this);

        }
    }
}
