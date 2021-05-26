using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_BlackJack.Models;

namespace WPF_BlackJack.Data
{
    class PlayerDataService
    {
        private static string connectionString =
        ConfigurationManager.ConnectionStrings["azure"].ConnectionString;

        private static readonly IDbConnection db = new SqlConnection(connectionString);

        public List<Player> GetUsers()
        {
            string sql = "Select * from Users";
            return (List<Player>)db.Query<Player>(sql);
        }

        public List<Round> GetRounds(int playerid)
        {
            string sql = "Select * from Rounds where Userid = " + playerid;
            return (List<Round>)db.Query<Round>(sql);
        }

        public void UpdateUser(Player player)
        {
            string sql = "Update Users set BankRoll = @bankroll where id = @id";
            db.Execute(sql, new
            {
                player.Id,
                player.BankRoll
            });
        }

        public void InsertUser(Player player)
        {

            string sql = "Insert into Users (Name, BankRoll) values (@name, @bankroll)";

            db.Execute(sql, new
            {
                player.Name,
                player.BankRoll
            });
        }

        public void InsertRound(Player player)
        {
            string sql = "Insert into Rounds (Userid, gains, winlos) values (@id, @totalwinnings, @win)";

            db.Execute(sql, new
            {
                player.Id,
                player.TotalWinnings,
                player.win
            });
        }
    }
}
