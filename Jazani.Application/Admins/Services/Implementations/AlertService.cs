using AutoMapper;
using Jazani.Application.Admins.Dtos.Alert;
using Jazani.Domain.Admins.Models;
using Jazani.Domain.Admins.Repositories;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace Jazani.Application.Admins.Services.Implementations
{
    public class AlertService : IAlertService
    {
        private readonly IAlertRepository _alertRepository;
        private readonly IMapper _mapper;

        public AlertService(IAlertRepository alertRepository, IMapper mapper)
        {
            _alertRepository = alertRepository;
            _mapper = mapper;
        }
        public async Task<IReadOnlyList<AlertDto>> FindAllAsync()
        {
            IReadOnlyList<Alertt> alerts = await _alertRepository.FindAllAsync();
            return _mapper.Map<IReadOnlyList<AlertDto>>(alerts);
        }

        public async Task<AlertDto?> FindByIdAsync(int id)
        {
            Alertt? alert = await _alertRepository.FindByIdAsync(id);
            return _mapper.Map<AlertDto?>(alert);
        }
        public async Task<AlertDto> CreateAsync(AlertSaveDto alertSaveDto)
        {
            Alertt alert = _mapper.Map<Alertt>(alertSaveDto);
            alert.Name = alertSaveDto.Name;
            alert.Description = alertSaveDto.Description;
            alert.RegistrationDate = DateTimeOffset.Now;
            alert.RuletypeId = alertSaveDto.RuletipeId;
            alert.State = true;
            


            Alertt alertSaved = await _alertRepository.SaveAsync(alert);

            return _mapper.Map<AlertDto>(alertSaved);
        }



        public async Task<AlertDto> EditAsync(int id, AlertSaveDto alertSaveDto)
        {
            Alertt alert = await _alertRepository.FindByIdAsync(id);

            _mapper.Map<AlertSaveDto, Alertt>(alertSaveDto, alert);

            alert.Name = GetSHA1(alert.Name);

            Alertt alertSaved = await _alertRepository.SaveAsync(alert);

            return _mapper.Map<AlertDto>(alertSaved);
        }
        public async Task<AlertDto> DisabledAsync(int id)
        {

            Alertt alert = await _alertRepository.FindByIdAsync(id);
            alert.State = false;

            Alertt alertSaved = await _alertRepository.SaveAsync(alert);

            return _mapper.Map<AlertDto>(alertSaved);
        }

        // 
        private static string GetSHA1(String texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }


    }
}
