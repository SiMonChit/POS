using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Entities;

namespace POS.DataAccess
{
    public class CashBookDataController:DataControllerBase
    {
        public void Insert(dsPOS.CashBookRow cashBook)
        {
            command = new SqlCommand("CashBook_Insert", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("@Code", cashBook.Code);
                command.Parameters.AddWithValue("@Name", cashBook.Name);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public void Update(dsPOS.CashBookRow cashBook)
        {
            command = new SqlCommand("CashBook_Update", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("@CashBookID", cashBook.CashBookID);
                command.Parameters.AddWithValue("@Code", cashBook.Code);
                command.Parameters.AddWithValue("@Name", cashBook.Name);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public void Delete(string CashBookID)
        {
            command = new SqlCommand("CashBook_Delete", connection);
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("@CashBookID", CashBookID);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public dsPOS.CashBookDataTable Select()
        {
            string SqlString = "CashBook_Select";
            dsPOS.CashBookDataTable dataTable = new dsPOS.CashBookDataTable();

            command = new SqlCommand(SqlString, connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return dataTable;
            
        }
        public dsPOS.CashBookDataTable SelectForDropDown()
        {
            dsPOS.CashBookDataTable dataTable = new dsPOS.CashBookDataTable();

            command = new SqlCommand("CashBook_SelectForDropDownList", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return dataTable;
        }
    }
}
