namespace PowerPlant.Domain.Entities;

public class ProductionPlan
{
    public decimal Load { get; set; }
    
    public Fuels Fuels { get; set; }
    
    public List<PowerPlant> PowerPlants { get; set; }
}