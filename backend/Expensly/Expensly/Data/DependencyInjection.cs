namespace Expensly.Data;

public static class DependencyInjection
{
    public static IServiceCollection AddData(this IServiceCollection services)
    {
        services.AddDbContext<ExpenslyContext>();
        services.AddTransient<ExpenslyContext>();
        
        return services;
    }
}