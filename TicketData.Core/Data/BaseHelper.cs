using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketData.Core.Extension;

namespace TicketData.Core.Data
{
    public class BaseHelper
    {
        public string ConnectionString { get; set; }

        public bool SetData(string cmdText, CommandType cmdType, List<SqlParameter> parameters)
        {
            bool result = false;
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(cmdText, con))
                    {
                        cmd.CommandType = cmdType;
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters.ToArray());
                        con.Open();
                        result = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex.ToInnestException();
            }
            return result;
        }

        public SqlDataReader GetData(string cmdText, CommandType cmdType, params SqlParameter[] parameters)
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.CommandType = cmdType;
                cmd.Parameters.AddRange(parameters);
                con.Open();
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw ex.ToInnestException();
            }
            return reader;
        }
    }
}
