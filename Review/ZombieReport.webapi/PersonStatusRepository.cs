namespace ZombieReport.webapi
{
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Dapper;

    public class PersonStatusRepository : Repository
    {
        public IEnumerable<PersonStatus> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<PersonStatus>(
                    "select p.PersonID, p.FirstName, p.LastName, p.PersonStatusID, ps.StatusDescription"
                    + " from Person p inner join PersonStatus ps on p.PersonStatusID = ps.PersonStatusID;"
                    , commandType: CommandType.Text);
            }
        }

        public PersonStatus Get(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<PersonStatus>(
                    "select PersonID, FirstName, LastName, PersonStatusID "
                    + "from Person "
                    + "where PersonID = @PersonID;"
                    ,new {PersonID = id} ,commandType: CommandType.Text).FirstOrDefault();
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "delete "
                    + "from Person "
                    + "where PersonID = @PersonID;"
                    ,new {PersonID = id} ,commandType: CommandType.Text);
            }
        }

        public void Update(PersonStatus personStatus)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "update Person "
                    + "set FirstName = @FirstName, LastName = @LastName, PersonStatusID = @PersonStatusID "
                    + "where PersonID = @PersonID;"
                    ,new {
                        PersonID = personStatus.PersonID, 
                        FirstName = personStatus.FirstName,
                        LastName = personStatus.LastName,
                        PersonStatusID = personStatus.PersonStatusID
                    } 
                    ,commandType: CommandType.Text);
            }
        }

        public void Insert(PersonStatus personStatus)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "insert into Person(FirstName, LastName, PersonStatusID) "
                    + "values(@FirstName, @LastName, @PersonStatusID);"
                    ,new { 
                        FirstName = personStatus.FirstName,
                        LastName = personStatus.LastName,
                        PersonStatusID = personStatus.PersonStatusID
                    } 
                    ,commandType: CommandType.Text);
            }
        }
    }
}