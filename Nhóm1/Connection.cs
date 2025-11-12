using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Nhóm1
{
    public static class Connection
    {
        public static readonly string ConnectionString = "server = .\\UTFUSONSQLSERVER; database = ShoeShop; Integrated Security = True;";
    }
}
