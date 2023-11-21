using MauiApp1.Models;
using System.Diagnostics;

namespace MauiApp1;

public partial class ItemPage : ContentPage, IQueryAttributable
{
    Person pers;
    PersonsDatabase db;
    
	public ItemPage(PersonsDatabase _db)
	{
        db = _db;
		InitializeComponent();
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.Keys.Contains("id"))
        {
            int id = int.Parse(query["id"].ToString());
            pers = db.GetPerson(id);
        }
        else
        {
            pers = new Person();
        }
        BindingContext = pers;

    }

    private async void btnSave_Clicked(object sender, EventArgs e)
    {
        db.SavePerson(pers);
        await Shell.Current.GoToAsync("..");

    }

    private async void btnDel_Clicked(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("Удалить?", "Вы уверены?", "Да", "Нет");
        if(answer)
        {
            db.DeletePerson(pers);
            await Shell.Current.GoToAsync("..");
        }

    }
}