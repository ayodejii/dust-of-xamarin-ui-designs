using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TestAppForUI.View;
using Xamarin.Forms;

namespace TestAppForUI.ViewModel
{
    public class SignInViewModel: BaseViewModel
    {
        public ICommand SignInCommand => new Command(NavToStartPage);
        private void NavToStartPage()
        {
            var startPage = new StartPage();
            var nav = App.Current.MainPage as NavigationPage;
            nav.PushAsync(startPage);
        }
    }
}
