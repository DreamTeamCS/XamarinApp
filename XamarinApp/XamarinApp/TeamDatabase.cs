using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp
{
    public class TeamDatabase
    {
        private SQLiteAsyncConnection database;

        public TeamDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Team>().Wait();
        }

        // Query using SQL query string
        public Task<List<Team>> GetItemsAsync()
        {
            return database.Table<Team>().ToListAsync();
        }

        // Query using LINQ
        public Task<Team> GetTeam(int pos)
        {
            return database.Table<Team>().Where(i => i.Position == pos).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Team team)
        {
            if (team.Position != 0)
            {
                return database.UpdateAsync(team);
            }
            else
            {
                return database.InsertAsync(team);
            }
        }

        public Task<int> DeleteItemAsync(Team team)
        {
            return database.DeleteAsync(team);
        }

        public Task<List<Team>> DeleteItems()
        {
            return database.QueryAsync<Team>("Delete FROM [Team]");
        }
    }
}
