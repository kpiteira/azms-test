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
            return mobileServiceClient != null ? mobileServiceClient : 
                mobileServiceClient = new MobileServiceClient("http://mobile-908114b5-c764-4fab-bc2c-2c1cf521bc43.azurewebsites.net");
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
            insertRecord();
        }
        private async void insertRecord()
        {
            Users user = new Users();
            user.Name = Guid.NewGuid().ToString(); 
            await getMobileServiceClient().GetTable<Users>().InsertAsync(user);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            mobileServiceClient = null;
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
