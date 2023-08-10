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
        }

        public static BannerViewModel Instance { get; private set; }

        public List<BannerData> GachaBanners { get; set; } = new List<BannerData>();
        public List<BannerData> ActivityBanners { get; set; } = new List<BannerData>();
    }
}
