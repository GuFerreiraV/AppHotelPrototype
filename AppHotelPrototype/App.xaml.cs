
namespace AppHotelPrototype
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
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
