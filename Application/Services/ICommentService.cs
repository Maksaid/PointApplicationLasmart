using Application.Dto;

namespace Application.Services;

public interface ICommentService
{
    Task<CommentDto> CreateCommentAsync(Guid pointId, String color, String text,CancellationToken cancellationToken);
}