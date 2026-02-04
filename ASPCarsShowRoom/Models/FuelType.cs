namespace ASPCarsShowRoom.Models
{
    public class FuelType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime RegisterOn { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
