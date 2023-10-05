using mima_bookshelf.pages;
using System;
using System.Runtime.InteropServices;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace mima_bookshelf
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            try
            {
                int myValue = Preferences.Get("book_count", 0);
                string[] myList = new string[myValue];
                for (int a = 0; a == myValue; a++)
                {
                    string title = Preferences.Get(a.ToString() + "_title", "not title");
                    myList[a] = title;
                }
                listview.ItemsSource = myList;
            }catch 
            {
                DisplayAlert("警告", "開けませんでした。", "OK");
            }
        }

        private void add_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new newpage();
        }
    }
}
