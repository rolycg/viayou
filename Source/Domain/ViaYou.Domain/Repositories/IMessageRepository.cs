using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaYou.Domain.Chat;

namespace ViaYou.Domain.Repositories
{
    public interface IMessageRepository
    {
        void Add(Message message);
        Message GetById(int id);
        IQueryable<Message> GetAll();
    }
}
