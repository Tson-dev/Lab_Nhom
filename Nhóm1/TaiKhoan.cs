using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhóm1
{
    internal class TaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;
        public TaiKhoan()
        {

        }
        public TaiKhoan(string tk, string mk)
        {
            this.tenTaiKhoan = tk;
            this.matKhau = mk;
        }
        public string TenTaiKhoan { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }

    }

}
