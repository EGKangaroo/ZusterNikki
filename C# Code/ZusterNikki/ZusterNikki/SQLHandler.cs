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

        //make new account function, returns whether is has succeeded or not
        public bool MakeNewAccount(string password, string passwordCopy, string name)
        {
            bool accountMade = true;

            if (!password.Equals(passwordCopy))
            {
                Console.WriteLine("Password not equal");
                return !accountMade;
            }

            if (!CheckValidAccountName(name))
            {
                Console.WriteLine("not a valid account name");
                return !accountMade;
            }

            CreateNewAccount(name, password);

            return accountMade;
        }

        //overload for when the account maker also specifies they have a patient number
        public bool MakeNewAccount(string password, string passwordCopy, string name, int patientNumber)
        {
            bool accountMade = true;

            if (!password.Equals(passwordCopy))
            {
                Console.WriteLine("Password not equal");
                return !accountMade;
            }

            if (!CheckValidPatientNumber(patientNumber))
            {
                Console.WriteLine("Not a valid number");
                return !accountMade;
            }

            if (!CheckUniquePatientID(patientNumber))
            {
                Console.WriteLine("Not a unique number");
                return !accountMade;
            }

            if (!CheckValidAccountName(name))
            {
                Console.WriteLine("not a valid account name");
                return !accountMade;
            }

            CreateNewAccount(name, password, patientNumber);

            return accountMade;
        }

        //inserts a new row into the player database to make a new account
        private void CreateNewAccount(string name, string password)
        {

            using(SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();

                string query = "INSERT INTO Player (Username, Password) Values (@nm, @pw)";

                using(SqlCommand MakeAccount = new SqlCommand(query, connection))
                {
                    MakeAccount.Parameters.AddWithValue("@nm", name);
                    MakeAccount.Parameters.AddWithValue("@pw", password);

                    MakeAccount.ExecuteNonQuery();
                }
            }
        }

        //override to insert a new row into player database when a patient number is specified
        private void CreateNewAccount(string name, string password, int patientNumber)
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();

                string query = "INSERT INTO Player (Username, Password, Age, Gender, PatientId) Values (@nm, @pw, @ag, @gn, @pn)";

                using (SqlCommand MakeAccount = new SqlCommand(query, connection))
                {
                    MakeAccount.Parameters.AddWithValue("@nm", name);
                    MakeAccount.Parameters.AddWithValue("@pw", password);
                    MakeAccount.Parameters.AddWithValue("@ag", GetAge(patientNumber));
                    MakeAccount.Parameters.AddWithValue("@gn", GetGender(patientNumber));
                    MakeAccount.Parameters.AddWithValue("@pn", patientNumber);

                    MakeAccount.ExecuteNonQuery();
                }
            }
        }

        //gets age from specified patientId
        private int GetAge(int patientNumber)
        {
            int age = 0;

            using(SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();

                string query = "SELECT Age FROM Patient WHERE Id = @id";

                using(SqlCommand ReadAge = new SqlCommand(query, connection))
                {

                    ReadAge.Parameters.AddWithValue("@id", patientNumber);

                    using (SqlDataReader reader = ReadAge.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            age = reader.GetInt32(0);
                        }
                    }
                }
            }

            return age;
        }

        //gets name from specified patientID
        private string GetGender(int patientNumber)
        {
            string name = "";

            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();

                string query = "SELECT Gender FROM Patient WHERE Id = @id";

                using (SqlCommand ReadAge = new SqlCommand(query, connection))
                {
                    ReadAge.Parameters.AddWithValue("@id", patientNumber);

                    using (SqlDataReader reader = ReadAge.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            name = reader.GetString(0);
                        }
                    }
                }
            }

            return name;
        }

        //checks whether the patient number that was given is valid
        private bool CheckValidPatientNumber(int patientNumber)
        {
            bool validId = false;

            using(SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();

                string query = "SELECT Id FROM Patient";

                using(SqlCommand CheckValidId = new SqlCommand(query, connection))
                {
                    using(SqlDataReader reader = CheckValidId.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            if (reader.GetInt32(0).Equals(patientNumber))
                            {
                                validId = true;
                            }
                        }
                    }
                }
            }

            return validId;
        }

        //checks whether the given patientnumber is not already in the player database
        private bool CheckUniquePatientID(int patientNumber)
        {
            bool unique = true;
            using(SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();

                string query = "SELECT PatientId FROM Player";

                using (SqlCommand CheckUniqueID = new SqlCommand(query, connection))
                {
                    using(SqlDataReader reader = CheckUniqueID.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                if (reader.GetInt32(0).Equals(patientNumber))
                                {
                                    unique = false;
                                }
                            }
                        }
                    }
                }
            }

            return unique;
        }

        //Check valid username
        private bool CheckValidAccountName(string name)
        {
            bool validName = true;

            using(SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();

                string query = "SELECT Username FROM Player";

                using(SqlCommand CheckValidUsername = new SqlCommand(query, connection))
                {
                    using(SqlDataReader reader = CheckValidUsername.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString(0).Equals(name))
                            {
                                validName = false;
                            }
                        }
                    }
                }
            }

            return validName;
        }

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
                            int age = 0;
                            string gender = null;
                            int id = reader.GetInt32(0);
                            string username = reader.GetString(2);
                            int score = reader.GetInt32(3);
                            if (!reader.IsDBNull(4))
                            {
                                age = reader.GetInt32(4);
                            }
                            if (!reader.IsDBNull(5))
                            {
                                gender = reader.GetString(5);
                            }
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
