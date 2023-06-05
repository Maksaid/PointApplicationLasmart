using DataAccess.Models;

namespace Application.Dto;

public record PointDto(Guid id, int x, int y, int r, string color, IEnumerable<CommentDto> comments);