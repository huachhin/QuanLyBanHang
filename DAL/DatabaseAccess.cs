using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    internal class DatabaseAccess
    {
        private SqlDataAdapter sqlDataAdapter;
        private SqlConnection sqlConnection;

        public DatabaseAccess()
        {
            sqlDataAdapter = new SqlDataAdapter();
            sqlConnection = new SqlConnection("SQL");
        }
        public SqlConnection openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            return sqlConnection;
        }
        public void executeQuery(String query, SqlParameter[] sqlParameters)
        {
            using (SqlCommand cmd = new SqlCommand(query, openConnection()))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddRange(sqlParameters);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
        public SqlDataReader executeReader(String query)
        {
            using (SqlCommand cmd = new SqlCommand(query, openConnection()))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                try
                {
                    return cmd.ExecuteReader();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            return null;
        }
    }
}
