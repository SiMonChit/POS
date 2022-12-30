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
    public class ItemsDataController:DataControllerBase
    {
        public void Insert(dsPOS.ItemsRow itemsRow)
        {
            command = new SqlCommand("Items_Insert", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("CategoryID", itemsRow.CategoryID);
                command.Parameters.AddWithValue("ItemsImage", itemsRow.ItemsImage);
                command.Parameters.AddWithValue("ItemCode", itemsRow.ItemCode);
                command.Parameters.AddWithValue("ItemName", itemsRow.ItemName);
                command.Parameters.AddWithValue("SellPrice", itemsRow.SellPrice);
                command.Parameters.AddWithValue("BuyPrice", itemsRow.BuyPrice);
                command.Parameters.AddWithValue("Qty", itemsRow.Qty);

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
        public void Update(dsPOS.ItemsRow itemsRow)
        {
            command = new SqlCommand("Items_Update", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("ItemsID", itemsRow.ItemsID);
                command.Parameters.AddWithValue("CategoryID", itemsRow.CategoryID);
                command.Parameters.AddWithValue("ItemsImage", itemsRow.ItemsImage);
                command.Parameters.AddWithValue("ItemCode", itemsRow.ItemCode);
                command.Parameters.AddWithValue("ItemName", itemsRow.ItemName);
                command.Parameters.AddWithValue("SellPrice", itemsRow.SellPrice);
                command.Parameters.AddWithValue("BuyPrice", itemsRow.BuyPrice);
                command.Parameters.AddWithValue("Qty", itemsRow.Qty);

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
        public void Delete(int ItemsID)
        {
            command = new SqlCommand("Items_Delete", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("ItemsID", ItemsID);

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
        public dsPOS.ItemsDataTable Select()
        {
            dsPOS.ItemsDataTable datatable = new dsPOS.ItemsDataTable();

            command = new SqlCommand("Items_Select", connection);

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

        public dsPOS.ItemsDataTable SelectForSale()
        {
            dsPOS.ItemsDataTable datatable = new dsPOS.ItemsDataTable();

            command = new SqlCommand("ItemsSelectForSale", connection);

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
        public dsPOS.ItemsRow SelectByID(int ItemsID)
        {
            dsPOS.ItemsDataTable datatable = new dsPOS.ItemsDataTable();

            command = new SqlCommand("Items_SelectByID", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("ItemsID", ItemsID);
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
        public dsPOS.ItemsRow SelectByCode(string ItemsCode)
        {
            dsPOS.ItemsDataTable datatable = new dsPOS.ItemsDataTable();

            command = new SqlCommand("Items_SelectByCode", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("ItemCode", ItemsCode);
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
        public dsPOS.ItemsDataTable SelectByName(string ItemsName)
        {
            dsPOS.ItemsDataTable datatable = new dsPOS.ItemsDataTable();

            command = new SqlCommand("Items_SelectByName", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("@ItemsName", ItemsName);
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
        public dsPOS.ItemsRow Select(string ItemsCode)
        {
            dsPOS.ItemsDataTable datatable = new dsPOS.ItemsDataTable();

            command = new SqlCommand("Items_SelectByCode", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("@ItemsCode", ItemsCode);
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
        public dsPOS.ItemsDataTable SelectForDropDownlist()
        {
            dsPOS.ItemsDataTable datatable = new dsPOS.ItemsDataTable();

            command = new SqlCommand("Items_SelectForDropDownlist", connection);

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
        public dsPOS.ItemsDataTable SelectForProduction()
        {
            dsPOS.ItemsDataTable datatable = new dsPOS.ItemsDataTable();

            command = new SqlCommand("Items_SelectForProduction", connection);

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
        public dsPOS.ItemsDataTable SelectByCategoriesID(string CategoriesID)
        {
            dsPOS.ItemsDataTable datatable = new dsPOS.ItemsDataTable();

            command = new SqlCommand("ItemsSelectbyCategoryID", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("@CategoryID", CategoriesID);
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
