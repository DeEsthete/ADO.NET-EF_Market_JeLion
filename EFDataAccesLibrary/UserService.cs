using EFResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccesLibrary
{
    public class UserService
    {
        public void Create(User item)
        {
            using (Model1 context = new Model1())
            {
                context.Users.Add(item);
                context.SaveChanges();
            }
        }

        public List<User> SelectAll()
        {
            List<User> temp = new List<User>();
            using (Model1 context = new Model1())
            {
                temp = context.Users.ToList();
            }
            return temp;
        }

        public User Select(int id)
        {
            User result = new User();
            using (Model1 context = new Model1())
            {
                List<User> tempList = context.Users.ToList();
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

        public void Update(User item)
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
                List<User> tempList = context.Users.ToList();
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i].Id == id)
                    {
                        context.Users.Remove(tempList[i]);
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
