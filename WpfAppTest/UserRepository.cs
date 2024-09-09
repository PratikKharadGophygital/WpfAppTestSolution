
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace WpfAppTest
{
    public class UserRepository
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Method to retrieve all users
        public IEnumerable<User> GetAllUsers()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<User>("SELECT * FROM tblUsers").ToList();
            }
        }

        // Method to add a new user
        public void AddUser(User user)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sqlQuery = "INSERT INTO tblUsers (FirstName, LastName, PhoneNumber) VALUES (@FirstName, @LastName, @PhoneNumber)";
                db.Execute(sqlQuery, user);
            }
        }
    }
}
