using EASYPROJECT01.EASY_CALLENDER01.MODEL.LIFE_STUDY_MODEL.THE_BIBLE_MODEL.THE_BIBLE_GET_MODEL;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using System.Text;
using System.Xml;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using EASYPROJECT01.EASY_CALLENDER01.MODEL.LIFE_STUDY_MODEL.THE_BIBLE_MODEL.THE_BIBLE_MODEL;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_SERVICES;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.LIFE_STUDY_SERVICES.THE_BIBLE
{
    public class The_Bible_Services01
    {
        private static File_Manger01 File_M1 = new File_Manger01();
        private static File_Manger13 File_M13 = new File_Manger13();
        public static List<string> BibleChunks = new();
        private static string[] data01 = new string[100];
        public List<string> thebook = new List<string>();
        public List<string> bookname = new List<string>();
        public List<string> charpter = new List<string>();
        public List<string> verses = new List<string>();
        private static bool _chunksLoaded = false;
        private List<string> date_list = new List<string>();
        private List<string> text_list = new List<string>();

        private static File_Manger01 File_M01 = new File_Manger01();
        private static File_Servicesr01 File_S01 = new File_Servicesr01();
        private List<The_Bible_Model01> The_Bible_M01 = new List<The_Bible_Model01>();

        public The_Bible_Services01()
        {
            load_bible_data();
        }

        public string get_data01()
        {

            string previous = string.Empty;
            for (int i = 0; i < bookname.Count; i++)
            {
                string current = bookname[i];
                if (current == previous)
                {
                    continue;

                }
                else
                {
                    previous = current;
                }
                data01[1] += $"{current}\n";

            }
            return data01[1];
        }
        public string get_data02(string input)
        {

            if (verses.Contains(input) == true)
            {
                foreach (string a in verses)
                {
                    data01[2] = $"{a}\n";
                }
            }
            else
            {
                data01[2] = "cant find";
            }
            return data01[2];
        }

        public string string_read_kjv()
        {
            data01[3] = File_M13.The_Book_of_TOB_pdf;
            return data01[3];
        }
        private void load_bible_data()
        {
            string[] lines = File_Manger01.The_Bible_KJV.Split('\n');
            string previousBook = string.Empty;

            foreach (string line in lines)
            {
                thebook.Add(line);

                if (string.IsNullOrWhiteSpace(line))
                {
                    bookname.Add("");
                    continue;
                }
                else
                {

                    int spaceIndex = line.IndexOf(' ');
                    string book = (spaceIndex == -1) ? line : line.Substring(0, spaceIndex);
                    if (book == previousBook)
                    {
                        continue;

                    }
                    else
                    {
                        previousBook = book;
                        bookname.Add(book);
                    }

                }
            }

        }
        public void LoadBibleChunks()
        {
            if (_chunksLoaded)
                return;

            // Load once from embedded text
            string[] lines = File_Manger01.The_Bible_KJV.Split('\n');

            const int versesPerChunk = 8;
            var sb = new StringBuilder();
            int count = 0;

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                sb.AppendLine(line);
                count++;

                if (count >= versesPerChunk)
                {
                    BibleChunks.Add(sb.ToString());
                    sb.Clear();
                    count = 0;
                }
            }

            if (sb.Length > 0)
                BibleChunks.Add(sb.ToString());

            _chunksLoaded = true;
        }
        public string select_past_text_using_textfile01(string input)
        {

            if (DateTime.TryParse(input, out DateTime searchDate))
            {
                foreach (var log in The_Bible_M01)
                {
                    if (log.Date.Date == searchDate.Date)
                    {
                        data01[0] = $"{log.Date:yyyy-MM-dd HH:mm:ss}\n" +
                                $"{log.Message}\n";

                    }
                    else
                    {
                        data01[0] = $"wrong input\n";
                    }
                }
            }
            else
            {
                data01[0] = $"something happened\n";

            }
            return data01[0];
        }
        public void set_past_text_using_textfile01(string[] lines)
        {


            for (int i = 0; i < lines.Length - 1; i += 2)
            {
                if (DateTime.TryParseExact(
                    lines[i],
                    "yyyy-MM-dd HH:mm:ss",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime date))
                {
                    The_Bible_M01.Add(new The_Bible_Model01
                    {
                        Date = date,
                        Message = lines[i + 1]
                    });
                }
            }
        }
    }
}