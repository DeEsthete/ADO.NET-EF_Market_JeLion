using EFResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccesLibrary
{
    public class OrderService
    {
        public void Create(Order item)
        {
            using (Model1 context = new Model1())
            {
                context.Orders.Add(item);
                context.SaveChanges();
            }
        }

        public List<Order> SelectAll()
        {
            List<Order> temp = new List<Order>();
            using (Model1 context = new Model1())
            {
                temp = context.Orders.ToList();
            }
            return temp;
        }

        public Order Select(int id)
        {
            Order result = new Order();
            using (Model1 context = new Model1())
            {
                List<Order> tempList = context.Orders.ToList();
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i].Id == id)
                    {
                        result = tempList[i];
                    }
                }
            }
            return result;
        }

        public void Update(Order item)
        {
            using (Model1 context = new Model1())
            {
                context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            using (Model1 context = new Model1())
            {
                List<Order> tempList = context.Orders.ToList();
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i].Id == id)
                    {
                        context.Orders.Remove(tempList[i]);
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
