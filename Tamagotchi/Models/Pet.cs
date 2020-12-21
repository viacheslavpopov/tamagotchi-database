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
        // public int Food { get; set; } = 100;
        // public int Life { get; set; } = 100;
        private static List<Pet> _instances = new List<Pet> { };
        // public Pet(string name)
        // {
        //     Name = name;
        // }
        public Pet(string name) //int food, int life)
        {
            Name = name;
            // Food = food;
            // Life = life;
        }
        public Pet (int id, string name)//, int food, int life)
        {
            Id = id;
            Name = name;
            // Food = food;
            // Life = life;
        }

        public override bool Equals(System.Object otherPet)
            {
                if (!(otherPet is Pet))
                {
                    return false;
                }
                else
                {
                    Pet newPet = (Pet) otherPet;
                    bool nameEquality = (this.Name == newPet.Name);
                    return nameEquality;
                }
            }
        
        public void Save()
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            // var cmd2 = conn.CreateCommand() as MySqlCommand;
            // var cmd3 = conn.CreateCommand() as MySqlCommand;

            cmd.CommandText = @"INSERT INTO pets (name) VALUES (@PetName);";
            // cmd2.CommandText = @"INSERT INTO pets (food) VALUES (@PetFood);";
            // cmd3.CommandText = @"INSERT INTO pets (life) VALUES (@PetLife);";
            MySqlParameter name = new MySqlParameter();
            name.ParameterName = "@PetName";
            name.Value = this.Name;
            // MySqlParameter food = new MySqlParameter();
            // food.ParameterName = "@PetFood";
            // food.Value = (int) this.Food;
            // MySqlParameter life = new MySqlParameter();
            // life.ParameterName = "@PetLife";
            // life.Value = (int) this.Life;
            cmd.Parameters.Add(name);
            // cmd2.Parameters.Add(food);
            // cmd3.Parameters.Add(life);
            cmd.ExecuteNonQuery();
            // cmd2.ExecuteNonQuery();
            // cmd3.ExecuteNonQuery();
            Id = (int) cmd.LastInsertedId;

            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
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
                // int petFood = rdr.GetInt32(2);
                // int petLife = rdr.GetInt32(3);
                Pet newPet = new Pet(petId, petName);//, petFood, petLife);
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
            Pet placeholderPet = new Pet("placeholder item");
            return placeholderPet;
        }

        // public void FeedPet()
        // { // Pet[02].FeedPet(); FeedPet(2)
        //     Life += 5;
        // }

        // public void Play()
        // {
        //     Life += 5;
        // }

        // public void PutToSleep()
        // {
        //     Life += 10;
        // }

        //Describe: Feed(property food(0-100))

        //Describe: Play(property happiness(0-100))

        //Describe: PutToSleep(property rest(0-100))
    }
}