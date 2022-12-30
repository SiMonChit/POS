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
    public class VoucherDataController:DataControllerBase
    {
        #region InsertVoucher

        #endregion
        public dsSale.SaleHeaderDataTable SaleVoucherSelect()
        {
            dsSale.SaleHeaderDataTable datatable = new dsSale.SaleHeaderDataTable();

            command = new SqlCommand("SaleVoucherSelectAll", connection);

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
        public dsSale.SaleHeaderDataTable SaleVoucherSelectByInvNo(string InvNo)
        {
            dsSale.SaleHeaderDataTable datatable = new dsSale.SaleHeaderDataTable();

            command = new SqlCommand("SaleVoucherSelectByInvNo", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("@InvNo", InvNo);
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
        public dsSale.SaleHeaderDataTable SaleVoucherSelectByDate(DateTime Date)
        {
            dsSale.SaleHeaderDataTable datatable = new dsSale.SaleHeaderDataTable();

            command = new SqlCommand("SaleVoucherSelectByDate", connection);

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.AddWithValue("@Date", Date);
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

        #region VoucherReport
        #endregion

    }
}
