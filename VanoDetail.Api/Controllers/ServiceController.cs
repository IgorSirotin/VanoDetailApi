using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using VanoDetail.Application.Services;

namespace VanoDetail.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ServiceController(IServiceService serviceService) : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<IActionResult> GetServiceAsync(int id, CancellationToken cancellationToken) =>
        Ok(await serviceService.GetServiceByIdAsync(id, cancellationToken));
}