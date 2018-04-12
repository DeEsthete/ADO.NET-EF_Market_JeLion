using EFResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccesLibrary
{
    public class PurseService
    {
        public void Create(Purse item)
        {
            using (Model1 context = new Model1())
            {
                context.Purses.Add(item);
                context.SaveChanges();
            }
        }

        public List<Purse> SelectAll()
        {
            List<Purse> temp = new List<Purse>();
            using (Model1 context = new Model1())
            {
                temp = context.Purses.ToList();
            }
            return temp;
        }

        public Purse Select(int id)
        {
            Purse result = new Purse();
            using (Model1 context = new Model1())
            {
                List<Purse> tempList = context.Purses.ToList();
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

        public void Update(Purse item)
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
                List<Purse> tempList = context.Purses.ToList();
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i].Id == id)
                    {
                        context.Purses.Remove(tempList[i]);
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
