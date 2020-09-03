using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppPanchenko
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor2 : ContentPage
    {
        public Valgusfoor2()
        {
            //InitializeComponent();
            Label punane = new Label()
            {
                Text = "Punane",
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            Frame pun = new Frame()
            {
                BackgroundColor = Color.Red,
                Content = punane,
                CornerRadius = 60,
                Margin = new Thickness(80, 0, 80, 0),
                VerticalOptions = VerticalOptions.CenterAndExpand,
                HorizontalOptions = HorizontalOptions.CenterAndExpand,
            };
            Label kollane = new Label()
            {
                Text = "Kollane",
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,

            };
            Frame kol = new Frame()
            {
                BackgroundColor = Color.Yellow,
                Content = kollane,
                CornerRadius = 60,
                Margin = new Thickness(80, 0, 80, 0),
                VerticalOptions = VerticalOptions.CenterAndExpand,
                HorizontalOptions = HorizontalOptions.CenterAndExpand,
            };
            Label roheline = new Label()
            {
                Text = "Roheline",
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            Frame roh = new Frame()
            {
                BackgroundColor = Color.Green,
                Content = roheline,
                CornerRadius = 60,
                Margin = new Thickness(80, 0, 80, 0),
                VerticalOptions = VerticalOptions.CenterAndExpand,
                HorizontalOptions = HorizontalOptins.CenterAndExpand,
            };
            Button btn=new Button()
            {
                Text = "Вкл",
                VerticalOptions = "StartAndExpand"
                HorizontalOptions = "StartAndExpand"
            }
            StackLayout stackLayout = new StackLayout()
            {
                Children =
                {
                    pun, kol, roh
                }
            };
            //stackLayout.Orientation = StackOrientation.Horizontal;
            Content = stackLayout;

        }
    }
}