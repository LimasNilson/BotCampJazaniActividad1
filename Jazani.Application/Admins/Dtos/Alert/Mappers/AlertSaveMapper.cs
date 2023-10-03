

using AutoMapper;
using Jazani.Application.Admins.Dtos.Alert;
using Jazani.Domain.Admins.Models;

namespace Jazani.Application.Admins.Dtos.Alert.Mappers
{
    public class AlertSaveMapper : Profile
    {
        public AlertSaveMapper()
        {
            CreateMap<Alertt, AlertSaveDto>().ReverseMap();
        }
    }
}
