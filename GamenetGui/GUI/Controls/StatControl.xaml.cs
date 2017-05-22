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

namespace GamenetGui.GUI.Controls
{
    /// <summary>
    /// Логика взаимодействия для StatControl.xaml
    /// </summary>
    public partial class StatControl : UserControl
    {
        public StatControl()
        {
            InitializeComponent();
            NormalHeightLoad = BorderLoad.Height;
            NormalHeightStat = BorderStat.Height;
            MinHeight = 23;
        }
        double NormalHeightLoad;
        double NormalHeightStat;
        new double MinHeight;
        private void BorderLoad_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (BorderLoad.Height != MinHeight)
                BorderLoad.Height = MinHeight;
            else
                BorderLoad.Height = NormalHeightLoad;
        }

        private void BorderStat_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (BorderStat.Height != MinHeight)
                BorderStat.Height = MinHeight;
            else
                BorderStat.Height = NormalHeightStat;
        }
    }
}
