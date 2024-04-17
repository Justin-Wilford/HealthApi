using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Queries;

public sealed class GetAverageHeartRateQuery : HttpEndpoint
{
    [HttpGet("HeartRate")]
    public async Task<int?> ExecuteAsync(
        [FromQuery] DateTime HeartRateDate,
        [FromQuery] int UserId,
        [FromServices] IHeartRateRepository heartRateRepsoitory)
    {
        var averageHeartRate = heartRateRepsoitory.GetAverageHeartRateAsync(HeartRateDate, UserId);

        return await averageHeartRate;
    }
}