using Microsoft.Practices.Unity;
using System.Data.Entity.Validation;

namespace ViaYou.Data.Repositories
{
    public class BaseRepository
    {
        [Dependency]
        public ViaYouDataContext Context { get; set; }

        public void SaveChanges()
        {
            try
            {
                Context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                int t = 5;// ex.EntityValidationErrors;
            }
        }
    }
}
