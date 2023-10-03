

using AutoMapper;
using Jazani.Domain.Admins.Models;

namespace Jazani.Application.Admins.Dtos.Periocities.Mappers
{
    public class NatureSaveMapper : Profile
    {
        public NatureSaveMapper()
        {

            CreateMap<Nature, NatureSaveDto>().ReverseMap();
        }
    }
}
