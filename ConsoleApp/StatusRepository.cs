using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

namespace ConsoleApp
{
    public class StatusRepository : Repository
    {
        public List<Status> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                string sql = 
                    "select p.FirstName, p.LastName, ps.StatusDescription "
                    + " from Person p "
                    + " inner join PersonStatus ps "
	                + " on p.PersonStatusID = ps.PersonStatusID; ";
                return dbConnection.Query<Status>(sql, commandType: CommandType.Text).ToList();
            }
        }
    }
}
