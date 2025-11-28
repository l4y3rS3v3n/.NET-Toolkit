namespace Services.Toolkit.API.Endpoints;

public static class HealthCheckEndpoint
{
    public static void HealthCheckApi(this WebApplication app)
    {
        app.MapGet("/hc", () => Results.Ok("Healthy"));
    }
}