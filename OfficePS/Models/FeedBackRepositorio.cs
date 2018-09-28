using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficePS.Models
{
    public class FeedBackRepositorio : IFeedBackRepositorio
    {

        public readonly AppDbContext _appDbContext;

        public FeedBackRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Create(FeedBack feedBack)
        {
            _appDbContext.FeedBacks.Add(feedBack);

            _appDbContext.SaveChanges();
        }

        public void Delete(FeedBack feedBack)
        {
            _appDbContext.FeedBacks.Remove(feedBack);

            _appDbContext.SaveChanges();
        }

        public IEnumerable<FeedBack> GetAll()
        {
            return _appDbContext.FeedBacks.ToList();

        }

        public FeedBack GetById(int id)
        {
            return _appDbContext.FeedBacks.FirstOrDefault(p => p.FeedBackId == id);
        }

        public void Update(FeedBack feedBack)
        {
            _appDbContext.FeedBacks.Update(feedBack);

            _appDbContext.SaveChanges();
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
