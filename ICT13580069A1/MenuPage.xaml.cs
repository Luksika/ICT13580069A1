using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580069A1
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();

            ViewButton.Clicked += ViewButton_Clicked;
            stackButton.Clicked += StackButton_Clicked;
            GridButton.Clicked += GridButton_Clicked;
            absoluteButton.Clicked += AbsoluteButton_Clicked;
            contenButton.Clicked += ContenButton_Clicked;
            NavButton.Clicked += NavButton_Clicked;
            TabButton.Clicked += TabButton_Clicked;
            carouselButton.Clicked += CarouselButton_Clicked;
        }

        void ViewButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new ICT13580069A1Page());
            mp.Detail = np;
            mp.IsPresented = false;
        }

        void StackButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new stackPage());
            mp.Detail = np;
            mp.IsPresented = false;
        }

        void GridButton_Clicked(object sender, EventArgs e)
        {
			var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new GridPage());
			mp.Detail = np;
			mp.IsPresented = false;
        }

        void AbsoluteButton_Clicked(object sender, EventArgs e)
        {
			var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new AbsolutePage());
			mp.Detail = np;
			mp.IsPresented = false;
        }

        void ContenButton_Clicked(object sender, EventArgs e)
        {
			var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new CarouselPage());
			mp.Detail = np;
			mp.IsPresented = false;
        }

        void NavButton_Clicked(object sender, EventArgs e)
        {
			var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new NavigationPage());
			mp.Detail = np;
			mp.IsPresented = false;
        }

        void TabButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var tp = new TabbedPage();
            tp.Children.Add(new TabPage1());
            tp.Children.Add(new TabPage2());
            tp.Children.Add(new TabPage3());
            var np = new NavigationPage(tp);
            mp.Detail = np;
            mp.IsPresented = false;
        }

        void CarouselButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var cp = new CarouselPage();
            cp.Children.Add(new TabPage1());
            cp.Children.Add(new TabPage2());
            cp.Children.Add(new TabPage3());
            var np = new NavigationPage(cp);
            mp.Detail = np;
            mp.IsPresented = false;
        }
    }
}

