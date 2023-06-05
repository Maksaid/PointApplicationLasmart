using Application.Dto;
using DataAccess.Models;

namespace Application.Mapping;

public static class PointMapping
{
    public static PointDto AsDto(this Point point)
            => new PointDto(point.Id, point.X, point.Y, point.R, point.Color, point.Comments.Select(p => p.AsDto()).ToArray());

}