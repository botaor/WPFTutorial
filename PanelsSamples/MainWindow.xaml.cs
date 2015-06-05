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

namespace PanelsSamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonCanvas_Click(object sender, RoutedEventArgs e)
        {
            WndCanvas wnd = new WndCanvas() ;
            wnd.ShowDialog() ;
        }

        private void buttonWrap_Click(object sender, RoutedEventArgs e)
        {
            WndWrap wnd = new WndWrap() ;
            wnd.ShowDialog() ;
        }

        private void buttonStack_Click(object sender, RoutedEventArgs e)
        {
            WndStack wnd = new WndStack() ;
            wnd.ShowDialog() ;
        }
    }
}
