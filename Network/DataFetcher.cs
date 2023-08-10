using BlueArchiveInfoFetcher.Data;
using BlueArchiveInfoFetcher.Serialized;
using BlueArchiveInfoFetcher.Utils;
using BlueArchiveInfoFetcher.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlueArchiveInfoFetcher.Network
{
    internal static class DataFetcher
    {
        public static async void Fetch()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("game-alias", "ba");
                    client.DefaultRequestHeaders.Add("game-id", "0");
                    client.DefaultRequestHeaders.Host = "ba.gamekee.com";
                    HttpResponseMessage response = await client.GetAsync("https://ba.gamekee.com/v1/wiki/index");
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<IndexData>(responseBody);
                        var temp1 = new List<BannerData>();
                        var temp2 = new List<BannerData>();
                        foreach(var l in data.data[4].list)
                        {
                            if (l.title.Contains("卡池"))
                            {
                                temp1.Add(BannerData.ConvertTo(l));
                            }
                            else
                            {
                                temp2.Add(BannerData.ConvertTo(l));
                            }
                        }
                        BannerViewModel.Instance.GachaBanners.AddRange(temp1.SortBanner());
                        BannerViewModel.Instance.ActivityBanners.AddRange(temp2.SortBanner());
                    }
                    else
                    {
                        Debug.WriteLine($"Request failed with status code {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
