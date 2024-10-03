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
        public string AdminId { get; private set; }
        //public bool Login(string username, string password)
        //{
        //    string query = "USP_Login_2";
        //    var parameters = new[]
        //    {
        //        new SqlParameter("@username", username),
        //        new SqlParameter("@password", password)
        //    };

        //    DataTable result = DataProvider.Instance.ExecuteQuery(query, parameters, CommandType.StoredProcedure);

        //    return result.Rows.Count > 0;
        //}
        public UserAccount Login(string username, string password)
        {
            string query = "USP_Login_2"; // Stored procedure trong cơ sở dữ liệu
            var parameters = new[]
            {
                new SqlParameter("@username", SqlDbType.NVarChar) { Value = username },
                new SqlParameter("@password", SqlDbType.NVarChar) { Value = password }
            };

            // Thực hiện truy vấn bằng DataProvider và truyền tham số
            DataTable result = DataProvider.Instance.ExecuteQuery(query, parameters, CommandType.StoredProcedure);

            // Kiểm tra kết quả trả về từ stored procedure
            if (result.Rows.Count > 0)
            {
                // Lấy giá trị từ kết quả truy vấn
                string role = result.Rows[0]["role"].ToString();
                string userName = result.Rows[0]["tai_khoan"].ToString();
                string adminId = result.Rows[0]["id"].ToString();

                // Lưu AdminId sau khi đăng nhập thành công
                AdminId = adminId;

                // Trả về thông tin người dùng
                return new UserAccount
                {
                    Role = role,
                    Username = userName,
                    AdminId = adminId
                };
            }

            // Trả về null nếu không tìm thấy tài khoản phù hợp
            return null;
        }
    }
}