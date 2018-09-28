using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficePS.Models
{
    public class ProcedimentosRepositorio : IProcedimentosRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public ProcedimentosRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Create(Procedimentos procedimentos)
        {
            _appDbContext.Procedimentos.Add(procedimentos);

            _appDbContext.SaveChanges();
        }

        public void Delete(Procedimentos procedimentos)
        {
            _appDbContext.Procedimentos.Remove(procedimentos);

            _appDbContext.SaveChanges();
        }

        public IEnumerable<Procedimentos> GetAll()
        {
            return _appDbContext.Procedimentos.ToList();
        }

        public Procedimentos GetById(int id)
        {
            return _appDbContext.Procedimentos.FirstOrDefault(p => p.ProcedimentosId == id);
        }

        public void Update(Procedimentos procedimentos)
        {
            _appDbContext.Procedimentos.Update(procedimentos);

            _appDbContext.SaveChanges();
        }
    }
}
