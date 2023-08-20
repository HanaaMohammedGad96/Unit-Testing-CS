namespace Resturant
{
    public class ReservationOrder
    {
        public int Id { get; set; }
        public User MadeBy { get; set; }
        public Table Table { get; set; }

        public bool CancelReservation(User user)
        => (user.IsAdmin || user == MadeBy);
    }
}
