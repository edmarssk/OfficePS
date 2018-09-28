using AutoMapper;
using OfficePS.Models;
using OfficePS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficePS.Mappers
{
    public class ModelToViewMapper : Profile
    {

        public override string ProfileName
        {
            get
            {
                return "ModelToViewMapper";
            }
        }

        public ModelToViewMapper()
        {
            CreateMap<Clientes, ClienteVM>();
        }
    }
}
