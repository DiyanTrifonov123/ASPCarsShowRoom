namespace ASPCarsShowRoom.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RegisterOn { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
