namespace Tamagotchi.Models
{
    public class Pet
    {
        public string Name { get; set; }
        public int Id { get; }
        public int Food { get; set; } = 100;
        public int Life { get; set; } = 100;
        public Pet(string name)
        {
            Name = name;
            Id = 1; //_instances.Count;
            // Food = food;
            // Life = life;
        }

    }
}