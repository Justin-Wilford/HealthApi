namespace HealthApi;

public interface IWaterIntakeRepository
{
    Task AddWaterAsync(WaterIntake waterIntake);
    Task<WaterIntake?> FindAllByDateAsync(DateTime dateTime);
    Task<WaterIntake?> FindByIdAsync(int WaterIntakeId);
    Task DeleteWaterAsync(int WaterIntakeId); 
}