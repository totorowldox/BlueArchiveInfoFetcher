using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using BlueArchiveInfoFetcher.Data;
using System.Reflection;

namespace BlueArchiveInfoFetcher.ViewModels
{
    internal class BannerViewModel : ViewModelBase
    {
        public BannerViewModel()
        {
            Instance = this;
/*            Banners = new ObservableCollection<BannerData>() { new BannerData() {
                Title = "你妈死了",
                Duration = "2007 - 2023",
                RemainTime = "20小时",
                Preview = new System.Windows.Media.Imaging.BitmapImage(new Uri("E:/DESKTOP/QQ截图20230807221015.png")),
            } };*/
        }

        public static BannerViewModel Instance { get; private set; }

        public List<BannerData> GachaBanners { get; set; } = new List<BannerData>();
        public List<BannerData> ActivityBanners { get; set; } = new List<BannerData>();
    }
}
