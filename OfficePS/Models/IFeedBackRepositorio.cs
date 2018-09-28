using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficePS.Models
{
    public interface IFeedBackRepositorio
    {
        IEnumerable<FeedBack> GetAll();

        FeedBack GetById(int id);

        void Create(FeedBack feedBack);

        void Update(FeedBack feedBack);

        void Delete(FeedBack feedBack);
    }
}
