using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CrawlerFile
    {
        private int stt;
        private int id;
        private String link;
        private String status;
        private String fileName;
        private String progressbar;

        public int Stt { get => stt; set => stt = value; }

        public int Id { get => id; set => id = value; }
        public string Link { get => link; set => link = value; }
        public string Status { get => status; set => status = value; }
        public string FileName { get => fileName; set => fileName = value; }
        public string Progressbar { get => progressbar; set => progressbar = value; }
    }
}
