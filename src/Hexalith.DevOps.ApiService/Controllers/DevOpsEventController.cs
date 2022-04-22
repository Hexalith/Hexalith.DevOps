namespace Hexalith.DevOps.ApiService.Controllers;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class DevOpsEventController : ControllerBase
{
    private readonly ILogger<DevOpsEventController> _logger;

    public DevOpsEventController(ILogger<DevOpsEventController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "/devops/workitem/change")]
    public IActionResult Post(DevOpsWorkItemChangeEvent wiChangeEvent)
    {
        if (wiChangeEvent.WorkItemId <= 0)
        {
            return BadRequest("Work Item Id must be greater than 0.");
        }
        return NoContent();
    }
}
