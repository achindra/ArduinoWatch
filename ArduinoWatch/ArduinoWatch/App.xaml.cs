using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ArduinoWatch
{
	public partial class App : Application
	{
        public App()
        {
            InitializeComponent();

            //MainPage = new ArduinoWatch.MainPage();
            var layout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "Hello World!"
                    }
                }
            };

            MainPage = new ContentPage
            {
                Content = layout
            };

            Label lblDay = new Label
            {
                Text = DateTime.Now.Date.DayOfWeek.ToString()
            };

            Label lblDate = new Label
            {
                Text = DateTime.Now.ToString("dd,MMM")
            };

            Label lblHH = new Label
            {
                Text = DateTime.Now.Hour.ToString()
            };

            Label lblMM = new Label
            {
                Text = DateTime.Now.Minute.ToString()
            };

            Label lblSteps = new Label
            {
                Text = DateTime.Now.Year.ToString()
            };

            Label lblSms = new Label
            {
                Text = "99"
            };

            Button btnSync = new Button
            {
                Text = "Sync"
            };

            btnSync.Clicked += async (s, e) =>
            {
                await MainPage.DisplayAlert("Alert", "Sync Button Clicked", "OK");
            };

            layout.Children.Add(lblDay);
            layout.Children.Add(lblDate);
            layout.Children.Add(lblHH);
            layout.Children.Add(lblMM);
            layout.Children.Add(lblSteps);
            layout.Children.Add(lblSms);
            layout.Children.Add(btnSync);

		}

        

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
