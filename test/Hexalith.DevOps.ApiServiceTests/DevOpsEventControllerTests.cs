namespace Hexalith.DevOps.ApiServiceTests;

using FluentAssertions;

using Hexalith.DevOps.ApiService.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using NSubstitute;

using Xunit;

#pragma warning disable IDE0058 // Expression value is never used

public class DevOpsEventControllerTests
{
    [Fact]
    public void Workitem_change_return_no_content()
    {
        var logger = Substitute.For<ILogger<DevOpsEventController>>();
        var controller = new DevOpsEventController(logger);
        var result = controller.Post(new ApiService.DevOpsWorkItemChangeEvent { WorkItemId = 50 });
        result.Should().BeOfType<NoContentResult>();
    }

    [Fact]
    public void Workitem_change_with_id_negative_should_return_bad_request()
    {
        var logger = Substitute.For<ILogger<DevOpsEventController>>();
        var controller = new DevOpsEventController(logger);
        var result = controller.Post(new ApiService.DevOpsWorkItemChangeEvent { WorkItemId = -100 });
        result.Should().BeOfType<BadRequestObjectResult>();
    }

    [Fact]
    public void Workitem_change_with_id_zero_should_return_bad_request()
    {
        var logger = Substitute.For<ILogger<DevOpsEventController>>();
        var controller = new DevOpsEventController(logger);
        var result = controller.Post(new ApiService.DevOpsWorkItemChangeEvent { WorkItemId = 0 });
        result.Should().BeOfType<BadRequestObjectResult>();
    }
}