using Dapper;
using Interface.DTO;
using Interface.Interface;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Context
{
    public class UserContext : SQLVerbinding ,IUserContext
    {
        private readonly string cons;
        private readonly IDbConnection connection;

        public UserContext(string cs)
        { 
            this.cons = cs;
            connection = new System.Data.SqlClient.SqlConnection(cs);
        }

        public UserDTO AttemptLogin(UserDTO userDTO)
        {
            List<UserDTO> list = new List<UserDTO>();

            var sql = "SELECT * from [User]";

            //execute statement
            try
            {
                using (connection)
                {
                    //execute query on database and return result
                    list = connection.Query<UserDTO>(sql).ToList();
                }
            }

            //catches exceptions
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            //closes database connection
            finally
            {
                connection.Close();
            }

            return list[0];
        }
    }
}
