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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        int clik = 0;
        private void btn_Clicked(object sender, EventArgs e)
        {

            //btn.Text = "Auf";
            clik++;
            btn.Text = clik.ToString();
            if (clik % 5 == 0)
            {           
                lbl.Text = "";
            }
            else
            {
                lbl.Text = "Nupp";
            }
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            clik = 0;
            btn.Text = clik.ToString();
        }
    }
}