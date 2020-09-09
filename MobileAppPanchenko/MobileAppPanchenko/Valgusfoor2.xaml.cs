using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppPanchenko
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor2 : ContentPage
    {
        Label punane, kollane, roheline;
        Frame pun, roh, kol;
        Button btn, valja;
        bool btn_valja;
        public Valgusfoor2()
        {
            //InitializeComponent();
            punane = new Label()
            {
                Text = "Punane",
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            pun = new Frame()
            {
                BackgroundColor = Color.Red,
                Content = punane,
                CornerRadius = 60,
                Margin = new Thickness(80, 0, 80, 0),
            };
            kollane = new Label()
            {
                Text = "Kollane",
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,

            };
            kol = new Frame()
            {
                BackgroundColor = Color.Yellow,
                Content = kollane,
                CornerRadius = 60,
                Margin = new Thickness(80, 0, 80, 0),
            };
            roheline = new Label()
            {
                Text = "Roheline",
                TextColor = Color.White,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            roh = new Frame()
            {
                BackgroundColor = Color.Green,
                Content = roheline,
                CornerRadius = 60,
                Margin = new Thickness(80, 0, 80, 0),
            };
            btn = new Button()
            {
                Text = "Вкл",
                BackgroundColor = Color.Gray,
                BorderColor=Color.Blue,
            };
            valja = new Button()
            {
                BorderColor = Color.Blue,
                BackgroundColor = Color.Gray,
                Text="Выкл",
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children =
                    {
                        pun, kol, roh, btn, valja
                    }
            };
            btn.Clicked += btn_Clicked;
            valja.Clicked += Valja_Clicked;
            var tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            pun.GestureRecognizers.Add(tap);
            var tap2 = new TapGestureRecognizer();
            tap2.Tapped += Tap_Tapped;
            kol.GestureRecognizers.Add(tap2);
            var tap3 = new TapGestureRecognizer();
            tap3.Tapped += Tap_Tapped;
            roh.GestureRecognizers.Add(tap3);
            Content = stackLayout;
        }

        private void Valja_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Color.FromRgb(100, 100, 100);
            kol.BackgroundColor = Color.Gray;
            roh.BackgroundColor = Color.FromHex("#808080");
            btn_valja = true;
        }
        Random rnd=new Random();
        private async void btn_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Color.Red;
            pun.BorderColor = Color.White;
            btn_valja = false;
            for(int i=0; i<100; i++)
            {
                punane.FontSize++;
                await Task.Run(() => Thread.Sleep(1000));
            }
            int c = rnd.Next(1, 4);
            if (c == 1)
            {
                pun.BackgroundColor = Color.Red;
                kol.BackgroundColor = Color.FromRgb(62, 62, 62);
                roh.BackgroundColor = Color.FromRgb(62, 62, 62);

            }
            else if (c == 2)
            {
                pun.BackgroundColor = Color.FromRgb(62, 62, 62);
                kol.BackgroundColor = Color.Yellow;
                roh.BackgroundColor = Color.FromRgb(62, 62, 62);
            }
            else if (c == 3)
            {
                pun.BackgroundColor = Color.FromRgb(62, 62, 62);
                kol.BackgroundColor = Color.FromRgb(62, 62, 62);
                roh.BackgroundColor = Color.Green;
            }
        }


        private void Tap_Tapped(object sender, EventArgs e)
        {
            Frame fr = sender as Frame;
            if (fr == pun) { punane.Text = "Cтой"; };
            if (fr == kol) { kollane.Text = "Подожди"; };
            if (fr == roh) { roheline.Text = "Иди "; };
            if (pun.BackgroundColor==Color.FromRgb(100, 100, 100)) {punane.Text = "Сначала включи"; kollane.Text = "Сначала включи"; roheline.Text = "Сначала включи"; };
            if (kol.BackgroundColor==Color.Gray) {punane.Text = "Сначала включи"; kollane.Text = "Сначала включи"; roheline.Text = "Сначала включи"; };
            if (roh.BackgroundColor==Color.FromHex("#808080")) {punane.Text = "Сначала включи"; kollane.Text = "Сначала включи"; roheline.Text = "Сначала включи"; };

        }
        
    }
}