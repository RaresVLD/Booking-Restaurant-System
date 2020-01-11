namespace RestaurantServiceProvider.DTO
{
    public class RestaurantDTO
    {
        public RestaurantDTO()
        {

        }
        public RestaurantDTO(string name, string addres, string description)
        {
            Name = name;
            Address = addres;
            Description = description;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
