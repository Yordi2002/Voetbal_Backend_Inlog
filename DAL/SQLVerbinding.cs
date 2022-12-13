using System.Data.SqlClient;

namespace DAL
{
    public class SQLVerbinding
    {
        private string connectiestring;
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader reader;

        private readonly string connect;

        public SQLVerbinding(string cs)
        {
            connect = cs;
        }

        public SQLVerbinding()
        {
            connectiestring = "Server=mssqlstud.fhict.local;Database=dbi459372_voetbal;User Id=dbi459372_voetbal;Password=Voetbal;";
        }
    }
}
