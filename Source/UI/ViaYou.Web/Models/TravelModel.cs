using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ViaYou.Web.Models
{
   //Este modelo todavia hay q engordarlo un poquito con las cosas q vi en la foto q mando adrian
    public class Travel
    {
        public virtual int travel_id { get; set; }
        public virtual string origin { get; set; }
        public virtual string destination { get; set; }
        public virtual DateTime Start_date { get; set; }
        public virtual DateTime End_Date { get; set; }
        public virtual int capacity { get; set; }
        public virtual int Calification { get; set; }
        //Los user no se si modelarlos con una clase nuestra o con la de asp.net, asumo q asp.net tiene implemetada una clase User ahi con todo listo
        public virtual User user { get; set; }
    }

    public class User : IdentityUser
    {
        public string TwitterHandle { get; set; }
        public string FacebookHandle { get; set; }
        public string GoogleHandle { get; set; }
        public List<Travel> Travels { get; set; }
    }


    //Esto no se si hace falta sino hace borralo,
    public class Chat
    {
        public virtual int chat_id { get; set; }
        public virtual List<User> users { get; set; }
        public virtual List<Message> messagges { get; set; }
    }

    public class Message
    {
        public virtual int message_id { get; set; }
        public virtual string message { get; set; }
        public virtual DateTime date { get; set; }
        public virtual User user { get; set; }
    }


    public class MusicStoreDB : DbContext
    {
        public DbSet<Travel> Travels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Chat> Chats { get; set; }
    }
}