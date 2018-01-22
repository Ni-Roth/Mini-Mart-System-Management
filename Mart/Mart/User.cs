namespace Mart
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User(int i ,string n)
        {
            Id = i;
            Name = n;
        }
    }
}