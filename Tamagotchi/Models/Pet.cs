using System.Collections.Generic;
using System.Threading;
using System;

namespace Tamagotchi.Models
{
    public class Pet
    {
        public string Name { get; set; }
        public int Id { get; }
        public int Food { get; set; } = 100;
        public int Life { get; set; } = 100;
        private static List<Pet> _instances = new List<Pet> { };
        public Pet(string name, int food, int life)
        {
            Name = name;
            Food = food;
            Life = life;
            _instances.Add(this);
            Id = _instances.Count;
        }
        public static List<Pet> GetAll()
        {
            return _instances;
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
        public static Pet Find(int searchId)
        {   // will throw exception if search # is > current range of Pets in program
            return _instances[searchId - 1];
        }
        public void FeedPet()
        { // Pet[02].FeedPet(); FeedPet(2)
            Life += 5;
        }

        public void Play()
        {
            Life += 5;
        }

        public void PutToSleep()
        {
            Life += 10;
        }

        //Describe: Feed(property food(0-100))

        //Describe: Play(property happiness(0-100))

        //Describe: PutToSleep(property rest(0-100))
    }
}