using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Threading;
using System;

namespace Tamagotchi.Models
{
    public class Pet
    {
        public string Name { get; set; }
        public int Id { get; }
        public int Life { get; set; } = 100;

        public Pet(string name)
        {
            Name = name;
            // Life = life;
        }
        public void Play()
        {
            Life += 5;
        }

        public void PutToSleep() 
        {
            Life += 10;
        }
        public void PassTime()
        {
            Life -= 50;
        }   
    }
}