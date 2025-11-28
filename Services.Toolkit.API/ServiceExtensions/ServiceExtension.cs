namespace Services.Toolkit.API.ServiceExtensions;

public static class ServiceExtension
{
    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddSwagger();
    }
    
    private static void AddSwagger(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }
}