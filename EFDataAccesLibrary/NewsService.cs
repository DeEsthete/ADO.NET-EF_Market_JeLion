using EFResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccesLibrary
{
    public class NewsService
    {
        public void Create(News item)
        {
            using (Model1 context = new Model1())
            {
                context.News.Add(item);
                context.SaveChanges();
            }
        }

        public List<News> SelectAll()
        {
            List<News> temp = new List<News>();
            using (Model1 context = new Model1())
            {
                temp = context.News.ToList();
            }
            return temp;
        }

        public News Select(int id)
        {
            News result = new News();
            using (Model1 context = new Model1())
            {
                List<News> tempList = context.News.ToList();
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

        public void Update(News item)
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
                List<News> tempList = context.News.ToList();
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i].Id == id)
                    {
                        context.News.Remove(tempList[i]);
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
