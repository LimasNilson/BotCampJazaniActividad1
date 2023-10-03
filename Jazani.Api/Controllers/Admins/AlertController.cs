using Jazani.Application.Admins.Dtos.Alert;
using Jazani.Application.Admins.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Jazani.Api.Controllers.Admins
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertController : ControllerBase
    {

        private readonly IAlertService _alertService;

        public AlertController(IAlertService alertrService)
        {
            _alertService = alertrService;
        }

        
        [HttpGet]
        public async Task<IReadOnlyList<AlertDto>> Get()
        {
            return await _alertService.FindAllAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<AlertDto?> Get(int id)
        {
            return await _alertService.FindByIdAsync(id);
        }

        
        [HttpPost]
        public async Task<AlertDto> Post([FromBody] AlertSaveDto alertSaveDto)
        {
            return await _alertService.CreateAsync(alertSaveDto);
        }

        
        [HttpPut("{id}")]
        public async Task<AlertDto> Put(int id, [FromBody] AlertSaveDto alertSaveDto)
        {
            return await _alertService.EditAsync(id, alertSaveDto);
        }

        
        [HttpDelete("{id}")]
        public async Task<AlertDto> Delete(int id)
        {
            return await _alertService.DisabledAsync(id);
        }
    }
}
