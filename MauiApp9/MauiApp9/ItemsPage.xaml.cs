namespace MauiApp9;

public partial class ItemsPage : ContentPage, IQueryAttributable
{
    private string myName;
	public ItemsPage()
	{
		InitializeComponent();
	}

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.Keys.Contains("name"))
        {
            myName = query["name"].ToString();
            txtHello.Text = $"Привет, {myName}!";
        }

        if (query.Keys.Contains("today"))
        {
            var date1 = Convert.ToDateTime(query["today"].ToString());
            txtToday.Text = date1.ToShortDateString();
        }

    }
}