using OfficePS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;
using System.IO;

namespace OfficePS.Models
{
    public class ClientesRepositorio : IClientesRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public ClientesRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        public void Add(ClienteVM clienteVM)
        {
            var cliente = Mapper.Map<ClienteVM, Clientes>(clienteVM);

            _appDbContext.Clientes.Add(cliente);

            _appDbContext.SaveChanges();
        }

        public void Delete(ClienteVM clienteVM)
        {
            var cliente = Mapper.Map<ClienteVM, Clientes>(clienteVM);

            _appDbContext.Clientes.Remove(cliente);

            _appDbContext.SaveChanges();
            
        }

        
        public void Update(ClienteVM clienteVM)
        {
            var cliente = Mapper.Map<ClienteVM, Clientes>(clienteVM);

            _appDbContext.Clientes.Update(cliente);

            _appDbContext.SaveChanges();
        }
         


        public IEnumerable<ClienteVM> GetAll()
        {
            var clientes = _appDbContext.Clientes.Take(10);
            var clientesVM = Mapper.Map<IEnumerable<Clientes>, IEnumerable<ClienteVM>>(clientes);
            return clientesVM;
        }

        public ClienteVM GetById(int id)
        {
            var cliente = _appDbContext.Clientes.FirstOrDefault(p => p.ClientesId == id);

            return Mapper.Map<Clientes, ClienteVM>(cliente); 
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
            GC.SuppressFinalize(this);
        }

        //private List<Cliente> NovosClientes()
        //{
        //    List<Cliente> clientes = new List<Cliente>();

        //    clientes.Add(new Cliente() { Id = 1, Nome = "Edmar Santos", Cpf = "12312312300", DtCadastro = DateTime.Now, Ativo = true, Email = "ed@ed.com", DtNascimento = Convert.ToDateTime("11/05/1986"), Rg = "85285232", Telefone = "11-5566-5566", FotoPerfil = "edmar.jpg" });
        //    clientes.Add(new Cliente() { Id = 2, Nome = "Fulano de tal", Cpf = "00011122233", DtCadastro = DateTime.Now, Ativo = true, Email = "fulano@ed.com", DtNascimento = Convert.ToDateTime("11/08/1990"), Rg = "22332233", Telefone = "11-5566-0000", FotoPerfil = "ela.jpg" });
        //    return clientes;
        //}
    }
}
