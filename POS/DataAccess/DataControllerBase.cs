using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DataAccess
{
    public class DataControllerBase
    {
        #region Private Variables
        public SqlTransaction Transaction;

        public SqlCommand command;

        public SqlConnection connection;

        public SqlDataAdapter adapter;

        #endregion

        #region Constructor

        public DataControllerBase()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString);
        }
        #endregion

    }
}
