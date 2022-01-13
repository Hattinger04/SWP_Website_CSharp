using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Models.DB {

    public class RepositoryUsersDB : IRepositoryUsers {

        private string connectionsString = "Server=localhost;database=testwebsite;user=root";
        private DbConnection connection;
        public void Connect() {
            if (this.connection == null) {
                this.connection = new MySqlConnection(this.connectionsString);
            }
            if (this.connection.State != System.Data.ConnectionState.Open) {
                this.connection.Open();
            }
        }
        public void Disconnect() {
            if (this.connection != null && this.connection.State == System.Data.ConnectionState.Open) {
                this.connection.Close();
            }
        }

        public bool ChangeUserData(int userID, User newUserData) {
            throw new NotImplementedException();
        }

        public bool Delete(int user_id) {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers() {
            throw new NotImplementedException();
        }

        public bool Insert(User user) {
            if (this.connection?.State == System.Data.ConnectionState.Open) {
                DbCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "insert into users values(null, @username, sha2(@password, 512), @email, @birthdate, @gender)";
                DbParameter paramUN = cmd.CreateParameter();
                paramUN.ParameterName = "username";
                paramUN.DbType = System.Data.DbType.String;
                paramUN.Value = user.Username;

                DbParameter paramPW = cmd.CreateParameter();
                paramPW.ParameterName = "password";
                paramPW.DbType = System.Data.DbType.String;
                paramPW.Value = user.Password;

                DbParameter paramEmail = cmd.CreateParameter();
                paramEmail.ParameterName = "email";
                paramEmail.DbType = System.Data.DbType.String;
                paramEmail.Value = user.Email;

                DbParameter paramBD = cmd.CreateParameter();
                paramBD.ParameterName = "birthdate";
                paramBD.DbType = System.Data.DbType.Date;
                paramBD.Value = user.Birthdate;

                DbParameter paramGender = cmd.CreateParameter();
                paramGender.ParameterName = "gender";
                paramGender.DbType = System.Data.DbType.Int32;
                paramGender.Value = user.Gender;

                cmd.Parameters.Add(paramUN);
                cmd.Parameters.Add(paramPW);
                cmd.Parameters.Add(paramEmail);
                cmd.Parameters.Add(paramBD);
                cmd.Parameters.Add(paramGender);

                return cmd.ExecuteNonQuery() == 1; 
            }
            return false;
        }

        public User Login(string username, string password) {
            throw new NotImplementedException();
        }
    }
}
