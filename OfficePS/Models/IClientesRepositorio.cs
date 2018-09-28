using OfficePS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficePS.Models
{
    public interface IClientesRepositorio: IDisposable
    {
        IEnumerable<ClienteVM> GetAll();

        ClienteVM GetById(int id);

        void Add(ClienteVM clienteVM);

        void Update(ClienteVM clienteVM);

        void Delete(ClienteVM clienteVM);

    }
}
