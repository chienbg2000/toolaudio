using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CrawleDAO
    {
        String folderName = "D:\\crawle";

        public static string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", "127.0.0.1", "test", "root", "");
        public CrawleDAO()
        {
           
        }
        public static List<CrawlerFile> geCrawlerStoriesFiles(int count)
        {
            using (MySqlConnection Connection = new MySqlConnection(connstring))
            {

                Connection.Open();

                string query = "SELECT * FROM crawler_stories_file  WHERE csf_status=1 LIMIT "+ count;
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, Connection);
                var reader = cmd.ExecuteReader();
                List<CrawlerFile> crawlerStoriesFiles = new List<CrawlerFile>();
                int stt = 0;
                while(reader.Read())
                {
                    CrawlerFile crawlerFile = new CrawlerFile();
                    crawlerFile.Stt = stt;
                    crawlerFile.Id = reader.GetInt32("id");
                    crawlerFile.Link = reader.GetString("csf_link");
                    crawlerFile.FileName = $"{ DateTime.Now.ToString("yyyy-MM-dd")}__{crawlerFile.Id}{ Path.GetFileName(crawlerFile.Link)}";
                    crawlerFile.Progressbar = "0%";
                    crawlerFile.Status = "1";

                    crawlerStoriesFiles.Add(crawlerFile);
                    stt++;
                }

                return crawlerStoriesFiles;

            }

        }
        public static CrawlerFile getNextCrawlerStoriesFile()
        {
            using (MySqlConnection Connection = new MySqlConnection(connstring)) {
              
                Connection.Open();
                
                string query = "SELECT * FROM crawler_stories_file  WHERE csf_status=1 LIMIT 1";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, Connection);
                var reader = cmd.ExecuteReader();
                CrawlerFile crawlerStoriesFile = new CrawlerFile();
                if (reader.Read())
                {
                    crawlerStoriesFile.Id = reader.GetInt32("id");
                    crawlerStoriesFile.Link = reader.GetString("csf_link");
                }
                   
                return crawlerStoriesFile;
                
            }
          
        }

        public static bool upDateStoriesFile(CrawlerFile crawlerStoriesFile)
        {
            using (MySqlConnection Connection = new MySqlConnection(connstring))
            {  
                Connection.Open();
                string query = String.Format("UPDATE crawler_stories_file set csf_status=2 , csf_path='{0}'  WHERE id={1}",crawlerStoriesFile.FileName,crawlerStoriesFile.Id);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, Connection);
                cmd.ExecuteNonQuery();
                Connection.Close();
                return true;
            }
        }

    }
}
