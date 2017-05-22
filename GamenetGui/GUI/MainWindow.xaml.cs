using Microsoft.Win32;
using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Capt.SettingsButton.Click += SettingsButton_Click;
            PPUB.wnd = this;
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            //Resources["BackgroundImage"] = File.ReadAllBytes(@"‪E:\Screenshot_10.png").ToImage();
            OpenFileDialog op = new OpenFileDialog();
            string s = op.ShowDialog().ToString();
            if (s.Contains("True"))
            {
                byte[] b = File.ReadAllBytes(op.FileName);
                BackgroundImage.Source = b.ToImage();
            }
            //(BitmapSource)FindResource("Close");
        }
      
        private void CaptionControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

     
    }
    public static class PPUB
    {
        public static Window wnd;
        public static Window ShowForm()
        {
            wnd = new MainWindow();
            wnd.Show();
            return wnd;
        }
        public static void SetClolor(Color cl)
        {
            ((MainWindow)wnd).BalanceRaw.Background = new SolidColorBrush(cl);
            ((MainWindow)wnd).Progress.Background = new SolidColorBrush(cl);
        }
    }
}
