using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace BlueArchiveInfoFetcher.Utils
{
    /// <summary>
    /// PopupImage.xaml 的交互逻辑
    /// </summary>
    public partial class PopupImage : Window
    {
        public PopupImage()
        {
            InitializeComponent();
        }

        public void ResetImage(ImageSource source)
        {
            Width = source.Width / 2;
            Height = source.Height / 2;
            ShowingImage.Source = source;
        }
    }
}
