namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("main", typeof(MainPage));
            Routing.RegisterRoute("item", typeof(ItemPage));
        }
    }
}