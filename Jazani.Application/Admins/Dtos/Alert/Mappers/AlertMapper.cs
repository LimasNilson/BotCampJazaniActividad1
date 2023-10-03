

using AutoMapper;
using Jazani.Domain.Admins.Models;

namespace Jazani.Application.Admins.Dtos.Alert.Mappers
{
    public class AlertMapper : Profile
    {
        public AlertMapper()
        {
            CreateMap<Alertt, AlertDto>();

        }
    }
}
