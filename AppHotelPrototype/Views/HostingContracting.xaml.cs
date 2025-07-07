namespace AppHotelPrototype.Views;

public partial class HostingContracting : ContentPage
{

    public HostingContracting()
	{
		InitializeComponent();
		App AppProperties = (App)Application.Current;

		pck_quarto.ItemsSource = AppProperties.rooms_list;

		// Impossibilita o check in antes do dia atual
		dtpck_checkin.MinimumDate = DateTime.Now;
		// Check in de no máx um mês
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
        
		dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
            // pula para próxima página
            Navigation.PushAsync(new HostingContracted());

		}
		catch (Exception ex) 
		{
			DisplayAlert("Erro", ex.Message, "Ok");
		
		}
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker element = sender as DatePicker;

		DateTime checkin_selected_date = element.Date;

		dtpck_checkout.MinimumDate = checkin_selected_date.AddDays(1);
		dtpck_checkout.MaximumDate = checkin_selected_date.AddMonths(6);
    }
}