using EFResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccesLibrary
{
    public class ReviewService
    {
        public void Create(Review item)
        {
            using (Model1 context = new Model1())
            {
                context.Reviews.Add(item);
                context.SaveChanges();
            }
        }

        public List<Review> SelectAll()
        {
            List<Review> temp = new List<Review>();
            using (Model1 context = new Model1())
            {
                temp = context.Reviews.ToList();
            }
            return temp;
        }

        public Review Select(int id)
        {
            Review result = new Review();
            using (Model1 context = new Model1())
            {
                List<Review> tempList = context.Reviews.ToList();
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

        public void Update(Review item)
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
                List<Review> tempList = context.Reviews.ToList();
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i].Id == id)
                    {
                        context.Reviews.Remove(tempList[i]);
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
