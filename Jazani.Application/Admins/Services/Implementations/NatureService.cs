

using AutoMapper;
using Jazani.Application.Admins.Dtos.Periocities;
using Jazani.Domain.Admins.Models;
using Jazani.Domain.Admins.Repositories;

namespace Jazani.Application.Admins.Services.Implementations
{
    public class NatureService : INatureService
    {
        private readonly INatureRepository _natureRepository;
        private readonly IMapper _mapper;


        public NatureService(INatureRepository natureRepository, IMapper mapper)
        {
            _natureRepository = natureRepository;
            _mapper = mapper;
        }
        public async Task<IReadOnlyList<NatureDto>> FindAllAsync()
        {
            IReadOnlyList<Nature> nature = await _natureRepository.FindAllAsync();
            return _mapper.Map<IReadOnlyList<NatureDto>>(nature);
        }

        public async Task<NatureDto?> FindByIdAsync(int id)
        {
            Nature? office = await _natureRepository.FindByIdAsync(id);
            return _mapper.Map<NatureDto?>(office);
        }
        public async Task<NatureDto> CreateAsync(NatureSaveDto natureSaveDto)
        {
            Nature office = _mapper.Map<Nature>(natureSaveDto);
            office.RegistrationDate = DateTimeOffset.Now;
            office.State = true;

            Nature officeSaved = await _natureRepository.SaveAsync(office);

            return _mapper.Map<NatureDto>(officeSaved);
        }
        public async Task<NatureDto> EditAsync(int id, NatureSaveDto natureSaveDto)
        {
            Nature nature = await _natureRepository.FindByIdAsync(id);

            _mapper.Map<NatureSaveDto, Nature>(natureSaveDto, nature);

            Nature officeSaved = await _natureRepository.SaveAsync(nature);

            return _mapper.Map<NatureDto>(officeSaved);
        }
        public async Task<NatureDto> DisabledAsync(int id)
        {
            Nature nature = await _natureRepository.FindByIdAsync(id);
            nature.State = false;

            Nature officeSaved = await _natureRepository.SaveAsync(nature);

            return _mapper.Map<NatureDto>(officeSaved);
        }




    }
}
