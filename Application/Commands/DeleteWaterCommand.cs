using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Commands;

public sealed class DeleteWaterCommand : HttpEndpoint
{
    [HttpDelete("waterIntake/{WaterIntakeId}")]
    public async Task ExecuteAsync(
        [FromServices] IWaterIntakeRepository waterIntakeRepository,
        [FromRoute] int WaterIntakeId)
    {
        await waterIntakeRepository.DeleteWaterAsync(WaterIntakeId);
    }
}