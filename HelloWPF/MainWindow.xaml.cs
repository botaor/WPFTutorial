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

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            GetResources();
        }

        private void GetResources()
        {
            string str ;

            str = Application.Current.FindResource("GlobalText").ToString() ;
            str = this.FindResource("strHelloWorld").ToString() ;
            str = SPanel.FindResource("ComboBoxTitle").ToString() ;

            // if it is not found in the current scope, then move up untill it is found
            str = SPanel.FindResource("GlobalText").ToString() ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show( "Button clicked!" ) ;
        }

        private void mainGrid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You clicked me at " + e.GetPosition(this).ToString());
        }
    }
}
