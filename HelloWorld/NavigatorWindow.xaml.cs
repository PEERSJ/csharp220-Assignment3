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
using System.Diagnostics;

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for NavigatorWindow.xaml
    /// </summary>
    public partial class NavigatorWindow : Window
    {
        public NavigatorWindow()
        {
            InitializeComponent();
        }

        //private void uxURL_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    // Convert the Uri into a string
        //    var fileName = e.Uri.AbsoluteUri;

        //    // Pass the fileName to the helper class
        //    var processStartInfo = new ProcessStartInfo(fileName);

        //    // Start a new process  (opens a new browswer window using the filename value for the URL address)
        //    Process.Start(processStartInfo);
        //}

        private void uxGoButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(uxURL.Text));
        }
    }
}
