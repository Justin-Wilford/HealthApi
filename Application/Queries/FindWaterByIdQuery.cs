using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Queries;

public sealed class FindWaterByIdQuery : HttpEndpoint
{
    [HttpGet("WaterIntake/{WaterIntakeId}")]
    public async Task<WaterIntake?> ExecuteAsync(
        [FromServices] IWaterIntakeRepository waterIntakeRepository,
        [FromRoute] int WaterIntakeId)
    {
        var waterIntake = waterIntakeRepository.FindByIdAsync(WaterIntakeId);

        return await waterIntake;
    }
}