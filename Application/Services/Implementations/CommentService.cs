using Application.Dto;
using Application.Extensions;
using Application.Mapping;
using DataAccess;
using DataAccess.Models;

namespace Application.Services.Implementations;

public class CommentService : ICommentService
{
    private readonly DatabaseContext _context;

    public CommentService(DatabaseContext context)
    {
        _context = context;
    }
    public async Task<CommentDto> CreateCommentAsync(Guid pointId, string color, string text,CancellationToken cancellationToken)
    {
        var point = await _context.Points.GetEntityAsync(pointId, cancellationToken);
        var comment = new Comment(Guid.NewGuid(), text, color, point);
        point.Comments.Add(comment);
        _context.Comments.Add(comment);
        await _context.SaveChangesAsync(cancellationToken);

        return comment.AsDto();
    }
}