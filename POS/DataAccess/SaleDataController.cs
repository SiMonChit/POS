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
    public class SaleDataController:DataControllerBase
    {
        #region Insert
        public string InsertSale(dsSale.SaleHeaderRow row, dsSale.SaleItemDataTable saleItem)
        {

            if (connection.State != ConnectionState.Open) connection.Open();
            Transaction = connection.BeginTransaction();

            command = new SqlCommand("SaleHeader_Insert", connection, Transaction);
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("VoucherNo", row.VoucherNo);
                command.Parameters.AddWithValue("VoucherDate", row.VoucherDate);
                command.Parameters.AddWithValue("SubTotal", row.SubTotal);
                command.Parameters.AddWithValue("Tax", row.Tax);
                command.Parameters.AddWithValue("GrandTotal", row.GrandTotal);

                string key = command.ExecuteScalar().ToString();

                InsertSaleItem(key, saleItem, connection, Transaction);

                return key;
            }
            catch (Exception ex)
            {
                Transaction.Rollback();
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    Transaction.Commit();
                    connection.Close();
                }
            }
        }

        public void InsertSaleItem(string HeaderID, dsSale.SaleItemDataTable saleItem, SqlConnection connection, SqlTransaction transaction)
        {

            try
            {
                foreach (dsSale.SaleItemRow _row in saleItem.Rows)
                {
                    command = new SqlCommand("SaleItem_Insert", connection, transaction);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("HeaderID", HeaderID);
                    command.Parameters.AddWithValue("ItemsID", _row.ItemsID);
                    command.Parameters.AddWithValue("Qty", _row.Qty);
                    command.Parameters.AddWithValue("Price", _row.Price);
                    command.Parameters.AddWithValue("Amount", _row.Amount);

                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Update
        #endregion

        #region Select
        public DataTable ShowSaleInvoiceForToday()
        {
            DataTable dataTable = new DataTable();

            command = new SqlCommand("ShowSaleInvoiceForToday", connection);
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

        #endregion


    }
}
