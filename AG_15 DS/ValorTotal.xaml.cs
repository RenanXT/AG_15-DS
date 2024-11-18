namespace AG_15_DS;

public partial class ValorTotal : ContentPage
{
	public ValorTotal()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
		DisplayAlert("Parabens", " Evento Cadastrado com Sucesso", "Ok");
    }
}