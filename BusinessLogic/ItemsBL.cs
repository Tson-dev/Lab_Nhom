using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class ItemsBL
    {
        ItemsDA itemsDA = new ItemsDA();
        public List<Items> GetAll()
        {
            return itemsDA.GetAll();
        }

        public Items GetByID(int id)
        {
            List<Items> list = itemsDA.GetAll();

            foreach (var item in list)
            {
                if(item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
