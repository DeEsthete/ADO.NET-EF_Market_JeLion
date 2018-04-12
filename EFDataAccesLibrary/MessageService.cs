using EFResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccesLibrary
{
    public class MessageService
    {
        public void Create(Message item)
        {
            using (Model1 context = new Model1())
            {
                context.Messages.Add(item);
                context.SaveChanges();
            }
        }

        public List<Message> SelectAll()
        {
            List<Message> temp = new List<Message>();
            using (Model1 context = new Model1())
            {
                temp = context.Messages.ToList();
            }
            return temp;
        }

        public Message Select(int id)
        {
            Message result = new Message();
            using (Model1 context = new Model1())
            {
                List<Message> tempList = context.Messages.ToList();
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

        public void Update(Message item)
        {
            using (Model1 context = new Model1())
            {
                List<Message> tempList = context.Messages.ToList();
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i].Id == item.Id)
                    {
                        tempList[i].ThemeId = item.ThemeId;
                        tempList[i].UserId = item.UserId;
                        tempList[i].MessageText = item.MessageText;
                    }
                }
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (Model1 context = new Model1())
            {
                List<Message> tempList = context.Messages.ToList();
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i].Id == id)
                    {
                        context.Messages.Remove(tempList[i]);
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
