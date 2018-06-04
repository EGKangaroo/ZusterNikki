using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ZusterNikki
{
    class SQLHandler
    {
        //connstring
        string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EGKan\OneDrive\Documents\GitHub\ZusterNikki\C# Code\ZusterNikki\ZusterNikki\NikkiDB.mdf;Integrated Security=True";

        //constructor
        public SQLHandler(){}

        //methods

        //update player score function
        public void UpdateScore(Player player)
        {
            using(SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();

                string query = "UPDATE Player SET Score = @scr WHERE Id = @id";

                using(SqlCommand updateScore = new SqlCommand(query, connection))
                {
                    updateScore.Parameters.AddWithValue("@scr", player.Score);
                    updateScore.Parameters.AddWithValue("@id", player.Id);

                    updateScore.ExecuteNonQuery();
                }
            }
        }

        //login function
        public Player Login(string name, string pass)
        {
            bool valid = ValidateLogin(name, pass);

            if (valid)
            {
                Player player = LoginValidAcc(name, pass);
                return player;
            }
            else
            {
                return null;
            }
        }

        //make a new player based on a validated login
        public Player LoginValidAcc(string name, string pass)
        {
            Player player;

            using(SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();

                string query = 
                    "SELECT * FROM Player " + 
                    "WHERE Username = '" + name + "'";

                using(SqlCommand login = new SqlCommand(query, connection))
                {
                    using(SqlDataReader reader = login.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string username = reader.GetString(2);
                            int score = reader.GetInt32(3);
                            int age = reader.GetInt32(4);
                            string gender = reader.GetString(5);
                            player = new Player(id, username, score, age, gender);
                            return player;
                        }
                    }
                }
            }

            return null;
        }

        //check login function determines if given login data is in the database
        public bool ValidateLogin(string name, string pass)
        {
            bool validated = false;

            if(name.Length > 50 || pass.Length > 50)
            {
                return validated;
            }

            using(SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();

                string query = "SELECT * FROM Player";

                using(SqlCommand readPlayers = new SqlCommand(query, connection))
                {
                    using(SqlDataReader reader = readPlayers.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString(1).Equals(pass) && reader.GetString(2).Equals(name))
                            {
                                validated = true;
                            }
                        }
                    }
                }
            }
            return validated;
        }
    }
}
