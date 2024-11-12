using System.Data.SqlClient;
using Catan.Models;

namespace Catan.Data
{
    internal class DAL
    {
        private static SqlConnection connection = new SqlConnection("data source=" + Environment.MachineName + ";initial catalog=Catan;" + "trusted_connection=true");
        public DAL()
        {
            //connection.ConnectionString = "data source=" + System.Environment.MachineName + ";initial catalog=Catan;trusted_connection=true" /*+ "MultipleActiveResultSets=True"*/;
        }


        //CRUD Player
        public void SavePlayer(Player player)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.Connection.Open();
                    command.CommandText = "INSERT INTO Player (Points, UserName, NumberOfStreets, NumberOfVillages, NumberOfCities, PlayerColour, FirstSettlement, FirstStreets) VALUES (@Points, @UserName, @NumberOfStreets, @NumberOfVillages, @NumberOfCities, @PlayerColour, @FirstSettlement, @FirstStreets)";
                    command.Parameters.AddWithValue("@Points", player.Points);
                    command.Parameters.AddWithValue("@UserName", player.UserName);
                    command.Parameters.AddWithValue("@NumberOfStreets", player.NumberOfStreets);
                    command.Parameters.AddWithValue("@NumberOfVillages", player.NumberOfVillages);
                    command.Parameters.AddWithValue("@NumberOfCities", player.NumberOfCities);
                    command.Parameters.AddWithValue("@PlayerColour", player.PlayerColour);
                    command.Parameters.AddWithValue("@FirstSettlement", player.FirstSettlement);
                    command.Parameters.AddWithValue("@FirstStreets", player.FirstStreets);
                    command.ExecuteNonQuery();
                    command.Connection.Close();

                }
            }
            catch
            {
                MessageBox.Show("Niet verbonden met SQL database\nhet programma sluit af");
                Application.Exit();
            }
        }

        public List<Player> GetAllPlayers()
        {
            try
            {
                List<Player> players = new List<Player>();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "SELECT * FROM Player";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Player player = new Player(
                                (int)reader["Id"],
                                (int)reader["Points"],
                                reader["UserName"].ToString(),
                                (int)reader["NumberOfStreets"],
                                (int)reader["NumberOfVillages"],
                                (int)reader["NumberOfCities"],
                                reader["PlayerColour"].ToString(),
                                (int)reader["FirstSettlement"],
                                (int)reader["FirstStreets"]
                                );
                            players.Add(player);
                        }
                    }
                    connection.Close();
                    return players;
                }
            }
            catch
            {
                MessageBox.Show("Niet verbonden met SQL database\nHet programma sluit af");
                Application.Exit();
                List<Player> list = new List<Player>();
                return list;
            }
        }

        public void UpdatePlayer(Player player)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "UPDATE Player SET Points = @Points, UserName = @UserName, NumberOfStreets = @NumberOfStreets, NumberOfVillages = @NumberOfVillages, NumberOfCities = @NumberOfCities, PlayerColour = @PlayerColour, FirstSettlement = @FirstSettlement, FirstStreets = @FirstStreets WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", player.Id);
                    command.Parameters.AddWithValue("@Points", player.Points);
                    command.Parameters.AddWithValue("@UserName", player.UserName);
                    command.Parameters.AddWithValue("@NumberOfStreets", player.NumberOfStreets);
                    command.Parameters.AddWithValue("@NumberOfVillages", player.NumberOfVillages);
                    command.Parameters.AddWithValue("@NumberOfCities", player.NumberOfCities);
                    command.Parameters.AddWithValue("@PlayerColour", player.PlayerColour);
                    command.Parameters.AddWithValue("@FirstSettlement", player.FirstSettlement);
                    command.Parameters.AddWithValue("@FirstStreets", player.FirstStreets);
                    command.ExecuteNonQuery();
                    connection.Close();

                }
            }
            catch
            {
                MessageBox.Show("Niet verbonden met SQL database\nHet programma sluit af");
                Application.Exit();
            }
        }
        public void DeletePlayer(Player player)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "DELETE FROM Player WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", player.Id);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Niet verbonden met SQL database\nHet programma sluit af");
                Application.Exit();
            }
        }

        public Player GetPlayerById(int id)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "SELECT * FROM Player WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Player player = new Player();
                        while (reader.Read())
                        {
                            player = new Player(
                                (int)reader["Id"],
                                (int)reader["Points"],
                                reader["UserName"].ToString(),
                                (int)reader["NumberOfStreets"],
                                (int)reader["NumberOfVillages"],
                                (int)reader["NumberOfCities"],
                                reader["PlayerColour"].ToString(),
                                (int)reader["FirstSettlement"],
                                (int)reader["FirstStreets"]
                                );


                        }
                        connection.Close();
                        return player;

                    }

                }
                return new Player();
            }
            catch
            {
                MessageBox.Show("Niet verbonden met SQL database\nHet programma sluit af");
                Application.Exit();
                return new Player();
            }
        }

    }
}
