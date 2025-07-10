using AppHotelPrototype.Models;

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

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
            // instanciando as propriedades do objeto Accommodation (model)
            Accommodation ac = new Accommodation 
			{
				
				SelectedRoom = (Room)pck_quarto.SelectedItem,
				QtdeAdults = Convert.ToInt32(stp_adultos.Value),
                QtdeChildrens = Convert.ToInt32(stp_criancas.Value),
				CheckinDate = dtpck_checkin.Date,
				CheckoutDate = dtpck_checkout.Date

            };

            // pula para próxima página
            await Navigation.PushAsync(new HostingContracted() 
			{
			
				BindingContext = ac // Passando a model preenchida para a próxima página

            });

		}
		catch (Exception ex) 
		{
			await DisplayAlert("Erro", ex.Message, "Ok");
		
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