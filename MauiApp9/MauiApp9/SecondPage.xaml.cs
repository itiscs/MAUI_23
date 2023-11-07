//using MediaPlayer;

namespace MauiApp9;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if (txtName.Text == "Admin" && txtPass.Text == "password")
			Shell.Current.GoToAsync($"items?name={txtName.Text}&today={DateTime.Now.ToShortDateString()}");
		else
			DisplayAlert("Ошибка","Неправильный логин-пароль","OK");

    }
}