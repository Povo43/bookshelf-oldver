using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mima_bookshelf.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class newpage : ContentPage
	{
		public newpage ()
		{
			InitializeComponent ();
		}

        private void omosirosa_slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var slider = omosirosa_slider.Value * 100;
            omosirosa_label.Text = "面白さ" + slider;
        }

        private void kandou_slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var slider = kandou_slider.Value * 100;
            kandoudo_label.Text = "感動度" + slider;
        }

        private void osusume_slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var slider = osusume_slider.Value * 100;
            osusumedo_label.Text = "おすすめ度" + slider;
        }

        
        private void hozon_button_Clicked(object sender, EventArgs e)
        {
            if (title_text.Text != "")
            {
                //何個目の設定かを確認
                int myValue = Preferences.Get("book_count", 0);
                Preferences.Set(myValue.ToString() + "_title", title_text.Text);
                Preferences.Set(myValue.ToString() + "_omosirosa", omosirosa_slider.Value);
                myValue += 1;
                Preferences.Set("book_count", myValue);
            }
            Application.Current.MainPage = new MainPage();
        }

        private void cancel_button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }
    }
}