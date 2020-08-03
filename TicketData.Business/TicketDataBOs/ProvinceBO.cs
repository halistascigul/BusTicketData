using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TicketData.Core.Data;
using TicketData.Core.Extension;
using TicketData.DataAccess.TicketAdaptation;
using TicketData.Domain.Entities;

namespace TicketData.Business.TicketDataBOs
{
    public class ProvinceBO : IMainBO<State>
    {
        TicketAdaptation helper = new TicketAdaptation();
        public bool Delete(int id)
        {
            try
            {
                string cmdText = "update States set IsActive='0', IsDeleted='1', Updated=@Updated where Id=@Id";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Id",id),
                    new SqlParameter("@Updated",DateTime.Now)
                };
                return helper.SetData(cmdText, CommandType.Text, parameters);
            }
            catch (Exception ex)
            {
                if (ex.ToInnestException().Message != null)
                    throw ex.ToInnestException();
                else
                    throw ex;
            }
        }

        public State Get(int id)
        {
            try
            {
                string cmdText = "select Id,Province where Id=@Id and IsActive='1' and IsDeleted='0'";
                State state = new State();
                var reader = helper.GetData(cmdText, CommandType.Text, new SqlParameter("@Id", id));
                while (reader.Read())
                {
                    state.Id = Convert.ToInt32(reader["Id"]);
                    state.Province = reader["Province"].ToString();
                }
                reader.Close();
                return state;
            }
            catch (Exception ex)
            {
                if (ex.ToInnestException().Message != null)
                    throw ex.ToInnestException();
                else
                    throw ex;
            }
        }

        public List<State> GetList()
        {
            List<State> states = new List<State>();
            try
            {
                string cmdText = "select Id, Province from States where IsActive='1' and IsDeleted='0'";
                var reader = helper.GetData(cmdText, CommandType.Text);
                while (reader.Read())
                {
                    State state = new State();
                    state.Id = Convert.ToInt32(reader["Id"]);
                    state.Province = reader["Province"].ToString();
                    states.Add(state);
                }
                reader.Close();
                return states;
            }
            catch (Exception ex)
            {
                if (ex.ToInnestException().Message != null)
                    throw ex.ToInnestException();
                else
                    throw ex;
            }
        }

        public bool Insert(State model)
        {
            try
            {
                string cmdText = "insert into States (Province,Created,Updated,IsActive,IsDeleted) values (@Province,@Created, @Updated,@IsActive,@IsDeleted)";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Province",model.Province),
                    new SqlParameter("@Created",model.Created),
                    new SqlParameter("@Updated",model.Updated),
                    new SqlParameter("@IsActive",model.IsActive),
                    new SqlParameter("@IsDeleted",model.IsDeleted)
                };
                return helper.SetData(cmdText, CommandType.Text, parameters);
            }
            catch (Exception ex)
            {
                if (ex.ToInnestException().Message != null)
                    throw ex.ToInnestException();
                else
                    throw ex;
            }
        }

        public bool Update(State model)
        {
            try
            {
                string cmdText = "Update States set Province=@Province,Updated=@Updated where Id=@Id";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Id",model.Id),
                    new SqlParameter("@Province",model.Province),
                    new SqlParameter("@Updated",DateTime.Now)
                };
                return helper.SetData(cmdText, CommandType.Text, parameters);
            }
            catch (Exception ex)
            {
                if (ex.ToInnestException().Message != null)
                    throw ex.ToInnestException();
                else
                    throw ex;
            }
        }
    }
}
