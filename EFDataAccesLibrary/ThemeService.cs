using EFResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccesLibrary
{
    public class ThemeService
    {
        public void Create(Theme item)
        {
            using (Model1 context = new Model1())
            {
                context.Themes.Add(item);
                context.SaveChanges();
            }
        }

        public List<Theme> SelectAll()
        {
            List<Theme> temp = new List<Theme>();
            using (Model1 context = new Model1())
            {
                temp = context.Themes.ToList();
            }
            return temp;
        }

        public Theme Select(int id)
        {
            Theme result = new Theme();
            using (Model1 context = new Model1())
            {
                List<Theme> tempList = context.Themes.ToList();
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

        public void Update(Theme item)
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
                List<Theme> tempList = context.Themes.ToList();
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i].Id == id)
                    {
                        context.Themes.Remove(tempList[i]);
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
