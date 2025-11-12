using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ItemsDA
    {
        public List<Items> GetAll()
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Connection.Items_GetAll;

            SqlDataReader reader = cmd.ExecuteReader();
            List<Items> list = new List<Items>();

            while (reader.Read())
            {
                Items item = new Items();
                item.ID = Convert.ToInt32(reader["ID"]);
                item.Name = reader["Name"].ToString();
                item.Gender = Convert.ToInt32(reader["Gender"]);
                item.Age = reader["Age"].ToString();
                item.Type = reader["Type"].ToString();
                item.Price = Convert.ToInt32(reader["Price"]);
                item.Stock = Convert.ToInt32(reader["Stock"]);
                if (reader["BrandID"] != DBNull.Value)
                {
                    item.BrandID = Convert.ToInt32(reader["BrandID"]);
                }
                list.Add(item);
            };

            conn.Close();
            return list;
        }
    }
}
