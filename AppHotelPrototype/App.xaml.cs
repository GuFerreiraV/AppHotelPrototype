
using AppHotelPrototype.Models;

namespace AppHotelPrototype
{
    public partial class App : Application
    {

        public List<Room> rooms_list = new List<Room>
        {
            new Room()
            {
                Description = "Suíte de Luxo",
                PriceAdult = 150.00,
                PriceChild = 55.00
            },

            new Room()
            {
                Description = "Suíte Padrão",
                PriceAdult = 100.00,
                PriceChild = 50.00
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.HostingContracting());
        }


        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Height = 600;
            window.Width = 400;
            return window;
        }
    }
}
