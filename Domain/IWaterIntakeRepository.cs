namespace HealthApi;

public interface IWaterIntakeRepository
{
    Task AddWaterAsync(WaterIntake waterIntake);
    Task<WaterIntake?> FindAllByDateAsync(DateTime dateTime, int userId);
    Task<WaterIntake?> FindByIdAsync(int WaterIntakeId);
    Task DeleteWaterAsync(int WaterIntakeId); 
}