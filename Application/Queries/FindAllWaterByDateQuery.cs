using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Queries;

public sealed class FindAllWaterByDateQuery : HttpEndpoint
{
    [HttpGet("WaterIntake")]
    public async Task<WaterIntake?> ExecuteAsync(
        [FromServices] IWaterIntakeRepository waterIntakeRepository,
        [FromQuery] DateTime WaterIntakeDate,
        [FromQuery] int UserId)
    {
        var waterIntake = waterIntakeRepository.FindAllByDateAsync(WaterIntakeDate, UserId);

        return await waterIntake;
    }
}