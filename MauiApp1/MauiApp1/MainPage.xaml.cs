using MauiApp1.Models;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
     
        public MainPage()
        {
            InitializeComponent();
            lstUsers.ItemsSource = Person.GetPeoples();
        }

        private void lstUsers_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var p = e.Item as Person;
            Shell.Current.GoToAsync($"item?id={p.Id}");

        }

        private void lstUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var p = e.CurrentSelection[0] as Person;
            Shell.Current.GoToAsync($"item?id={p.Id}");

        }
    }
}