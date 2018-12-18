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

namespace TestReriseWindow
{
    /// <summary>
    /// RWindow.xaml 的交互逻辑
    /// </summary>
    public partial class RWindow : Window
    {
        public RWindow()
        {
            InitializeComponent();
        }

        //protected override void OnContentRendered(EventArgs e)
        //{
        //    base.OnContentRendered(e);

        //    // 窗体尺寸和内容尺寸不一致，说明已经受限于最大尺寸，此时缩放内容
        //    if (ActualWidth < RootGrid.ActualWidth)
        //    {
        //        RootViewbox.Stretch = Stretch.Uniform;
        //    }
        //}

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            if (ActualWidth < RootGrid.ActualWidth)
            {
                RootViewbox.Stretch = Stretch.Uniform;
            }
        }
    }

    
}
