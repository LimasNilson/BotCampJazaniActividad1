using Jazani.Application.Admins.Dtos.Periocities;
using Jazani.Application.Admins.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Jazani.Api.Controllers.Admins
{
    [Route("api/[controller]")]
    [ApiController]
    public class NatureController : ControllerBase
    {
        private readonly INatureService _natureService;

        public NatureController(INatureService natureService)
        {
            _natureService =natureService;
        }

       
        [HttpGet]
        public async Task<IEnumerable<NatureDto>> Get()
        {
            return await _natureService.FindAllAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<NatureDto?> Get(int id)
        {
            return await _natureService.FindByIdAsync(id);
        }

        
        [HttpPost]
        public async Task<NatureDto> Post([FromBody] NatureSaveDto natureSaveDto)
        {
            return await _natureService.CreateAsync(natureSaveDto);
        }

     
        [HttpPut("{id}")]
        public async Task<NatureDto> Put(int id, [FromBody] NatureSaveDto natureSaveDto)
        {
            return await _natureService.EditAsync(id, natureSaveDto);
        }

        
        [HttpDelete("{id}")]
        public async Task<NatureDto> Delete(int id)
        {
            return await _natureService.DisabledAsync(id);
        }
    }
}
