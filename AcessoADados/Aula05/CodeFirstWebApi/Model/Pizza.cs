namespace CodeFirstWebApi.Model
{
    public class Pizza
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Customer? Cliente { get; set; }
    }
}
