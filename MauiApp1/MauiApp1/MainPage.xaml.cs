using MauiApp1.Models;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        PersonsDatabase _db;
     
        public MainPage(PersonsDatabase db)
        {
            InitializeComponent();
            _db = db;
            FillCollection();
        }

        protected override void OnAppearing()
        {
            FillCollection();
        }

        private void FillCollection()
        {
            lstUsers.ItemsSource = _db.GetPersons();
        }



        private void lstUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var p = e.CurrentSelection[0] as Person;
            Shell.Current.GoToAsync($"item?id={p.Id}");

        }

        private void addPerson_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync($"item");
        }
    }
}