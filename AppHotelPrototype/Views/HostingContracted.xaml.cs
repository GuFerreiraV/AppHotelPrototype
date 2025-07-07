namespace AppHotelPrototype.Views;

public partial class HostingContracted : ContentPage
{
	

	public HostingContracted()
	{
		InitializeComponent();
        
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();
		}
		catch (Exception ex) {
			DisplayAlert("Erro", ex.Message, "OK");
		}
    }
}