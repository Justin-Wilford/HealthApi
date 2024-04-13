using HealthApi.Infrastructure;

namespace HealthApi.Application;

public static class InfrastructureServiceExtensions
{
    public static IServiceCollection AddDapperRepositories(this IServiceCollection services)
    {
        services.AddScoped<IExerciseRepository, DapperExerciseRepository>();
        services.AddScoped<IGoalRepository, DapperGoalRepository>();
        services.AddScoped<IHeartRateRepository, DapperHeartRateRepository>();
        services.AddScoped<IStepsRepository, DapperStepsRepository>();
        services.AddScoped<IUsersRepository, DapperUsersRepository>();
        services.AddScoped<IWaterIntakeRepository, DapperWaterIntakeRepository>();

        return services;
    }
}