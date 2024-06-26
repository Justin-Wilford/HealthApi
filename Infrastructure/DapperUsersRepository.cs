using Dapper;
using HealthApi.Application;
using Microsoft.Data.SqlClient;

namespace HealthApi.Infrastructure;

public sealed class DapperUsersRepository : IUsersRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperUsersRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    public async Task AddUserAsync(Users users)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
        
            var sql = "INSERT INTO Users (Username, Age, Birthday, UserHeight, UserWeight, StepLength) VALUES (@Username, @Age, @Birthday, @UserHeight, @UserWeight, @StepLength)";
            connection.Execute(sql, users);
        }
    }

    public async Task UpdateUserAsync(Users user)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();

            var sql = @"UPDATE Users SET
                            Username = @Username,
                            Age = @Age,
                            UserHeight = @UserHeight,
                            UserWeight = @UserWeight,
                            StepLength = @StepLength
                        WHERE UserId = @UserId";

            await connection.ExecuteAsync(sql, user);
        }
    }

    public async Task<List<Users>> FindAllUsersAsync()
    {
        await using var connection = new SqlConnection(_databaseOptions.ConnectionString);
        
        await connection.OpenAsync();

        var query = await connection.QueryAsync<Users>("SELECT * FROM Users");

        return query.ToList();
    }

    public async Task<Users?> FindUserByIdAsync(int userId)
    {
        await using (var connection = new SqlConnection(_databaseOptions.ConnectionString))
        {
            await connection.OpenAsync();
            
            var query = await connection.QuerySingleAsync<Users>("SELECT * FROM Users WHERE UserId = @UserId", new {UserId = userId});

            return query;
        }
    }
}