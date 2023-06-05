using Application.Dto;
using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommentController : ControllerBase
{
    private readonly ICommentService _service;

    public CommentController(ICommentService service)
    {
        _service = service;
    }

    public CancellationToken CancellationToken => HttpContext.RequestAborted;

    [HttpPost("create-comment")]
    public async Task<ActionResult<CommentDto>> CreateAsync([FromBody] CommentModel model)
    {
        var comment = await _service.CreateCommentAsync(Guid.Parse(model.PointId), model.Color,model.Text, CancellationToken);
        return Ok(comment);
    }
}