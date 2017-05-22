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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GamenetGui
{
    /// <summary>
    /// Логика взаимодействия для CaptionControl.xaml
    /// </summary>
    public partial class CaptionControl : UserControl
    {
        public CaptionControl()
        {
            InitializeComponent();
        }

        private void CloseButton_MouseEnter(object sender, MouseEventArgs e)
        {
            ImgClose.Source = (BitmapSource)FindResource("CloseHover");

        }

        private void CloseButton_MouseLeave(object sender, MouseEventArgs e)
        {
            ImgClose.Source = (BitmapSource)FindResource("Close");

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void SettingsButton_MouseEnter(object sender, MouseEventArgs e)
        {
            ImgSettings.Source = (BitmapSource)FindResource("SettingsHover");
        }

        private void SettingsButton_MouseLeave(object sender, MouseEventArgs e)
        {
            ImgSettings.Source = (BitmapSource)FindResource("Settings");
        }
    }
}
