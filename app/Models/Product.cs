using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models
{
    internal class Product
    {
        private string masp, tensp;
        private int slt;
        private SqlMoney gia;

        public string MaSP
        {
            get
            {
                return masp;
            }
            set
            {
                masp = value;
            }
        }
        public string TenSP
        {
            get
            {
                return tensp;
            }
            set
            {
                tensp = value;
            }
        }
        public int Slt
        {
            get
            {
                return slt;
            }
            set
            {
                slt = value;
            }
        }
        public SqlMoney Gia
        {
            get
            {
                return gia;
            }
            set
            {
                gia = value;
            }
        }

        public Product(string masanpham, string tensanpham, int soluong, SqlMoney giatien)
        {
            MaSP = masanpham;
            TenSP = tensanpham;
            Slt = soluong;
            Gia = giatien;
        }
    }
}
