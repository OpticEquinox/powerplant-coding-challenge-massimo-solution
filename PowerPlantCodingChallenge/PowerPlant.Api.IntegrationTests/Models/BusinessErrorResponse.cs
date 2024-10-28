namespace PowerPlant.Api.IntegrationTests.Models;

public class BusinessErrorResponse
{
    public string Type { get; set; }
    public string Title { get; set; }
    public int Status { get; set; }
    public string TraceId { get; set; }
    public string ErrorDetails { get; set; }
}