namespace Application.Dto;

public record CommentDto(Guid commentId, Guid pointId, String color, String text);
