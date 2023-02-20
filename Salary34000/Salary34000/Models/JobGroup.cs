namespace Salary34000.Models;

public class JobGroup : IdDescriptionModel
{
    public double ProportionIncrease { get; set; }
    public double IncreaseCoefficient { get; set; }
    public double CumulativeCoefficient { get; set; }
    public double FinalCoefficient { get; set; }
    public double JobExtra { get; set; }
    public double ManagementExtra { get; set; }
}