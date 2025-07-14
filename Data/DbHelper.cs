using Microsoft.Data.SqlClient;
using mvccemx.Models;
using System.Data;

namespace mvccemx.Data
{
    public class DbHelper
    {
        private static readonly string connectionString = "Server=localhost;Database=UserManagementDb;Trusted_Connection=True;Encrypt=False;";



        public static DataTable GetUsers()
        {
            DataTable dt = new();
            using SqlConnection conn = new(connectionString);
            using SqlCommand cmd = new("SELECT * FROM Users", conn);
            conn.Open();
            SqlDataAdapter da = new(cmd);
            da.Fill(dt);
            return dt;
        }

        public static void AddUser(UserModel user)
        {
            using SqlConnection conn = new(connectionString);
            using SqlCommand cmd = new("INSERT INTO Users (Username, EmployeeId, EmployeeName, IsActive) VALUES (@Username, @EmployeeId, @EmployeeName, @IsActive)", conn);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@EmployeeId", user.EmployeeId);
            cmd.Parameters.AddWithValue("@EmployeeName", user.EmployeeName);
            cmd.Parameters.AddWithValue("@IsActive", user.IsActive);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
