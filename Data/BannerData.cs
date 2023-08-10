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
        public string RemainingTime { get; set; }
        public BitmapImage Preview { get; set; }
        public DateTime EndTime { get; set; }
        public string PubArea { get; set; }

        public static BannerData ConvertTo(Serialized.List list)
        {
            var from = Utils.Utilities.StampToDateTime((long)list.begin_at).ToLocalTime();
            var to = Utils.Utilities.StampToDateTime((long)list.end_at).ToLocalTime();
            BitmapImage preview;
            try
            {
                preview = new BitmapImage(new Uri($"https:{list.picture}"));
            }
            catch
            {
                preview = new BitmapImage(new Uri($"file://{Directory.GetCurrentDirectory()}/Placeholder.webp"));
            }
            var duration = to - DateTime.Now;
            return new BannerData()
            {
                Title = list.title,
                Duration = $"{from:MM-dd HH:mm} ~ \n{to:MM-dd HH:mm}",
                RemainingTime = $"{duration.Days}天 {duration.Hours}小时 {duration.Minutes}分钟",
                Preview = preview,
                EndTime = to,
                PubArea = list.pub_area
        };
        }
    }
}
