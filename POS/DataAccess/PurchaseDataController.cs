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
    public class PurchaseDataController:DataControllerBase
    {
		public void Insert(dsPOS.PurchaseRow purchaseRow)
		{
			command = new SqlCommand("Purchase_Insert", connection);
			command.CommandType = CommandType.StoredProcedure;

			command.Parameters.AddWithValue("ItemsID", purchaseRow.ItemsID);
			command.Parameters.AddWithValue("BuyPrice", purchaseRow.BuyPrice);
			command.Parameters.AddWithValue("Qty", purchaseRow.Qty);
			command.Parameters.AddWithValue("Amount", purchaseRow.Amount);
			command.Parameters.AddWithValue("PurchaseDate", purchaseRow.PurchaseDate);

			try
			{
				connection.Open();
				command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				if (connection.State == ConnectionState.Open)
				{
					connection.Close();
				}
			}
		}

		public void Update(dsPOS.PurchaseRow purchaseRow)
		{
			command = new SqlCommand("Purchase_Update", connection);
			command.CommandType = CommandType.StoredProcedure;

			command.Parameters.AddWithValue("PurchaseID", purchaseRow.PurchaseID);
			command.Parameters.AddWithValue("ItemsID", purchaseRow.ItemsID);
			command.Parameters.AddWithValue("BuyPrice", purchaseRow.BuyPrice);
			command.Parameters.AddWithValue("Qty", purchaseRow.Qty);
			command.Parameters.AddWithValue("Amount", purchaseRow.Amount);
			command.Parameters.AddWithValue("PurchaseDate", purchaseRow.PurchaseDate);

			try
			{
				connection.Open();
				command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				if (connection.State == ConnectionState.Open)
				{
					connection.Close();
				}
			}
		}

		public dsPOS.PurchaseDataTable Select()
        {
			dsPOS.PurchaseDataTable dataTable = new dsPOS.PurchaseDataTable();

			command = new SqlCommand("Purchase_Select", connection);
			command.CommandType = CommandType.StoredProcedure;

			try
			{
				SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
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

			if (dataTable.Rows.Count == 0)
			{
				return null;
			}
			return dataTable;
		}
	}
}
