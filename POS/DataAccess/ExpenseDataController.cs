using POS.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DataAccess
{
    public class ExpenseDataController:DataControllerBase
    {
        public void Insert(dsPOS.ExpenseRow expRow)
        {
             command = new SqlCommand("Expense_Insert", connection);

            command.CommandType = CommandType.StoredProcedure;

            string key = null;
            try
            {

                command.Parameters.AddWithValue("CashBookID", expRow.CashBookID);
                command.Parameters.AddWithValue("Description", expRow.Description);
                command.Parameters.AddWithValue("Amount", expRow.Amount);
                command.Parameters.AddWithValue("ApproveBy", expRow.AproveBy);
                command.Parameters.AddWithValue("ExpDate", expRow.ExpDate);

                connection.Open();
                key = (string)command.ExecuteScalar();
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
        public void Update(dsPOS.ExpenseRow expRow)
        {
            command = new SqlCommand("Expense_Update", connection);

            command.CommandType = CommandType.StoredProcedure;
            try
            {

                command.Parameters.AddWithValue("ExpenseID", expRow.ExpenseID);
                command.Parameters.AddWithValue("CashBookID", expRow.CashBookID);
                command.Parameters.AddWithValue("Description", expRow.Description);
                command.Parameters.AddWithValue("Amount", expRow.Amount);
                command.Parameters.AddWithValue("ApproveBy", expRow.AproveBy);
                command.Parameters.AddWithValue("ExpDate", expRow.ExpDate);

                if (connection.State != ConnectionState.Open) connection.Open();
                command.ExecuteNonQuery();
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
        }
        public void Delete(string ExpenseID)
        {
            command = new SqlCommand("Expense_Delete", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("ExpenseID", ExpenseID);

                if (connection.State != ConnectionState.Open) connection.Open();
                command.ExecuteNonQuery();
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
        }
        public dsPOS.ExpenseDataTable Select()
        {
            dsPOS.ExpenseDataTable datatable = new dsPOS.ExpenseDataTable();

            base.command = new SqlCommand("Expense_Select", connection);

            base.command.CommandType = CommandType.StoredProcedure;

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(datatable);
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

            return datatable;

        }

        public dsPOS.ExpenseDataTable SelectByCashBookID(string CashBookID)
        {
            dsPOS.ExpenseDataTable datatable = new dsPOS.ExpenseDataTable();

            base.command = new SqlCommand("Expense_SelectByCashBookID", connection);

            base.command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("CashBookID", CashBookID);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(datatable);
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

            return datatable;

        }
        public dsPOS.ExpenseDataTable SelectByDate(DateTime FromDate, DateTime ToDate)
        {
            dsPOS.ExpenseDataTable datatable = new dsPOS.ExpenseDataTable();
           command = new SqlCommand("Expense_SelectByDate", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("FromDate", FromDate);
                command.Parameters.AddWithValue("ToDate", ToDate);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(datatable);
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

            return datatable;

        }

    }
}
