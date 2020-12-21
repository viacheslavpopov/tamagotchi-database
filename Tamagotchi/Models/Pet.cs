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
        public int Food { get; set; } = 100;
        public int Life { get; set; } = 100;
        private static List<Pet> _instances = new List<Pet> { };
        // public Pet(string name)
        // {
        //     Name = name;
        // }
        public Pet(string name, int food, int life)
        {
            Name = name;
            Food = food;
            Life = life;
            // _instances.Add(this);
            // Id = _instances.Count;
        }
        public Pet (int id, string name, int food, int life)
        {
            Id = id;
            Name = name;
            Food = food;
            Life = life;
        }
        public static List<Pet> GetAll()
        {
            List<Pet> allPets = new List<Pet> { };
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM pets;";
            MySqlDataReader rdr = cmd. ExecuteReader() as MySqlDataReader;
            while (rdr.Read())
            {
                int petId = rdr.GetInt32(0);
                string petName = rdr.GetString(1);
                int petFood = rdr.GetInt32(2);
                int petLife = rdr.GetInt32(3);
                Pet newPet = new Pet(petId, petName, petFood, petLife);
                allPets.Add(newPet);
            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allPets;
            }
        public static void ClearAll()
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"DELETE FROM pets;";
            cmd.ExecuteNonQuery();
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
        }

        public static Pet Find(int searchId)
        {   // will throw exception if search # is > current range of Pets in program
            Pet placeholderPet = new Pet("placeholder item", 0, 0);
            return placeholderPet;
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