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
using System.ComponentModel;

//
//Jeff Peerson    CSharp-220    Assignment #3   Sorting ListView Columns  
// 

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        private string sort = "asc";
        //private List<Models.User> users = new List<Models.User>();

        public SecondWindow()
        {
            InitializeComponent();


            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "DavePwd" });
            users.Add(new Models.User { Name = "Steve", Password = "StevePwd" });
            users.Add(new Models.User { Name = "Lisa", Password = "LisaPwd" });

            uxList.ItemsSource = users;

        }


        private void uxList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void uxList_ColumnHeaderClickedHandler(object sender, RoutedEventArgs e)
        {
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(uxList.ItemsSource);
            view.SortDescriptions.Clear();

            if (view.CanSort)
            {
                if (this.sort == "asc")
                {
                    view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
                    view.SortDescriptions.Add(new SortDescription("Password", ListSortDirection.Ascending));
                }
                else
                {
                    view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Descending));
                    view.SortDescriptions.Add(new SortDescription("Password", ListSortDirection.Descending));
                }

                if (this.sort == "asc")
                {
                    this.sort = "desc";
                }
                else
                {
                    this.sort = "asc";
                }

            }
        }


        //private void uxList_ColumnHeaderClickedHandler(object sender, RoutedEventArgs e)
        //{
        //    CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(uxList.ItemsSource);
        //    if (view.CanSort)
        //    {
        //        if (sort == "asc")
        //        {
        //            view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
        //            view.SortDescriptions.Add(new SortDescription("Password", ListSortDirection.Ascending));
        //        }
        //        else
        //        {
        //            view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Descending));
        //            view.SortDescriptions.Add(new SortDescription("Password", ListSortDirection.Descending));
        //        }

        //        if (sort == "asc")
        //        {
        //            sort = "desc";
        //        }
        //        else
        //        {
        //            sort = "asc";
        //        }
        //    }
        //}
    }
}
