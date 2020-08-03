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
    public class BusBO : IMainBO<Bus>
    {
        TicketAdaptation helper = new TicketAdaptation();
        public bool Delete(int id)
        {
            bool result = false;
            try
            {
                string cmdText = "update Bus set IsActive='0', IsDeleted='1', Updated=@Updated where Id=@Id";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Id",id),
                    new SqlParameter("@Updated",DateTime.Now)
                };
                result = helper.SetData(cmdText, CommandType.Text, parameters);
            }
            catch (Exception ex)
            {
                throw ex.ToInnestException();
            }
            return result;
        }

        public Bus Get(int id)
        {
            try
            {
                string cmdText = "select Id,BusModel,BusType,SeatingCapacity,WhereFrom, WhereTo, TravelDate, TravelTime from Buses where Id=@Id";
                var reader = helper.GetData(cmdText, CommandType.Text, new SqlParameter("@Id", id));
                Bus bus = new Bus();
                while (reader.Read())
                {
                    bus.Id = Convert.ToInt32(reader["Id"]);
                    bus.BusModel = reader["BusModel"].ToString();
                    bus.BusType = reader["BusType"].ToString();
                    bus.SeatingCapacity = Convert.ToByte(reader["SeatingCapacity"]);
                    bus.WhereFrom = reader["WhereFrom"].ToString();
                    bus.WhereTo = reader["WhereTo"].ToString();
                    bus.TravelDate = Convert.ToDateTime(reader["TravelDate"]);
                    bus.TravelTime = reader["TravelTime"].ToString();
                }
                return bus;
            }
            catch (Exception ex)
            {
                throw ex.ToInnestException();
            }
        }

        public List<Bus> GetList()
        {
            List<Bus> buses = new List<Bus>();
            try
            {
                string cmdText = "select Id,BusModel,SeatingCapacity,BusType,WhereFrom, WhereTo, TravelDate, TravelTime from Buses where IsActive='1'and IsDeleted='0'";
                var reader = helper.GetData(cmdText, CommandType.Text);
                while (reader.Read())
                {
                    Bus bus = new Bus();
                    bus.Id = Convert.ToInt32(reader["Id"]);
                    bus.BusModel = reader["BusModel"].ToString();
                    bus.BusType = reader["BusType"].ToString();
                    bus.SeatingCapacity = Convert.ToByte(reader["SeatingCapacity"]);
                    bus.WhereFrom = reader["WhereFrom"].ToString();
                    bus.WhereTo = (string)reader["WhereTo"];
                    bus.TravelDate = Convert.ToDateTime(reader["TravelDate"]);
                    bus.TravelTime = reader["TravelTime"].ToString();
                    buses.Add(bus);
                }
                reader.Close();
                return buses;
            }
            catch (Exception ex)
            {
                if (ex.ToInnestException().Message != null)
                    throw ex.ToInnestException();
                else
                    throw ex;
            }
        }

        public bool Insert(Bus model)
        {
            try
            {
                string cmdText = "insert into Buses (BusModel,SeatingCapacity,BusType,WhereFrom,WhereTo,TravelDate,TravelTime, Created,Updated,IsActive,IsDeleted) values (@BusModel,@SeatingCapacity,@BusType,@WhereFrom,@WhereTo, @TravelDate,@TravelTime,@Created,@Updated,@IsActive,@IsDeleted)";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@BusModel",model.BusModel),
                    new SqlParameter("@SeatingCapacity",model.SeatingCapacity),
                    new SqlParameter("@BusType",model.BusType),
                    new SqlParameter("@WhereFrom",model.WhereFrom),
                    new SqlParameter("@WhereTo",model.WhereTo),
                    new SqlParameter("@TravelDate",model.TravelDate),
                    new SqlParameter("@TravelTime",model.TravelTime),
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

        public bool Update(Bus model)
        {
            try
            {
                string cmdText = "update Buses set WhereFrom=@WhereFrom, WhereTo=@WhereTo, TravelDate=@TravelDate, TravelTime=@TravelTime, Updated=@Updated where Id=@Id";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Id",model.Id),
                    new SqlParameter("@WhereFrom",model.WhereFrom),
                    new SqlParameter("@WhereTo",model.WhereTo),
                    new SqlParameter("@TravelDate",model.TravelDate),
                    new SqlParameter("@TravelTime",model.TravelTime),
                    new SqlParameter("@Updated",DateTime.Now),
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

        public List<Bus> GetListByDate(string whereFrom, string whereTo, DateTime travelDate)
        {
            List<Bus> buses = new List<Bus>();
            try
            {
                string cmdText = "select Id,TravelTime from Buses where WhereFrom=@WhereFrom and WhereTo=@WhereTo and TravelDate=@TravelDate";
                var reader = helper.GetData(cmdText, CommandType.Text, new SqlParameter("@WhereFrom", whereFrom), new SqlParameter("@WhereTo", whereTo), new SqlParameter("@TravelDate", travelDate));
                while (reader.Read())
                {
                    Bus bus = new Bus();
                    bus.Id = Convert.ToInt32(reader["Id"]);
                    bus.TravelTime = reader["TravelTime"].ToString();
                    buses.Add(bus);
                }
                reader.Close();
                return buses;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Bus GetBus(string whereFrom, DateTime travelDate, string travelTime)
        {
            try
            {
                string cmdText = "select Id, BusModel from Buses where WhereFrom=@WhereFrom and TravelDate=@TravelDate and TravelTime=@TravelTime";
                var reader = helper.GetData(cmdText, CommandType.Text, new SqlParameter("@WhereFrom", whereFrom), new SqlParameter("@TravelDate", travelDate), new SqlParameter("@TravelTime", travelTime));
                Bus bus = new Bus();
                while (reader.Read())
                {
                    bus.Id = Convert.ToInt32(reader["Id"]);
                    bus.BusModel = reader["BusModel"].ToString();
                }
                return bus;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
