using Application.Dto;
using DataAccess.Models;

namespace Application.Services;

public interface IPointService
{
     Task<PointDto> CreatePointAsync(string color, int radius, int x, int y,
        CancellationToken cancellationToken);

    Task<PointDto> DeletePointAsync(Guid id, CancellationToken cancellationToken);
    Task<List<PointDto>> GetPoints();
}