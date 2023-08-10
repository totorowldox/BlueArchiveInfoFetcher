using BlueArchiveInfoFetcher.Network;
using BlueArchiveInfoFetcher.Utils;
using BlueArchiveInfoFetcher.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BlueArchiveInfoFetcher
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new BannerViewModel();
            DataFetcher.Fetch();
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("123");
            Image image = sender as Image;
            var window = new PopupImage();
            window.ResetImage(image.Source);
            window.Activate();
            window.Show();
            window.Topmost = true;
        }
    }
}
