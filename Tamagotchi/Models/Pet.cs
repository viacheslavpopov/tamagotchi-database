using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Threading;
using System;

namespace Tamagotchi.Models
{
    public class Pet
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Life { get; set; } = 100;
        public void PassTime()
        {
            Life -= 50;
        }   
        public void Play()
        {
            PassTime();
            Life += 5;
        }

        public void PutToSleep() 
        {
            PassTime();
            Life += 10;
        }
    }
}