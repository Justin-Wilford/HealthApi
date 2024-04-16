using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Application.Commands;

public sealed class AddWaterCommand : HttpEndpoint
{
    [HttpPost("waterIntake")]
    public async Task ExecuteAsync(
        [FromServices] IWaterIntakeRepository waterIntakeRepository,
        [FromBody] WaterIntake waterIntake)
    {
        await waterIntakeRepository.AddWaterAsync(waterIntake);
    }
}