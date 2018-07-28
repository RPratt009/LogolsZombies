namespace GradeBook.webapi
{
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Dapper;

    public class GradeReportRepository : Repository
    {
        public IEnumerable<GradeReport> GetAll() //We return GradeReport class 
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();//open connection to database
                string sql = "select s.PersonID, s.FirstName, s.LastName,s.GradeID,g.LetterGrade "//EN SONDA KESINLIKLE 1 SPACE OLMALI
                     + "from students s "//EN SONDA KESINLIKLE 1 SPACE OLMALI
                     + "inner join studentsgrade g "//EN SONDA KESINLIKLE 1 SPACE OLMALI
                     + "on s.GradeID= g.GradeID ";
                return dbConnection.Query<GradeReport>(sql, commandType: CommandType.Text).ToList(); 
                    
            }
        }

        public GradeReport Get(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<GradeReport>(
                    "select s.PersonID, s.FirstName, s.LastName,s.GradeID,g.LetterGrade "//EN SONDA KESINLIKLE 1 SPACE OLMALI
                     + "from students s "//EN SONDA KESINLIKLE 1 SPACE OLMALI
                     + "inner join studentsgrade g "//EN SONDA KESINLIKLE 1 SPACE OLMALI
                     + "on s.GradeID= g.GradeID "
                     + "where PersonID = @PersonID;"
                    , new { PersonID = id }, commandType: CommandType.Text).FirstOrDefault();
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "delete "
                    + "from students "
                    + "where PersonID = @PersonID;"
                    , new { PersonID = id }, commandType: CommandType.Text);
            }
        }

        public void Update(GradeReport gradeReport)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "update students "
                    + "set FirstName = @FirstName, LastName = @LastName, GradeID = @GradeID "
                    + "where PersonID = @PersonID;"
                    , new
                    {
                        PersonID = gradeReport.PersonID,
                        FirstName = gradeReport.FirstName,
                        LastName = gradeReport.LastName,
                        GradeID = gradeReport.GradeID
                    }
                    , commandType: CommandType.Text);
            }
        }

        public void Insert(GradeReport gradeReport)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute(
                    "insert into students (FirstName, LastName, GradeID) "
                    + "values(@FirstName, @LastName, @GradeID);"
                    , new
                    {
                        FirstName = gradeReport.FirstName,
                        LastName = gradeReport.LastName,
                        GradeID = gradeReport.GradeID
                    }
                    , commandType: CommandType.Text);
            }
        }
    }
}