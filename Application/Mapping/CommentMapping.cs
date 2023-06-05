using Application.Dto;
using DataAccess.Models;

namespace Application.Mapping;

public static class CommentMapping
{
    public static CommentDto AsDto(this Comment comment)
        => new CommentDto(comment.Id, comment.Point.Id, comment.Color, comment.CommentText);

}