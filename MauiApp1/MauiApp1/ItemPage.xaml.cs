using MauiApp1.Models;

namespace MauiApp1;

public partial class ItemPage : ContentPage, IQueryAttributable
{
    
	public ItemPage()
	{
		InitializeComponent();
	}

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        int id = int.Parse(query["id"].ToString());
        var pers = Person.GetPeoples().Find(x => x.Id == id);
        BindingContext = pers;
    }
}