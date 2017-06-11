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

            //hází výjimku
            database.CreateTableAsync<Team>().Wait();
        }
        public Task<List<Team>> GetItemsAsync()
        {
            return database.Table<Team>().ToListAsync();
        }
        public Task<List<Team>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Team>("SELECT * FROM [Team] WHERE [Done] = 0");
        }
        public Task<Team> GetItemAsync(int id)
        {
            return database.Table<Team>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }
        public Task<int> SaveItemAsync(Team team)
        {
            if (team.ID != 0)
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
    }
}
