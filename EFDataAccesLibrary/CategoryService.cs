using EFResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccesLibrary
{
    public class CategoryService
    {
        public void Create(Category item)
        {
            using (Model1 context = new Model1())
            {
                context.Categories.Add(item);
                context.SaveChanges();
            }
        }

        public List<Category> SelectAll()
        {
            List<Category> temp = new List<Category>();
            using (Model1 context = new Model1())
            {
                temp = context.Categories.ToList();
            }
            return temp;
        }

        public Category Select(int id)
        {
            Category result = new Category();
            using (Model1 context = new Model1())
            {
                List<Category> tempList = context.Categories.ToList();
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

        public void Update(Category item)
        {
            using (Model1 context = new Model1())
            {
                List<Category> tempList = context.Categories.ToList();
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i].Id == item.Id)
                    {
                        tempList[i].CategoryName = item.CategoryName;
                    }
                }
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (Model1 context = new Model1())
            {
                List<Category> tempList = context.Categories.ToList();
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i].Id == id)
                    {
                        context.Categories.Remove(tempList[i]);
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
