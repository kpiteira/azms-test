using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TestingMCTables
{
    public class App : Application
    {
        private static MobileServiceClient mobileServiceClient = null;
        public static MobileServiceClient getMobileServiceClient()
        {
            return mobileServiceClient != null ? mobileServiceClient : mobileServiceClient = new MobileServiceClient("");
        }
        public App()
        {
            // The root page of your application
            var content = new ContentPage
            {
                Title = "TestingMCTables",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };

            MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
