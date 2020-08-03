using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TicketData.Core.Data;
using TicketData.Core.Extension;
using TicketData.DataAccess.TicketAdaptation;
using TicketData.Domain.Entities;

namespace TicketData.Business.TicketDataBOs
{
    public class PassengerBO : IMainBO<Passenger>
    {
        TicketAdaptation helper = new TicketAdaptation();
        public bool Delete(int id)
        {
            try
            {
                string cmdText = "update Passengers set IsActive='0', IsDeleted='1', Updated=@Updated where Id=@Id";
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

        public Passenger Get(int id)
        {
            try
            {
                string cmdText = "select Id, FullName, IdentityNumber, Phone, Email, Gender, SeatNumber, FeeToPay, BusId, from Passengers where Id=@Id and IsActive='1' and IsDeleted='0'";
                Passenger passenger = new Passenger();
                var reader = helper.GetData(cmdText, CommandType.Text, new SqlParameter("@Id", id));
                while (reader.Read())
                {
                    passenger.Id = Convert.ToInt32(reader["Id"]);
                    passenger.FullName = reader["FullName"].ToString();
                    passenger.IdentityNumber = Convert.ToInt64(reader["IdentityNumber"]);
                    passenger.Phone = reader["Phone"].ToString();
                    passenger.Email = reader["Email"].ToString();
                    passenger.Gender = reader["Gender"].ToString();
                    passenger.SeatNumber = Convert.ToByte(reader["SeatNumber"]);
                    passenger.FeeToPay = Convert.ToDecimal("FeeToPay");
                    passenger.BusId = Convert.ToInt32(reader["BusId"]);
                }
                reader.Close();
                return passenger;
            }
            catch (Exception ex)
            {
                if (ex.ToInnestException().Message != null)
                    throw ex.ToInnestException();
                else
                    throw ex;
            }
        }

        public List<Passenger> GetList()
        {
            List<Passenger> passengers = new List<Passenger>();
            try
            {
                string cmdText = "select Id, FullName, IdentityNumber, Phone, Email, Gender, SeatNumber, FeeToPay, BusId from Passengers where IsActive='1' and IsDeleted='0'";
                var reader = helper.GetData(cmdText, CommandType.Text);
                while (reader.Read())
                {
                    Passenger passenger = new Passenger();
                    passenger.Id = Convert.ToInt32(reader["Id"]);
                    passenger.FullName = reader["FullName"].ToString();
                    passenger.IdentityNumber = Convert.ToInt64(reader["IdentityNumber"]);
                    passenger.Phone = reader["Phone"].ToString();
                    passenger.Email = reader["Email"].ToString();
                    passenger.Gender = reader["Gender"].ToString();
                    passenger.SeatNumber = Convert.ToByte(reader["SeatNumber"]);
                    passenger.FeeToPay = Convert.ToDecimal("FeeToPay");
                    passenger.BusId = Convert.ToInt32(reader["BusId"]);
                    passengers.Add(passenger);
                }
                reader.Close();
                return passengers;
            }
            catch (Exception ex)
            {
                if (ex.ToInnestException().Message != null)
                    throw ex.ToInnestException();
                else
                    throw ex;
            }
        }

        public bool Insert(Passenger model)
        {
            try
            {
                string cmdText = "insert into Passengers (FullName,BusId,IdentityNumber,Phone,Email,Gender,SeatNumber,FeeToPay, Created,Updated,IsActive,IsDeleted) values (@FullName,@BusId,@IdentityNumber,@Phone,@Email,@Gender,@SeatNumber, @FeeToPay, @Created, @Updated, @IsActive, @IsDeleted)";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@FullName",model.FullName),
                    new SqlParameter("@BusId",model.BusId),
                    new SqlParameter("@IdentityNumber",model.IdentityNumber),
                    new SqlParameter("@Phone",model.Phone),
                    new SqlParameter("@Email",model.Email),
                    new SqlParameter("@Gender",model.Gender),
                    new SqlParameter("@SeatNumber",model.SeatNumber),
                    new SqlParameter("@FeeToPay",model.FeeToPay),
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

        public bool Update(Passenger model)
        {
            try
            {
                string cmdText = "update Passengers set FullName=@FullName, IdentityNumber=@IdentityNumber, Phone=@Phone, Email=@Email, Gender=@Gender, SeatNumber=@SeatNumber, FeeToPay=@FeeToPay, BusId=@BusId, Updated=@Updated where Id=@Id";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Id",model.Id),
                    new SqlParameter("@FullName",model.FullName),
                    new SqlParameter("@IdentityNumber",model.IdentityNumber),
                    new SqlParameter("@Phone",model.Phone),
                    new SqlParameter("@Email",model.Email),
                    new SqlParameter("@Gender",model.Gender),
                    new SqlParameter("@SeatNumber",model.SeatNumber),
                    new SqlParameter("@FeeToPay",model.FeeToPay),
                    new SqlParameter("@BusId",model.BusId),
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

        public List<Passenger> GetListInBus(int id)
        {
            List<Passenger> passengers = new List<Passenger>();
            try
            {
                string cmdText = "select Id, SeatNumber, BusId, Gender,IdentityNumber from Passengers where BusId=@BusId and IsActive='1' and IsDeleted='0'";
                var reader = helper.GetData(cmdText, CommandType.Text, new SqlParameter("@BusId", id));
                while (reader.Read())
                {
                    Passenger passenger = new Passenger();
                    passenger.Id = Convert.ToInt32(reader["Id"]);
                    passenger.SeatNumber = Convert.ToByte(reader["SeatNumber"]);
                    passenger.BusId = Convert.ToInt32(reader["BusId"]);
                    passenger.Gender = reader["Gender"].ToString();
                    passenger.IdentityNumber = Convert.ToInt64(reader["IdentityNumber"]);
                    passengers.Add(passenger);
                }
                reader.Close();
                return passengers;
            }
            catch (Exception ex)
            {
                if (ex.ToInnestException().Message != null)
                    throw ex.ToInnestException();
                else
                    throw ex;
            }
        }

        public List<Passenger> GetPassengersInBus(int id)
        {
            try
            {
                List<Passenger> passengers = new List<Passenger>(); 
                string cmdText = "select Passengers.Id, Passengers.FullName, Passengers.IdentityNumber, Passengers.SeatNumber, Passengers.BusId, Passengers.Phone, Passengers.Email, Passengers.Gender, Passengers.FeeToPay from Passengers inner join Buses on Buses.Id=@BusId and Passengers.BusId=@BusId and Passengers.IsActive ='1' and Passengers.IsDeleted='0'";
                var reader = helper.GetData(cmdText, CommandType.Text, new SqlParameter("@BusId", id));
                while (reader.Read())
                {
                    Passenger passenger = new Passenger();
                    Bus bus = new Bus();
                    passenger.Id = Convert.ToInt32(reader["Id"]);
                    passenger.FullName = reader["FullName"].ToString();
                    passenger.IdentityNumber = Convert.ToInt64(reader["IdentityNumber"]);
                    passenger.SeatNumber = Convert.ToByte(reader["SeatNumber"]);
                    passenger.BusId = Convert.ToInt32(reader["BusId"]);
                    passenger.Phone = reader["Phone"].ToString();
                    passenger.Email = reader["Email"].ToString();
                    passenger.Gender = reader["Gender"].ToString();
                    passenger.FeeToPay = Convert.ToDecimal(reader["FeeToPay"]);

                    passengers.Add(passenger);
                }
                reader.Close();
                return passengers;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool EndOfTravel(int busId)
        {
            try
            {
                string cmdText = "update Passengers set Passengers.IsActive='0', Passengers.IsDeleted='1' from Buses where Buses.TravelDate<SYSDATETIME() and Buses.Id=@BusId and Passengers.BusId=@BusId";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@BusId",busId)
                };
                return helper.SetData(cmdText, CommandType.Text, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
