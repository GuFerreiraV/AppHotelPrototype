namespace AppHotelPrototype.Models
{
    public class Accommodation
    {

        public Room SelectedRoom { get; set; }

        public int QtdeAdults { get; set; }

        public int QtdeChildrens { get; set; }

        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }

        // Estadia
        public int Stay
        {
            get => CheckoutDate.Subtract(CheckinDate).Days;

        }

        public double TotalValue
        {
            get => (QtdeAdults * SelectedRoom.PriceAdult) + (QtdeChildrens * SelectedRoom.PriceChild);

        }


    }
}
