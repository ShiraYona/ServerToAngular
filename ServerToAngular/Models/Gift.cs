namespace ServerToAngular.Models
{
    public class Gift
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Donor { get; set; }
        public int Cost { get; set; } = 10;
        public Gift(int id, string name, string donor, int cost)
        {
            Id = id;
            Name = name;
            Donor = donor;
            Cost = cost;
        }
    }
}
