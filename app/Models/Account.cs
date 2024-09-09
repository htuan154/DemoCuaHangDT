using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    internal class Account
    {
        private static Account instance;

        internal static Account Instance
        {
            get
            {
                if (instance == null)
                    instance = new Account();
                return instance;
            }
            private set => instance = value;
        }

        private Account() { }

        public bool Login(string username, string password)
        {
            string query = "USP_Login";
            var parameters = new[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };

            DataTable result = DataProvider.Instance.ExecuteQuery(query, parameters, CommandType.StoredProcedure);

            return result.Rows.Count > 0;
        }

    }
}