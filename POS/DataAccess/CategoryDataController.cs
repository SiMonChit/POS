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
    public class CategoryDataController:DataControllerBase
    {
        public void Insert(string Code,string CategoryName)
        {
            command = new SqlCommand("Category_Insert", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("Code", Code);
                command.Parameters.AddWithValue("CategoryName", CategoryName);
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
        public void Update(int CategoryID, string Code, string CategoryName)
        {
            command = new SqlCommand("Category_Update", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("CategoryID", CategoryID);
                command.Parameters.AddWithValue("Code", Code);
                command.Parameters.AddWithValue("CategoriesName", CategoryName);
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
        public void Delete(int CategoriesID)
        {
            command = new SqlCommand("Category_Delete", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("CategoryID", CategoriesID);
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
        public dsPOS.CategoryDataTable Select()
        {
            dsPOS.CategoryDataTable datatable = new dsPOS.CategoryDataTable();

            command = new SqlCommand("Category_Select", connection);

            command.CommandType = CommandType.StoredProcedure;

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
                connection.Close();
            }
            return datatable;
        }

        public dsPOS.CategoryRow Select(string CategoriesID)
        {
            dsPOS.CategoryDataTable datatable = new dsPOS.CategoryDataTable();

            command = new SqlCommand("Category_SelectByID", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("@CategoriesID", CategoriesID);
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
                connection.Close();
            }
            if (datatable.Rows.Count > 0)
                return datatable[0];

            return null;
        }
        public dsPOS.CategoryDataTable SelectByID(string CategoriesID)
        {
            dsPOS.CategoryDataTable datatable = new dsPOS.CategoryDataTable();

            command = new SqlCommand("CategorySelectByID", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("@CategoriesID", CategoriesID);
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
                connection.Close();
            }
            return datatable;
        }
    }
}
