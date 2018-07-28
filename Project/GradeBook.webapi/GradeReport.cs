namespace GradeBook.webapi
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;

    public class GradeReport
    {
        public int PersonID { get; set; }
        public int GradeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LetterGrade { get; set; }
    }
}
