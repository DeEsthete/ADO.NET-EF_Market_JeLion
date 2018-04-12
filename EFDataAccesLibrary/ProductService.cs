using EFResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccesLibrary
{
    public class ProductService
    {
        public void Create(Product item)
        {
            using (Model1 context = new Model1())
            {
                context.Products.Add(item);
                context.SaveChanges();
            }
        }

        public List<Product> SelectAll()
        {
            List<Product> temp = new List<Product>();
            using (Model1 context = new Model1())
            {
                temp = context.Products.ToList();
            }
            return temp;
        }

        public Product Select(int id)
        {
            Product result = new Product();
            using (Model1 context = new Model1())
            {
                List<Product> tempList = context.Products.ToList();
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

        public void Update(Product item)
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
                List<Product> tempList = context.Products.ToList();
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i].Id == id)
                    {
                        context.Products.Remove(tempList[i]);
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
