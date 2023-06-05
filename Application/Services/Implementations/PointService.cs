using Application.Dto;
using Application.Extensions;
using Application.Mapping;
using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementations;

internal class PointService : IPointService
{
    private readonly DatabaseContext _context;

    public PointService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<PointDto> CreatePointAsync(string color, int radius, int x, int y, CancellationToken cancellationToken)
    {
        var point = new Point(Guid.NewGuid(), x, y, radius, color, new List<Comment>());
        _context.Points.Add(point);
        await _context.SaveChangesAsync(cancellationToken);

        return point.AsDto();
    }

    public async Task<PointDto> DeletePointAsync(Guid id, CancellationToken cancellationToken)
    {
        var pointToDelete = await _context.Points.GetEntityAsync(id, cancellationToken);
        var dto = pointToDelete.AsDto();
        _context.Points.Remove(pointToDelete);
        await _context.SaveChangesAsync(cancellationToken);

        return dto;
    }

    public async Task<List<PointDto>> GetPoints()
    {
        var points = await _context.Points.ToListAsync();
            var pp = points.Select(x => x.AsDto()).ToList();
            return pp;

    }
}