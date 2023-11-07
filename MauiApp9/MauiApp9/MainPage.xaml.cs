using Microsoft.Maui.Controls.Shapes;
using System.Drawing;

namespace MauiApp9
{
    public partial class MainPage : ContentPage
    {
     
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("second");

            //Random r = new Random();

            //Ellipse el = new Ellipse();
            //el.WidthRequest = 150;
            //el.HeightRequest = 150;
            //el.Fill = Microsoft.Maui.Graphics.Color.
            //    FromRgb(r.Next(255), r.Next(255), r.Next(255));

            //stk.Children.Add(el);
            
        }
    }
}