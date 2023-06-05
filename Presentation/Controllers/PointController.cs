using Application.Dto;
using Application.Services;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PointController : ControllerBase
{
    private readonly IPointService _service;

    public PointController(IPointService service)
    {
        _service = service;
    }
    public CancellationToken CancellationToken => HttpContext.RequestAborted;

    [HttpPost("create-point")]
    public async Task<ActionResult<PointDto>> CreateAsync([FromBody] PointModel model)
    {
        var point = await _service.CreatePointAsync(model.Color,model.R, model.X,model.Y,CancellationToken);
        return Ok(point);
    }
    
    [HttpDelete("delete-point")]
    public async Task<ActionResult<PointDto>> DeleteAsync(string id)
    {
        var pointId = id.Substring(2, id.Length-3);
        var point = await _service.DeletePointAsync(Guid.Parse(pointId),CancellationToken);
        return Ok(point);
    }

    [HttpGet("get-points")]
    public async Task<ActionResult<List<Point>>> GetDatabase()
    {
        var points = await _service.GetPoints();
        return Ok(points);
    }
}