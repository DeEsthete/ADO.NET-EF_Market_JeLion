using EFResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccesLibrary
{
    public class CreatorService
    {
        public void Create(Creator item)
        {
            using (Model1 context = new Model1())
            {
                context.Creators.Add(item);
                context.SaveChanges();
            }
        }

        public List<Creator> SelectAll()
        {
            List<Creator> temp = new List<Creator>();
            using (Model1 context = new Model1())
            {
                temp = context.Creators.ToList();
            }
            return temp;
        }

        public Creator Select(int id)
        {
            Creator result = new Creator();
            using (Model1 context = new Model1())
            {
                List<Creator> tempList = context.Creators.ToList();
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

        public void Update(Creator item)
        {
            using (Model1 context = new Model1())
            {
                List<Creator> tempList = context.Creators.ToList();
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i].Id == item.Id)
                    {
                        tempList[i].Name = item.Name;
                        tempList[i].Description = item.Description;
                    }
                }
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (Model1 context = new Model1())
            {
                List<Creator> tempList = context.Creators.ToList();
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i].Id == id)
                    {
                        context.Creators.Remove(tempList[i]);
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
