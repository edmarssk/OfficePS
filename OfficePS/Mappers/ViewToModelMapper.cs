using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using OfficePS.Models;
using OfficePS.ViewModels;

namespace OfficePS.Mappers
{
    public class ViewToModelMapper : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewToModelMapper";
            }
        }

        public ViewToModelMapper()
        {
            CreateMap<ClienteVM, Clientes>();
        }
    }
}
