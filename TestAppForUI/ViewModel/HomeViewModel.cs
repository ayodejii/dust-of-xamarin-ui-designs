using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using TestAppForUI.Model;
using TestAppForUI.View;
using Xamarin.Forms;

namespace TestAppForUI.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            PageContents = GetPageContents();
        }
        private ObservableCollection<PageContent> pageContents;

        public ObservableCollection<PageContent> PageContents
        {
            get { return pageContents; }
            set 
            { 
                pageContents = value;
                OnPropertyChanged(nameof(PageContents));
            }
        }

        private ObservableCollection<PageContent> GetPageContents()
        {
            return new ObservableCollection<PageContent>
            {
                new PageContent{ Header= "Create a Trip", Child = "Trips will automatically make a list of suggested items so that you do not  forget anything ever again!", Image = "trip01.png"},
                new PageContent{ Header= "Search Travel Place", Child = "Easy discovering new place and share these between your friends and travel together", Image = "trip02.png"},
                new PageContent{ Header= "Flight Booking", Child = "Found a flight that matches yout destination and schedule? Book it instanly in just a few taps", Image = "trip03.png"}
            };
        }

        public ICommand LoginCommand => new Command(Login);
        private void Login()
        {
            var signinPage = new SignInPage();

            var navigation = Application.Current.MainPage as NavigationPage;
            navigation.PushAsync(signinPage, true);
        }
    }
}
