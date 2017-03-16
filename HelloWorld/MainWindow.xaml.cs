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
using System.ComponentModel;
using System.Data.Entity;


// Jeff Peerson   D220  Client Applications   Homework 1

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Models.User user = new Models.User();

        public MainWindow()   //constructor
        {
            InitializeComponent();
            //WindowState = WindowState.Maximized;
            buttonThumbsUp.Visibility = Visibility.Hidden;
        }

        public override void EndInit()
        {
            base.EndInit();
            uxName.DataContext = user;
            uxNameError.DataContext = user;

            var sample = new SampleEntities();

            sample.Users.Load();

            uxList.ItemsSource = sample.Users.Local;
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            string sMsg = "Submitting password: " + uxPassword.Text;
            MessageBox.Show(sMsg);
            buttonThumbsUp.Visibility = Visibility.Visible;

            var window = new SecondWindow();
            Application.Current.MainWindow = window;
            Close();
            window.Show();

        }

        private void uxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableSubmitButton();
        }

        private void uxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableSubmitButton();
        }



        private void EnableSubmitButton()
        {
            if (uxName.Text.Length > 0 && (uxPassword.Text.Length > 0 || uxPasswordBox.Password.Length > 0))
            {
                uxSubmit.IsEnabled = true;
            }
            else
            {
                uxSubmit.IsEnabled = false;
            }
        }

        private void uxPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            EnableSubmitButton();
        }
    }
}
