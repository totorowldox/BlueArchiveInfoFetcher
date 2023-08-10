using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace BlueArchiveInfoFetcher.Data
{
    internal class BannerData
    {
        public string Title { get; set; }
        public string Duration { get; set; }
        public string RemainTime { get; set; }
        public BitmapImage Preview { get; set; }

        public DateTime endTime;
        public string PubArea;

        public static BannerData ConvertTo(Serialized.List list)
        {
            var from = Utils.Utilities.StampToDateTime((long)list.begin_at).ToLocalTime();
            var to = Utils.Utilities.StampToDateTime((long)list.end_at).ToLocalTime();
            BitmapImage preview = null;
            try
            {
                preview = new BitmapImage(new Uri($"https:{list.picture}"));
            }
            catch
            {
                preview = new BitmapImage(new Uri($"file://{Directory.GetCurrentDirectory()}/Placeholder.webp"));
            }
            Debug.WriteLine("123");
            var duration = to - DateTime.Now;
            return new BannerData()
            {
                Title = list.title,
                Duration = $"{from:MM-dd HH:mm} ~ \n{to:MM-dd HH:mm}",
                RemainTime = $"{duration.Days}天 {duration.Hours}小时 {duration.Minutes}分钟",
                Preview = preview,
                endTime = to,
                PubArea = list.pub_area
        };
        }
    }
}
