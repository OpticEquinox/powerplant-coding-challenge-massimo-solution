using System.Text.Json.Serialization;
using PowerPlant.Api.Common;

namespace PowerPlant.Api.Models;

public record ProductionPlanResponseDTO
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("p")]
    [JsonConverter(typeof(DecimalJsonConverter))]
    public decimal P { get; set; }
}