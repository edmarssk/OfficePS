using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficePS.Models
{
    public interface IProcedimentosRepositorio
    {
        IEnumerable<Procedimentos> GetAll();

        Procedimentos GetById(int id);

        void Create(Procedimentos procedimentos);

        void Update(Procedimentos procedimentos);

        void Delete(Procedimentos procedimentos);
    }
}
