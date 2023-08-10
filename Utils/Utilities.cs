using BlueArchiveInfoFetcher.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BlueArchiveInfoFetcher.Utils
{
    internal static class Utilities
    {
        public static DateTime StampToDateTime(long timeStamp)
        {
            DateTime dateTimeStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dateTimeStart.Add(toNow);
        }

        public static List<BannerData> SortBanner(this List<BannerData> banner)
        {
            return banner.OrderByDescending(x => x.endTime).ThenByDescending(x =>
            {
                switch (x.PubArea)
                {
                    case "日服":
                        return 1;
                    case "国际服":
                        return 2;
                    case "国服":
                        return 0;
                    default:
                        return 3;
                }
            }).ToList();
        }
    }
}
