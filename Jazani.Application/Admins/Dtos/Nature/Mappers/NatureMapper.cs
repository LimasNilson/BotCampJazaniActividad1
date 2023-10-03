

using AutoMapper;
using Jazani.Domain.Admins.Models;

namespace Jazani.Application.Admins.Dtos.Periocities.Mappers
{
    public class NatureMapper : Profile
    {
        public NatureMapper()
        {
            CreateMap<Nature, NatureDto>();
        }
    }
}
